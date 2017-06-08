namespace ProcessNote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Processes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.Label();
            this.MemoryNum = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NoteSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CPUNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ThreadsNum = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Processes
            // 
            this.Processes.Sorted = true;
            this.Processes.FormattingEnabled = true;
            this.Processes.ItemHeight = 16;
            this.Processes.Location = new System.Drawing.Point(53, 71);
            this.Processes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Processes.Name = "Processes";
            this.Processes.Size = new System.Drawing.Size(300, 212);
            this.Processes.TabIndex = 0;
            this.Processes.SelectedIndexChanged += new System.EventHandler(this.Processes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Running processes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Running processes: ";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(699, 71);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(46, 17);
            this.Num.TabIndex = 4;
            this.Num.Text = "label3";
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Location = new System.Drawing.Point(381, 169);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(105, 17);
            this.Memory.TabIndex = 5;
            this.Memory.Text = "Memory usage:";
            // 
            // MemoryNum
            // 
            this.MemoryNum.AutoSize = true;
            this.MemoryNum.Location = new System.Drawing.Point(493, 167);
            this.MemoryNum.Name = "MemoryNum";
            this.MemoryNum.Size = new System.Drawing.Size(0, 17);
            this.MemoryNum.TabIndex = 6;
            // 
            // Note
            // 
            this.Note.AcceptsReturn = true;
            this.Note.Location = new System.Drawing.Point(53, 322);
            this.Note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(300, 194);
            this.Note.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Notes (Dada is only stored temporarily!!!)";
            // 
            // NoteSave
            // 
            this.NoteSave.Location = new System.Drawing.Point(361, 494);
            this.NoteSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteSave.Name = "NoteSave";
            this.NoteSave.Size = new System.Drawing.Size(75, 23);
            this.NoteSave.TabIndex = 11;
            this.NoteSave.Text = "Save";
            this.NoteSave.UseVisualStyleBackColor = true;
            this.NoteSave.Click += new System.EventHandler(this.NoteSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "CPU usage:";
            // 
            // CPUNum
            // 
            this.CPUNum.AutoSize = true;
            this.CPUNum.Location = new System.Drawing.Point(475, 203);
            this.CPUNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPUNum.Name = "CPUNum";
            this.CPUNum.Size = new System.Drawing.Size(0, 17);
            this.CPUNum.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Threads used:";
            // 
            // ThreadsNum
            // 
            this.ThreadsNum.AutoSize = true;
            this.ThreadsNum.Location = new System.Drawing.Point(489, 245);
            this.ThreadsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThreadsNum.Name = "ThreadsNum";
            this.ThreadsNum.Size = new System.Drawing.Size(0, 17);
            this.ThreadsNum.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(629, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 133);
            this.button2.TabIndex = 16;
            this.button2.Text = "Shut down the application slowly and painfully!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(719, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 59);
            this.button3.TabIndex = 17;
            this.button3.Text = "Turn me on!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(719, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Always on top";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ThreadsNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CPUNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoteSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.MemoryNum);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Processes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Processes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label Memory;
        private System.Windows.Forms.Label MemoryNum;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NoteSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CPUNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ThreadsNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Label label6;
    }
}

