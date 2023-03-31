namespace HSMActorModelPoC
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblHSMCount = new Label();
            neHSMCount = new NumericUpDown();
            grpHSM = new GroupBox();
            pnlHSMList = new Panel();
            hsmComponent1 = new HsmComponent();
            hsmComponent2 = new HsmComponent();
            hsmComponent3 = new HsmComponent();
            hsmComponent4 = new HsmComponent();
            hsmComponent5 = new HsmComponent();
            hsmComponent6 = new HsmComponent();
            hsmComponent7 = new HsmComponent();
            hsmComponent8 = new HsmComponent();
            hsmComponent9 = new HsmComponent();
            hsmComponent10 = new HsmComponent();
            hsmComponent11 = new HsmComponent();
            hsmComponent12 = new HsmComponent();
            btnStart = new Button();
            neACount = new NumericUpDown();
            lblACount = new Label();
            neBCount = new NumericUpDown();
            lblBCount = new Label();
            neCCount = new NumericUpDown();
            lblCCount = new Label();
            neCRemainingCount = new NumericUpDown();
            lblRemainingCDataCount = new Label();
            neBRemainingCount = new NumericUpDown();
            lblRemainingBDataCount = new Label();
            neARemainingCount = new NumericUpDown();
            lblRemainingADataCount = new Label();
            neCurrentTPS = new NumericUpDown();
            lblCurrentTPS = new Label();
            neMaxTPS = new NumericUpDown();
            lblMaxTPS = new Label();
            tmrTPS = new System.Windows.Forms.Timer(components);
            lblDuration = new Label();
            txtDuration = new TextBox();
            tmrDuration = new System.Windows.Forms.Timer(components);
            btnHSMTest = new Button();
            ((System.ComponentModel.ISupportInitialize)neHSMCount).BeginInit();
            grpHSM.SuspendLayout();
            pnlHSMList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)neACount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neBCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neCCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neCRemainingCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neBRemainingCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neARemainingCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neCurrentTPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)neMaxTPS).BeginInit();
            SuspendLayout();
            // 
            // lblHSMCount
            // 
            lblHSMCount.AutoSize = true;
            lblHSMCount.Location = new Point(12, 9);
            lblHSMCount.Name = "lblHSMCount";
            lblHSMCount.Size = new Size(75, 15);
            lblHSMCount.TabIndex = 0;
            lblHSMCount.Text = "HSM Count :";
            // 
            // neHSMCount
            // 
            neHSMCount.Location = new Point(93, 7);
            neHSMCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            neHSMCount.Name = "neHSMCount";
            neHSMCount.ReadOnly = true;
            neHSMCount.Size = new Size(96, 23);
            neHSMCount.TabIndex = 1;
            neHSMCount.TextAlign = HorizontalAlignment.Right;
            neHSMCount.Value = new decimal(new int[] { 4, 0, 0, 0 });
            neHSMCount.ValueChanged += neHSMCount_ValueChanged;
            // 
            // grpHSM
            // 
            grpHSM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpHSM.Controls.Add(pnlHSMList);
            grpHSM.Location = new Point(12, 97);
            grpHSM.Name = "grpHSM";
            grpHSM.Size = new Size(858, 539);
            grpHSM.TabIndex = 2;
            grpHSM.TabStop = false;
            grpHSM.Text = "HSM List";
            // 
            // pnlHSMList
            // 
            pnlHSMList.AutoScroll = true;
            pnlHSMList.BackColor = Color.White;
            pnlHSMList.Controls.Add(hsmComponent1);
            pnlHSMList.Controls.Add(hsmComponent2);
            pnlHSMList.Controls.Add(hsmComponent3);
            pnlHSMList.Controls.Add(hsmComponent4);
            pnlHSMList.Controls.Add(hsmComponent5);
            pnlHSMList.Controls.Add(hsmComponent6);
            pnlHSMList.Controls.Add(hsmComponent7);
            pnlHSMList.Controls.Add(hsmComponent8);
            pnlHSMList.Controls.Add(hsmComponent9);
            pnlHSMList.Controls.Add(hsmComponent10);
            pnlHSMList.Controls.Add(hsmComponent11);
            pnlHSMList.Controls.Add(hsmComponent12);
            pnlHSMList.Dock = DockStyle.Fill;
            pnlHSMList.Location = new Point(3, 19);
            pnlHSMList.Name = "pnlHSMList";
            pnlHSMList.Size = new Size(852, 517);
            pnlHSMList.TabIndex = 0;
            // 
            // hsmComponent1
            // 
            hsmComponent1.Location = new Point(3, 3);
            hsmComponent1.Name = "hsmComponent1";
            hsmComponent1.Size = new Size(203, 251);
            hsmComponent1.TabIndex = 0;
            // 
            // hsmComponent2
            // 
            hsmComponent2.Location = new Point(212, 3);
            hsmComponent2.Name = "hsmComponent2";
            hsmComponent2.Size = new Size(203, 251);
            hsmComponent2.TabIndex = 1;
            // 
            // hsmComponent3
            // 
            hsmComponent3.Location = new Point(421, 3);
            hsmComponent3.Name = "hsmComponent3";
            hsmComponent3.Size = new Size(203, 251);
            hsmComponent3.TabIndex = 2;
            // 
            // hsmComponent4
            // 
            hsmComponent4.Location = new Point(630, 3);
            hsmComponent4.Name = "hsmComponent4";
            hsmComponent4.Size = new Size(203, 251);
            hsmComponent4.TabIndex = 3;
            // 
            // hsmComponent5
            // 
            hsmComponent5.Location = new Point(630, 260);
            hsmComponent5.Name = "hsmComponent5";
            hsmComponent5.Size = new Size(203, 251);
            hsmComponent5.TabIndex = 7;
            // 
            // hsmComponent6
            // 
            hsmComponent6.Location = new Point(421, 260);
            hsmComponent6.Name = "hsmComponent6";
            hsmComponent6.Size = new Size(203, 251);
            hsmComponent6.TabIndex = 6;
            // 
            // hsmComponent7
            // 
            hsmComponent7.Location = new Point(212, 260);
            hsmComponent7.Name = "hsmComponent7";
            hsmComponent7.Size = new Size(203, 251);
            hsmComponent7.TabIndex = 5;
            // 
            // hsmComponent8
            // 
            hsmComponent8.Location = new Point(3, 260);
            hsmComponent8.Name = "hsmComponent8";
            hsmComponent8.Size = new Size(203, 251);
            hsmComponent8.TabIndex = 4;
            // 
            // hsmComponent9
            // 
            hsmComponent9.Location = new Point(630, 517);
            hsmComponent9.Name = "hsmComponent9";
            hsmComponent9.Size = new Size(203, 251);
            hsmComponent9.TabIndex = 11;
            // 
            // hsmComponent10
            // 
            hsmComponent10.Location = new Point(421, 517);
            hsmComponent10.Name = "hsmComponent10";
            hsmComponent10.Size = new Size(203, 251);
            hsmComponent10.TabIndex = 10;
            // 
            // hsmComponent11
            // 
            hsmComponent11.Location = new Point(212, 517);
            hsmComponent11.Name = "hsmComponent11";
            hsmComponent11.Size = new Size(203, 251);
            hsmComponent11.TabIndex = 9;
            // 
            // hsmComponent12
            // 
            hsmComponent12.Location = new Point(3, 517);
            hsmComponent12.Name = "hsmComponent12";
            hsmComponent12.Size = new Size(203, 251);
            hsmComponent12.TabIndex = 8;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(93, 37);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // neACount
            // 
            neACount.Location = new Point(319, 7);
            neACount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neACount.Name = "neACount";
            neACount.Size = new Size(96, 23);
            neACount.TabIndex = 7;
            neACount.TextAlign = HorizontalAlignment.Right;
            neACount.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            neACount.ValueChanged += neACount_ValueChanged;
            // 
            // lblACount
            // 
            lblACount.AutoSize = true;
            lblACount.Location = new Point(229, 9);
            lblACount.Name = "lblACount";
            lblACount.Size = new Size(84, 15);
            lblACount.TabIndex = 6;
            lblACount.Text = "A Data Count :";
            // 
            // neBCount
            // 
            neBCount.Location = new Point(517, 7);
            neBCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neBCount.Name = "neBCount";
            neBCount.Size = new Size(96, 23);
            neBCount.TabIndex = 9;
            neBCount.TextAlign = HorizontalAlignment.Right;
            neBCount.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            neBCount.ValueChanged += neBCount_ValueChanged;
            // 
            // lblBCount
            // 
            lblBCount.AutoSize = true;
            lblBCount.Location = new Point(428, 9);
            lblBCount.Name = "lblBCount";
            lblBCount.Size = new Size(83, 15);
            lblBCount.TabIndex = 8;
            lblBCount.Text = "B Data Count :";
            // 
            // neCCount
            // 
            neCCount.Location = new Point(720, 7);
            neCCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neCCount.Name = "neCCount";
            neCCount.Size = new Size(96, 23);
            neCCount.TabIndex = 11;
            neCCount.TextAlign = HorizontalAlignment.Right;
            neCCount.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            neCCount.ValueChanged += neCCount_ValueChanged;
            // 
            // lblCCount
            // 
            lblCCount.AutoSize = true;
            lblCCount.Location = new Point(630, 9);
            lblCCount.Name = "lblCCount";
            lblCCount.Size = new Size(84, 15);
            lblCCount.TabIndex = 10;
            lblCCount.Text = "C Data Count :";
            // 
            // neCRemainingCount
            // 
            neCRemainingCount.Enabled = false;
            neCRemainingCount.Location = new Point(720, 39);
            neCRemainingCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neCRemainingCount.Minimum = new decimal(new int[] { 100000000, 0, 0, int.MinValue });
            neCRemainingCount.Name = "neCRemainingCount";
            neCRemainingCount.ReadOnly = true;
            neCRemainingCount.Size = new Size(96, 23);
            neCRemainingCount.TabIndex = 17;
            neCRemainingCount.TextAlign = HorizontalAlignment.Right;
            neCRemainingCount.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // lblRemainingCDataCount
            // 
            lblRemainingCDataCount.AutoSize = true;
            lblRemainingCDataCount.Location = new Point(630, 41);
            lblRemainingCDataCount.Name = "lblRemainingCDataCount";
            lblRemainingCDataCount.Size = new Size(70, 15);
            lblRemainingCDataCount.TabIndex = 16;
            lblRemainingCDataCount.Text = "Remaining :";
            // 
            // neBRemainingCount
            // 
            neBRemainingCount.Enabled = false;
            neBRemainingCount.Location = new Point(517, 39);
            neBRemainingCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neBRemainingCount.Minimum = new decimal(new int[] { 100000000, 0, 0, int.MinValue });
            neBRemainingCount.Name = "neBRemainingCount";
            neBRemainingCount.ReadOnly = true;
            neBRemainingCount.Size = new Size(96, 23);
            neBRemainingCount.TabIndex = 15;
            neBRemainingCount.TextAlign = HorizontalAlignment.Right;
            neBRemainingCount.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // lblRemainingBDataCount
            // 
            lblRemainingBDataCount.AutoSize = true;
            lblRemainingBDataCount.Location = new Point(428, 41);
            lblRemainingBDataCount.Name = "lblRemainingBDataCount";
            lblRemainingBDataCount.Size = new Size(70, 15);
            lblRemainingBDataCount.TabIndex = 14;
            lblRemainingBDataCount.Text = "Remaining :";
            // 
            // neARemainingCount
            // 
            neARemainingCount.Enabled = false;
            neARemainingCount.Location = new Point(319, 39);
            neARemainingCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neARemainingCount.Minimum = new decimal(new int[] { 100000000, 0, 0, int.MinValue });
            neARemainingCount.Name = "neARemainingCount";
            neARemainingCount.ReadOnly = true;
            neARemainingCount.Size = new Size(96, 23);
            neARemainingCount.TabIndex = 13;
            neARemainingCount.TextAlign = HorizontalAlignment.Right;
            neARemainingCount.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // lblRemainingADataCount
            // 
            lblRemainingADataCount.AutoSize = true;
            lblRemainingADataCount.Location = new Point(229, 41);
            lblRemainingADataCount.Name = "lblRemainingADataCount";
            lblRemainingADataCount.Size = new Size(70, 15);
            lblRemainingADataCount.TabIndex = 12;
            lblRemainingADataCount.Text = "Remaining :";
            // 
            // neCurrentTPS
            // 
            neCurrentTPS.Enabled = false;
            neCurrentTPS.Location = new Point(720, 68);
            neCurrentTPS.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neCurrentTPS.Name = "neCurrentTPS";
            neCurrentTPS.ReadOnly = true;
            neCurrentTPS.Size = new Size(96, 23);
            neCurrentTPS.TabIndex = 19;
            neCurrentTPS.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCurrentTPS
            // 
            lblCurrentTPS.AutoSize = true;
            lblCurrentTPS.Location = new Point(630, 70);
            lblCurrentTPS.Name = "lblCurrentTPS";
            lblCurrentTPS.Size = new Size(72, 15);
            lblCurrentTPS.TabIndex = 18;
            lblCurrentTPS.Text = "Current TPS:";
            // 
            // neMaxTPS
            // 
            neMaxTPS.Enabled = false;
            neMaxTPS.Location = new Point(517, 70);
            neMaxTPS.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            neMaxTPS.Name = "neMaxTPS";
            neMaxTPS.ReadOnly = true;
            neMaxTPS.Size = new Size(96, 23);
            neMaxTPS.TabIndex = 21;
            neMaxTPS.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMaxTPS
            // 
            lblMaxTPS.AutoSize = true;
            lblMaxTPS.Location = new Point(427, 72);
            lblMaxTPS.Name = "lblMaxTPS";
            lblMaxTPS.Size = new Size(55, 15);
            lblMaxTPS.TabIndex = 20;
            lblMaxTPS.Text = "Max TPS:";
            // 
            // tmrTPS
            // 
            tmrTPS.Interval = 1000;
            tmrTPS.Tick += tmrTPS_Tick;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(229, 76);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(59, 15);
            lblDuration.TabIndex = 22;
            lblDuration.Text = "Duration :";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(319, 70);
            txtDuration.Name = "txtDuration";
            txtDuration.ReadOnly = true;
            txtDuration.Size = new Size(96, 23);
            txtDuration.TabIndex = 23;
            txtDuration.TextAlign = HorizontalAlignment.Right;
            // 
            // tmrDuration
            // 
            tmrDuration.Interval = 10;
            tmrDuration.Tick += tmrDuration_Tick;
            // 
            // btnHSMTest
            // 
            btnHSMTest.Location = new Point(93, 62);
            btnHSMTest.Name = "btnHSMTest";
            btnHSMTest.Size = new Size(75, 23);
            btnHSMTest.TabIndex = 24;
            btnHSMTest.Text = "HSM Test";
            btnHSMTest.UseVisualStyleBackColor = true;
            btnHSMTest.Click += btnHSMTest_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 648);
            Controls.Add(btnHSMTest);
            Controls.Add(txtDuration);
            Controls.Add(lblDuration);
            Controls.Add(neMaxTPS);
            Controls.Add(lblMaxTPS);
            Controls.Add(neCurrentTPS);
            Controls.Add(lblCurrentTPS);
            Controls.Add(neCRemainingCount);
            Controls.Add(lblRemainingCDataCount);
            Controls.Add(neBRemainingCount);
            Controls.Add(lblRemainingBDataCount);
            Controls.Add(neARemainingCount);
            Controls.Add(lblRemainingADataCount);
            Controls.Add(neCCount);
            Controls.Add(lblCCount);
            Controls.Add(neBCount);
            Controls.Add(lblBCount);
            Controls.Add(neACount);
            Controls.Add(lblACount);
            Controls.Add(btnStart);
            Controls.Add(grpHSM);
            Controls.Add(neHSMCount);
            Controls.Add(lblHSMCount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM Actor Model PoC";
            ((System.ComponentModel.ISupportInitialize)neHSMCount).EndInit();
            grpHSM.ResumeLayout(false);
            pnlHSMList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)neACount).EndInit();
            ((System.ComponentModel.ISupportInitialize)neBCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)neCCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)neCRemainingCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)neBRemainingCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)neARemainingCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)neCurrentTPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)neMaxTPS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHSMCount;
        private NumericUpDown neHSMCount;
        private GroupBox grpHSM;
        private Panel pnlHSMList;
        private Button btnStart;
        private HsmComponent hsmComponent9;
        private HsmComponent hsmComponent10;
        private HsmComponent hsmComponent11;
        private HsmComponent hsmComponent12;
        private HsmComponent hsmComponent5;
        private HsmComponent hsmComponent6;
        private HsmComponent hsmComponent7;
        private HsmComponent hsmComponent8;
        private HsmComponent hsmComponent4;
        private HsmComponent hsmComponent3;
        private HsmComponent hsmComponent2;
        private HsmComponent hsmComponent1;
        private NumericUpDown neACount;
        private Label lblACount;
        private NumericUpDown neBCount;
        private Label lblBCount;
        private NumericUpDown neCCount;
        private Label lblCCount;
        private NumericUpDown neCRemainingCount;
        private Label lblRemainingCDataCount;
        private NumericUpDown neBRemainingCount;
        private Label lblRemainingBDataCount;
        private NumericUpDown neARemainingCount;
        private Label lblRemainingADataCount;
        private NumericUpDown neCurrentTPS;
        private Label lblCurrentTPS;
        private NumericUpDown neMaxTPS;
        private Label lblMaxTPS;
        private System.Windows.Forms.Timer tmrTPS;
        private Label lblDuration;
        private TextBox txtDuration;
        private System.Windows.Forms.Timer tmrDuration;
        private Button btnHSMTest;
    }
}