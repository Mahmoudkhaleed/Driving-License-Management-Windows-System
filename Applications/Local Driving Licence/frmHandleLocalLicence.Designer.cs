namespace DVLD_Project
{
    partial class frmHandleLocalLicence
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandleLocalLicence));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_LocalAppLicenceID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tapPage_PersonalInfo = new System.Windows.Forms.TabPage();
            this.cuc_SearchForPerson1 = new DVLD_Project.User_Controls.cuc_SearchForPerson();
            this.btn_Next = new System.Windows.Forms.Button();
            this.tabPage_LoginInfo = new System.Windows.Forms.TabPage();
            this.cob_LicenceClasses = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_CreatedBy = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_AppFees = new System.Windows.Forms.Label();
            this.lb_AppDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lb_Head = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.cuc_SearchForUser1 = new DVLD_Project.User_Controls.cuc_SearchForPerson();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tapPage_PersonalInfo.SuspendLayout();
            this.tabPage_LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lb_LocalAppLicenceID
            // 
            this.lb_LocalAppLicenceID.AutoSize = true;
            this.lb_LocalAppLicenceID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LocalAppLicenceID.Location = new System.Drawing.Point(190, 50);
            this.lb_LocalAppLicenceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_LocalAppLicenceID.Name = "lb_LocalAppLicenceID";
            this.lb_LocalAppLicenceID.Size = new System.Drawing.Size(45, 15);
            this.lb_LocalAppLicenceID.TabIndex = 11;
            this.lb_LocalAppLicenceID.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Licence Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Application Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "D.L. Application ID:";
            // 
            // tapPage_PersonalInfo
            // 
            this.tapPage_PersonalInfo.BackColor = System.Drawing.Color.White;
            this.tapPage_PersonalInfo.Controls.Add(this.cuc_SearchForPerson1);
            this.tapPage_PersonalInfo.Controls.Add(this.btn_Next);
            this.tapPage_PersonalInfo.Location = new System.Drawing.Point(4, 26);
            this.tapPage_PersonalInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tapPage_PersonalInfo.Name = "tapPage_PersonalInfo";
            this.tapPage_PersonalInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tapPage_PersonalInfo.Size = new System.Drawing.Size(786, 407);
            this.tapPage_PersonalInfo.TabIndex = 0;
            this.tapPage_PersonalInfo.Text = "Personal Info";
            // 
            // cuc_SearchForPerson1
            // 
            this.cuc_SearchForPerson1.BackColor = System.Drawing.Color.White;
            this.cuc_SearchForPerson1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuc_SearchForPerson1.Location = new System.Drawing.Point(1, 0);
            this.cuc_SearchForPerson1.Margin = new System.Windows.Forms.Padding(4);
            this.cuc_SearchForPerson1.Name = "cuc_SearchForPerson1";
            this.cuc_SearchForPerson1.Size = new System.Drawing.Size(771, 359);
            this.cuc_SearchForPerson1.TabIndex = 17;
            this.cuc_SearchForPerson1.OnPersonSelect += new System.Action<int>(this.cuc_SearchForPerson1_OnPersonSelect);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.White;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Image = global::DVLD_Project.Properties.Resources.arrow_right;
            this.btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Next.Location = new System.Drawing.Point(688, 365);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(81, 35);
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Text = "        Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tabPage_LoginInfo
            // 
            this.tabPage_LoginInfo.Controls.Add(this.cob_LicenceClasses);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox5);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox1);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox4);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox3);
            this.tabPage_LoginInfo.Controls.Add(this.lb_CreatedBy);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox2);
            this.tabPage_LoginInfo.Controls.Add(this.lb_AppFees);
            this.tabPage_LoginInfo.Controls.Add(this.lb_AppDate);
            this.tabPage_LoginInfo.Controls.Add(this.lb_LocalAppLicenceID);
            this.tabPage_LoginInfo.Controls.Add(this.label7);
            this.tabPage_LoginInfo.Controls.Add(this.label5);
            this.tabPage_LoginInfo.Controls.Add(this.label3);
            this.tabPage_LoginInfo.Controls.Add(this.label4);
            this.tabPage_LoginInfo.Controls.Add(this.label1);
            this.tabPage_LoginInfo.Location = new System.Drawing.Point(4, 26);
            this.tabPage_LoginInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_LoginInfo.Name = "tabPage_LoginInfo";
            this.tabPage_LoginInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_LoginInfo.Size = new System.Drawing.Size(786, 407);
            this.tabPage_LoginInfo.TabIndex = 1;
            this.tabPage_LoginInfo.Text = "Application Info";
            this.tabPage_LoginInfo.UseVisualStyleBackColor = true;
            // 
            // cob_LicenceClasses
            // 
            this.cob_LicenceClasses.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_LicenceClasses.FormattingEnabled = true;
            this.cob_LicenceClasses.Location = new System.Drawing.Point(203, 142);
            this.cob_LicenceClasses.Margin = new System.Windows.Forms.Padding(2);
            this.cob_LicenceClasses.Name = "cob_LicenceClasses";
            this.cob_LicenceClasses.Size = new System.Drawing.Size(299, 24);
            this.cob_LicenceClasses.TabIndex = 43;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Project.Properties.Resources.username;
            this.pictureBox5.Location = new System.Drawing.Point(162, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.currency_dollar_sign;
            this.pictureBox1.Location = new System.Drawing.Point(162, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.calendar_week__1_;
            this.pictureBox4.Location = new System.Drawing.Point(162, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox3.Location = new System.Drawing.Point(162, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // lb_CreatedBy
            // 
            this.lb_CreatedBy.AutoSize = true;
            this.lb_CreatedBy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreatedBy.Location = new System.Drawing.Point(190, 243);
            this.lb_CreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CreatedBy.Name = "lb_CreatedBy";
            this.lb_CreatedBy.Size = new System.Drawing.Size(28, 15);
            this.lb_CreatedBy.TabIndex = 11;
            this.lb_CreatedBy.Text = "???";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.id__1_;
            this.pictureBox2.Location = new System.Drawing.Point(162, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // lb_AppFees
            // 
            this.lb_AppFees.AutoSize = true;
            this.lb_AppFees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppFees.Location = new System.Drawing.Point(190, 196);
            this.lb_AppFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AppFees.Name = "lb_AppFees";
            this.lb_AppFees.Size = new System.Drawing.Size(28, 15);
            this.lb_AppFees.TabIndex = 11;
            this.lb_AppFees.Text = "???";
            // 
            // lb_AppDate
            // 
            this.lb_AppDate.AutoSize = true;
            this.lb_AppDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppDate.Location = new System.Drawing.Point(190, 98);
            this.lb_AppDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AppDate.Name = "lb_AppDate";
            this.lb_AppDate.Size = new System.Drawing.Size(28, 15);
            this.lb_AppDate.TabIndex = 11;
            this.lb_AppDate.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Application Fees:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapPage_PersonalInfo);
            this.tabControl1.Controls.Add(this.tabPage_LoginInfo);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 51);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 437);
            this.tabControl1.TabIndex = 6;
            // 
            // lb_Head
            // 
            this.lb_Head.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Head.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Head.Location = new System.Drawing.Point(41, 6);
            this.lb_Head.Name = "lb_Head";
            this.lb_Head.Size = new System.Drawing.Size(728, 38);
            this.lb_Head.TabIndex = 9;
            this.lb_Head.Text = "New Local Driving Licence";
            this.lb_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::DVLD_Project.Properties.Resources.diskette;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(697, 494);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 35);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "        Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD_Project.Properties.Resources.close__2_;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(602, 494);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "        Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // cuc_SearchForUser1
            // 
            this.cuc_SearchForUser1.BackColor = System.Drawing.Color.White;
            this.cuc_SearchForUser1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuc_SearchForUser1.Location = new System.Drawing.Point(6, 6);
            this.cuc_SearchForUser1.Margin = new System.Windows.Forms.Padding(4);
            this.cuc_SearchForUser1.Name = "cuc_SearchForUser1";
            this.cuc_SearchForUser1.Size = new System.Drawing.Size(771, 362);
            this.cuc_SearchForUser1.TabIndex = 17;
            // 
            // frmHandleLocalLicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 541);
            this.Controls.Add(this.lb_Head);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHandleLocalLicence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handle Local Licence";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tapPage_PersonalInfo.ResumeLayout(false);
            this.tabPage_LoginInfo.ResumeLayout(false);
            this.tabPage_LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapPage_PersonalInfo;
        private User_Controls.cuc_SearchForPerson cuc_SearchForUser1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TabPage tabPage_LoginInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_LocalAppLicenceID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Head;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_CreatedBy;
        private System.Windows.Forms.Label lb_AppFees;
        private System.Windows.Forms.Label lb_AppDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cob_LicenceClasses;
        private User_Controls.cuc_SearchForPerson cuc_SearchForPerson1;
    }
}