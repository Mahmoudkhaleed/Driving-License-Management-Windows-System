namespace DVLD_Project
{
    partial class frmPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonDetails));
            this.lb_Head = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.cuc_PersonCard1 = new DVLD_Project.cuc_PersonCard();
            this.SuspendLayout();
            // 
            // lb_Head
            // 
            this.lb_Head.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Head.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Head.Location = new System.Drawing.Point(29, 18);
            this.lb_Head.Name = "lb_Head";
            this.lb_Head.Size = new System.Drawing.Size(728, 38);
            this.lb_Head.TabIndex = 1;
            this.lb_Head.Text = "Person Details";
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
            this.btn_close.Location = new System.Drawing.Point(683, 347);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cuc_PersonCard1
            // 
            this.cuc_PersonCard1.BackColor = System.Drawing.Color.White;
            this.cuc_PersonCard1.Location = new System.Drawing.Point(4, 59);
            this.cuc_PersonCard1.Name = "cuc_PersonCard1";
            this.cuc_PersonCard1.Size = new System.Drawing.Size(776, 282);
            this.cuc_PersonCard1.TabIndex = 0;
            // 
            // PersonDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 391);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_Head);
            this.Controls.Add(this.cuc_PersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.ResumeLayout(false);

        }

        #endregion

        private cuc_PersonCard cuc_PersonCard1;
        private System.Windows.Forms.Label lb_Head;
        private System.Windows.Forms.Button btn_close;
    }
}