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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("User 1 - [Host]");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("User 2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.masterTable = new System.Windows.Forms.TableLayoutPanel();
            this.nicknameTable = new System.Windows.Forms.TableLayoutPanel();
            this.nameChange = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.userSettingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.soundCheck = new System.Windows.Forms.CheckBox();
            this.ipDisplay = new System.Windows.Forms.Label();
            this.roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.roomInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.usersList = new System.Windows.Forms.ListView();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.masterTable.SuspendLayout();
            this.nicknameTable.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.userSettingsTable.SuspendLayout();
            this.roomInfoGroupBox.SuspendLayout();
            this.roomInfoTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterTable
            // 
            this.masterTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.masterTable.ColumnCount = 2;
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.masterTable.Controls.Add(this.settingsGroupBox, 1, 0);
            this.masterTable.Controls.Add(this.roomInfoGroupBox, 0, 0);
            this.masterTable.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.masterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTable.Location = new System.Drawing.Point(0, 0);
            this.masterTable.Margin = new System.Windows.Forms.Padding(2);
            this.masterTable.Name = "masterTable";
            this.masterTable.RowCount = 2;
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.masterTable.Size = new System.Drawing.Size(624, 211);
            this.masterTable.TabIndex = 1;
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
            this.nicknameTable.Size = new System.Drawing.Size(296, 25);
            this.nicknameTable.TabIndex = 8;
            // 
            // nameChange
            // 
            this.nameChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameChange.ForeColor = System.Drawing.Color.Gray;
            this.nameChange.Location = new System.Drawing.Point(70, 2);
            this.nameChange.Margin = new System.Windows.Forms.Padding(2);
            this.nameChange.Name = "nameChange";
            this.nameChange.Size = new System.Drawing.Size(234, 20);
            this.nameChange.TabIndex = 1;
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
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.userSettingsTable);
            this.settingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsGroupBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.settingsGroupBox.Location = new System.Drawing.Point(315, 3);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(306, 175);
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
            this.userSettingsTable.Size = new System.Drawing.Size(300, 152);
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
            this.soundCheck.Size = new System.Drawing.Size(296, 16);
            this.soundCheck.TabIndex = 1;
            this.soundCheck.Text = "Play sound when someone sends a message.";
            this.soundCheck.UseVisualStyleBackColor = true;
            // 
            // ipDisplay
            // 
            this.ipDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ipDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipDisplay.ForeColor = System.Drawing.Color.Gray;
            this.ipDisplay.Location = new System.Drawing.Point(2, 3);
            this.ipDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipDisplay.Name = "ipDisplay";
            this.ipDisplay.Size = new System.Drawing.Size(296, 13);
            this.ipDisplay.TabIndex = 1;
            this.ipDisplay.Text = "IP Address";
            // 
            // roomInfoGroupBox
            // 
            this.roomInfoGroupBox.Controls.Add(this.roomInfoTable);
            this.roomInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomInfoGroupBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.roomInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.roomInfoGroupBox.Name = "roomInfoGroupBox";
            this.roomInfoGroupBox.Size = new System.Drawing.Size(306, 175);
            this.roomInfoGroupBox.TabIndex = 14;
            this.roomInfoGroupBox.TabStop = false;
            this.roomInfoGroupBox.Text = "Room Information";
            // 
            // roomInfoTable
            // 
            this.roomInfoTable.ColumnCount = 1;
            this.roomInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roomInfoTable.Controls.Add(this.ipDisplay, 0, 0);
            this.roomInfoTable.Controls.Add(this.usersList, 0, 1);
            this.roomInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomInfoTable.Location = new System.Drawing.Point(3, 20);
            this.roomInfoTable.Margin = new System.Windows.Forms.Padding(2);
            this.roomInfoTable.Name = "roomInfoTable";
            this.roomInfoTable.RowCount = 2;
            this.roomInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.roomInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roomInfoTable.Size = new System.Drawing.Size(300, 152);
            this.roomInfoTable.TabIndex = 6;
            // 
            // usersList
            // 
            this.usersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersList.ForeColor = System.Drawing.Color.Gray;
            this.usersList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.usersList.Location = new System.Drawing.Point(2, 22);
            this.usersList.Margin = new System.Windows.Forms.Padding(2);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(296, 128);
            this.usersList.TabIndex = 7;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.View = System.Windows.Forms.View.List;
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
            this.updateButton.Location = new System.Drawing.Point(108, 2);
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
            this.cancelButton.Location = new System.Drawing.Point(208, 2);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 20);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(315, 184);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 24);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // Options
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(624, 211);
            this.Controls.Add(this.masterTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 180);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.masterTable.ResumeLayout(false);
            this.nicknameTable.ResumeLayout(false);
            this.nicknameTable.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.userSettingsTable.ResumeLayout(false);
            this.roomInfoGroupBox.ResumeLayout(false);
            this.roomInfoTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel masterTable;
        private System.Windows.Forms.TableLayoutPanel roomInfoTable;
        private System.Windows.Forms.ListView usersList;
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
    }
}