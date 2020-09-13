﻿namespace AsynchronousDemo
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
            this.btnSyncReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbSyncProcessedTime = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbSyncJobs = new System.Windows.Forms.RichTextBox();
            this.btnSyncRun = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAsyncClockTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAsyncCPUTime = new System.Windows.Forms.Label();
            this.btnAsyncReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbAsyncProcessedTime = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbAsyncJobs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsyncRun = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblSyncClockTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSyncCPUTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1603, 960);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSyncClockTime);
            this.tabPage1.Controls.Add(this.label6);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAsyncClockTime);
            this.tabPage2.Controls.Add(this.label5);
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
            this.tabPage2.Text = "Async";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAsyncClockTime
            // 
            this.lblAsyncClockTime.AutoSize = true;
            this.lblAsyncClockTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsyncClockTime.Location = new System.Drawing.Point(884, 658);
            this.lblAsyncClockTime.Name = "lblAsyncClockTime";
            this.lblAsyncClockTime.Size = new System.Drawing.Size(0, 37);
            this.lblAsyncClockTime.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Clock Time :";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPU Time :";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(8, 71);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1587, 881);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Async Perf";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 55);
            this.label3.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(815, 763);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(768, 109);
            this.button3.TabIndex = 12;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox3);
            this.groupBox5.Location = new System.Drawing.Point(807, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(750, 634);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Process Time";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(0, 67);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(744, 561);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox4);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(777, 634);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jobs";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(-3, 61);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(774, 567);
            this.richTextBox4.TabIndex = 1;
            this.richTextBox4.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 688);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 55);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time Elapsed:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 763);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(768, 109);
            this.button4.TabIndex = 9;
            this.button4.Text = "Run ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblSyncClockTime
            // 
            this.lblSyncClockTime.AutoSize = true;
            this.lblSyncClockTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyncClockTime.Location = new System.Drawing.Point(884, 658);
            this.lblSyncClockTime.Name = "lblSyncClockTime";
            this.lblSyncClockTime.Size = new System.Drawing.Size(0, 37);
            this.lblSyncClockTime.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Clock Time :";
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
            this.label8.Size = new System.Drawing.Size(182, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "CPU Time :";
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbSyncProcessedTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbSyncJobs;
        private System.Windows.Forms.Button btnSyncRun;
        private System.Windows.Forms.Button btnSyncReset;
        private System.Windows.Forms.Label lblAsyncCPUTime;
        private System.Windows.Forms.Button btnAsyncReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbAsyncProcessedTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbAsyncJobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsyncRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblAsyncClockTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSyncClockTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSyncCPUTime;
        private System.Windows.Forms.Label label8;
    }
}

