using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntunePackagingTool
{
    public partial class formLicense : Form
    {
        string TempDir, LicenseAgreement;
        public formLicense()
        {
            InitializeComponent();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            if (!chkbxAgreeToLicense.Checked)
            {
                var LicenseWarning = MessageBox.Show("You must agree to the license to use this product. Click OK to agree to the license, or click Cancel to exit Intune Packaging Tool", "Forgive the intrusion...", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch (LicenseWarning)
                {
                    case DialogResult.Cancel:
                        Application.Exit();
                        break;
                    case DialogResult.OK:
                        break;
                    default:
                        Application.Exit();
                        break;
                }
            }
            else
            {
                if (!File.Exists(LicenseAgreement))
                {
                    File.Create(LicenseAgreement);
                    this.Close();
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html");
        }

        private void formLicense_Load(object sender, EventArgs e)
        {
            TempDir = Path.GetTempPath() + "IntunePackagingTool";
            LicenseAgreement = TempDir + "\\AgreedToLicense";
            this.Select();
        }
    }
}
