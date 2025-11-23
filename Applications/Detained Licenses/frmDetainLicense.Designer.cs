namespace DVLD_Project.Detained_Licenses
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_SearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuc_LicenceDetails1 = new DVLD_Project.User_Controls.cuc_LicenceDetails();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_FineFees = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_CreatedBy = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lb_DetainDate = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lb_LicenceID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_RAppID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_ShowLicenceHistory = new System.Windows.Forms.LinkLabel();
            this.lb_ShowLicenceInfo = new System.Windows.Forms.LinkLabel();
            this.gb_Filter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 83;
            this.label1.Text = "Detain License";
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.btn_Search);
            this.gb_Filter.Controls.Add(this.tb_SearchBox);
            this.gb_Filter.Controls.Add(this.label2);
            this.gb_Filter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Filter.Location = new System.Drawing.Point(187, 35);
            this.gb_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Filter.Size = new System.Drawing.Size(455, 61);
            this.gb_Filter.TabIndex = 85;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Filter";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Image = global::DVLD_Project.Properties.Resources.zoom;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(343, 16);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(105, 35);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "        Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.Location = new System.Drawing.Point(101, 22);
            this.tb_SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SearchBox.Name = "tb_SearchBox";
            this.tb_SearchBox.Size = new System.Drawing.Size(228, 22);
            this.tb_SearchBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Licence ID:";
            // 
            // cuc_LicenceDetails1
            // 
            this.cuc_LicenceDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuc_LicenceDetails1.Location = new System.Drawing.Point(10, 101);
            this.cuc_LicenceDetails1.Name = "cuc_LicenceDetails1";
            this.cuc_LicenceDetails1.Size = new System.Drawing.Size(896, 264);
            this.cuc_LicenceDetails1.TabIndex = 84;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tb_FineFees);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.labl);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lb_CreatedBy);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.lb_DetainDate);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.lb_LicenceID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lb_RAppID);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(889, 124);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(400, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 67;
            this.label19.Text = "Created By:";
            // 
            // tb_FineFees
            // 
            this.tb_FineFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_FineFees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FineFees.Location = new System.Drawing.Point(182, 82);
            this.tb_FineFees.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FineFees.Name = "tb_FineFees";
            this.tb_FineFees.Size = new System.Drawing.Size(86, 22);
            this.tb_FineFees.TabIndex = 9;
            this.tb_FineFees.Text = "0";
            this.tb_FineFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 16);
            this.label17.TabIndex = 64;
            this.label17.Text = "Detain Date:";
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Location = new System.Drawing.Point(11, 85);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(73, 16);
            this.labl.TabIndex = 62;
            this.labl.Text = "Fine Fees:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_Project.Properties.Resources.username;
            this.pictureBox9.Location = new System.Drawing.Point(562, 54);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(23, 22);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 76;
            this.pictureBox9.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(400, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Licence ID:";
            // 
            // lb_CreatedBy
            // 
            this.lb_CreatedBy.AutoSize = true;
            this.lb_CreatedBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreatedBy.Location = new System.Drawing.Point(591, 57);
            this.lb_CreatedBy.Name = "lb_CreatedBy";
            this.lb_CreatedBy.Size = new System.Drawing.Size(29, 16);
            this.lb_CreatedBy.TabIndex = 57;
            this.lb_CreatedBy.Text = "N/N";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Project.Properties.Resources.calendar_week__1_;
            this.pictureBox7.Location = new System.Drawing.Point(150, 54);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 72;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_Project.Properties.Resources.currency_dollar_sign;
            this.pictureBox8.Location = new System.Drawing.Point(150, 82);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(23, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 77;
            this.pictureBox8.TabStop = false;
            // 
            // lb_DetainDate
            // 
            this.lb_DetainDate.AutoSize = true;
            this.lb_DetainDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DetainDate.Location = new System.Drawing.Point(179, 57);
            this.lb_DetainDate.Name = "lb_DetainDate";
            this.lb_DetainDate.Size = new System.Drawing.Size(29, 16);
            this.lb_DetainDate.TabIndex = 56;
            this.lb_DetainDate.Text = "N/N";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox6.Location = new System.Drawing.Point(562, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 70;
            this.pictureBox6.TabStop = false;
            // 
            // lb_LicenceID
            // 
            this.lb_LicenceID.AutoSize = true;
            this.lb_LicenceID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LicenceID.Location = new System.Drawing.Point(591, 29);
            this.lb_LicenceID.Name = "lb_LicenceID";
            this.lb_LicenceID.Size = new System.Drawing.Size(29, 16);
            this.lb_LicenceID.TabIndex = 68;
            this.lb_LicenceID.Text = "N/N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Detain ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox2.Location = new System.Drawing.Point(150, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // lb_RAppID
            // 
            this.lb_RAppID.AutoSize = true;
            this.lb_RAppID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RAppID.Location = new System.Drawing.Point(179, 25);
            this.lb_RAppID.Name = "lb_RAppID";
            this.lb_RAppID.Size = new System.Drawing.Size(29, 16);
            this.lb_RAppID.TabIndex = 54;
            this.lb_RAppID.Text = "N/N";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::DVLD_Project.Properties.Resources.diskette;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(800, 493);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 35);
            this.btn_Save.TabIndex = 87;
            this.btn_Save.Text = "        Detain";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD_Project.Properties.Resources.close__2_;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(705, 493);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_Close.TabIndex = 88;
            this.btn_Close.Text = "        Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lb_ShowLicenceHistory
            // 
            this.lb_ShowLicenceHistory.AutoSize = true;
            this.lb_ShowLicenceHistory.Enabled = false;
            this.lb_ShowLicenceHistory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowLicenceHistory.Location = new System.Drawing.Point(12, 502);
            this.lb_ShowLicenceHistory.Name = "lb_ShowLicenceHistory";
            this.lb_ShowLicenceHistory.Size = new System.Drawing.Size(133, 16);
            this.lb_ShowLicenceHistory.TabIndex = 89;
            this.lb_ShowLicenceHistory.TabStop = true;
            this.lb_ShowLicenceHistory.Text = "Show Licence History";
            this.lb_ShowLicenceHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_ShowLicenceHistory_LinkClicked);
            // 
            // lb_ShowLicenceInfo
            // 
            this.lb_ShowLicenceInfo.AutoSize = true;
            this.lb_ShowLicenceInfo.Enabled = false;
            this.lb_ShowLicenceInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowLicenceInfo.Location = new System.Drawing.Point(169, 502);
            this.lb_ShowLicenceInfo.Name = "lb_ShowLicenceInfo";
            this.lb_ShowLicenceInfo.Size = new System.Drawing.Size(112, 16);
            this.lb_ShowLicenceInfo.TabIndex = 90;
            this.lb_ShowLicenceInfo.TabStop = true;
            this.lb_ShowLicenceInfo.Text = "Show Licence Info";
            this.lb_ShowLicenceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_ShowLicenceInfo_LinkClicked);
            // 
            // DetainLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 539);
            this.Controls.Add(this.lb_ShowLicenceInfo);
            this.Controls.Add(this.lb_ShowLicenceHistory);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_Filter);
            this.Controls.Add(this.cuc_LicenceDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetainLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.gb_Filter.ResumeLayout(false);
            this.gb_Filter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_SearchBox;
        private System.Windows.Forms.Label label2;
        private User_Controls.cuc_LicenceDetails cuc_LicenceDetails1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_CreatedBy;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lb_DetainDate;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lb_LicenceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_RAppID;
        private System.Windows.Forms.TextBox tb_FineFees;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.LinkLabel lb_ShowLicenceHistory;
        private System.Windows.Forms.LinkLabel lb_ShowLicenceInfo;
    }
}