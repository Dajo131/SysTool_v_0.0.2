using System.Windows;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.IO;
using Microsoft.PowerShell.Commands.Internal.Format;
using Microsoft.PowerShell.Cmdletization.Xml;
using Microsoft.PowerShell.Cim;
using Microsoft.PowerShell.Commands.Management;
using System.Windows.Forms;
using System.Management;


namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Variablen

        //Buttons

        private void SysInfo_Click(object sender, RoutedEventArgs e)
        {
        }

        private void LocAdmin_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
        }

        private void StartItem_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Process_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Applications_Click(object sender, RoutedEventArgs e)
        {
        }

        private void RDP_Click(object sender, RoutedEventArgs e)
        {
        }

        private void RemoteAssistance_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ViewC_Click(object sender, RoutedEventArgs e)
        {
            OpenExplorer(string.Format(@"\\{0}\C$",Textbox.Text));
        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            string input = Interaction.InputBox("Write your Message for the User", "NetworkMessage", "Test", 700,400);

            Process MSG = new Process();
            MSG.StartInfo.FileName = "msg.exe";
            MSG.StartInfo.Arguments = string.Format(@" * /server:{0}.meier.local {1}",Textbox.Text, input);
            MSG.Start();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            NetworkRestart NetReForm = new NetworkRestart();
            NetReForm.Show();
        }

        // Funktionen 

        //öffnen des Explorers
        private static void OpenExplorer(string path)
        {
            if (Directory.Exists(path))
                  Process.Start("explorer.exe", path);
        }
    }
}