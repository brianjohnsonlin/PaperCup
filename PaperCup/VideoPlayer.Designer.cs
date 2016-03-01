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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.localPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.Chat = new System.Windows.Forms.ListBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.chooseMedia = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // localPort
            // 
            this.localPort.Location = new System.Drawing.Point(117, 19);
            this.localPort.Name = "localPort";
            this.localPort.Size = new System.Drawing.Size(174, 20);
            this.localPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.localPort);
            this.groupBox2.Controls.Add(this.remotePort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(31, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port Info|";
            // 
            // remotePort
            // 
            this.remotePort.Location = new System.Drawing.Point(117, 54);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(174, 20);
            this.remotePort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remote Port";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(347, 31);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(129, 62);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connect_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(31, 302);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(342, 20);
            this.sendMessage.TabIndex = 3;
            // 
            // Chat
            // 
            this.Chat.FormattingEnabled = true;
            this.Chat.Location = new System.Drawing.Point(31, 107);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(445, 186);
            this.Chat.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(379, 295);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(97, 27);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(495, 34);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(501, 350);
            this.mediaPlayer.TabIndex = 6;
            // 
            // chooseMedia
            // 
            this.chooseMedia.Location = new System.Drawing.Point(31, 337);
            this.chooseMedia.Name = "chooseMedia";
            this.chooseMedia.Size = new System.Drawing.Size(122, 47);
            this.chooseMedia.TabIndex = 7;
            this.chooseMedia.Text = "Choose Media";
            this.chooseMedia.UseVisualStyleBackColor = true;
            this.chooseMedia.Click += new System.EventHandler(this.chooseMedia_Click);
            // 
            // VideoPlayer
            // 
            this.ClientSize = new System.Drawing.Size(1013, 400);
            this.Controls.Add(this.chooseMedia);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "VideoPlayer";
            this.Tag = "video";
            this.Text = "Video Player";
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox localPort;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sendMessage;
        private System.Windows.Forms.ListBox Chat;
        private System.Windows.Forms.Button sendButton;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button chooseMedia;
    }
}