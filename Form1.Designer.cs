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
            this.outputPath_AB_txtBox = new System.Windows.Forms.TextBox();
            this.btnRunAB29 = new System.Windows.Forms.Button();
            this.runningJobsDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.waitingJobsDGV = new System.Windows.Forms.DataGridView();
            this.OwnCC_Open_Diff = new System.Windows.Forms.Panel();
            this.RunOwnCC_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputPath_OwnCC_txtBox = new System.Windows.Forms.TextBox();
            this.OwnCC_title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.outputPath_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PSPCCC_Cat = new System.Windows.Forms.Panel();
            this.outputPathCat_txtBox = new System.Windows.Forms.TextBox();
            this.PSPCCC_Cat_title = new System.Windows.Forms.Label();
            this.RunCategorization = new System.Windows.Forms.Button();
            this.endDateCat_txtBox = new System.Windows.Forms.TextBox();
            this.startDateCat_txtbox = new System.Windows.Forms.TextBox();
            this.FXRate = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FXRate_outputPath_txtBox = new System.Windows.Forms.TextBox();
            this.FXRate_title = new System.Windows.Forms.Label();
            this.RunFXRate_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FXRate_endDate_txtBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.FXRate_startDate_txtBox = new System.Windows.Forms.TextBox();
            this.Chargeback = new System.Windows.Forms.Panel();
            this.Run_Chargeback = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.ChargebackInputPath_txtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChargebackOutputPath_txtBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ChargebackEndDate_txtBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ChargebackStartDate_txtBox = new System.Windows.Forms.TextBox();
            this.chargeback_title = new System.Windows.Forms.Label();
            this.AB28_AB29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningJobsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingJobsDGV)).BeginInit();
            this.OwnCC_Open_Diff.SuspendLayout();
            this.PSPCCC_Cat.SuspendLayout();
            this.FXRate.SuspendLayout();
            this.Chargeback.SuspendLayout();
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
            this.AB28_AB29.Controls.Add(this.outputPath_AB_txtBox);
            this.AB28_AB29.Controls.Add(this.btnRunAB29);
            this.AB28_AB29.Location = new System.Drawing.Point(279, 45);
            this.AB28_AB29.Name = "AB28_AB29";
            this.AB28_AB29.Size = new System.Drawing.Size(790, 319);
            this.AB28_AB29.TabIndex = 6;
            // 
            // AB28_AB29_title
            // 
            this.AB28_AB29_title.AutoSize = true;
            this.AB28_AB29_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AB28_AB29_title.Location = new System.Drawing.Point(298, 21);
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
            // outputPath_AB_txtBox
            // 
            this.outputPath_AB_txtBox.Location = new System.Drawing.Point(105, 142);
            this.outputPath_AB_txtBox.Name = "outputPath_AB_txtBox";
            this.outputPath_AB_txtBox.Size = new System.Drawing.Size(678, 22);
            this.outputPath_AB_txtBox.TabIndex = 0;
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
            // OwnCC_Open_Diff
            // 
            this.OwnCC_Open_Diff.AutoSize = true;
            this.OwnCC_Open_Diff.Controls.Add(this.RunOwnCC_btn);
            this.OwnCC_Open_Diff.Controls.Add(this.label1);
            this.OwnCC_Open_Diff.Controls.Add(this.outputPath_OwnCC_txtBox);
            this.OwnCC_Open_Diff.Controls.Add(this.OwnCC_title);
            this.OwnCC_Open_Diff.Location = new System.Drawing.Point(282, 45);
            this.OwnCC_Open_Diff.Name = "OwnCC_Open_Diff";
            this.OwnCC_Open_Diff.Size = new System.Drawing.Size(787, 313);
            this.OwnCC_Open_Diff.TabIndex = 21;
            // 
            // RunOwnCC_btn
            // 
            this.RunOwnCC_btn.Location = new System.Drawing.Point(261, 252);
            this.RunOwnCC_btn.Name = "RunOwnCC_btn";
            this.RunOwnCC_btn.Size = new System.Drawing.Size(241, 40);
            this.RunOwnCC_btn.TabIndex = 16;
            this.RunOwnCC_btn.Text = "Run OwnCC Open Differences";
            this.RunOwnCC_btn.UseVisualStyleBackColor = true;
            this.RunOwnCC_btn.Click += new System.EventHandler(this.RunOwnCC_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Output Path:";
            // 
            // outputPath_OwnCC_txtBox
            // 
            this.outputPath_OwnCC_txtBox.Location = new System.Drawing.Point(99, 145);
            this.outputPath_OwnCC_txtBox.Name = "outputPath_OwnCC_txtBox";
            this.outputPath_OwnCC_txtBox.Size = new System.Drawing.Size(678, 22);
            this.outputPath_OwnCC_txtBox.TabIndex = 14;
            // 
            // OwnCC_title
            // 
            this.OwnCC_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OwnCC_title.AutoSize = true;
            this.OwnCC_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnCC_title.Location = new System.Drawing.Point(256, 21);
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
            // 
            // outputPathCat_txtBox
            // 
            this.outputPathCat_txtBox.Location = new System.Drawing.Point(112, 170);
            this.outputPathCat_txtBox.Name = "outputPathCat_txtBox";
            this.outputPathCat_txtBox.Size = new System.Drawing.Size(668, 22);
            this.outputPathCat_txtBox.TabIndex = 2;
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
            // FXRate
            // 
            this.FXRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FXRate.BackColor = System.Drawing.SystemColors.Control;
            this.FXRate.Controls.Add(this.label7);
            this.FXRate.Controls.Add(this.label8);
            this.FXRate.Controls.Add(this.FXRate_outputPath_txtBox);
            this.FXRate.Controls.Add(this.FXRate_title);
            this.FXRate.Controls.Add(this.RunFXRate_btn);
            this.FXRate.Controls.Add(this.label13);
            this.FXRate.Controls.Add(this.label14);
            this.FXRate.Controls.Add(this.label15);
            this.FXRate.Controls.Add(this.FXRate_endDate_txtBox);
            this.FXRate.Controls.Add(this.label16);
            this.FXRate.Controls.Add(this.FXRate_startDate_txtBox);
            this.FXRate.Location = new System.Drawing.Point(283, 47);
            this.FXRate.Name = "FXRate";
            this.FXRate.Size = new System.Drawing.Size(784, 310);
            this.FXRate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Output Path:";
            // 
            // FXRate_outputPath_txtBox
            // 
            this.FXRate_outputPath_txtBox.Location = new System.Drawing.Point(112, 170);
            this.FXRate_outputPath_txtBox.Name = "FXRate_outputPath_txtBox";
            this.FXRate_outputPath_txtBox.Size = new System.Drawing.Size(668, 22);
            this.FXRate_outputPath_txtBox.TabIndex = 2;
            // 
            // FXRate_title
            // 
            this.FXRate_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FXRate_title.AutoSize = true;
            this.FXRate_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FXRate_title.Location = new System.Drawing.Point(196, 19);
            this.FXRate_title.Name = "FXRate_title";
            this.FXRate_title.Size = new System.Drawing.Size(232, 25);
            this.FXRate_title.TabIndex = 11;
            this.FXRate_title.Text = "FX Rate - PL63000022";
            // 
            // RunFXRate_btn
            // 
            this.RunFXRate_btn.Location = new System.Drawing.Point(234, 252);
            this.RunFXRate_btn.Name = "RunFXRate_btn";
            this.RunFXRate_btn.Size = new System.Drawing.Size(293, 38);
            this.RunFXRate_btn.TabIndex = 3;
            this.RunFXRate_btn.Text = "Run FX Rate";
            this.RunFXRate_btn.UseVisualStyleBackColor = true;
            this.RunFXRate_btn.Click += new System.EventHandler(this.RunFXRate_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "(yyyy-mm-dd)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "(yyyy-mm-dd)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "End Date:";
            // 
            // FXRate_endDate_txtBox
            // 
            this.FXRate_endDate_txtBox.Location = new System.Drawing.Point(112, 117);
            this.FXRate_endDate_txtBox.Name = "FXRate_endDate_txtBox";
            this.FXRate_endDate_txtBox.Size = new System.Drawing.Size(135, 22);
            this.FXRate_endDate_txtBox.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Start Date:";
            // 
            // FXRate_startDate_txtBox
            // 
            this.FXRate_startDate_txtBox.Location = new System.Drawing.Point(112, 69);
            this.FXRate_startDate_txtBox.Name = "FXRate_startDate_txtBox";
            this.FXRate_startDate_txtBox.Size = new System.Drawing.Size(135, 22);
            this.FXRate_startDate_txtBox.TabIndex = 0;
            // 
            // Chargeback
            // 
            this.Chargeback.Controls.Add(this.Run_Chargeback);
            this.Chargeback.Controls.Add(this.label21);
            this.Chargeback.Controls.Add(this.ChargebackInputPath_txtBox);
            this.Chargeback.Controls.Add(this.label9);
            this.Chargeback.Controls.Add(this.ChargebackOutputPath_txtBox);
            this.Chargeback.Controls.Add(this.label17);
            this.Chargeback.Controls.Add(this.label18);
            this.Chargeback.Controls.Add(this.label19);
            this.Chargeback.Controls.Add(this.ChargebackEndDate_txtBox);
            this.Chargeback.Controls.Add(this.label20);
            this.Chargeback.Controls.Add(this.ChargebackStartDate_txtBox);
            this.Chargeback.Controls.Add(this.chargeback_title);
            this.Chargeback.Location = new System.Drawing.Point(278, 42);
            this.Chargeback.Name = "Chargeback";
            this.Chargeback.Size = new System.Drawing.Size(790, 318);
            this.Chargeback.TabIndex = 22;
            // 
            // Run_Chargeback
            // 
            this.Run_Chargeback.Location = new System.Drawing.Point(233, 262);
            this.Run_Chargeback.Name = "Run_Chargeback";
            this.Run_Chargeback.Size = new System.Drawing.Size(325, 38);
            this.Run_Chargeback.TabIndex = 24;
            this.Run_Chargeback.Text = "Run Chargeback";
            this.Run_Chargeback.UseVisualStyleBackColor = true;
            this.Run_Chargeback.Click += new System.EventHandler(this.Run_Chargeback_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 188);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 17);
            this.label21.TabIndex = 23;
            this.label21.Text = "Input Path:";
            // 
            // ChargebackInputPath_txtBox
            // 
            this.ChargebackInputPath_txtBox.Location = new System.Drawing.Point(108, 185);
            this.ChargebackInputPath_txtBox.Name = "ChargebackInputPath_txtBox";
            this.ChargebackInputPath_txtBox.Size = new System.Drawing.Size(668, 22);
            this.ChargebackInputPath_txtBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Output Path:";
            // 
            // ChargebackOutputPath_txtBox
            // 
            this.ChargebackOutputPath_txtBox.Location = new System.Drawing.Point(108, 231);
            this.ChargebackOutputPath_txtBox.Name = "ChargebackOutputPath_txtBox";
            this.ChargebackOutputPath_txtBox.Size = new System.Drawing.Size(668, 22);
            this.ChargebackOutputPath_txtBox.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(28, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "(yyyy-mm-dd)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "(yyyy-mm-dd)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "End Date:";
            // 
            // ChargebackEndDate_txtBox
            // 
            this.ChargebackEndDate_txtBox.Location = new System.Drawing.Point(108, 147);
            this.ChargebackEndDate_txtBox.Name = "ChargebackEndDate_txtBox";
            this.ChargebackEndDate_txtBox.Size = new System.Drawing.Size(135, 22);
            this.ChargebackEndDate_txtBox.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "Start Date:";
            // 
            // ChargebackStartDate_txtBox
            // 
            this.ChargebackStartDate_txtBox.Location = new System.Drawing.Point(108, 99);
            this.ChargebackStartDate_txtBox.Name = "ChargebackStartDate_txtBox";
            this.ChargebackStartDate_txtBox.Size = new System.Drawing.Size(135, 22);
            this.ChargebackStartDate_txtBox.TabIndex = 14;
            // 
            // chargeback_title
            // 
            this.chargeback_title.AutoSize = true;
            this.chargeback_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargeback_title.Location = new System.Drawing.Point(327, 26);
            this.chargeback_title.Name = "chargeback_title";
            this.chargeback_title.Size = new System.Drawing.Size(129, 25);
            this.chargeback_title.TabIndex = 13;
            this.chargeback_title.Text = "Chargeback";
            this.chargeback_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Controls.Add(this.OwnCC_Open_Diff);
            this.Controls.Add(this.Chargeback);
            this.Controls.Add(this.AB28_AB29);
            this.Controls.Add(this.FXRate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AB28_AB29.ResumeLayout(false);
            this.AB28_AB29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningJobsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingJobsDGV)).EndInit();
            this.OwnCC_Open_Diff.ResumeLayout(false);
            this.OwnCC_Open_Diff.PerformLayout();
            this.PSPCCC_Cat.ResumeLayout(false);
            this.PSPCCC_Cat.PerformLayout();
            this.FXRate.ResumeLayout(false);
            this.FXRate.PerformLayout();
            this.Chargeback.ResumeLayout(false);
            this.Chargeback.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBoxProcesses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel AB28_AB29;
        private System.Windows.Forms.Button btnRunAB29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox outputPath_AB_txtBox;
        private System.Windows.Forms.Label AB28_AB29_title;
        private System.Windows.Forms.DataGridView runningJobsDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView waitingJobsDGV;
        private System.Windows.Forms.Panel OwnCC_Open_Diff;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputPath_OwnCC_txtBox;
        private System.Windows.Forms.Button RunOwnCC_btn;
        private System.Windows.Forms.Panel FXRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FXRate_outputPath_txtBox;
        private System.Windows.Forms.Label FXRate_title;
        private System.Windows.Forms.Button RunFXRate_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox FXRate_endDate_txtBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox FXRate_startDate_txtBox;
        private System.Windows.Forms.Panel Chargeback;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ChargebackInputPath_txtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ChargebackOutputPath_txtBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ChargebackEndDate_txtBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ChargebackStartDate_txtBox;
        private System.Windows.Forms.Label chargeback_title;
        private System.Windows.Forms.Button Run_Chargeback;
    }
}

