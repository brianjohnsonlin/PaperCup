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
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.masterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sidebarTable = new System.Windows.Forms.TableLayoutPanel();
            this.settingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.chooseMedia = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.portInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.portInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.enterPortInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.localPort = new System.Windows.Forms.TextBox();
            this.localPortLabel = new System.Windows.Forms.Label();
            this.remotePortLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.chatTable = new System.Windows.Forms.TableLayoutPanel();
            this.Chat = new System.Windows.Forms.ListBox();
            this.sendTable = new System.Windows.Forms.TableLayoutPanel();
            this.sendMessage = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.masterPanel.SuspendLayout();
            this.sidebarTable.SuspendLayout();
            this.settingsTable.SuspendLayout();
            this.portInfoTable.SuspendLayout();
            this.portInfoGroupBox.SuspendLayout();
            this.enterPortInfoTable.SuspendLayout();
            this.chatTable.SuspendLayout();
            this.sendTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(320, 20);
            this.mediaPlayer.Margin = new System.Windows.Forms.Padding(20);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(924, 641);
            this.mediaPlayer.TabIndex = 6;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            this.mediaPlayer.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.mediaPlayer_PositionChange);
            // 
            // masterPanel
            // 
            this.masterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.masterPanel.ColumnCount = 2;
            this.masterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.masterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterPanel.Controls.Add(this.sidebarTable, 0, 0);
            this.masterPanel.Controls.Add(this.mediaPlayer, 1, 0);
            this.masterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterPanel.Location = new System.Drawing.Point(0, 0);
            this.masterPanel.Name = "masterPanel";
            this.masterPanel.RowCount = 1;
            this.masterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterPanel.Size = new System.Drawing.Size(1264, 681);
            this.masterPanel.TabIndex = 9;
            // 
            // sidebarTable
            // 
            this.sidebarTable.ColumnCount = 1;
            this.sidebarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebarTable.Controls.Add(this.settingsTable, 0, 2);
            this.sidebarTable.Controls.Add(this.portInfoTable, 0, 0);
            this.sidebarTable.Controls.Add(this.chatTable, 0, 1);
            this.sidebarTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarTable.Location = new System.Drawing.Point(3, 3);
            this.sidebarTable.Name = "sidebarTable";
            this.sidebarTable.RowCount = 3;
            this.sidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.sidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.sidebarTable.Size = new System.Drawing.Size(294, 675);
            this.sidebarTable.TabIndex = 11;
            // 
            // settingsTable
            // 
            this.settingsTable.ColumnCount = 2;
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.34375F));
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.65625F));
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.34375F));
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.65625F));
            this.settingsTable.Controls.Add(this.chooseMedia, 0, 0);
            this.settingsTable.Controls.Add(this.settingsButton, 1, 0);
            this.settingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTable.Location = new System.Drawing.Point(3, 614);
            this.settingsTable.Name = "settingsTable";
            this.settingsTable.RowCount = 1;
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsTable.Size = new System.Drawing.Size(288, 58);
            this.settingsTable.TabIndex = 12;
            // 
            // chooseMedia
            // 
            this.chooseMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseMedia.BackgroundImage = global::PaperCup.Properties.Resources.button1;
            this.chooseMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseMedia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chooseMedia.FlatAppearance.BorderSize = 0;
            this.chooseMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chooseMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseMedia.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.chooseMedia.Location = new System.Drawing.Point(5, 5);
            this.chooseMedia.Margin = new System.Windows.Forms.Padding(5);
            this.chooseMedia.Name = "chooseMedia";
            this.chooseMedia.Size = new System.Drawing.Size(212, 47);
            this.chooseMedia.TabIndex = 7;
            this.chooseMedia.Text = "Choose Media";
            this.chooseMedia.UseVisualStyleBackColor = true;
            this.chooseMedia.Click += new System.EventHandler(this.chooseMedia_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.BackgroundImage = global::PaperCup.Properties.Resources.icon_ios7_gear_128;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.settingsButton.FlatAppearance.BorderSize = 3;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(230, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(50, 50);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // portInfoTable
            // 
            this.portInfoTable.ColumnCount = 2;
            this.portInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.90952F));
            this.portInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.09049F));
            this.portInfoTable.Controls.Add(this.portInfoGroupBox, 0, 0);
            this.portInfoTable.Controls.Add(this.connectButton, 1, 0);
            this.portInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portInfoTable.Location = new System.Drawing.Point(3, 3);
            this.portInfoTable.Name = "portInfoTable";
            this.portInfoTable.RowCount = 1;
            this.portInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.portInfoTable.Size = new System.Drawing.Size(288, 94);
            this.portInfoTable.TabIndex = 10;
            // 
            // portInfoGroupBox
            // 
            this.portInfoGroupBox.Controls.Add(this.enterPortInfoTable);
            this.portInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portInfoGroupBox.ForeColor = System.Drawing.Color.Gray;
            this.portInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.portInfoGroupBox.Name = "portInfoGroupBox";
            this.portInfoGroupBox.Size = new System.Drawing.Size(192, 88);
            this.portInfoGroupBox.TabIndex = 1;
            this.portInfoGroupBox.TabStop = false;
            this.portInfoGroupBox.Text = "Port Information";
            // 
            // enterPortInfoTable
            // 
            this.enterPortInfoTable.ColumnCount = 2;
            this.enterPortInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.12195F));
            this.enterPortInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.87805F));
            this.enterPortInfoTable.Controls.Add(this.remotePort, 1, 1);
            this.enterPortInfoTable.Controls.Add(this.localPort, 1, 0);
            this.enterPortInfoTable.Controls.Add(this.localPortLabel, 0, 0);
            this.enterPortInfoTable.Controls.Add(this.remotePortLabel, 0, 1);
            this.enterPortInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterPortInfoTable.Location = new System.Drawing.Point(3, 27);
            this.enterPortInfoTable.Name = "enterPortInfoTable";
            this.enterPortInfoTable.RowCount = 2;
            this.enterPortInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enterPortInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.enterPortInfoTable.Size = new System.Drawing.Size(186, 58);
            this.enterPortInfoTable.TabIndex = 10;
            // 
            // remotePort
            // 
            this.remotePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remotePort.ForeColor = System.Drawing.Color.Gray;
            this.remotePort.Location = new System.Drawing.Point(88, 34);
            this.remotePort.Margin = new System.Windows.Forms.Padding(5);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(93, 31);
            this.remotePort.TabIndex = 5;
            // 
            // localPort
            // 
            this.localPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.localPort.ForeColor = System.Drawing.Color.Gray;
            this.localPort.Location = new System.Drawing.Point(88, 5);
            this.localPort.Margin = new System.Windows.Forms.Padding(5);
            this.localPort.Name = "localPort";
            this.localPort.Size = new System.Drawing.Size(93, 31);
            this.localPort.TabIndex = 3;
            // 
            // localPortLabel
            // 
            this.localPortLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.localPortLabel.AutoSize = true;
            this.localPortLabel.Location = new System.Drawing.Point(6, 0);
            this.localPortLabel.Name = "localPortLabel";
            this.localPortLabel.Size = new System.Drawing.Size(70, 29);
            this.localPortLabel.TabIndex = 1;
            this.localPortLabel.Text = "Local Port";
            // 
            // remotePortLabel
            // 
            this.remotePortLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remotePortLabel.AutoSize = true;
            this.remotePortLabel.Location = new System.Drawing.Point(3, 29);
            this.remotePortLabel.Name = "remotePortLabel";
            this.remotePortLabel.Size = new System.Drawing.Size(77, 29);
            this.remotePortLabel.TabIndex = 3;
            this.remotePortLabel.Text = "Remote Port";
            // 
            // connectButton
            // 
            this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.connectButton.FlatAppearance.BorderSize = 3;
            this.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.connectButton.Location = new System.Drawing.Point(201, 32);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(84, 30);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connect_Click);
            // 
            // chatTable
            // 
            this.chatTable.ColumnCount = 1;
            this.chatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatTable.Controls.Add(this.Chat, 0, 0);
            this.chatTable.Controls.Add(this.sendTable, 0, 1);
            this.chatTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTable.Location = new System.Drawing.Point(5, 105);
            this.chatTable.Margin = new System.Windows.Forms.Padding(5);
            this.chatTable.Name = "chatTable";
            this.chatTable.RowCount = 2;
            this.chatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.chatTable.Size = new System.Drawing.Size(284, 501);
            this.chatTable.TabIndex = 13;
            // 
            // Chat
            // 
            this.Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chat.FormattingEnabled = true;
            this.Chat.ItemHeight = 25;
            this.Chat.Location = new System.Drawing.Point(0, 0);
            this.Chat.Margin = new System.Windows.Forms.Padding(0);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(284, 464);
            this.Chat.TabIndex = 5;
            // 
            // sendTable
            // 
            this.sendTable.ColumnCount = 2;
            this.sendTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.2766F));
            this.sendTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7234F));
            this.sendTable.Controls.Add(this.sendMessage, 0, 0);
            this.sendTable.Controls.Add(this.sendButton, 1, 0);
            this.sendTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendTable.Location = new System.Drawing.Point(3, 467);
            this.sendTable.Name = "sendTable";
            this.sendTable.RowCount = 1;
            this.sendTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sendTable.Size = new System.Drawing.Size(278, 31);
            this.sendTable.TabIndex = 6;
            // 
            // sendMessage
            // 
            this.sendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessage.Location = new System.Drawing.Point(0, 0);
            this.sendMessage.Margin = new System.Windows.Forms.Padding(0);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(198, 31);
            this.sendMessage.TabIndex = 3;
            //this.sendMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendMessage_KeyPress);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.sendButton.FlatAppearance.BorderSize = 3;
            this.sendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.sendButton.Location = new System.Drawing.Point(198, 0);
            this.sendButton.Margin = new System.Windows.Forms.Padding(0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(80, 31);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // VideoPlayer
            // 
            this.AcceptButton = this.sendButton;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.masterPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "VideoPlayer";
            this.Tag = "video";
            this.Text = "Video Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlayer_FormClosing);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.masterPanel.ResumeLayout(false);
            this.sidebarTable.ResumeLayout(false);
            this.settingsTable.ResumeLayout(false);
            this.portInfoTable.ResumeLayout(false);
            this.portInfoGroupBox.ResumeLayout(false);
            this.enterPortInfoTable.ResumeLayout(false);
            this.enterPortInfoTable.PerformLayout();
            this.chatTable.ResumeLayout(false);
            this.sendTable.ResumeLayout(false);
            this.sendTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.TableLayoutPanel masterPanel;
        private System.Windows.Forms.TableLayoutPanel sidebarTable;
        private System.Windows.Forms.TableLayoutPanel portInfoTable;
        private System.Windows.Forms.GroupBox portInfoGroupBox;
        private System.Windows.Forms.TableLayoutPanel enterPortInfoTable;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.TextBox localPort;
        private System.Windows.Forms.Label localPortLabel;
        private System.Windows.Forms.Label remotePortLabel;
        private System.Windows.Forms.TableLayoutPanel chatTable;
        private System.Windows.Forms.ListBox Chat;
        private System.Windows.Forms.TableLayoutPanel sendTable;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendMessage;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TableLayoutPanel settingsTable;
        private System.Windows.Forms.Button chooseMedia;
        private System.Windows.Forms.Button settingsButton;
    }
}