namespace PAF_app2
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
            this.ListBoxProcesses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AB28_AB29 = new System.Windows.Forms.Panel();
            this.AB28_AB29_title = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.outputPath_txtBox = new System.Windows.Forms.TextBox();
            this.btnRunAB29 = new System.Windows.Forms.Button();
            this.runningJobsDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.waitingJobsDGV = new System.Windows.Forms.DataGridView();
            this.OwnCC_Open_Difference = new System.Windows.Forms.Panel();
            this.OwnCC_title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.outputPath_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PSPCCC_Cat = new System.Windows.Forms.Panel();
            this.RunCategorization = new System.Windows.Forms.Button();
            this.outputPathCat_txtBox = new System.Windows.Forms.TextBox();
            this.endDateCat_txtBox = new System.Windows.Forms.TextBox();
            this.startDateCat_txtbox = new System.Windows.Forms.TextBox();
            this.PSPCCC_Cat_title = new System.Windows.Forms.Label();
            this.AB28_AB29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningJobsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingJobsDGV)).BeginInit();
            this.OwnCC_Open_Difference.SuspendLayout();
            this.PSPCCC_Cat.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxProcesses
            // 
            this.ListBoxProcesses.BackColor = System.Drawing.SystemColors.Window;
            this.ListBoxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxProcesses.FormattingEnabled = true;
            this.ListBoxProcesses.ItemHeight = 18;
            this.ListBoxProcesses.Location = new System.Drawing.Point(35, 46);
            this.ListBoxProcesses.Name = "ListBoxProcesses";
            this.ListBoxProcesses.ScrollAlwaysVisible = true;
            this.ListBoxProcesses.Size = new System.Drawing.Size(241, 310);
            this.ListBoxProcesses.TabIndex = 5;
            this.ListBoxProcesses.SelectedIndexChanged += new System.EventHandler(this.ListBoxProcesses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(32, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1030, 3);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // AB28_AB29
            // 
            this.AB28_AB29.AutoSize = true;
            this.AB28_AB29.BackColor = System.Drawing.SystemColors.Control;
            this.AB28_AB29.Controls.Add(this.AB28_AB29_title);
            this.AB28_AB29.Controls.Add(this.label10);
            this.AB28_AB29.Controls.Add(this.outputPath_txtBox);
            this.AB28_AB29.Controls.Add(this.btnRunAB29);
            this.AB28_AB29.Location = new System.Drawing.Point(279, 46);
            this.AB28_AB29.Name = "AB28_AB29";
            this.AB28_AB29.Size = new System.Drawing.Size(790, 312);
            this.AB28_AB29.TabIndex = 6;
            // 
            // AB28_AB29_title
            // 
            this.AB28_AB29_title.AutoSize = true;
            this.AB28_AB29_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AB28_AB29_title.Location = new System.Drawing.Point(197, 19);
            this.AB28_AB29_title.Name = "AB28_AB29_title";
            this.AB28_AB29_title.Size = new System.Drawing.Size(137, 25);
            this.AB28_AB29_title.TabIndex = 12;
            this.AB28_AB29_title.Text = "AB28 / AB29";
            this.AB28_AB29_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Output Path:";
            // 
            // outputPath_txtBox
            // 
            this.outputPath_txtBox.Location = new System.Drawing.Point(105, 142);
            this.outputPath_txtBox.Name = "outputPath_txtBox";
            this.outputPath_txtBox.Size = new System.Drawing.Size(678, 22);
            this.outputPath_txtBox.TabIndex = 0;
            // 
            // btnRunAB29
            // 
            this.btnRunAB29.Location = new System.Drawing.Point(202, 252);
            this.btnRunAB29.Name = "btnRunAB29";
            this.btnRunAB29.Size = new System.Drawing.Size(325, 38);
            this.btnRunAB29.TabIndex = 1;
            this.btnRunAB29.Text = "Run AB28_AB29";
            this.btnRunAB29.UseVisualStyleBackColor = true;
            this.btnRunAB29.Click += new System.EventHandler(this.BtnRunAB29_Click);
            // 
            // runningJobsDGV
            // 
            this.runningJobsDGV.AllowUserToAddRows = false;
            this.runningJobsDGV.AllowUserToDeleteRows = false;
            this.runningJobsDGV.AllowUserToResizeRows = false;
            this.runningJobsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runningJobsDGV.Location = new System.Drawing.Point(279, 367);
            this.runningJobsDGV.Name = "runningJobsDGV";
            this.runningJobsDGV.ReadOnly = true;
            this.runningJobsDGV.RowHeadersVisible = false;
            this.runningJobsDGV.RowHeadersWidth = 51;
            this.runningJobsDGV.RowTemplate.Height = 24;
            this.runningJobsDGV.Size = new System.Drawing.Size(790, 203);
            this.runningJobsDGV.TabIndex = 18;
            this.runningJobsDGV.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.e);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1034, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "v0.1";
            // 
            // waitingJobsDGV
            // 
            this.waitingJobsDGV.AllowUserToAddRows = false;
            this.waitingJobsDGV.AllowUserToDeleteRows = false;
            this.waitingJobsDGV.AllowUserToResizeRows = false;
            this.waitingJobsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitingJobsDGV.Location = new System.Drawing.Point(32, 367);
            this.waitingJobsDGV.Name = "waitingJobsDGV";
            this.waitingJobsDGV.ReadOnly = true;
            this.waitingJobsDGV.RowHeadersVisible = false;
            this.waitingJobsDGV.RowHeadersWidth = 51;
            this.waitingJobsDGV.RowTemplate.Height = 24;
            this.waitingJobsDGV.Size = new System.Drawing.Size(241, 203);
            this.waitingJobsDGV.TabIndex = 20;
            // 
            // OwnCC_Open_Difference
            // 
            this.OwnCC_Open_Difference.AutoSize = true;
            this.OwnCC_Open_Difference.Controls.Add(this.OwnCC_title);
            this.OwnCC_Open_Difference.Location = new System.Drawing.Point(282, 45);
            this.OwnCC_Open_Difference.Name = "OwnCC_Open_Difference";
            this.OwnCC_Open_Difference.Size = new System.Drawing.Size(787, 313);
            this.OwnCC_Open_Difference.TabIndex = 21;
            // 
            // OwnCC_title
            // 
            this.OwnCC_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OwnCC_title.AutoSize = true;
            this.OwnCC_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnCC_title.Location = new System.Drawing.Point(212, 30);
            this.OwnCC_title.Name = "OwnCC_title";
            this.OwnCC_title.Size = new System.Drawing.Size(268, 25);
            this.OwnCC_title.TabIndex = 13;
            this.OwnCC_title.Text = "Own CC Open Differences";
            this.OwnCC_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "(yyyy-mm-dd)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "(yyyy-mm-dd)";
            // 
            // outputPath_lbl
            // 
            this.outputPath_lbl.AutoSize = true;
            this.outputPath_lbl.Location = new System.Drawing.Point(18, 173);
            this.outputPath_lbl.Name = "outputPath_lbl";
            this.outputPath_lbl.Size = new System.Drawing.Size(88, 17);
            this.outputPath_lbl.TabIndex = 13;
            this.outputPath_lbl.Text = "Output Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 14;
            // 
            // PSPCCC_Cat
            // 
            this.PSPCCC_Cat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PSPCCC_Cat.BackColor = System.Drawing.SystemColors.Control;
            this.PSPCCC_Cat.Controls.Add(this.label2);
            this.PSPCCC_Cat.Controls.Add(this.outputPath_lbl);
            this.PSPCCC_Cat.Controls.Add(this.outputPathCat_txtBox);
            this.PSPCCC_Cat.Controls.Add(this.PSPCCC_Cat_title);
            this.PSPCCC_Cat.Controls.Add(this.RunCategorization);
            this.PSPCCC_Cat.Controls.Add(this.label12);
            this.PSPCCC_Cat.Controls.Add(this.label11);
            this.PSPCCC_Cat.Controls.Add(this.label5);
            this.PSPCCC_Cat.Controls.Add(this.endDateCat_txtBox);
            this.PSPCCC_Cat.Controls.Add(this.label4);
            this.PSPCCC_Cat.Controls.Add(this.startDateCat_txtbox);
            this.PSPCCC_Cat.Location = new System.Drawing.Point(279, 47);
            this.PSPCCC_Cat.Name = "PSPCCC_Cat";
            this.PSPCCC_Cat.Size = new System.Drawing.Size(784, 310);
            this.PSPCCC_Cat.TabIndex = 7;
            this.PSPCCC_Cat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // RunCategorization
            // 
            this.RunCategorization.Location = new System.Drawing.Point(234, 252);
            this.RunCategorization.Name = "RunCategorization";
            this.RunCategorization.Size = new System.Drawing.Size(293, 38);
            this.RunCategorization.TabIndex = 3;
            this.RunCategorization.Text = "Run";
            this.RunCategorization.UseVisualStyleBackColor = true;
            this.RunCategorization.Click += new System.EventHandler(this.RunCategorization_Click);
            // 
            // outputPathCat_txtBox
            // 
            this.outputPathCat_txtBox.Location = new System.Drawing.Point(112, 170);
            this.outputPathCat_txtBox.Name = "outputPathCat_txtBox";
            this.outputPathCat_txtBox.Size = new System.Drawing.Size(668, 22);
            this.outputPathCat_txtBox.TabIndex = 2;
            // 
            // endDateCat_txtBox
            // 
            this.endDateCat_txtBox.Location = new System.Drawing.Point(112, 117);
            this.endDateCat_txtBox.Name = "endDateCat_txtBox";
            this.endDateCat_txtBox.Size = new System.Drawing.Size(135, 22);
            this.endDateCat_txtBox.TabIndex = 1;
            // 
            // startDateCat_txtbox
            // 
            this.startDateCat_txtbox.Location = new System.Drawing.Point(112, 69);
            this.startDateCat_txtbox.Name = "startDateCat_txtbox";
            this.startDateCat_txtbox.Size = new System.Drawing.Size(135, 22);
            this.startDateCat_txtbox.TabIndex = 0;
            // 
            // PSPCCC_Cat_title
            // 
            this.PSPCCC_Cat_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PSPCCC_Cat_title.AutoSize = true;
            this.PSPCCC_Cat_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSPCCC_Cat_title.Location = new System.Drawing.Point(196, 19);
            this.PSPCCC_Cat_title.Name = "PSPCCC_Cat_title";
            this.PSPCCC_Cat_title.Size = new System.Drawing.Size(152, 25);
            this.PSPCCC_Cat_title.TabIndex = 11;
            this.PSPCCC_Cat_title.Text = "Categorization";
            this.PSPCCC_Cat_title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1086, 595);
            this.Controls.Add(this.waitingJobsDGV);
            this.Controls.Add(this.ListBoxProcesses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.runningJobsDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PSPCCC_Cat);
            this.Controls.Add(this.OwnCC_Open_Difference);
            this.Controls.Add(this.AB28_AB29);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AB28_AB29.ResumeLayout(false);
            this.AB28_AB29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningJobsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingJobsDGV)).EndInit();
            this.OwnCC_Open_Difference.ResumeLayout(false);
            this.OwnCC_Open_Difference.PerformLayout();
            this.PSPCCC_Cat.ResumeLayout(false);
            this.PSPCCC_Cat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBoxProcesses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel AB28_AB29;
        private System.Windows.Forms.Button btnRunAB29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox outputPath_txtBox;
        private System.Windows.Forms.Label AB28_AB29_title;
        private System.Windows.Forms.DataGridView runningJobsDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView waitingJobsDGV;
        private System.Windows.Forms.Panel OwnCC_Open_Difference;
        private System.Windows.Forms.Label OwnCC_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label outputPath_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PSPCCC_Cat;
        private System.Windows.Forms.Button RunCategorization;
        private System.Windows.Forms.TextBox outputPathCat_txtBox;
        private System.Windows.Forms.TextBox endDateCat_txtBox;
        private System.Windows.Forms.TextBox startDateCat_txtbox;
        private System.Windows.Forms.Label PSPCCC_Cat_title;
    }
}

