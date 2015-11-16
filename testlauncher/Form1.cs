using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace testlauncher
{
    public partial class Form1 : Form
    {
        string wowdir = "";
        configMGR conf = new configMGR();
        public Form1()
        {
            InitializeComponent();
            if (conf.getValue("wowpath") == "_WOWPATH_")
            {
                playBTN.Hide();
            }
            else
            {
                label1.Hide();
                linkLabel1.Hide();
                playBTN.Show();
            }
            
            webBrowser1.WebBrowserShortcutsEnabled = false;
            webBrowser1.ScrollBarsEnabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable Files (.exe)|*.exe|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                wowdir = dialog.FileName;
                //Commented only for testing purpose.
                //conf.setValue("_WOWPATH_", wowdir);
                label1.Hide();
                linkLabel1.Hide();
                playBTN.Show();
            }
        }

        private void homepageBTN_Click(object sender, EventArgs e)
        {
            Process.Start("http://azerothshard.ga");
        }

        private void forumBTN_Click(object sender, EventArgs e)
        {
            Process.Start("http://azerothshard.ga/forums/forum/azerothshard/");
        }

        private void bugtrackerBTN_Click(object sender, EventArgs e)
        {
            Process.Start("http://lab.azerothshard.ga/");
        }

        private void playBTN_Click(object sender, EventArgs e)
        {
            Process.Start(@wowdir);
        }
    }
}
