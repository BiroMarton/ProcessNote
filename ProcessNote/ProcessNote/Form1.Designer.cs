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
            this.SuspendLayout();
            // 
            // Processes
            // 
            this.Processes.FormattingEnabled = true;
            this.Processes.Location = new System.Drawing.Point(40, 58);
            this.Processes.Margin = new System.Windows.Forms.Padding(2);
            this.Processes.Name = "Processes";
            this.Processes.Size = new System.Drawing.Size(226, 173);
            this.Processes.TabIndex = 0;
            this.Processes.SelectedIndexChanged += new System.EventHandler(this.Processes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Running processes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Running processes: ";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(524, 58);
            this.Num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(35, 13);
            this.Num.TabIndex = 4;
            this.Num.Text = "label3";
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Location = new System.Drawing.Point(286, 137);
            this.Memory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(79, 13);
            this.Memory.TabIndex = 5;
            this.Memory.Text = "Memory usage:";
            // 
            // MemoryNum
            // 
            this.MemoryNum.AutoSize = true;
            this.MemoryNum.Location = new System.Drawing.Point(370, 136);
            this.MemoryNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemoryNum.Name = "MemoryNum";
            this.MemoryNum.Size = new System.Drawing.Size(0, 13);
            this.MemoryNum.TabIndex = 6;
            // 
            // Note
            // 
            this.Note.AcceptsReturn = true;
            this.Note.Location = new System.Drawing.Point(40, 262);
            this.Note.Margin = new System.Windows.Forms.Padding(2);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(226, 158);
            this.Note.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Notes (Dada is only stored temporarily!!!)";
            // 
            // NoteSave
            // 
            this.NoteSave.Location = new System.Drawing.Point(271, 401);
            this.NoteSave.Margin = new System.Windows.Forms.Padding(2);
            this.NoteSave.Name = "NoteSave";
            this.NoteSave.Size = new System.Drawing.Size(56, 19);
            this.NoteSave.TabIndex = 11;
            this.NoteSave.Text = "Save";
            this.NoteSave.UseVisualStyleBackColor = true;
            this.NoteSave.Click += new System.EventHandler(this.NoteSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CPU usage:";
            // 
            // CPUNum
            // 
            this.CPUNum.AutoSize = true;
            this.CPUNum.Location = new System.Drawing.Point(356, 150);
            this.CPUNum.Name = "CPUNum";
            this.CPUNum.Size = new System.Drawing.Size(0, 13);
            this.CPUNum.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 497);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

