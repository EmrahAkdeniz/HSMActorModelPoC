namespace HSMActorModelPoC
{
    partial class HsmComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpHSM = new System.Windows.Forms.GroupBox();
            this.txtMaxTPS = new System.Windows.Forms.TextBox();
            this.lblMaxTPS = new System.Windows.Forms.Label();
            this.txtLoadTPS = new System.Windows.Forms.TextBox();
            this.lblLoadTPS = new System.Windows.Forms.Label();
            this.txtProcessedCount = new System.Windows.Forms.TextBox();
            this.lblProcessedCount = new System.Windows.Forms.Label();
            this.txtQueuedCount = new System.Windows.Forms.TextBox();
            this.lblQueuedCount = new System.Windows.Forms.Label();
            this.lblCurKeys = new System.Windows.Forms.Label();
            this.lstCurKeys = new System.Windows.Forms.ListBox();
            this.lnkLblDelKey = new System.Windows.Forms.LinkLabel();
            this.lnkLblAddKey = new System.Windows.Forms.LinkLabel();
            this.lblKeyList = new System.Windows.Forms.Label();
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.grpHSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHSM
            // 
            this.grpHSM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHSM.BackColor = System.Drawing.Color.LightBlue;
            this.grpHSM.Controls.Add(this.txtMaxTPS);
            this.grpHSM.Controls.Add(this.lblMaxTPS);
            this.grpHSM.Controls.Add(this.txtLoadTPS);
            this.grpHSM.Controls.Add(this.lblLoadTPS);
            this.grpHSM.Controls.Add(this.txtProcessedCount);
            this.grpHSM.Controls.Add(this.lblProcessedCount);
            this.grpHSM.Controls.Add(this.txtQueuedCount);
            this.grpHSM.Controls.Add(this.lblQueuedCount);
            this.grpHSM.Controls.Add(this.lblCurKeys);
            this.grpHSM.Controls.Add(this.lstCurKeys);
            this.grpHSM.Controls.Add(this.lnkLblDelKey);
            this.grpHSM.Controls.Add(this.lnkLblAddKey);
            this.grpHSM.Controls.Add(this.lblKeyList);
            this.grpHSM.Controls.Add(this.lstKeys);
            this.grpHSM.Location = new System.Drawing.Point(11, 7);
            this.grpHSM.Name = "grpHSM";
            this.grpHSM.Size = new System.Drawing.Size(180, 234);
            this.grpHSM.TabIndex = 0;
            this.grpHSM.TabStop = false;
            this.grpHSM.Text = "HSM #1";
            // 
            // txtMaxTPS
            // 
            this.txtMaxTPS.BackColor = System.Drawing.Color.White;
            this.txtMaxTPS.Location = new System.Drawing.Point(78, 200);
            this.txtMaxTPS.Name = "txtMaxTPS";
            this.txtMaxTPS.ReadOnly = true;
            this.txtMaxTPS.Size = new System.Drawing.Size(74, 23);
            this.txtMaxTPS.TabIndex = 13;
            this.txtMaxTPS.Text = "0";
            this.txtMaxTPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaxTPS
            // 
            this.lblMaxTPS.AutoSize = true;
            this.lblMaxTPS.Location = new System.Drawing.Point(6, 203);
            this.lblMaxTPS.Name = "lblMaxTPS";
            this.lblMaxTPS.Size = new System.Drawing.Size(63, 15);
            this.lblMaxTPS.TabIndex = 12;
            this.lblMaxTPS.Text = "Max(TPS) :";
            // 
            // txtLoadTPS
            // 
            this.txtLoadTPS.BackColor = System.Drawing.Color.White;
            this.txtLoadTPS.Location = new System.Drawing.Point(78, 171);
            this.txtLoadTPS.Name = "txtLoadTPS";
            this.txtLoadTPS.ReadOnly = true;
            this.txtLoadTPS.Size = new System.Drawing.Size(74, 23);
            this.txtLoadTPS.TabIndex = 11;
            this.txtLoadTPS.Text = "0";
            this.txtLoadTPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLoadTPS
            // 
            this.lblLoadTPS.AutoSize = true;
            this.lblLoadTPS.Location = new System.Drawing.Point(6, 174);
            this.lblLoadTPS.Name = "lblLoadTPS";
            this.lblLoadTPS.Size = new System.Drawing.Size(66, 15);
            this.lblLoadTPS.TabIndex = 10;
            this.lblLoadTPS.Text = "Load(TPS) :";
            // 
            // txtProcessedCount
            // 
            this.txtProcessedCount.BackColor = System.Drawing.Color.White;
            this.txtProcessedCount.Location = new System.Drawing.Point(78, 142);
            this.txtProcessedCount.Name = "txtProcessedCount";
            this.txtProcessedCount.ReadOnly = true;
            this.txtProcessedCount.Size = new System.Drawing.Size(74, 23);
            this.txtProcessedCount.TabIndex = 9;
            this.txtProcessedCount.Text = "0";
            this.txtProcessedCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProcessedCount
            // 
            this.lblProcessedCount.AutoSize = true;
            this.lblProcessedCount.Location = new System.Drawing.Point(6, 145);
            this.lblProcessedCount.Name = "lblProcessedCount";
            this.lblProcessedCount.Size = new System.Drawing.Size(66, 15);
            this.lblProcessedCount.TabIndex = 8;
            this.lblProcessedCount.Text = "Processed :";
            // 
            // txtQueuedCount
            // 
            this.txtQueuedCount.BackColor = System.Drawing.Color.White;
            this.txtQueuedCount.Location = new System.Drawing.Point(78, 112);
            this.txtQueuedCount.Name = "txtQueuedCount";
            this.txtQueuedCount.ReadOnly = true;
            this.txtQueuedCount.Size = new System.Drawing.Size(74, 23);
            this.txtQueuedCount.TabIndex = 7;
            this.txtQueuedCount.Text = "0";
            this.txtQueuedCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQueuedCount
            // 
            this.lblQueuedCount.AutoSize = true;
            this.lblQueuedCount.Location = new System.Drawing.Point(6, 117);
            this.lblQueuedCount.Name = "lblQueuedCount";
            this.lblQueuedCount.Size = new System.Drawing.Size(55, 15);
            this.lblQueuedCount.TabIndex = 6;
            this.lblQueuedCount.Text = "Queued :";
            // 
            // lblCurKeys
            // 
            this.lblCurKeys.AutoSize = true;
            this.lblCurKeys.Location = new System.Drawing.Point(95, 19);
            this.lblCurKeys.Name = "lblCurKeys";
            this.lblCurKeys.Size = new System.Drawing.Size(74, 15);
            this.lblCurKeys.TabIndex = 4;
            this.lblCurKeys.Text = "Current Keys";
            // 
            // lstCurKeys
            // 
            this.lstCurKeys.FormattingEnabled = true;
            this.lstCurKeys.ItemHeight = 15;
            this.lstCurKeys.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstCurKeys.Location = new System.Drawing.Point(105, 37);
            this.lstCurKeys.Name = "lstCurKeys";
            this.lstCurKeys.Size = new System.Drawing.Size(47, 64);
            this.lstCurKeys.TabIndex = 5;
            // 
            // lnkLblDelKey
            // 
            this.lnkLblDelKey.AutoSize = true;
            this.lnkLblDelKey.Location = new System.Drawing.Point(59, 70);
            this.lnkLblDelKey.Name = "lnkLblDelKey";
            this.lnkLblDelKey.Size = new System.Drawing.Size(35, 15);
            this.lnkLblDelKey.TabIndex = 3;
            this.lnkLblDelKey.TabStop = true;
            this.lnkLblDelKey.Text = "< Del";
            this.lnkLblDelKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblDelKey_LinkClicked);
            // 
            // lnkLblAddKey
            // 
            this.lnkLblAddKey.AutoSize = true;
            this.lnkLblAddKey.Location = new System.Drawing.Point(59, 46);
            this.lnkLblAddKey.Name = "lnkLblAddKey";
            this.lnkLblAddKey.Size = new System.Drawing.Size(40, 15);
            this.lnkLblAddKey.TabIndex = 2;
            this.lnkLblAddKey.TabStop = true;
            this.lnkLblAddKey.Text = "Add >";
            this.lnkLblAddKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblAddKey_LinkClicked);
            // 
            // lblKeyList
            // 
            this.lblKeyList.AutoSize = true;
            this.lblKeyList.Location = new System.Drawing.Point(6, 19);
            this.lblKeyList.Name = "lblKeyList";
            this.lblKeyList.Size = new System.Drawing.Size(47, 15);
            this.lblKeyList.TabIndex = 0;
            this.lblKeyList.Text = "Key List";
            // 
            // lstKeys
            // 
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.ItemHeight = 15;
            this.lstKeys.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstKeys.Location = new System.Drawing.Point(6, 37);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(47, 64);
            this.lstKeys.TabIndex = 1;
            // 
            // HsmComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpHSM);
            this.Name = "HsmComponent";
            this.Size = new System.Drawing.Size(203, 251);
            this.grpHSM.ResumeLayout(false);
            this.grpHSM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpHSM;
        private TextBox txtMaxTPS;
        private Label lblMaxTPS;
        private TextBox txtLoadTPS;
        private Label lblLoadTPS;
        private TextBox txtProcessedCount;
        private Label lblProcessedCount;
        private TextBox txtQueuedCount;
        private Label lblQueuedCount;
        private Label lblCurKeys;
        private ListBox lstCurKeys;
        private LinkLabel lnkLblDelKey;
        private LinkLabel lnkLblAddKey;
        private Label lblKeyList;
        private ListBox lstKeys;
    }
}
