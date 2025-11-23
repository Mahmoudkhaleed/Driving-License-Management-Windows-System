namespace DVLD_Project
{
    partial class frmHandleUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandleUser));
            this.ctrlBox_HandleUser = new System.Windows.Forms.TabControl();
            this.tapPage_PersonalInfo = new System.Windows.Forms.TabPage();
            this.cuc_SearchForUser1 = new DVLD_Project.User_Controls.cuc_SearchForPerson();
            this.btn_Next = new System.Windows.Forms.Button();
            this.tabPage_LoginInfo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.cb_IsActive = new System.Windows.Forms.CheckBox();
            this.lb_UserID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.ctrlBox_HandleUser.SuspendLayout();
            this.tapPage_PersonalInfo.SuspendLayout();
            this.tabPage_LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlBox_HandleUser
            // 
            this.ctrlBox_HandleUser.Controls.Add(this.tapPage_PersonalInfo);
            this.ctrlBox_HandleUser.Controls.Add(this.tabPage_LoginInfo);
            this.ctrlBox_HandleUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlBox_HandleUser.Location = new System.Drawing.Point(10, 25);
            this.ctrlBox_HandleUser.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlBox_HandleUser.Name = "ctrlBox_HandleUser";
            this.ctrlBox_HandleUser.SelectedIndex = 0;
            this.ctrlBox_HandleUser.Size = new System.Drawing.Size(794, 460);
            this.ctrlBox_HandleUser.TabIndex = 0;
            // 
            // tapPage_PersonalInfo
            // 
            this.tapPage_PersonalInfo.BackColor = System.Drawing.Color.White;
            this.tapPage_PersonalInfo.Controls.Add(this.cuc_SearchForUser1);
            this.tapPage_PersonalInfo.Controls.Add(this.btn_Next);
            this.tapPage_PersonalInfo.Location = new System.Drawing.Point(4, 26);
            this.tapPage_PersonalInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tapPage_PersonalInfo.Name = "tapPage_PersonalInfo";
            this.tapPage_PersonalInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tapPage_PersonalInfo.Size = new System.Drawing.Size(786, 430);
            this.tapPage_PersonalInfo.TabIndex = 0;
            this.tapPage_PersonalInfo.Text = "Personal Info";
            // 
            // cuc_SearchForUser1
            // 
            this.cuc_SearchForUser1.BackColor = System.Drawing.Color.White;
            this.cuc_SearchForUser1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuc_SearchForUser1.Location = new System.Drawing.Point(6, 6);
            this.cuc_SearchForUser1.Margin = new System.Windows.Forms.Padding(4);
            this.cuc_SearchForUser1.Name = "cuc_SearchForUser1";
            this.cuc_SearchForUser1.Size = new System.Drawing.Size(771, 373);
            this.cuc_SearchForUser1.TabIndex = 17;
            this.cuc_SearchForUser1.OnPersonSelect += new System.Action<int>(this.cuc_SearchForUser1_OnPersonSelect);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.White;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Image = global::DVLD_Project.Properties.Resources.arrow_right;
            this.btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Next.Location = new System.Drawing.Point(694, 385);
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
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox1);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox3);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox2);
            this.tabPage_LoginInfo.Controls.Add(this.pictureBox10);
            this.tabPage_LoginInfo.Controls.Add(this.cb_IsActive);
            this.tabPage_LoginInfo.Controls.Add(this.lb_UserID);
            this.tabPage_LoginInfo.Controls.Add(this.label6);
            this.tabPage_LoginInfo.Controls.Add(this.label5);
            this.tabPage_LoginInfo.Controls.Add(this.tb_ConfirmPassword);
            this.tabPage_LoginInfo.Controls.Add(this.label4);
            this.tabPage_LoginInfo.Controls.Add(this.tb_password);
            this.tabPage_LoginInfo.Controls.Add(this.label1);
            this.tabPage_LoginInfo.Controls.Add(this.tb_Username);
            this.tabPage_LoginInfo.Location = new System.Drawing.Point(4, 26);
            this.tabPage_LoginInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_LoginInfo.Name = "tabPage_LoginInfo";
            this.tabPage_LoginInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_LoginInfo.Size = new System.Drawing.Size(786, 430);
            this.tabPage_LoginInfo.TabIndex = 1;
            this.tabPage_LoginInfo.Text = "Login Info";
            this.tabPage_LoginInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox1.Location = new System.Drawing.Point(30, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox3.Location = new System.Drawing.Point(90, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.view_mode_average_icons;
            this.pictureBox2.Location = new System.Drawing.Point(30, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD_Project.Properties.Resources.user__1_;
            this.pictureBox10.Location = new System.Drawing.Point(30, 95);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(23, 22);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 43;
            this.pictureBox10.TabStop = false;
            // 
            // cb_IsActive
            // 
            this.cb_IsActive.AutoSize = true;
            this.cb_IsActive.Checked = true;
            this.cb_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_IsActive.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_IsActive.Location = new System.Drawing.Point(29, 236);
            this.cb_IsActive.Name = "cb_IsActive";
            this.cb_IsActive.Size = new System.Drawing.Size(79, 20);
            this.cb_IsActive.TabIndex = 3;
            this.cb_IsActive.Text = "Is Active";
            this.cb_IsActive.UseVisualStyleBackColor = true;
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserID.Location = new System.Drawing.Point(118, 51);
            this.lb_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(28, 15);
            this.lb_UserID.TabIndex = 11;
            this.lb_UserID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // tb_ConfirmPassword
            // 
            this.tb_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ConfirmPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConfirmPassword.Location = new System.Drawing.Point(54, 194);
            this.tb_ConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            this.tb_ConfirmPassword.PasswordChar = '*';
            this.tb_ConfirmPassword.Size = new System.Drawing.Size(169, 22);
            this.tb_ConfirmPassword.TabIndex = 2;
            this.tb_ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ConfirmPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username:";
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(54, 144);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(169, 22);
            this.tb_password.TabIndex = 1;
            this.tb_password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID:";
            // 
            // tb_Username
            // 
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(54, 95);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(169, 22);
            this.tb_Username.TabIndex = 0;
            this.tb_Username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Username_Validating);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD_Project.Properties.Resources.close__2_;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(607, 489);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "        Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::DVLD_Project.Properties.Resources.diskette;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(702, 489);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 35);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "        Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmHandleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 535);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.ctrlBox_HandleUser);
            this.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmHandleUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.ctrlBox_HandleUser.ResumeLayout(false);
            this.tapPage_PersonalInfo.ResumeLayout(false);
            this.tabPage_LoginInfo.ResumeLayout(false);
            this.tabPage_LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ctrlBox_HandleUser;
        private System.Windows.Forms.TabPage tapPage_PersonalInfo;
        private System.Windows.Forms.TabPage tabPage_LoginInfo;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lb_UserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.CheckBox cb_IsActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_Save;
        private User_Controls.cuc_SearchForPerson cuc_SearchForUser1;
    }
}