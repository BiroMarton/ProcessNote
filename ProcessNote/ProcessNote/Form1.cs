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
using System.Windows.Forms.VisualStyles;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> notes = new Dictionary<string, string>();
        Process[] process = Process.GetProcesses();

        public void getProcess()
        {
            foreach (Process p in process)
            {
                Processes.Items.Add(p.ProcessName + " - " + p.Id);
            }
            Num.Text = process.Length.ToString();
        }


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

        string t1 = "FATAL ERROR!!!";
        string t2 = "???";
        string t3 = "SYSTEM FAILURE!!!";
        int time = 0;

        public Form1()
        {
         
            InitializeComponent();
            timer1.Enabled = false;
            this.TopMost = false;
            getProcess();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Processes.Items.Clear();
            getProcess();


        }

        private void Processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String longName = Processes.SelectedItem.ToString();
            string name = longName.Substring(0,longName.IndexOf("-")-1);
            string id = longName.Substring(longName.IndexOf("-") + 2);
            Process[] proc = Process.GetProcessesByName(name);
            MemoryNum.Text = (proc[0].PrivateMemorySize64 / (1024 * 1024)).ToString() + " MB";
            notes.TryGetValue(id, out string o);
            Note.Text = o;
            CPUNum.Text = RunTest(name).ToString() + "%";
            ProcessThreadCollection a = proc[0].Threads;
            ThreadsNum.Text = a.Count.ToString();




        }

        private void NoteSave_Click(object sender, EventArgs e)
        {
            String longName = Processes.SelectedItem.ToString();
            String name = longName.Substring( longName.IndexOf("-") + 2);
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (time)

            {
                case 1:
                    button2.Text = "CRITICAL SYSTEM FAILURE! SHUTTING DOWN!";
                    break;

                case 3:
                    button1.Text = t2;
                    MemoryNum.Text = t1;
                    break;
                case 5:
                    Processes.Items.Clear();
                    for (var i = 0; i < 3; i++)
                    {
                        Processes.Items.Add(t1);

                    }
                    button3.Text = t2;
                    break;
                case 7:
                    label6.Text = t3;
                    ThreadsNum.Text = t1;
                    break;
                case 11:
                    Num.Text = "9999999999999999999999999+";
                    label2.Text = t2;
                    label3.Text = t2;
                    break;
                case 13:
                    for (var i = 0; i < 3; i++)
                    {
                        Processes.Items.Add(t1);

                    }
                    break;
                case 16:
                    button2.Text = t1;
                    Memory.Text = t3;
                    Note.Text = "Data is corrupted, all progress is lost!";
                    break;
                case 22:
                    label4.Text = t2;
                    label5.Text = t3;
                    NoteSave.Text = t2;
                    break;

            }

            time += 1;

            if(time == 30)
            {
                this.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TopMost = !(this.TopMost);
            if (this.TopMost == true)
            {
                button3.Text = "Turn me off";
            }
            else
            {
                button3.Text = "Turn me on!";
            }
        }
    }
}
