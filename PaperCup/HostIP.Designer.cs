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
            this.masterTable.Margin = new System.Windows.Forms.Padding(1);
            this.masterTable.Name = "masterTable";
            this.masterTable.RowCount = 2;
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.masterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.masterTable.Size = new System.Drawing.Size(326, 76);
            this.masterTable.TabIndex = 1;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(1, 0);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(324, 41);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter the I.P. Address of the user who is hosting the room you would like to join" +
    ":";
            // 
            // enterInfoTable
            // 
            this.enterInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterInfoTable.ColumnCount = 3;
            this.enterInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.enterInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.enterInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.enterInfoTable.Controls.Add(this.joinButton, 1, 0);
            this.enterInfoTable.Controls.Add(this.cancelButton, 2, 0);
            this.enterInfoTable.Controls.Add(this.IP, 0, 0);
            this.enterInfoTable.Location = new System.Drawing.Point(1, 42);
            this.enterInfoTable.Margin = new System.Windows.Forms.Padding(1);
            this.enterInfoTable.Name = "enterInfoTable";
            this.enterInfoTable.RowCount = 1;
            this.enterInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.enterInfoTable.Size = new System.Drawing.Size(324, 33);
            this.enterInfoTable.TabIndex = 1;
            // 
            // joinButton
            // 
            this.joinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinButton.Location = new System.Drawing.Point(209, 5);
            this.joinButton.Margin = new System.Windows.Forms.Padding(5);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(50, 23);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join!";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(269, 5);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // IP
            // 
            this.IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IP.Location = new System.Drawing.Point(5, 6);
            this.IP.Margin = new System.Windows.Forms.Padding(5);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(194, 20);
            this.IP.TabIndex = 0;
            this.IP.TextChanged += new System.EventHandler(this.IP_TextChanged);
            this.IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IP_KeyPress);
            // 
            // HostIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 76);
            this.Controls.Add(this.masterTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
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