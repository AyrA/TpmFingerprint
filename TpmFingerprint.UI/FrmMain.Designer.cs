namespace TpmFingerprint.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnCopy = new Button();
            TbFingerprint = new TextBox();
            LblInfo = new Label();
            SuspendLayout();
            // 
            // BtnCopy
            // 
            BtnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCopy.Location = new Point(697, 12);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(75, 23);
            BtnCopy.TabIndex = 0;
            BtnCopy.Text = "&Copy";
            BtnCopy.UseVisualStyleBackColor = true;
            // 
            // TbFingerprint
            // 
            TbFingerprint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbFingerprint.Location = new Point(12, 14);
            TbFingerprint.Name = "TbFingerprint";
            TbFingerprint.ReadOnly = true;
            TbFingerprint.Size = new Size(679, 20);
            TbFingerprint.TabIndex = 1;
            // 
            // LblInfo
            // 
            LblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblInfo.Location = new Point(12, 46);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(760, 66);
            LblInfo.TabIndex = 2;
            LblInfo.Text = resources.GetString("LblInfo.Text");
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 121);
            Controls.Add(LblInfo);
            Controls.Add(TbFingerprint);
            Controls.Add(BtnCopy);
            Name = "FrmMain";
            Text = "TPM Fingerprint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCopy;
        private TextBox TbFingerprint;
        private Label LblInfo;
    }
}
