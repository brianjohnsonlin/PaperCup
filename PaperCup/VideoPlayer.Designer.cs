namespace PaperCup
{
    partial class VideoPlayer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.localPort = new System.Windows.Forms.TextBox();
            this.localIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.remoteIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.Chat = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.localPort);
            this.groupBox1.Controls.Add(this.localIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // localPort
            // 
            this.localPort.Location = new System.Drawing.Point(122, 97);
            this.localPort.Name = "localPort";
            this.localPort.Size = new System.Drawing.Size(174, 26);
            this.localPort.TabIndex = 3;
            this.localPort.TextChanged += new System.EventHandler(this.localPort_TextChanged);
            // 
            // localIP
            // 
            this.localIP.Location = new System.Drawing.Point(122, 51);
            this.localIP.Name = "localIP";
            this.localIP.Size = new System.Drawing.Size(174, 26);
            this.localIP.TabIndex = 2;
            this.localIP.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "I.P. Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remotePort);
            this.groupBox2.Controls.Add(this.remoteIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(379, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote";
            // 
            // remotePort
            // 
            this.remotePort.Location = new System.Drawing.Point(122, 97);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(182, 26);
            this.remotePort.TabIndex = 5;
            // 
            // remoteIP
            // 
            this.remoteIP.Location = new System.Drawing.Point(122, 51);
            this.remoteIP.Name = "remoteIP";
            this.remoteIP.Size = new System.Drawing.Size(182, 26);
            this.remoteIP.TabIndex = 4;
            this.remoteIP.Text = "1";
            this.remoteIP.TextChanged += new System.EventHandler(this.remoteIP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "I.P. Address";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(560, 196);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(129, 62);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(31, 457);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(429, 26);
            this.sendMessage.TabIndex = 3;
            // 
            // Chat
            // 
            this.Chat.FormattingEnabled = true;
            this.Chat.ItemHeight = 20;
            this.Chat.Location = new System.Drawing.Point(31, 196);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(523, 244);
            this.Chat.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(463, 454);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(91, 32);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // VideoPlayer
            // 
            this.ClientSize = new System.Drawing.Size(1205, 587);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VideoPlayer";
            this.Tag = "video";
            this.Text = "Video Player";
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox localPort;
        private System.Windows.Forms.TextBox localIP;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.TextBox remoteIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sendMessage;
        private System.Windows.Forms.ListBox Chat;
        private System.Windows.Forms.Button sendButton;
    }
}