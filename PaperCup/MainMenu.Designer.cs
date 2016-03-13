namespace PaperCup
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.masterTable = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.nicknameBox = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.masterTable.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bottomTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterTable
            // 
            this.masterTable.ColumnCount = 1;
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.Controls.Add(this.buttonsTable, 0, 0);
            this.masterTable.Controls.Add(this.bottomTable, 0, 1);
            this.masterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTable.Location = new System.Drawing.Point(0, 0);
            this.masterTable.Margin = new System.Windows.Forms.Padding(0);
            this.masterTable.Name = "masterTable";
            this.masterTable.RowCount = 2;
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.masterTable.Size = new System.Drawing.Size(609, 296);
            this.masterTable.TabIndex = 3;
            // 
            // buttonsTable
            // 
            this.buttonsTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonsTable.BackColor = System.Drawing.SystemColors.Control;
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83444F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16556F));
            this.buttonsTable.Controls.Add(this.pictureBox2, 0, 0);
            this.buttonsTable.Controls.Add(this.createButton, 0, 1);
            this.buttonsTable.Controls.Add(this.joinButton, 1, 1);
            this.buttonsTable.Controls.Add(this.pictureBox1, 1, 0);
            this.buttonsTable.Location = new System.Drawing.Point(2, 7);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 2;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.Size = new System.Drawing.Size(604, 250);
            this.buttonsTable.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PaperCup.Properties.Resources.createRoom11;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 184);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(168)))));
            this.createButton.BackgroundImage = global::PaperCup.Properties.Resources.button1;
            this.createButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Candara", 21.86387F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.Green;
            this.createButton.Location = new System.Drawing.Point(30, 203);
            this.createButton.Margin = new System.Windows.Forms.Padding(30, 3, 15, 5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(256, 42);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create a Room";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(168)))));
            this.joinButton.BackgroundImage = global::PaperCup.Properties.Resources.button1;
            this.joinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.joinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.joinButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.Font = new System.Drawing.Font("Candara", 21.86387F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.ForeColor = System.Drawing.Color.Green;
            this.joinButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.joinButton.Location = new System.Drawing.Point(331, 203);
            this.joinButton.Margin = new System.Windows.Forms.Padding(30, 3, 15, 5);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(258, 42);
            this.joinButton.TabIndex = 2;
            this.joinButton.Text = "Join a Room";
            this.joinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PaperCup.Properties.Resources.joinRoom1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(311, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 184);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bottomTable
            // 
            this.bottomTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.bottomTable.ColumnCount = 2;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Controls.Add(this.nicknameBox, 1, 0);
            this.bottomTable.Controls.Add(this.nicknameLabel, 0, 0);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomTable.Location = new System.Drawing.Point(0, 265);
            this.bottomTable.Margin = new System.Windows.Forms.Padding(0);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Size = new System.Drawing.Size(609, 31);
            this.bottomTable.TabIndex = 3;
            // 
            // nicknameBox
            // 
            this.nicknameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nicknameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.nicknameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameBox.ForeColor = System.Drawing.Color.Gray;
            this.nicknameBox.Location = new System.Drawing.Point(106, 2);
            this.nicknameBox.Margin = new System.Windows.Forms.Padding(0);
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.Size = new System.Drawing.Size(496, 26);
            this.nicknameBox.TabIndex = 1;
            this.nicknameBox.TextChanged += new System.EventHandler(this.nicknameBox_TextChanged);
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.nicknameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nicknameLabel.Location = new System.Drawing.Point(2, 0);
            this.nicknameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(98, 31);
            this.nicknameLabel.TabIndex = 2;
            this.nicknameLabel.Text = "Nickname:";
            this.nicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PaperCup.Properties.Resources.icon_ios7_gear_128;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(609, 296);
            this.Controls.Add(this.masterTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 335);
            this.MinimumSize = new System.Drawing.Size(625, 335);
            this.Name = "MainMenu";
            this.Text = "PaperCup";
            this.masterTable.ResumeLayout(false);
            this.buttonsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bottomTable.ResumeLayout(false);
            this.bottomTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel masterTable;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.TextBox nicknameBox;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

