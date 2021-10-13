using IntunePackagingTool.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;


namespace IntunePackagingTool
{
    public partial class formMain : Form
    {
        string AppDir, IntuneWinAppUtil, TempDir, LicenseAgreement, rootFile, ExpectedIntuneWinFile, TempIntuneWinFile, DirtyExit;
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            label_generic.Hide();
            txtRenameFile.Hide();
            lblExpectedFileName.Hide();
            AppDir = Directory.GetCurrentDirectory();
            TempDir = Path.GetTempPath() + "IntunePackagingTool";
            if (!Directory.Exists(TempDir))
            {
                Directory.CreateDirectory(TempDir);
            }
            LicenseAgreement = TempDir + @"\AgreedToLicense";
            IntuneWinAppUtil = TempDir + @"\IntuneWinAppUtil.exe";
            DirtyExit = TempDir + @"\.DirtyExit";

            if(File.Exists(DirtyExit))
            {
                MessageBox.Show("Intune Packaging Tool was not shut down properly. This could negatively affect your package files or experience." + Environment.NewLine + Environment.NewLine +
                                "This is most often caused by an application crash or a dirty shutdown (such as force closing via TaskMgr.exe)." + Environment.NewLine + Environment.NewLine +
                                "We're going to erase your temporary files and re-launch. You will be greeted as if this is the first time you have run the program." + Environment.NewLine + Environment.NewLine +
                                "If this issue persists, please lodge an issue in GitHub. Please include your Windows version and architecture (e.g., Windows 10 1909 64 bit) in the issue.");
                foreach(var file in Directory.GetFiles(TempDir))
                {
                    File.Delete(file);
                }
            }


            /////////////////////



            //txtSrcDir.Text = @"C:\temp\Intune Package Test\Jabber";
            //txtInstaller.Text = @"C:\temp\Intune Package Test\Jabber\CiscoJabberSetup.msi";
            //txtOutDir.Text = @"C:\temp\Intune Package Test";
            //////////////////////////////

            if (!File.Exists(IntuneWinAppUtil))
            {
                var IntuneExe = Path.Combine(TempDir, "IntuneWinAppUtil.exe");
                File.WriteAllBytes(IntuneExe, Resources.IntuneWinAppUtil);
            }
            if (!Directory.Exists(TempDir))
            {
                Directory.CreateDirectory(TempDir);
            }
            if (!File.Exists(LicenseAgreement))
            {
                var LicenseAgreementPage = new formLicense();
                var LicenseResponse = LicenseAgreementPage.ShowDialog();

            }

            File.Create(DirtyExit).Close();
        }

        private void btnSelectSrcDir_Click(object sender, EventArgs e)
        {
            var SrcDir = OpenFileOrFolder(true);
            if (!String.IsNullOrWhiteSpace(SrcDir))
            {
                txtSrcDir.Text = SrcDir;
            }
        }

