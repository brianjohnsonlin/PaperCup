namespace PaperCup
{
    partial class HostIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostIP));
            this.masterTable = new System.Windows.Forms.TableLayoutPanel();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.enterInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.joinButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.TextBox();
            this.masterTable.SuspendLayout();
            this.enterInfoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterTable
            // 
            this.masterTable.ColumnCount = 1;
            this.masterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.Controls.Add(this.instructionsLabel, 0, 0);
            this.masterTable.Controls.Add(this.enterInfoTable, 0, 1);
            this.masterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterTable.Location = new System.Drawing.Point(0, 0);
            this.masterTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masterTable.Name = "masterTable";
            this.masterTable.RowCount = 2;
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.masterTable.Size = new System.Drawing.Size(652, 146);
            this.masterTable.TabIndex = 1;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.instructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.Gray;
            this.instructionsLabel.Location = new System.Drawing.Point(2, 0);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(648, 79);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter the I.P. Address of the user who is hosting the room you would like to join" +
    ":";
            // 
            // enterInfoTable
            // 
            this.enterInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterInfoTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.enterInfoTable.ColumnCount = 3;
            this.enterInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.enterInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.enterInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.enterInfoTable.Controls.Add(this.joinButton, 1, 0);
            this.enterInfoTable.Controls.Add(this.cancelButton, 2, 0);
            this.enterInfoTable.Controls.Add(this.IP, 0, 0);
            this.enterInfoTable.Location = new System.Drawing.Point(2, 81);
            this.enterInfoTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterInfoTable.Name = "enterInfoTable";
            this.enterInfoTable.RowCount = 1;
            this.enterInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.enterInfoTable.Size = new System.Drawing.Size(648, 63);
            this.enterInfoTable.TabIndex = 1;
            // 
            // joinButton
            // 
            this.joinButton.BackgroundImage = global::PaperCup.Properties.Resources.button1;
            this.joinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.joinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinButton.FlatAppearance.BorderSize = 0;
            this.joinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.047121F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.ForeColor = System.Drawing.Color.Green;
            this.joinButton.Location = new System.Drawing.Point(418, 10);
            this.joinButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(100, 43);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join!";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::PaperCup.Properties.Resources.button1;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.Gray;
            this.cancelButton.Location = new System.Drawing.Point(538, 10);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 43);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // IP
            // 
            this.IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(211)))));
            this.IP.ForeColor = System.Drawing.Color.Gray;
            this.IP.Location = new System.Drawing.Point(10, 16);
            this.IP.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(388, 31);
            this.IP.TabIndex = 0;
            this.IP.TextChanged += new System.EventHandler(this.IP_TextChanged);
            this.IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IP_KeyPress);
            // 
            // HostIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 146);
            this.Controls.Add(this.masterTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Host I.P.";
            this.masterTable.ResumeLayout(false);
            this.enterInfoTable.ResumeLayout(false);
            this.enterInfoTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel masterTable;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TableLayoutPanel enterInfoTable;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button cancelButton;
    }
}