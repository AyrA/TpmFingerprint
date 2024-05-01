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
            this.LblInfo = new System.Windows.Forms.Label();
            this.TbFingerprint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCopy
            // 
            this.BtnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopy.Location = new System.Drawing.Point(697, 12);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(75, 23);
            this.BtnCopy.TabIndex = 0;
            this.BtnCopy.Text = "&Copy";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInfo.AutoEllipsis = true;
            this.LblInfo.Location = new System.Drawing.Point(12, 48);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(760, 84);
            this.LblInfo.TabIndex = 1;
            this.LblInfo.Text = resources.GetString("LblInfo.Text");
            // 
            // TbFingerprint
            // 
            this.TbFingerprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFingerprint.Location = new System.Drawing.Point(12, 14);
            this.TbFingerprint.Name = "TbFingerprint";
            this.TbFingerprint.ReadOnly = true;
            this.TbFingerprint.Size = new System.Drawing.Size(679, 20);
            this.TbFingerprint.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 141);
            this.Controls.Add(this.TbFingerprint);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnCopy);
            this.Name = "FrmMain";
            this.Text = "TPM Fingerprint";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.TextBox TbFingerprint;
    }
}

