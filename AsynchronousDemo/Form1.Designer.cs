namespace AsynchronousDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSyncCPUTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSyncReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbSyncProcessedTime = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbSyncJobs = new System.Windows.Forms.RichTextBox();
            this.btnSyncRun = new System.Windows.Forms.Button();
            this.btnAsyncRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbAsyncJobs = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbAsyncProcessedTime = new System.Windows.Forms.RichTextBox();
            this.btnAsyncReset = new System.Windows.Forms.Button();
            this.lblAsyncCPUTime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1603, 960);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSyncCPUTime);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnSyncReset);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSyncRun);
            this.tabPage1.Location = new System.Drawing.Point(8, 71);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1587, 881);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Synchronous";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSyncCPUTime
            // 
            this.lblSyncCPUTime.AutoSize = true;
            this.lblSyncCPUTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyncCPUTime.Location = new System.Drawing.Point(884, 707);
            this.lblSyncCPUTime.Name = "lblSyncCPUTime";
            this.lblSyncCPUTime.Size = new System.Drawing.Size(0, 37);
            this.lblSyncCPUTime.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(675, 707);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Time :";
            // 
            // btnSyncReset
            // 
            this.btnSyncReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncReset.Location = new System.Drawing.Point(815, 763);
            this.btnSyncReset.Name = "btnSyncReset";
            this.btnSyncReset.Size = new System.Drawing.Size(768, 109);
            this.btnSyncReset.TabIndex = 6;
            this.btnSyncReset.Text = "Reset";
            this.btnSyncReset.UseVisualStyleBackColor = true;
            this.btnSyncReset.Click += new System.EventHandler(this.btnSyncReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbSyncProcessedTime);
            this.groupBox2.Location = new System.Drawing.Point(807, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 634);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process Time";
            // 
            // rtbSyncProcessedTime
            // 
            this.rtbSyncProcessedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSyncProcessedTime.Location = new System.Drawing.Point(0, 67);
            this.rtbSyncProcessedTime.Name = "rtbSyncProcessedTime";
            this.rtbSyncProcessedTime.Size = new System.Drawing.Size(744, 561);
            this.rtbSyncProcessedTime.TabIndex = 0;
            this.rtbSyncProcessedTime.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbSyncJobs);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 634);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jobs";
            // 
            // rtbSyncJobs
            // 
            this.rtbSyncJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSyncJobs.Location = new System.Drawing.Point(-3, 61);
            this.rtbSyncJobs.Name = "rtbSyncJobs";
            this.rtbSyncJobs.Size = new System.Drawing.Size(774, 567);
            this.rtbSyncJobs.TabIndex = 1;
            this.rtbSyncJobs.Text = "";
            // 
            // btnSyncRun
            // 
            this.btnSyncRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncRun.Location = new System.Drawing.Point(3, 763);
            this.btnSyncRun.Name = "btnSyncRun";
            this.btnSyncRun.Size = new System.Drawing.Size(768, 109);
            this.btnSyncRun.TabIndex = 2;
            this.btnSyncRun.Text = "Run ";
            this.btnSyncRun.UseVisualStyleBackColor = true;
            this.btnSyncRun.Click += new System.EventHandler(this.btnSyncRun_Click);
            // 
            // btnAsyncRun
            // 
            this.btnAsyncRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsyncRun.Location = new System.Drawing.Point(3, 763);
            this.btnAsyncRun.Name = "btnAsyncRun";
            this.btnAsyncRun.Size = new System.Drawing.Size(768, 109);
            this.btnAsyncRun.TabIndex = 9;
            this.btnAsyncRun.Text = "Run ";
            this.btnAsyncRun.UseVisualStyleBackColor = true;
            this.btnAsyncRun.Click += new System.EventHandler(this.btnAsyncRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Time :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbAsyncJobs);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(777, 634);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jobs";
            // 
            // rtbAsyncJobs
            // 
            this.rtbAsyncJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAsyncJobs.Location = new System.Drawing.Point(-3, 61);
            this.rtbAsyncJobs.Name = "rtbAsyncJobs";
            this.rtbAsyncJobs.Size = new System.Drawing.Size(774, 567);
            this.rtbAsyncJobs.TabIndex = 1;
            this.rtbAsyncJobs.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbAsyncProcessedTime);
            this.groupBox3.Location = new System.Drawing.Point(807, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 634);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Time";
            // 
            // rtbAsyncProcessedTime
            // 
            this.rtbAsyncProcessedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAsyncProcessedTime.Location = new System.Drawing.Point(0, 67);
            this.rtbAsyncProcessedTime.Name = "rtbAsyncProcessedTime";
            this.rtbAsyncProcessedTime.Size = new System.Drawing.Size(744, 561);
            this.rtbAsyncProcessedTime.TabIndex = 0;
            this.rtbAsyncProcessedTime.Text = "";
            // 
            // btnAsyncReset
            // 
            this.btnAsyncReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsyncReset.Location = new System.Drawing.Point(815, 763);
            this.btnAsyncReset.Name = "btnAsyncReset";
            this.btnAsyncReset.Size = new System.Drawing.Size(768, 109);
            this.btnAsyncReset.TabIndex = 12;
            this.btnAsyncReset.Text = "Reset";
            this.btnAsyncReset.UseVisualStyleBackColor = true;
            this.btnAsyncReset.Click += new System.EventHandler(this.btnAsyncReset_Click);
            // 
            // lblAsyncCPUTime
            // 
            this.lblAsyncCPUTime.AutoSize = true;
            this.lblAsyncCPUTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsyncCPUTime.Location = new System.Drawing.Point(884, 707);
            this.lblAsyncCPUTime.Name = "lblAsyncCPUTime";
            this.lblAsyncCPUTime.Size = new System.Drawing.Size(0, 37);
            this.lblAsyncCPUTime.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAsyncCPUTime);
            this.tabPage2.Controls.Add(this.btnAsyncReset);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAsyncRun);
            this.tabPage2.Location = new System.Drawing.Point(8, 71);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1587, 881);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asynchronous";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 984);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Async Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbSyncProcessedTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbSyncJobs;
        private System.Windows.Forms.Button btnSyncRun;
        private System.Windows.Forms.Button btnSyncReset;
        private System.Windows.Forms.Label lblSyncCPUTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAsyncCPUTime;
        private System.Windows.Forms.Button btnAsyncReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbAsyncProcessedTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbAsyncJobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsyncRun;
    }
}

