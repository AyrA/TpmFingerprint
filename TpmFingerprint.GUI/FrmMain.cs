using System;
using System.Diagnostics;
using System.Windows.Forms;
using TpmFingerprint.Lib;

namespace TpmFingerprint.GUI
{
    public partial class FrmMain : Form
    {
        byte[] fingerprint;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                fingerprint = TpmAdapter.GetFingerprint();
                TbFingerprint.Text = Tools.Hex(fingerprint);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to retrieve TPM fingerprint. {ex.Message}",
                    "Unable to retrieve TPM fingerprint",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TbFingerprint.Text = ex.Message;
                TbFingerprint.Enabled = BtnCopy.Enabled = RbHex.Enabled = RbBase64.Enabled = false;
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

        private void RbHex_CheckedChanged(object sender, EventArgs e)
        {
            if (RbHex.Checked)
            {
                TbFingerprint.Text = Tools.Hex(fingerprint);
            }
            else
            {
                TbFingerprint.Text = Convert.ToBase64String(fingerprint);
            }
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(LblLink.Text) { UseShellExecute = true });
            }
            catch
            {
                Clipboard.Clear();
                Clipboard.SetText(LblLink.Text);
                MessageBox.Show(
                    "Unable to launch your default browser. Link was copied to clipboard instead.",
                    "URL launch failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
