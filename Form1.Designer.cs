﻿namespace PAF_app2
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
            this.ExecuteQuery = new System.Windows.Forms.Button();
            this.Path2Save = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.TextBox();
            this.ListBoxProcesses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRunAB29 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.Location = new System.Drawing.Point(389, 416);
            this.ExecuteQuery.Name = "ExecuteQuery";
            this.ExecuteQuery.Size = new System.Drawing.Size(337, 40);
            this.ExecuteQuery.TabIndex = 0;
            this.ExecuteQuery.Text = "ExecuteQuery";
            this.ExecuteQuery.UseVisualStyleBackColor = true;
            this.ExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_Click);
            // 
            // Path2Save
            // 
            this.Path2Save.Location = new System.Drawing.Point(169, 379);
            this.Path2Save.Name = "Path2Save";
            this.Path2Save.Size = new System.Drawing.Size(557, 22);
            this.Path2Save.TabIndex = 1;
            this.Path2Save.TextChanged += new System.EventHandler(this.InputQueryText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filename";
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(169, 425);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(214, 22);
            this.Filename.TabIndex = 4;
            // 
            // ListBoxProcesses
            // 
            this.ListBoxProcesses.FormattingEnabled = true;
            this.ListBoxProcesses.ItemHeight = 16;
            this.ListBoxProcesses.Items.AddRange(new object[] {
            "TEST QUERY",
            "TEST2",
            "AB29_TEST"});
            this.ListBoxProcesses.Location = new System.Drawing.Point(71, 58);
            this.ListBoxProcesses.Name = "ListBoxProcesses";
            this.ListBoxProcesses.ScrollAlwaysVisible = true;
            this.ListBoxProcesses.Size = new System.Drawing.Size(168, 292);
            this.ListBoxProcesses.TabIndex = 5;
            this.ListBoxProcesses.SelectedIndexChanged += new System.EventHandler(this.ListBoxProcesses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(9, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(782, 2);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(260, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 292);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnRunAB29);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(263, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 286);
            this.panel2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(307, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 0;
            // 
            // btnRunAB29
            // 
            this.btnRunAB29.Location = new System.Drawing.Point(126, 260);
            this.btnRunAB29.Name = "btnRunAB29";
            this.btnRunAB29.Size = new System.Drawing.Size(325, 23);
            this.btnRunAB29.TabIndex = 2;
            this.btnRunAB29.Text = "Run AB29";
            this.btnRunAB29.UseVisualStyleBackColor = true;
            this.btnRunAB29.Click += new System.EventHandler(this.BtnRunAB29_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxProcesses);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path2Save);
            this.Controls.Add(this.ExecuteQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteQuery;
        private System.Windows.Forms.TextBox Path2Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.ListBox ListBoxProcesses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnRunAB29;
    }
}

