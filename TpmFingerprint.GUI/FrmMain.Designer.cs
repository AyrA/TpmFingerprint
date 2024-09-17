namespace TpmFingerprint.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnCopy = new System.Windows.Forms.Button();
            this.TbFingerprint = new System.Windows.Forms.TextBox();
            this.RbHex = new System.Windows.Forms.RadioButton();
            this.RbBase64 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BtnCopy
            // 
            this.BtnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopy.Location = new System.Drawing.Point(497, 12);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(75, 23);
            this.BtnCopy.TabIndex = 0;
            this.BtnCopy.Text = "&Copy";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // TbFingerprint
            // 
            this.TbFingerprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFingerprint.Location = new System.Drawing.Point(12, 14);
            this.TbFingerprint.Name = "TbFingerprint";
            this.TbFingerprint.ReadOnly = true;
            this.TbFingerprint.Size = new System.Drawing.Size(479, 20);
            this.TbFingerprint.TabIndex = 2;
            // 
            // RbHex
            // 
            this.RbHex.AutoSize = true;
            this.RbHex.Checked = true;
            this.RbHex.Location = new System.Drawing.Point(12, 40);
            this.RbHex.Name = "RbHex";
            this.RbHex.Size = new System.Drawing.Size(44, 17);
            this.RbHex.TabIndex = 3;
            this.RbHex.TabStop = true;
            this.RbHex.Text = "Hex";
            this.RbHex.UseVisualStyleBackColor = true;
            this.RbHex.CheckedChanged += new System.EventHandler(this.RbHex_CheckedChanged);
            // 
            // RbBase64
            // 
            this.RbBase64.AutoSize = true;
            this.RbBase64.Location = new System.Drawing.Point(62, 40);
            this.RbBase64.Name = "RbBase64";
            this.RbBase64.Size = new System.Drawing.Size(61, 17);
            this.RbBase64.TabIndex = 4;
            this.RbBase64.Text = "Base64";
            this.RbBase64.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "What is this?";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "This is your TPM (Trusted Platform Module) hardware id. It is globally unique to " +
    "this device.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "How do I use it?";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(32, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 79);
            this.label4.TabIndex = 5;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "How do I change it?";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.Location = new System.Drawing.Point(32, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(540, 49);
            this.label6.TabIndex = 5;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // LblLink
            // 
            this.LblLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(12, 339);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(197, 13);
            this.LblLink.TabIndex = 6;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "https://github.com/AyrA/TpmFingerprint";
            this.LblLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.LblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLink_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbBase64);
            this.Controls.Add(this.RbHex);
            this.Controls.Add(this.TbFingerprint);
            this.Controls.Add(this.BtnCopy);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmMain";
            this.Text = "TPM Fingerprint";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.TextBox TbFingerprint;
        private System.Windows.Forms.RadioButton RbHex;
        private System.Windows.Forms.RadioButton RbBase64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel LblLink;
    }
}

