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
            this.RootPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RootPassword.Location = new System.Drawing.Point(132, 61);
            this.RootPassword.Margin = new System.Windows.Forms.Padding(10);
            this.RootPassword.Name = "RootPassword";
            this.RootPassword.PasswordChar = 'x';
            this.RootPassword.Size = new System.Drawing.Size(204, 24);
            this.RootPassword.TabIndex = 3;
            this.RootPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_IP
            // 
            this.Label_IP.AutoSize = true;
            this.Label_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_IP.Location = new System.Drawing.Point(20, 23);
            this.Label_IP.Margin = new System.Windows.Forms.Padding(10);
            this.Label_IP.Name = "Label_IP";
            this.Label_IP.Size = new System.Drawing.Size(84, 18);
            this.Label_IP.TabIndex = 0;
            this.Label_IP.Text = "IP Сервера";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(20, 61);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(10);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(92, 18);
            this.LabelPassword.TabIndex = 0;
            this.LabelPassword.Text = "Пароль root";
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(132, 105);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(10);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(204, 43);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Вход";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ServerIP
            // 
            this.ServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerIP.Location = new System.Drawing.Point(132, 23);
            this.ServerIP.Margin = new System.Windows.Forms.Padding(10);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(139, 24);
            this.ServerIP.TabIndex = 1;
            this.ServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerPort
            // 
            this.ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerPort.Location = new System.Drawing.Point(277, 23);
            this.ServerPort.Margin = new System.Windows.Forms.Padding(10);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(59, 24);
            this.ServerPort.TabIndex = 2;
            this.ServerPort.Text = "22";
            this.ServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormServerConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 171);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.Label_IP);
            this.Controls.Add(this.RootPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormServerConnector";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Подключение";
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