        private void btnSelectInstaller_Click(object sender, EventArgs e)
        {
            var Installer = OpenFileOrFolder(false);
            if (!String.IsNullOrWhiteSpace(Installer))
            {
                txtInstaller.Text = Installer;
            }
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            var OutDir = OpenFileOrFolder(true);
            if (!String.IsNullOrWhiteSpace(OutDir))
            {
                txtOutDir.Text = OutDir;
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(DirtyExit);
        }

        private void btnBuildPackage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSrcDir.Text))
            {
                MessageBox.Show("You must choose a source directory! Please click the \"Select Src Dir\" button and browse to the folder containing your installation sources.", "Needed info is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtInstaller.Text))
            {
                MessageBox.Show("You must choose a primary installer! Please click the \"Select Installer\" button and browse to an installation executable, script, or binary target.", "Needed info is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtOutDir.Text))
            {
                MessageBox.Show("You must choose a directory to output your Intune package file! Please click the \"Select Out Dir\" button and browse to the folder you wish to store your package file.", "Needed info is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var fileExtIndex = txtInstaller.Text.LastIndexOf('.');
                var InstallerPath = txtInstaller.Text.Substring(0, fileExtIndex);
                var pathIndex = InstallerPath.LastIndexOf(@"\");
                rootFile = InstallerPath.Substring(pathIndex, InstallerPath.Length - pathIndex);
                ExpectedIntuneWinFile = txtOutDir.Text + rootFile + ".intunewin";
                TempIntuneWinFile = TempDir + rootFile + ".intunewin";
                var PotentialRename = String.Format(@"{0}\{1}.intunewin", txtOutDir.Text, txtRenameFile.Text);

                if (chkRenamePackageFile.Checked)
                {
                    if(File.Exists(PotentialRename))
                    {
                        var UserResponse = MessageBox.Show("The package file \"" + PotentialRename + "\" already exists." + Environment.NewLine + Environment.NewLine +
                                        "Click \"Yes\" to overwrite." + Environment.NewLine +
                                        "Click \"No\" to rename the existing file." + Environment.NewLine +
                                        "Click \"Cancel\" to abort."
                                        , "Package File Already Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        switch (UserResponse)
                        {
                            case DialogResult.Yes:
                                File.Delete(PotentialRename);
                                RunTheProcess(TempIntuneWinFile, PotentialRename, txtOutDir.Text, txtRenameFile.Text);
                                break;
                            case DialogResult.No:
                                var createDateTime = File.GetLastWriteTime(ExpectedIntuneWinFile);
                                File.Copy(PotentialRename, PotentialRename + "." + createDateTime.ToString("yyyy-dd-MM_HH.mm.ss"));
                                File.Delete(PotentialRename);
                                RunTheProcess(TempIntuneWinFile, PotentialRename, txtOutDir.Text, txtRenameFile.Text);
                                break;
                            case DialogResult.Cancel:
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        RunTheProcess(TempIntuneWinFile, PotentialRename, txtOutDir.Text, txtRenameFile.Text + ".intunewin");
                    }
                }
                else
                {
                    if (File.Exists(ExpectedIntuneWinFile))
                    {
                        var UserResponse = MessageBox.Show("The package file \"" + ExpectedIntuneWinFile + "\" already exists." + Environment.NewLine + Environment.NewLine +
                                        "Click \"Yes\" to overwrite." + Environment.NewLine +
                                        "Click \"No\" to rename the existing file." + Environment.NewLine +
                                        "Click \"Cancel\" to abort."
                                        , "Package File Already Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        switch (UserResponse)
                        {
                            case DialogResult.Yes:
                                File.Delete(ExpectedIntuneWinFile);
                                RunTheProcess(TempIntuneWinFile, PotentialRename, txtOutDir.Text, txtRenameFile.Text);
                                break;
                            case DialogResult.No:
                                var createDateTime = File.GetLastWriteTime(ExpectedIntuneWinFile);
                                File.Copy(ExpectedIntuneWinFile, ExpectedIntuneWinFile + "." + createDateTime.ToString("yyyy-dd-MM_HH.mm.ss"));
                                File.Delete(ExpectedIntuneWinFile);
                                RunTheProcess(TempIntuneWinFile, PotentialRename, txtOutDir.Text, txtRenameFile.Text);
                                break;
                            case DialogResult.Cancel:
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        RunTheProcess(TempIntuneWinFile, PotentialRename, txtOutDir.Text, txtRenameFile.Text);
                    }
                }
            }
        }

        private void btnOpenOutDir_Click(object sender, EventArgs e)
        {
            Process.Start(txtOutDir.Text);
        }

        private void txtInstaller_TextChanged(object sender, EventArgs e)
        {
            var fileExtIndex = txtInstaller.Text.LastIndexOf('.');
            var InstallerPath = txtInstaller.Text.Substring(0, fileExtIndex);
            var pathIndex = InstallerPath.LastIndexOf(@"\");
            var rootFile = InstallerPath.Substring(pathIndex, InstallerPath.Length - pathIndex);
            var ExpectedIntuneWinFile = rootFile + ".intunewin";
            label_generic.Show();
            
            lblExpectedFileName.Text = ExpectedIntuneWinFile;
        }

        private void chkRenamePackageFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRenamePackageFile.Checked)
            {
                txtRenameFile.Show();
                lblExpectedFileName.Show();
            }
            else
            {
                txtRenameFile.Hide();
                txtRenameFile.Text = "";
                lblExpectedFileName.Hide();
            }
        }

        private string OpenFileOrFolder(bool IsFolderPicker)
        {
            using (var OpenFileOrFolder = new CommonOpenFileDialog())
            {
                if (!String.IsNullOrWhiteSpace(txtSrcDir.Text))
                {
                    OpenFileOrFolder.InitialDirectory = txtSrcDir.Text;
                }
                else
                {
                    OpenFileOrFolder.InitialDirectory = "C:\\";
                }
                OpenFileOrFolder.IsFolderPicker = IsFolderPicker;
                if(OpenFileOrFolder.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    return OpenFileOrFolder.FileName;
                }
                else
                {
                    return null;
                }
            }
        }

        void ProcessDataReceived(object sender, DataReceivedEventArgs e)
        {
            
            txtConsoleOutput.Invoke(new Action(() =>
                {
                    txtConsoleOutput.Text += Environment.NewLine + e.Data;
                    txtConsoleOutput.Update();
                    txtConsoleOutput.SelectionStart = txtConsoleOutput.Text.Length;
                    txtConsoleOutput.ScrollToCaret();
                }));
            
        }

        void RunTheProcess(string TempIntuneFile, string ExpectedPackage, string PackagePath, string NewPackageName)
        {
            txtConsoleOutput.Clear();
            txtConsoleOutput.Update();
            txtSrcDir.Enabled = false;
            txtInstaller.Enabled = false;
            txtOutDir.Enabled = false;
            btnBuildPackage.Enabled = false;
            btnSelectInstaller.Enabled = false;
            btnSelectOutput.Enabled = false;
            btnSelectSrcDir.Enabled = false;

            this.Width = this.Width + 845;
            this.Update();


            /////////////////// Here follows the bit with threading, and stdout and stderr etc






            ////////// Process



            var BuildIntunePackage = new Process();
            var BuildIntuneInfo = new ProcessStartInfo();
            BuildIntuneInfo.FileName = IntuneWinAppUtil;
            BuildIntuneInfo.Arguments = "-c \"" + txtSrcDir.Text + "\" -s \"" + txtInstaller.Text + "\" -o \"" + TempDir + "\"";
            BuildIntuneInfo.CreateNoWindow = true;
            BuildIntuneInfo.RedirectStandardOutput = true;
            BuildIntuneInfo.RedirectStandardError = true;
            BuildIntuneInfo.UseShellExecute = false;


            BuildIntunePackage.StartInfo = BuildIntuneInfo;
            BuildIntunePackage.EnableRaisingEvents = true;
            BuildIntunePackage.ErrorDataReceived += ProcessDataReceived;
            BuildIntunePackage.OutputDataReceived += ProcessDataReceived;

            var ProcReturn = BuildIntunePackage.Start();
            BuildIntunePackage.BeginErrorReadLine();
            BuildIntunePackage.BeginOutputReadLine();
            //BuildIntunePackage.WaitForExit();
            while (!BuildIntunePackage.HasExited)
            {
                Application.DoEvents();
                txtConsoleOutput.Update();
            }



            ///////// Threading
            //var ThreadDetails = new ThreadStart(() => BuildIntunePackage.Start());
            //var WorkingThread = new Thread(ThreadDetails);
            //WorkingThread.Start();

            if (chkRenamePackageFile.Checked)
            {
                File.Move(TempIntuneFile, Path.Combine(txtOutDir.Text,NewPackageName));
            }






            ///////////////// That bit is over now.







            this.Width = this.Width - 845;
            txtSrcDir.Enabled = true;
            txtInstaller.Enabled = true;
            txtOutDir.Enabled = true;
            btnBuildPackage.Enabled = true;
            btnSelectInstaller.Enabled = true;
            btnSelectOutput.Enabled = true;
            btnSelectSrcDir.Enabled = true;
            this.Update();
        }
    }
}
