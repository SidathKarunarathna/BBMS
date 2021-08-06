
namespace BBMS
{
    partial class MainDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDash));
            this.desktoppanel = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.iconclose = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.Label();
            this.iconcurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenue = new System.Windows.Forms.Panel();
            this.iconCampaign = new FontAwesome.Sharp.IconButton();
            this.iconUserRegistration = new FontAwesome.Sharp.IconButton();
            this.iconPendingReq = new FontAwesome.Sharp.IconButton();
            this.iconDonations = new FontAwesome.Sharp.IconButton();
            this.iconLogout = new FontAwesome.Sharp.IconButton();
            this.iconDonors = new FontAwesome.Sharp.IconButton();
            this.iconDonorRegistration = new FontAwesome.Sharp.IconButton();
            this.iconBloodStock = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IconRestLogo = new FontAwesome.Sharp.IconPictureBox();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrent)).BeginInit();
            this.panelMenue.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // desktoppanel
            // 
            this.desktoppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktoppanel.Location = new System.Drawing.Point(338, 98);
            this.desktoppanel.Margin = new System.Windows.Forms.Padding(2);
            this.desktoppanel.Name = "desktoppanel";
            this.desktoppanel.Size = new System.Drawing.Size(702, 542);
            this.desktoppanel.TabIndex = 2;
            // 
            // TitleBar
            // 
            this.TitleBar.BackgroundImage = global::BBMS.Properties.Resources.back;
            this.TitleBar.Controls.Add(this.iconclose);
            this.TitleBar.Controls.Add(this.TitleText);
            this.TitleBar.Controls.Add(this.iconcurrent);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(338, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(702, 98);
            this.TitleBar.TabIndex = 1;
            // 
            // iconclose
            // 
            this.iconclose.BackColor = System.Drawing.Color.Transparent;
            this.iconclose.FlatAppearance.BorderSize = 0;
            this.iconclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconclose.ForeColor = System.Drawing.Color.Transparent;
            this.iconclose.Image = global::BBMS.Properties.Resources.delete_48px;
            this.iconclose.Location = new System.Drawing.Point(1522, 0);
            this.iconclose.Margin = new System.Windows.Forms.Padding(2);
            this.iconclose.Name = "iconclose";
            this.iconclose.Size = new System.Drawing.Size(30, 32);
            this.iconclose.TabIndex = 3;
            this.iconclose.UseVisualStyleBackColor = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click_1);
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.BackColor = System.Drawing.Color.Transparent;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TitleText.Location = new System.Drawing.Point(78, 37);
            this.TitleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(117, 25);
            this.TitleText.TabIndex = 2;
            this.TitleText.Text = "Dashboard";
            // 
            // iconcurrent
            // 
            this.iconcurrent.BackColor = System.Drawing.Color.Transparent;
            this.iconcurrent.ForeColor = System.Drawing.Color.Red;
            this.iconcurrent.IconChar = FontAwesome.Sharp.IconChar.Hospital;
            this.iconcurrent.IconColor = System.Drawing.Color.Red;
            this.iconcurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcurrent.IconSize = 45;
            this.iconcurrent.Location = new System.Drawing.Point(17, 32);
            this.iconcurrent.Margin = new System.Windows.Forms.Padding(2);
            this.iconcurrent.Name = "iconcurrent";
            this.iconcurrent.Size = new System.Drawing.Size(45, 49);
            this.iconcurrent.TabIndex = 1;
            this.iconcurrent.TabStop = false;
            // 
            // panelMenue
            // 
            this.panelMenue.BackgroundImage = global::BBMS.Properties.Resources.back;
            this.panelMenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMenue.Controls.Add(this.iconCampaign);
            this.panelMenue.Controls.Add(this.iconUserRegistration);
            this.panelMenue.Controls.Add(this.iconPendingReq);
            this.panelMenue.Controls.Add(this.iconDonations);
            this.panelMenue.Controls.Add(this.iconLogout);
            this.panelMenue.Controls.Add(this.iconDonors);
            this.panelMenue.Controls.Add(this.iconDonorRegistration);
            this.panelMenue.Controls.Add(this.iconBloodStock);
            this.panelMenue.Controls.Add(this.panel2);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 0);
            this.panelMenue.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(338, 640);
            this.panelMenue.TabIndex = 0;
            // 
            // iconCampaign
            // 
            this.iconCampaign.BackColor = System.Drawing.Color.Transparent;
            this.iconCampaign.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconCampaign.FlatAppearance.BorderSize = 0;
            this.iconCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCampaign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconCampaign.IconChar = FontAwesome.Sharp.IconChar.HospitalAlt;
            this.iconCampaign.IconColor = System.Drawing.Color.White;
            this.iconCampaign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCampaign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCampaign.Location = new System.Drawing.Point(0, 647);
            this.iconCampaign.Margin = new System.Windows.Forms.Padding(2);
            this.iconCampaign.Name = "iconCampaign";
            this.iconCampaign.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconCampaign.Size = new System.Drawing.Size(338, 73);
            this.iconCampaign.TabIndex = 8;
            this.iconCampaign.Text = "Donations Campaigns";
            this.iconCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCampaign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCampaign.UseVisualStyleBackColor = false;
            this.iconCampaign.Click += new System.EventHandler(this.iconCampaign_Click);
            // 
            // iconUserRegistration
            // 
            this.iconUserRegistration.BackColor = System.Drawing.Color.Transparent;
            this.iconUserRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconUserRegistration.FlatAppearance.BorderSize = 0;
            this.iconUserRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUserRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconUserRegistration.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconUserRegistration.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconUserRegistration.IconColor = System.Drawing.Color.White;
            this.iconUserRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUserRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconUserRegistration.Location = new System.Drawing.Point(0, 574);
            this.iconUserRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.iconUserRegistration.Name = "iconUserRegistration";
            this.iconUserRegistration.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconUserRegistration.Size = new System.Drawing.Size(338, 73);
            this.iconUserRegistration.TabIndex = 7;
            this.iconUserRegistration.Text = "User Registration";
            this.iconUserRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconUserRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconUserRegistration.UseVisualStyleBackColor = false;
            this.iconUserRegistration.Click += new System.EventHandler(this.iconUserRegistration_Click);
            // 
            // iconPendingReq
            // 
            this.iconPendingReq.BackColor = System.Drawing.Color.Transparent;
            this.iconPendingReq.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPendingReq.FlatAppearance.BorderSize = 0;
            this.iconPendingReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPendingReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPendingReq.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconPendingReq.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconPendingReq.IconColor = System.Drawing.Color.White;
            this.iconPendingReq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPendingReq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPendingReq.Location = new System.Drawing.Point(0, 501);
            this.iconPendingReq.Margin = new System.Windows.Forms.Padding(2);
            this.iconPendingReq.Name = "iconPendingReq";
            this.iconPendingReq.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconPendingReq.Size = new System.Drawing.Size(338, 73);
            this.iconPendingReq.TabIndex = 6;
            this.iconPendingReq.Text = "Pending Requests";
            this.iconPendingReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPendingReq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPendingReq.UseVisualStyleBackColor = false;
            this.iconPendingReq.Click += new System.EventHandler(this.iconPendingReq_Click);
            // 
            // iconDonations
            // 
            this.iconDonations.BackColor = System.Drawing.Color.Transparent;
            this.iconDonations.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDonations.FlatAppearance.BorderSize = 0;
            this.iconDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDonations.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconDonations.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.iconDonations.IconColor = System.Drawing.Color.White;
            this.iconDonations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDonations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDonations.Location = new System.Drawing.Point(0, 428);
            this.iconDonations.Margin = new System.Windows.Forms.Padding(2);
            this.iconDonations.Name = "iconDonations";
            this.iconDonations.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconDonations.Size = new System.Drawing.Size(338, 73);
            this.iconDonations.TabIndex = 5;
            this.iconDonations.Text = "Donations";
            this.iconDonations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDonations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDonations.UseVisualStyleBackColor = false;
            this.iconDonations.Click += new System.EventHandler(this.iconDonations_Click);
            // 
            // iconLogout
            // 
            this.iconLogout.BackColor = System.Drawing.Color.Transparent;
            this.iconLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconLogout.FlatAppearance.BorderSize = 0;
            this.iconLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconLogout.IconColor = System.Drawing.Color.White;
            this.iconLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogout.Location = new System.Drawing.Point(0, 567);
            this.iconLogout.Margin = new System.Windows.Forms.Padding(2);
            this.iconLogout.Name = "iconLogout";
            this.iconLogout.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconLogout.Size = new System.Drawing.Size(338, 73);
            this.iconLogout.TabIndex = 4;
            this.iconLogout.Text = "Log Out";
            this.iconLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLogout.UseVisualStyleBackColor = false;
            // 
            // iconDonors
            // 
            this.iconDonors.BackColor = System.Drawing.Color.Transparent;
            this.iconDonors.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDonors.FlatAppearance.BorderSize = 0;
            this.iconDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDonors.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconDonors.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.iconDonors.IconColor = System.Drawing.Color.White;
            this.iconDonors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDonors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDonors.Location = new System.Drawing.Point(0, 355);
            this.iconDonors.Margin = new System.Windows.Forms.Padding(2);
            this.iconDonors.Name = "iconDonors";
            this.iconDonors.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconDonors.Size = new System.Drawing.Size(338, 73);
            this.iconDonors.TabIndex = 3;
            this.iconDonors.Text = "Donors";
            this.iconDonors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDonors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDonors.UseVisualStyleBackColor = false;
            this.iconDonors.Click += new System.EventHandler(this.iconDonors_Click);
            // 
            // iconDonorRegistration
            // 
            this.iconDonorRegistration.BackColor = System.Drawing.Color.Transparent;
            this.iconDonorRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDonorRegistration.FlatAppearance.BorderSize = 0;
            this.iconDonorRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDonorRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDonorRegistration.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconDonorRegistration.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconDonorRegistration.IconColor = System.Drawing.Color.White;
            this.iconDonorRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDonorRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDonorRegistration.Location = new System.Drawing.Point(0, 282);
            this.iconDonorRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.iconDonorRegistration.Name = "iconDonorRegistration";
            this.iconDonorRegistration.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconDonorRegistration.Size = new System.Drawing.Size(338, 73);
            this.iconDonorRegistration.TabIndex = 2;
            this.iconDonorRegistration.Text = "Donor Registration";
            this.iconDonorRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDonorRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDonorRegistration.UseVisualStyleBackColor = false;
            this.iconDonorRegistration.Click += new System.EventHandler(this.iconDonorRegistration_Click);
            // 
            // iconBloodStock
            // 
            this.iconBloodStock.BackColor = System.Drawing.Color.Transparent;
            this.iconBloodStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconBloodStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBloodStock.FlatAppearance.BorderSize = 0;
            this.iconBloodStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBloodStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBloodStock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconBloodStock.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.iconBloodStock.IconColor = System.Drawing.Color.White;
            this.iconBloodStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBloodStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBloodStock.Location = new System.Drawing.Point(0, 209);
            this.iconBloodStock.Margin = new System.Windows.Forms.Padding(2, 16, 2, 2);
            this.iconBloodStock.Name = "iconBloodStock";
            this.iconBloodStock.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconBloodStock.Size = new System.Drawing.Size(338, 73);
            this.iconBloodStock.TabIndex = 1;
            this.iconBloodStock.Text = "Blood Stock";
            this.iconBloodStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBloodStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBloodStock.UseVisualStyleBackColor = false;
            this.iconBloodStock.Click += new System.EventHandler(this.iconBloodStock_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.IconRestLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 209);
            this.panel2.TabIndex = 0;
            // 
            // IconRestLogo
            // 
            this.IconRestLogo.BackColor = System.Drawing.Color.Transparent;
            this.IconRestLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconRestLogo.BackgroundImage")));
            this.IconRestLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconRestLogo.ForeColor = System.Drawing.Color.Transparent;
            this.IconRestLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconRestLogo.IconColor = System.Drawing.Color.Transparent;
            this.IconRestLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconRestLogo.IconSize = 180;
            this.IconRestLogo.InitialImage = null;
            this.IconRestLogo.Location = new System.Drawing.Point(58, 10);
            this.IconRestLogo.Margin = new System.Windows.Forms.Padding(2);
            this.IconRestLogo.Name = "IconRestLogo";
            this.IconRestLogo.Size = new System.Drawing.Size(200, 180);
            this.IconRestLogo.TabIndex = 0;
            this.IconRestLogo.TabStop = false;
            this.IconRestLogo.Click += new System.EventHandler(this.IconRestLogo_Click);
            // 
            // MainDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.desktoppanel);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.panelMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrent)).EndInit();
            this.panelMenue.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconRestLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TitleBar;
        private FontAwesome.Sharp.IconButton iconCampaign;
        private FontAwesome.Sharp.IconButton iconUserRegistration;
        private FontAwesome.Sharp.IconButton iconPendingReq;
        private FontAwesome.Sharp.IconButton iconDonations;
        private FontAwesome.Sharp.IconButton iconLogout;
        private FontAwesome.Sharp.IconButton iconDonors;
        private FontAwesome.Sharp.IconButton iconDonorRegistration;
        private FontAwesome.Sharp.IconButton iconBloodStock;
        private FontAwesome.Sharp.IconPictureBox IconRestLogo;
        private FontAwesome.Sharp.IconPictureBox iconcurrent;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Panel desktoppanel;
        private System.Windows.Forms.Button iconclose;
    }
}