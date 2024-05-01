using System;
using System.Windows.Forms;
using TpmFingerprint.Lib;

namespace TpmFingerprint.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            byte[] key;
            try
            {
                key = TpmAdapter.GetFingerprint();
                TbFingerprint.Text = Tools.HashHex(key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to retrieve TPM fingerprint. {ex.Message}",
                    "Unable to retrieve TPM fingerprint",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (TbFingerprint.Text.Length > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(TbFingerprint.Text);
                MessageBox.Show(
                    $"Value copied to clipboard",
                    "Value copied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    $"Value is empty",
                    "Empty value",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
