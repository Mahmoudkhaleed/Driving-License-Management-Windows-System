namespace DVLD_Project.Local_Driving_Licence
{
    partial class frmTestAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointments));
            this.lb_header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_TestsAppointments = new System.Windows.Forms.DataGridView();
            this.cmc_HandleVisionAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuc_ApplicationInfo1 = new DVLD_Project.User_Controls.cuc_ApplicationInfo();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_AddAppointment = new System.Windows.Forms.Button();
            this.pb_HeaderImage = new System.Windows.Forms.PictureBox();
            this.btn_NextTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestsAppointments)).BeginInit();
            this.cmc_HandleVisionAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HeaderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_header
            // 
            this.lb_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.Location = new System.Drawing.Point(247, 70);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(268, 24);
            this.lb_header.TabIndex = 49;
            this.lb_header.Text = "Vision Test Appointments";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Appointments";
            // 
            // dgv_TestsAppointments
            // 
            this.dgv_TestsAppointments.AllowUserToAddRows = false;
            this.dgv_TestsAppointments.AllowUserToDeleteRows = false;
            this.dgv_TestsAppointments.AllowUserToOrderColumns = true;
            this.dgv_TestsAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TestsAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_TestsAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_TestsAppointments.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_TestsAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TestsAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TestsAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TestsAppointments.ContextMenuStrip = this.cmc_HandleVisionAppointment;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TestsAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TestsAppointments.EnableHeadersVisualStyles = false;
            this.dgv_TestsAppointments.Location = new System.Drawing.Point(12, 424);
            this.dgv_TestsAppointments.Name = "dgv_TestsAppointments";
            this.dgv_TestsAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TestsAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TestsAppointments.Size = new System.Drawing.Size(738, 95);
            this.dgv_TestsAppointments.TabIndex = 59;
            // 
            // cmc_HandleVisionAppointment
            // 
            this.cmc_HandleVisionAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmc_HandleVisionAppointment.Name = "cms_HandlePerson";
            this.cmc_HandleVisionAppointment.Size = new System.Drawing.Size(146, 80);
            this.cmc_HandleVisionAppointment.Opening += new System.ComponentModel.CancelEventHandler(this.cmc_HandleVisionAppointment_Opening);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.document__1_;
            this.EditToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(145, 38);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.takeTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.list__1_;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(145, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // cuc_ApplicationInfo1
            // 
            this.cuc_ApplicationInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuc_ApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.cuc_ApplicationInfo1.Location = new System.Drawing.Point(12, 95);
            this.cuc_ApplicationInfo1.Name = "cuc_ApplicationInfo1";
            this.cuc_ApplicationInfo1.Size = new System.Drawing.Size(740, 289);
            this.cuc_ApplicationInfo1.TabIndex = 50;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::DVLD_Project.Properties.Resources.close__1_;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(658, 525);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 32);
            this.btn_close.TabIndex = 61;
            this.btn_close.Text = "        Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_AddAppointment
            // 
            this.btn_AddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddAppointment.BackColor = System.Drawing.Color.White;
            this.btn_AddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAppointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAppointment.Image = global::DVLD_Project.Properties.Resources.addDoc;
            this.btn_AddAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddAppointment.Location = new System.Drawing.Point(581, 388);
            this.btn_AddAppointment.Name = "btn_AddAppointment";
            this.btn_AddAppointment.Size = new System.Drawing.Size(169, 32);
            this.btn_AddAppointment.TabIndex = 60;
            this.btn_AddAppointment.Text = "        Add Appointment";
            this.btn_AddAppointment.UseVisualStyleBackColor = false;
            this.btn_AddAppointment.Click += new System.EventHandler(this.btn_AddAppointment_Click);
            // 
            // pb_HeaderImage
            // 
            this.pb_HeaderImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_HeaderImage.Image = global::DVLD_Project.Properties.Resources.PracticalTest;
            this.pb_HeaderImage.Location = new System.Drawing.Point(314, 0);
            this.pb_HeaderImage.Name = "pb_HeaderImage";
            this.pb_HeaderImage.Size = new System.Drawing.Size(134, 66);
            this.pb_HeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_HeaderImage.TabIndex = 48;
            this.pb_HeaderImage.TabStop = false;
            // 
            // btn_NextTest
            // 
            this.btn_NextTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NextTest.BackColor = System.Drawing.Color.White;
            this.btn_NextTest.Enabled = false;
            this.btn_NextTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextTest.Image = global::DVLD_Project.Properties.Resources.arrow_right;
            this.btn_NextTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NextTest.Location = new System.Drawing.Point(628, 34);
            this.btn_NextTest.Name = "btn_NextTest";
            this.btn_NextTest.Size = new System.Drawing.Size(122, 32);
            this.btn_NextTest.TabIndex = 61;
            this.btn_NextTest.Text = "        Next Test";
            this.btn_NextTest.UseVisualStyleBackColor = false;
            this.btn_NextTest.Visible = false;
            this.btn_NextTest.Click += new System.EventHandler(this.btn_NextTest_Click);
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 563);
            this.Controls.Add(this.btn_NextTest);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_AddAppointment);
            this.Controls.Add(this.dgv_TestsAppointments);
            this.Controls.Add(this.cuc_ApplicationInfo1);
            this.Controls.Add(this.pb_HeaderImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SechduleVisionTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestsAppointments)).EndInit();
            this.cmc_HandleVisionAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_HeaderImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_HeaderImage;
        private System.Windows.Forms.Label lb_header;
        private User_Controls.cuc_ApplicationInfo cuc_ApplicationInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_TestsAppointments;
        private System.Windows.Forms.Button btn_AddAppointment;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ContextMenuStrip cmc_HandleVisionAppointment;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Button btn_NextTest;
    }
}