namespace MiniSteam
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dataManagementToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            addGameToolStripMenuItem = new ToolStripMenuItem();
            dgvData = new DataGridView();
            cmbxSelectedUser = new ComboBox();
            cmbxSelectedRating = new ComboBox();
            lblSelectUsers = new Label();
            lblSelectRating = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataManagementToolStripMenuItem
            // 
            dataManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, addGameToolStripMenuItem });
            dataManagementToolStripMenuItem.Name = "dataManagementToolStripMenuItem";
            dataManagementToolStripMenuItem.Size = new Size(147, 24);
            dataManagementToolStripMenuItem.Text = "Data Management";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(163, 26);
            addUserToolStripMenuItem.Text = "Add User";
            // 
            // addGameToolStripMenuItem
            // 
            addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            addGameToolStripMenuItem.Size = new Size(163, 26);
            addGameToolStripMenuItem.Text = "Add Game";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(30, 218);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(743, 188);
            dgvData.TabIndex = 1;
            // 
            // cmbxSelectedUser
            // 
            cmbxSelectedUser.FormattingEnabled = true;
            cmbxSelectedUser.Location = new Point(30, 174);
            cmbxSelectedUser.Name = "cmbxSelectedUser";
            cmbxSelectedUser.Size = new Size(212, 28);
            cmbxSelectedUser.TabIndex = 2;
            // 
            // cmbxSelectedRating
            // 
            cmbxSelectedRating.FormattingEnabled = true;
            cmbxSelectedRating.Location = new Point(561, 174);
            cmbxSelectedRating.Name = "cmbxSelectedRating";
            cmbxSelectedRating.Size = new Size(212, 28);
            cmbxSelectedRating.TabIndex = 3;
            // 
            // lblSelectUsers
            // 
            lblSelectUsers.AutoSize = true;
            lblSelectUsers.Location = new Point(30, 140);
            lblSelectUsers.Name = "lblSelectUsers";
            lblSelectUsers.Size = new Size(80, 20);
            lblSelectUsers.TabIndex = 4;
            lblSelectUsers.Text = "Select user";
            // 
            // lblSelectRating
            // 
            lblSelectRating.AutoSize = true;
            lblSelectRating.Location = new Point(561, 140);
            lblSelectRating.Name = "lblSelectRating";
            lblSelectRating.Size = new Size(92, 20);
            lblSelectRating.TabIndex = 5;
            lblSelectRating.Text = "Select rating";
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSelectRating);
            Controls.Add(lblSelectUsers);
            Controls.Add(cmbxSelectedRating);
            Controls.Add(cmbxSelectedUser);
            Controls.Add(dgvData);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_Main";
            Text = "Main";
            Load += frm_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataManagementToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem addGameToolStripMenuItem;
        private DataGridView dgvData;
        private ComboBox cmbxSelectedUser;
        private ComboBox cmbxSelectedRating;
        private Label lblSelectUsers;
        private Label lblSelectRating;
    }
}
