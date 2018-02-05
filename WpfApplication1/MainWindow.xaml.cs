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
using System.Security;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System;


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

        bool LoginStatus = false;
 
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
            Process RDP = new Process();
            RDP.StartInfo.FileName = "mstsc.exe";
            RDP.StartInfo.Arguments = string.Format(@"/v:{0}.meier.local /f", Computername.Text);
            RDP.Start();
        }

        private void RemoteAssistance_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ViewC_Click(object sender, RoutedEventArgs e)
        {
            OpenExplorer(string.Format(@"\\{0}\C$", Computername.Text));
        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            string input = Interaction.InputBox("Write your Message for the User", "NetworkMessage", "Test", 700, 400);

            Process MSG = new Process();
            MSG.StartInfo.FileName = "msg.exe";
            MSG.StartInfo.Arguments = string.Format(@" * /server:{0}.meier.local {1}", Computername.Text, input);
            MSG.Start();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Process Restart = new Process();
            Restart.StartInfo.FileName = "cmd.exe";
            Restart.StartInfo.Arguments = string.Format(@" /C shutdown -i -m \\{0}.meier.local", Computername.Text);
            Restart.Start();
        }

        public void Password_Click(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (Authenticate("meier.local", Benutzername.Text, Kennwort.Text))
            {
                string Popup1 = "Login successful";
                MessageBox.Show(Popup1);
                bool loginStatus = true;
            }
            else
            {
                string Popup2 = "Login was not successful";
                MessageBox.Show(Popup2);
                bool LoginStatus = false
            };
        }
    


    // Funktionen 

    //öffnen des Explorers
    private static void OpenExplorer(string path)
        {
            if (Directory.Exists(path))
                Process.Start("explorer.exe", path);
        }

        public static bool Authenticate(string domain, string username, string password)
        {
            SecureString pwd = new SecureString();
            bool bAuth = false;
            DirectoryEntry entry = null;

            //Durchlaufe das Passwort und hänge es dem SecureString an
            foreach (char c in password)
            {
                pwd.AppendChar(c);
            }

            //Bewirkt, dass das Passwort nicht mehr verändert werden kann
            pwd.MakeReadOnly();

            //Passwort wird einem Pointer übergeben, damit dieser später "entschlüsselt" werden kann
            IntPtr pPwd = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(pwd);

            try
            {
                entry = new DirectoryEntry(string.Concat(@"LDAP://", domain), username, System.Runtime.InteropServices.Marshal.PtrToStringBSTR(pPwd));
                object nativeObject = entry.NativeObject;
                bAuth = true;
            }
            catch (Exception)
            {
                bAuth = false;
            }
            finally
            {
                entry.Close();
                entry.Dispose();
            }
            return bAuth;
        }

    }    
}