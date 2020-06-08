namespace ServerConfigEditor
{
    partial class FormServerConnector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServerConnector));
            this.RootPassword = new System.Windows.Forms.TextBox();
            this.Label_IP = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ServerIP = new System.Windows.Forms.MaskedTextBox();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RootPassword
            // 
            resources.ApplyResources(this.RootPassword, "RootPassword");
            this.RootPassword.Name = "RootPassword";
            this.RootPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RootPassword_KeyDown);
            // 
            // Label_IP
            // 
            resources.ApplyResources(this.Label_IP, "Label_IP");
            this.Label_IP.Name = "Label_IP";
            // 
            // LabelPassword
            // 
            resources.ApplyResources(this.LabelPassword, "LabelPassword");
            this.LabelPassword.Name = "LabelPassword";
            // 
            // EnterButton
            // 
            resources.ApplyResources(this.EnterButton, "EnterButton");
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ServerIP
            // 
            resources.ApplyResources(this.ServerIP, "ServerIP");
            this.ServerIP.Name = "ServerIP";
            // 
            // ServerPort
            // 
            resources.ApplyResources(this.ServerPort, "ServerPort");
            this.ServerPort.Name = "ServerPort";
            // 
            // FormServerConnector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.Label_IP);
            this.Controls.Add(this.RootPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormServerConnector";
            this.Activated += new System.EventHandler(this.FormServerConnector_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RootPassword;
        private System.Windows.Forms.Label Label_IP;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.MaskedTextBox ServerIP;
        private System.Windows.Forms.TextBox ServerPort;
    }
}
