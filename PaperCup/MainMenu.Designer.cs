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
            this.masterTable = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.createButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.nicknameBox = new System.Windows.Forms.TextBox();
            this.masterTable.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterTable
            // 
            this.masterTable.ColumnCount = 1;
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.masterTable.Controls.Add(this.buttonsTable, 0, 0);
            this.masterTable.Controls.Add(this.bottomTable, 0, 1);
            this.masterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTable.Location = new System.Drawing.Point(0, 0);
            this.masterTable.Margin = new System.Windows.Forms.Padding(0);
            this.masterTable.Name = "masterTable";
            this.masterTable.RowCount = 2;
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.46243F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.537572F));
            this.masterTable.Size = new System.Drawing.Size(956, 534);
            this.masterTable.TabIndex = 3;
            // 
            // buttonsTable
            // 
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.createButton, 0, 0);
            this.buttonsTable.Controls.Add(this.joinButton, 1, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTable.Location = new System.Drawing.Point(50, 50);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(50);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Size = new System.Drawing.Size(856, 383);
            this.buttonsTable.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createButton.Location = new System.Drawing.Point(30, 30);
            this.createButton.Margin = new System.Windows.Forms.Padding(30);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(368, 323);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create a Room";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // joinButton
            // 
            this.joinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinButton.Location = new System.Drawing.Point(458, 30);
            this.joinButton.Margin = new System.Windows.Forms.Padding(30);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(368, 323);
            this.joinButton.TabIndex = 2;
            this.joinButton.Text = "Join a Room";
            this.joinButton.UseVisualStyleBackColor = true;
            // 
            // bottomTable
            // 
            this.bottomTable.ColumnCount = 3;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.51495F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.48505F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.bottomTable.Controls.Add(this.nicknameLabel, 0, 0);
            this.bottomTable.Controls.Add(this.settingsButton, 2, 0);
            this.bottomTable.Controls.Add(this.nicknameBox, 1, 0);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTable.Location = new System.Drawing.Point(10, 493);
            this.bottomTable.Margin = new System.Windows.Forms.Padding(10);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTable.Size = new System.Drawing.Size(936, 31);
            this.bottomTable.TabIndex = 3;
            this.bottomTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel.Location = new System.Drawing.Point(3, 0);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(121, 31);
            this.nicknameLabel.TabIndex = 2;
            this.nicknameLabel.Text = "Nickname:";
            this.nicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.Location = new System.Drawing.Point(772, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(161, 25);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "button3";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // nicknameBox
            // 
            this.nicknameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nicknameBox.Location = new System.Drawing.Point(130, 3);
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.Size = new System.Drawing.Size(636, 20);
            this.nicknameBox.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 534);
            this.Controls.Add(this.masterTable);
            this.Name = "MainMenu";
            this.Text = "PaperCup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.masterTable.ResumeLayout(false);
            this.buttonsTable.ResumeLayout(false);
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
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox nicknameBox;
        private System.Windows.Forms.Label nicknameLabel;
    }
}

