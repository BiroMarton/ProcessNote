using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> notes = new Dictionary<string, string>();
        

        private static float RunTest(string appName)
        {
           float result = 0;
           PerformanceCounter total_cpu = new PerformanceCounter("Process", "% Processor Time", "_Total");
           PerformanceCounter process_cpu = new PerformanceCounter("Process", "% Processor Time", appName);

          total_cpu.NextValue();
          process_cpu.NextValue();
          System.Threading.Thread.Sleep(1000);
          float t = total_cpu.NextValue();
          float p = process_cpu.NextValue();
          result = p / t * 100;
         
                
          return result;
        }

        public Form1()
        {
         
            InitializeComponent();
            Process[] process = Process.GetProcesses();
            this.TopMost = true;
           

            foreach (Process p in process)
            {
                Processes.Items.Add(p.ProcessName);
            }
            ;
            Num.Text = process.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();
            Processes.Items.Clear();
            foreach (Process p in process)
            {
                Processes.Items.Add(p.ProcessName);
            }
            Num.Text = process.Length.ToString();

        }

        private void Processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = Processes.SelectedItem.ToString();
            Process[] proc = Process.GetProcessesByName(name);
            MemoryNum.Text = (proc[0].PrivateMemorySize64 / (1024 * 1024)).ToString() + " MB";
            notes.TryGetValue(name, out string o);
            Note.Text = o;
            CPUNum.Text = RunTest(name).ToString() + "%";

        }

        private void NoteSave_Click(object sender, EventArgs e)
        {
            String name = Processes.SelectedItem.ToString();
            String content = Note.Text;
            if (notes.ContainsKey(name))
            {
                notes[name] = content;
            }
            else
            {
                notes.Add(name, content);
            }

        }


    }
}
