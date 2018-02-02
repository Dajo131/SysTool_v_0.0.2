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

namespace WpfApplication1
{
    public partial class NetworkRestart : Form
    {
        //Variablen deklaration
        int time;

        //Buttons-Funktion

        public NetworkRestart()
        {
            InitializeComponent();
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", string.Format(@" -r -f -m \\{0}.meier.local {1} {2}", TB, TextBoxComment.Text, TextBoxTime));

            //   Process Restart = new Process();
            //       Restart.StartInfo.FileName = "shutdown.exe";
            //       Restart.StartInfo.Arguments = string.Format(@" {1} {2} {3} -m \\{4}.meier.local {5}", Shutdown, Restart, Force, TB, TextBoxComment.Text, TextBoxTime.Text);
            //       Restart.Start();
        }

        private void Shutdown_CheckedChanged(object sender, EventArgs e)
        {
            string Shutdown = "-s";
        }

        private void Restart_CheckedChanged(object sender, EventArgs e)
        {
            string Restart = "-r";
        }

        private void Force_CheckedChanged(object sender, EventArgs e)
        {
            string Force = "-force";
        }

        private void TextBoxComment_TextChanged(object sender, EventArgs e)
        {
            string Comment = TextBoxComment.Text;
        }

        private void TextBoxTime_Click(object sender, EventArgs e)
        {
           // int time = Int32.Parse(TextBoxTime.Text);
        }

        string TB = "PCLH-171";
       
      
    }
}
