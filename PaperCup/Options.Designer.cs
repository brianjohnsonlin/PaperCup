namespace PaperCup {
    partial class Options {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.masterTable = new System.Windows.Forms.TableLayoutPanel();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.userSettingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.soundCheck = new System.Windows.Forms.CheckBox();
            this.nicknameTable = new System.Windows.Forms.TableLayoutPanel();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.nameChange = new System.Windows.Forms.TextBox();
            this.roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.roomInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.localPortTextBox = new System.Windows.Forms.TextBox();
            this.remotePortTextBox = new System.Windows.Forms.TextBox();
            this.ipDisplay = new System.Windows.Forms.Label();
            this.yourIPLabel = new System.Windows.Forms.Label();
            this.connectedIPLabel = new System.Windows.Forms.Label();
            this.ripDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.localPortLabel = new System.Windows.Forms.Label();
            this.remotePortLabel = new System.Windows.Forms.Label();
            this.masterTable.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.userSettingsTable.SuspendLayout();
            this.nicknameTable.SuspendLayout();
            this.roomInfoGroupBox.SuspendLayout();
            this.roomInfoTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterTable
            // 
            this.masterTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.masterTable.ColumnCount = 1;
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.masterTable.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.masterTable.Controls.Add(this.settingsGroupBox, 0, 1);
            this.masterTable.Controls.Add(this.roomInfoGroupBox, 0, 0);
            this.masterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTable.Location = new System.Drawing.Point(0, 0);
            this.masterTable.Margin = new System.Windows.Forms.Padding(2);
            this.masterTable.Name = "masterTable";
            this.masterTable.RowCount = 3;
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.masterTable.Size = new System.Drawing.Size(284, 191);
            this.masterTable.TabIndex = 1;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.userSettingsTable);
            this.settingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsGroupBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.settingsGroupBox.Location = new System.Drawing.Point(3, 83);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(278, 74);
            this.settingsGroupBox.TabIndex = 12;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "User Settings";
            // 
            // userSettingsTable
            // 
            this.userSettingsTable.ColumnCount = 1;
            this.userSettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userSettingsTable.Controls.Add(this.soundCheck, 0, 0);
            this.userSettingsTable.Controls.Add(this.nicknameTable, 0, 1);
            this.userSettingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSettingsTable.Location = new System.Drawing.Point(3, 20);
            this.userSettingsTable.Margin = new System.Windows.Forms.Padding(2);
            this.userSettingsTable.Name = "userSettingsTable";
            this.userSettingsTable.RowCount = 2;
            this.userSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userSettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userSettingsTable.Size = new System.Drawing.Size(272, 51);
            this.userSettingsTable.TabIndex = 9;
            // 
            // soundCheck
            // 
            this.soundCheck.Checked = true;
            this.soundCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soundCheck.Location = new System.Drawing.Point(2, 2);
            this.soundCheck.Margin = new System.Windows.Forms.Padding(2);
            this.soundCheck.Name = "soundCheck";
            this.soundCheck.Size = new System.Drawing.Size(268, 16);
            this.soundCheck.TabIndex = 1;
            this.soundCheck.Text = "Play a sound when someone sends a message.";
            this.soundCheck.UseVisualStyleBackColor = true;
            // 
            // nicknameTable
            // 
            this.nicknameTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nicknameTable.ColumnCount = 2;
            this.nicknameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.nicknameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nicknameTable.Controls.Add(this.nicknameLabel, 0, 0);
            this.nicknameTable.Controls.Add(this.nameChange, 1, 0);
            this.nicknameTable.ForeColor = System.Drawing.Color.Gray;
            this.nicknameTable.Location = new System.Drawing.Point(2, 22);
            this.nicknameTable.Margin = new System.Windows.Forms.Padding(2);
            this.nicknameTable.Name = "nicknameTable";
            this.nicknameTable.RowCount = 1;
            this.nicknameTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.nicknameTable.Size = new System.Drawing.Size(268, 25);
            this.nicknameTable.TabIndex = 8;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.nicknameLabel.Location = new System.Drawing.Point(7, 6);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(58, 13);
            this.nicknameLabel.TabIndex = 2;
            this.nicknameLabel.Text = "Nickname:";
            // 
            // nameChange
            // 
            this.nameChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameChange.ForeColor = System.Drawing.Color.Gray;
            this.nameChange.Location = new System.Drawing.Point(70, 2);
            this.nameChange.Margin = new System.Windows.Forms.Padding(2);
            this.nameChange.MaxLength = 30;
            this.nameChange.Name = "nameChange";
            this.nameChange.Size = new System.Drawing.Size(196, 20);
            this.nameChange.TabIndex = 1;
            // 
            // roomInfoGroupBox
            // 
            this.roomInfoGroupBox.Controls.Add(this.roomInfoTable);
            this.roomInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInfoGroupBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.roomInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.roomInfoGroupBox.Name = "roomInfoGroupBox";
            this.roomInfoGroupBox.Size = new System.Drawing.Size(278, 74);
            this.roomInfoGroupBox.TabIndex = 14;
            this.roomInfoGroupBox.TabStop = false;
            this.roomInfoGroupBox.Text = "Network Information";
            // 
            // roomInfoTable
            // 
            this.roomInfoTable.ColumnCount = 4;
            this.roomInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.roomInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.roomInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.roomInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roomInfoTable.Controls.Add(this.localPortTextBox, 3, 0);
            this.roomInfoTable.Controls.Add(this.remotePortTextBox, 3, 1);
            this.roomInfoTable.Controls.Add(this.ipDisplay, 1, 0);
            this.roomInfoTable.Controls.Add(this.yourIPLabel, 0, 0);
            this.roomInfoTable.Controls.Add(this.connectedIPLabel, 0, 1);
            this.roomInfoTable.Controls.Add(this.ripDisplay, 1, 1);
            this.roomInfoTable.Controls.Add(this.localPortLabel, 2, 0);
            this.roomInfoTable.Controls.Add(this.remotePortLabel, 2, 1);
            this.roomInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomInfoTable.Location = new System.Drawing.Point(3, 20);
            this.roomInfoTable.Margin = new System.Windows.Forms.Padding(2);
            this.roomInfoTable.Name = "roomInfoTable";
            this.roomInfoTable.RowCount = 3;
            this.roomInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.roomInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.roomInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roomInfoTable.Size = new System.Drawing.Size(272, 51);
            this.roomInfoTable.TabIndex = 6;
            // 
            // localPortTextBox
            // 
            this.localPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localPortTextBox.ForeColor = System.Drawing.Color.Gray;
            this.localPortTextBox.Location = new System.Drawing.Point(232, 2);
            this.localPortTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.localPortTextBox.MaxLength = 5;
            this.localPortTextBox.Name = "localPortTextBox";
            this.localPortTextBox.Size = new System.Drawing.Size(38, 20);
            this.localPortTextBox.TabIndex = 3;
            // 
            // remotePortTextBox
            // 
            this.remotePortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remotePortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remotePortTextBox.ForeColor = System.Drawing.Color.Gray;
            this.remotePortTextBox.Location = new System.Drawing.Point(232, 22);
            this.remotePortTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.remotePortTextBox.MaxLength = 5;
            this.remotePortTextBox.Name = "remotePortTextBox";
            this.remotePortTextBox.Size = new System.Drawing.Size(38, 20);
            this.remotePortTextBox.TabIndex = 4;
            // 
            // ipDisplay
            // 
            this.ipDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ipDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipDisplay.ForeColor = System.Drawing.Color.Gray;
            this.ipDisplay.Location = new System.Drawing.Point(112, 3);
            this.ipDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipDisplay.Name = "ipDisplay";
            this.ipDisplay.Size = new System.Drawing.Size(81, 13);
            this.ipDisplay.TabIndex = 1;
            this.ipDisplay.Text = "local IP";
            this.ipDisplay.Click += new System.EventHandler(this.ipDisplay_Click);
            // 
            // yourIPLabel
            // 
            this.yourIPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.yourIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourIPLabel.ForeColor = System.Drawing.Color.Gray;
            this.yourIPLabel.Location = new System.Drawing.Point(2, 3);
            this.yourIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yourIPLabel.Name = "yourIPLabel";
            this.yourIPLabel.Size = new System.Drawing.Size(106, 13);
            this.yourIPLabel.TabIndex = 2;
            this.yourIPLabel.Text = "Your IP Address is:";
            // 
            // connectedIPLabel
            // 
            this.connectedIPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.connectedIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedIPLabel.ForeColor = System.Drawing.Color.Gray;
            this.connectedIPLabel.Location = new System.Drawing.Point(2, 23);
            this.connectedIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectedIPLabel.Name = "connectedIPLabel";
            this.connectedIPLabel.Size = new System.Drawing.Size(106, 13);
            this.connectedIPLabel.TabIndex = 5;
            this.connectedIPLabel.Text = "You\'re connected to:";
            // 
            // ripDisplay
            // 
            this.ripDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ripDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ripDisplay.ForeColor = System.Drawing.Color.Gray;
            this.ripDisplay.Location = new System.Drawing.Point(112, 23);
            this.ripDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ripDisplay.Name = "ripDisplay";
            this.ripDisplay.Size = new System.Drawing.Size(81, 13);
            this.ripDisplay.TabIndex = 6;
            this.ripDisplay.Text = "remote IP";
            this.ripDisplay.Click += new System.EventHandler(this.ripDisplay_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 25);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.BackgroundImage = global::PaperCup.Properties.Resources.button1;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.Green;
            this.updateButton.Location = new System.Drawing.Point(80, 2);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 20);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackgroundImage = global::PaperCup.Properties.Resources.button1;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.Gray;
            this.cancelButton.Location = new System.Drawing.Point(180, 2);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 20);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // localPortLabel
            // 
            this.localPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.localPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localPortLabel.ForeColor = System.Drawing.Color.Gray;
            this.localPortLabel.Location = new System.Drawing.Point(197, 3);
            this.localPortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.localPortLabel.Name = "localPortLabel";
            this.localPortLabel.Size = new System.Drawing.Size(31, 13);
            this.localPortLabel.TabIndex = 7;
            this.localPortLabel.Text = "Port:";
            // 
            // remotePortLabel
            // 
            this.remotePortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remotePortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remotePortLabel.ForeColor = System.Drawing.Color.Gray;
            this.remotePortLabel.Location = new System.Drawing.Point(197, 23);
            this.remotePortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remotePortLabel.Name = "remotePortLabel";
            this.remotePortLabel.Size = new System.Drawing.Size(31, 13);
            this.remotePortLabel.TabIndex = 8;
            this.remotePortLabel.Text = "Port:";
            // 
            // Options
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.masterTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 230);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.masterTable.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.userSettingsTable.ResumeLayout(false);
            this.nicknameTable.ResumeLayout(false);
            this.nicknameTable.PerformLayout();
            this.roomInfoGroupBox.ResumeLayout(false);
            this.roomInfoTable.ResumeLayout(false);
            this.roomInfoTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel masterTable;
        private System.Windows.Forms.Label ipDisplay;
        private System.Windows.Forms.TableLayoutPanel userSettingsTable;
        private System.Windows.Forms.CheckBox soundCheck;
        private System.Windows.Forms.TableLayoutPanel nicknameTable;
        private System.Windows.Forms.TextBox nameChange;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.GroupBox roomInfoGroupBox;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel roomInfoTable;
        private System.Windows.Forms.TextBox remotePortTextBox;
        private System.Windows.Forms.TextBox localPortTextBox;
        private System.Windows.Forms.Label yourIPLabel;
        private System.Windows.Forms.Label connectedIPLabel;
        private System.Windows.Forms.Label ripDisplay;
        private System.Windows.Forms.Label localPortLabel;
        private System.Windows.Forms.Label remotePortLabel;
    }
}