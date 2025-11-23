namespace DVLD_Project.User
{
    partial class frmUserDetails
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
            this.lb_Head = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_EditUser = new System.Windows.Forms.LinkLabel();
            this.cuc_userCard1 = new DVLD_Project.User_Controls.cuc_userCard();
            this.SuspendLayout();
            // 
            // lb_Head
            // 
            this.lb_Head.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Head.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Head.Location = new System.Drawing.Point(23, 15);
            this.lb_Head.Name = "lb_Head";
            this.lb_Head.Size = new System.Drawing.Size(728, 38);
            this.lb_Head.TabIndex = 8;
            this.lb_Head.Text = "User Details";
            this.lb_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::DVLD_Project.Properties.Resources.close__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(669, 446);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_EditUser
            // 
            this.lb_EditUser.AutoSize = true;
            this.lb_EditUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EditUser.Location = new System.Drawing.Point(670, 53);
            this.lb_EditUser.Name = "lb_EditUser";
            this.lb_EditUser.Size = new System.Drawing.Size(95, 17);
            this.lb_EditUser.TabIndex = 49;
            this.lb_EditUser.TabStop = true;
            this.lb_EditUser.Text = "Edit User Info";
            this.lb_EditUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_EditUser_LinkClicked);
            // 
            // cuc_userCard1
            // 
            this.cuc_userCard1.BackColor = System.Drawing.Color.White;
            this.cuc_userCard1.Location = new System.Drawing.Point(5, 63);
            this.cuc_userCard1.Name = "cuc_userCard1";
            this.cuc_userCard1.Size = new System.Drawing.Size(760, 359);
            this.cuc_userCard1.TabIndex = 50;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 490);
            this.Controls.Add(this.lb_EditUser);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_Head);
            this.Controls.Add(this.cuc_userCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_Head;
        private System.Windows.Forms.LinkLabel lb_EditUser;
        private User_Controls.cuc_userCard cuc_userCard1;
    }
}