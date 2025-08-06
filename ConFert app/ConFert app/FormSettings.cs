using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFert_app
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtOutputFolder.Text = Properties.Settings.Default.OutputFolder;
            chkPlaySound.Checked = Properties.Settings.Default.PlaySound;
            rbAutoRename.Checked = Properties.Settings.Default.Rename;
            rbOverwrite.Checked = !Properties.Settings.Default.Rename;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFolder.Text = fbd.SelectedPath;
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputFolder = txtOutputFolder.Text;
            Properties.Settings.Default.PlaySound = chkPlaySound.Checked;
            Properties.Settings.Default.Rename = rbAutoRename.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
