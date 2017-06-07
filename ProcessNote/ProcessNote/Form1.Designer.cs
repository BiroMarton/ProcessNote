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
            this.ProcssStart = new System.Windows.Forms.Label();
            this.StartNum = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NoteSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Processes
            // 
            this.Processes.FormattingEnabled = true;
            this.Processes.ItemHeight = 16;
            this.Processes.Location = new System.Drawing.Point(54, 72);
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
            this.button1.Location = new System.Drawing.Point(370, 72);
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
            this.label2.Location = new System.Drawing.Point(554, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Running processes: ";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(698, 72);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(46, 17);
            this.Num.TabIndex = 4;
            this.Num.Text = "label3";
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Location = new System.Drawing.Point(444, 171);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(105, 17);
            this.Memory.TabIndex = 5;
            this.Memory.Text = "Memory usage:";
            // 
            // MemoryNum
            // 
            this.MemoryNum.AutoSize = true;
            this.MemoryNum.Location = new System.Drawing.Point(556, 170);
            this.MemoryNum.Name = "MemoryNum";
            this.MemoryNum.Size = new System.Drawing.Size(0, 17);
            this.MemoryNum.TabIndex = 6;
            // 
            // ProcssStart
            // 
            this.ProcssStart.AutoSize = true;
            this.ProcssStart.Location = new System.Drawing.Point(444, 192);
            this.ProcssStart.Name = "ProcssStart";
            this.ProcssStart.Size = new System.Drawing.Size(115, 17);
            this.ProcssStart.TabIndex = 7;
            this.ProcssStart.Text = "Process started: ";
            // 
            // StartNum
            // 
            this.StartNum.AutoSize = true;
            this.StartNum.Location = new System.Drawing.Point(557, 192);
            this.StartNum.Name = "StartNum";
            this.StartNum.Size = new System.Drawing.Size(0, 17);
            this.StartNum.TabIndex = 8;
            // 
            // Note
            // 
            this.Note.AcceptsReturn = true;
            this.Note.Location = new System.Drawing.Point(54, 323);
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
            this.NoteSave.Location = new System.Drawing.Point(361, 493);
            this.NoteSave.Name = "NoteSave";
            this.NoteSave.Size = new System.Drawing.Size(75, 23);
            this.NoteSave.TabIndex = 11;
            this.NoteSave.Text = "Save";
            this.NoteSave.UseVisualStyleBackColor = true;
            this.NoteSave.Click += new System.EventHandler(this.NoteSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.NoteSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.StartNum);
            this.Controls.Add(this.ProcssStart);
            this.Controls.Add(this.MemoryNum);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Processes);
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
        private System.Windows.Forms.Label ProcssStart;
        private System.Windows.Forms.Label StartNum;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NoteSave;
    }
}

