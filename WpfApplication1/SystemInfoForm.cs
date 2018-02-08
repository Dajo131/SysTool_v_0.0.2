using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Management;
using Microsoft.Management.Infrastructure;


namespace WpfApplication1
{
    public partial class SystemInfoForm : Form
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGrid datagrid1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        public SystemInfoForm()
        {
            InitializeComponent();
        }

        
        //[STAThread]
        //private void Run()
        //{
        //    Application.Run(new SystemInfoForm());
        //}
       
 
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>


        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datagrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the win32 API or type in a new one. Then click on the \"Show\" button.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Details";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(600, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(504, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Win32_DiskDrive",
            "Win32_OperatingSystem",
            "Win32_Processor",
            "Win32_ComputerSystem",
            "Win32_StartupCommand",
            "Win32_ProgramGroup",
            "Win32_SystemDevices"});
            this.comboBox1.Location = new System.Drawing.Point(24, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(456, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // datagrid1
            // 
            this.datagrid1.DataMember = "";
            this.datagrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.datagrid1.Location = new System.Drawing.Point(24, 96);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.Size = new System.Drawing.Size(744, 264);
            this.datagrid1.TabIndex = 11;
            // 
            // SystemInfoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagrid1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.Name = "SystemInfoForm";
            this.Text = "System Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);

        }
            
        private void Form1_Load(object sender, System.EventArgs e)
        {
        }
        private void button1_Click(object sender, System.EventArgs e)
        {

            datagrid1.DataSource = GetStuff(comboBox1.Text);
        }
        
        public ArrayList GetStuff(string queryObject)
        {
            ManagementObjectSearcher searcher;
            int i = 0;
            ArrayList hd = new ArrayList();
            try
            {
                //ConnectionOptions options = new ConnectionOptions();
                 //options.Impersonation = System.Management.ImpersonationLevel.Impersonate;

                //ManagementScope Target = new ManagementScope("\\\\NBLH-025\\root\\cimv");
                //Target.Connect();
                ObjectQuery query = new ObjectQuery(
                    "SELECT * FROM " + queryObject);
                
                searcher = new ManagementObjectSearcher(query);

                foreach (System.Management.ManagementObject W_HD in searcher.Get())
                {
                    i++;
                    PropertyDataCollection searcherProperties =
                      W_HD.Properties;
                    foreach (PropertyData sp in searcherProperties)
                    {
                        hd.Add(sp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return hd;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

