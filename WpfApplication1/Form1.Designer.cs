namespace WpfApplication1
{
    partial class NetworkRestart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OK = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.CheckBox();
            this.Restart = new System.Windows.Forms.CheckBox();
            this.Force = new System.Windows.Forms.CheckBox();
            this.TextBoxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxComment = new System.Windows.Forms.TextBox();
            this.Abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(200, 30);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.Location = new System.Drawing.Point(21, 36);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(97, 17);
            this.Shutdown.TabIndex = 2;
            this.Shutdown.Text = "Herunterfahren";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.CheckedChanged += new System.EventHandler(this.Shutdown_CheckedChanged);
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_CheckedChanged);
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.Location = new System.Drawing.Point(21, 60);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(66, 17);
            this.Restart.TabIndex = 3;
            this.Restart.Text = "Neustart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.CheckedChanged += new System.EventHandler(this.Restart_CheckedChanged);
            this.Restart.Click += new System.EventHandler(this.Restart_CheckedChanged);
            // 
            // Force
            // 
            this.Force.AutoSize = true;
            this.Force.Location = new System.Drawing.Point(21, 83);
            this.Force.Name = "Force";
            this.Force.Size = new System.Drawing.Size(53, 17);
            this.Force.TabIndex = 6;
            this.Force.Text = "Force";
            this.Force.UseVisualStyleBackColor = true;
            this.Force.CheckedChanged += new System.EventHandler(this.Force_CheckedChanged);
            this.Force.Click += new System.EventHandler(this.Force_CheckedChanged);
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.Location = new System.Drawing.Point(21, 128);
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTime.TabIndex = 8;
            this.TextBoxTime.Click += new System.EventHandler(this.TextBoxTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zeit zum bis zum Neustart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kommentar zum Herunterfahren";
            // 
            // TextBoxComment
            // 
            this.TextBoxComment.Location = new System.Drawing.Point(21, 170);
            this.TextBoxComment.Name = "TextBoxComment";
            this.TextBoxComment.Size = new System.Drawing.Size(100, 20);
            this.TextBoxComment.TabIndex = 10;
            this.TextBoxComment.Click += new System.EventHandler(this.TextBoxComment_TextChanged);
            this.TextBoxComment.TextChanged += new System.EventHandler(this.TextBoxComment_TextChanged);
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(200, 60);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(75, 23);
            this.Abort.TabIndex = 12;
            this.Abort.Text = "Abbrechen";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // NetworkRestart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(333, 351);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxTime);
            this.Controls.Add(this.Force);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.OK);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NetworkRestart";
            this.Text = "NetworkRestart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Abort;
        public System.Windows.Forms.CheckBox Shutdown;
        public System.Windows.Forms.CheckBox Restart;
        public System.Windows.Forms.CheckBox Force;
        public System.Windows.Forms.TextBox TextBoxTime;
        public System.Windows.Forms.TextBox TextBoxComment;
    }
}