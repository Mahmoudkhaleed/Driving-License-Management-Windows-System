namespace DVLD_Project.Local_Driving_Licence
{
    partial class frmIssueDrivingLicenceFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicenceFirstTime));
            this.cuc_ApplicationInfo1 = new DVLD_Project.User_Controls.cuc_ApplicationInfo();
            this.tb_Notes = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Issue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cuc_ApplicationInfo1
            // 
            this.cuc_ApplicationInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuc_ApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.cuc_ApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.cuc_ApplicationInfo1.Name = "cuc_ApplicationInfo1";
            this.cuc_ApplicationInfo1.Size = new System.Drawing.Size(698, 289);
            this.cuc_ApplicationInfo1.TabIndex = 0;
            // 
            // tb_Notes
            // 
            this.tb_Notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Notes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Notes.Location = new System.Drawing.Point(78, 304);
            this.tb_Notes.Name = "tb_Notes";
            this.tb_Notes.Size = new System.Drawing.Size(632, 90);
            this.tb_Notes.TabIndex = 87;
            this.tb_Notes.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 86;
            this.label10.Text = "Notes:";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD_Project.Properties.Resources.close__2_;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(508, 400);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(98, 38);
            this.btn_Close.TabIndex = 89;
            this.btn_Close.Text = "        Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Issue
            // 
            this.btn_Issue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Issue.BackColor = System.Drawing.Color.White;
            this.btn_Issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Issue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Issue.Image = global::DVLD_Project.Properties.Resources.edit__1_;
            this.btn_Issue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Issue.Location = new System.Drawing.Point(612, 400);
            this.btn_Issue.Name = "btn_Issue";
            this.btn_Issue.Size = new System.Drawing.Size(98, 38);
            this.btn_Issue.TabIndex = 88;
            this.btn_Issue.Text = "        Issue";
            this.btn_Issue.UseVisualStyleBackColor = false;
            this.btn_Issue.Click += new System.EventHandler(this.btn_Issue_Click);
            // 
            // IssueDrivingLicenceFirstTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Issue);
            this.Controls.Add(this.tb_Notes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cuc_ApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IssueDrivingLicenceFirstTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving Licence (First Time)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.cuc_ApplicationInfo cuc_ApplicationInfo1;
        private System.Windows.Forms.RichTextBox tb_Notes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Issue;
    }
}