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

namespace INziftr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //



        private void start_Click(object sender, EventArgs e)
        {
            if (Process.GetProcesses().Any(p => p.ProcessName.Contains("minerd")))
            {
                MessageBox.Show("You already have an instance of 'minerd.exe' currently running! Please exit 'minerd.exe' to continue!");
            }
            else
            {
                if (Directory.Exists(Global.location))
                {
                    Methods m = new Methods();
                    m.cas(System.Environment.CurrentDirectory + "\\temp_folder\\minerd.exe -a zr5 -t " + Global.coreCount / 2 + " -o " +textBox1.Text + " -u " +address.Text + " -p 1");
                }
                else
                {
                    MessageBox.Show("Mining files must be downloaded before you may start mining!");
                }
                
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (!Process.GetProcesses().Any(p => p.ProcessName.Contains("minerd")))
            {
                MessageBox.Show("There are no running instances of 'minerd.exe' currently running!");
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("minerd"))
                {
                    process.Kill();
                    MessageBox.Show("'minerd.exe' has been successfully stopped!");
                }
            }
        }

        private void hide_CheckedChanged(object sender, EventArgs e)
        {
            if (Process.GetProcesses().Any(p => p.ProcessName.Contains("minerd")))
            {
                MessageBox.Show("Changes will not take effect until you restart the miner!");
                if (hide.Checked)
                {
                    Global.hide = true;
                }
                else
                {
                    Global.hide = false;
                }
            }
            else
            {
                if (hide.Checked)
                {
                    Global.hide = true;
                }
                else
                {
                    Global.hide = false;
                }
            }
        }

        private void dl_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.dlFiles();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Process.GetProcesses().Any(p => p.ProcessName.Contains("minerd")))
            {
                MessageBox.Show("The miner is currently running! Exit the miner and try again.");
            }
            else
            {
                Methods m = new Methods();
                m.delFiles();
            }
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void ziftrlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.ziftrcoin.com/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
