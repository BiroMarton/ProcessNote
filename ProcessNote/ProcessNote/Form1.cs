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
        public Form1()
        {
            InitializeComponent();
            Process[] process = Process.GetProcesses();
            ListProcesses();
            Num.Text = process.Length.ToString();
            


             void ListProcesses()
            {
                foreach (Process p in process)
                {
                    Processes.Items.Add(p.ProcessName);
                }
            }
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
            StartNum.Text = proc[0].StartTime.ToString();
        }

        private void NoteSave_Click(object sender, EventArgs e)
        {
            String name = Processes.SelectedItem.ToString();
            String content = Note.Text;
            if (notes.ContainsKey(name))
            {
             
            }

        }
    }
}
