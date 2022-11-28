namespace StudentManagement
{
    partial class frmAttendanceDetail
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
            this.lbAttendID = new System.Windows.Forms.Label();
            this.lbCourseID = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.lbSlot = new System.Windows.Forms.Label();
            this.lbAttStatus = new System.Windows.Forms.Label();
            this.txtAttendID = new System.Windows.Forms.TextBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.cboCourseID = new System.Windows.Forms.ComboBox();
            this.cboAccountID = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAttendanceStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbAttendID
            // 
            this.lbAttendID.AutoSize = true;
            this.lbAttendID.Location = new System.Drawing.Point(47, 31);
            this.lbAttendID.Name = "lbAttendID";
            this.lbAttendID.Size = new System.Drawing.Size(54, 15);
            this.lbAttendID.TabIndex = 0;
            this.lbAttendID.Text = "AttendID";
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(46, 83);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(55, 15);
            this.lbCourseID.TabIndex = 1;
            this.lbCourseID.Text = "CourseID";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Location = new System.Drawing.Point(38, 137);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(63, 15);
            this.lbAccountID.TabIndex = 2;
            this.lbAccountID.Text = "AccountID";
            // 
            // lbSlot
            // 
            this.lbSlot.AutoSize = true;
            this.lbSlot.Location = new System.Drawing.Point(66, 192);
            this.lbSlot.Name = "lbSlot";
            this.lbSlot.Size = new System.Drawing.Size(27, 15);
            this.lbSlot.TabIndex = 3;
            this.lbSlot.Text = "Slot";
            // 
            // lbAttStatus
            // 
            this.lbAttStatus.AutoSize = true;
            this.lbAttStatus.Location = new System.Drawing.Point(21, 238);
            this.lbAttStatus.Name = "lbAttStatus";
            this.lbAttStatus.Size = new System.Drawing.Size(103, 15);
            this.lbAttStatus.TabIndex = 4;
            this.lbAttStatus.Text = "Attendance Status";
            // 
            // txtAttendID
            // 
            this.txtAttendID.Location = new System.Drawing.Point(125, 28);
            this.txtAttendID.Name = "txtAttendID";
            this.txtAttendID.Size = new System.Drawing.Size(205, 23);
            this.txtAttendID.TabIndex = 6;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(125, 189);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(205, 23);
            this.txtSlot.TabIndex = 7;
            // 
            // cboCourseID
            // 
            this.cboCourseID.FormattingEnabled = true;
            this.cboCourseID.Location = new System.Drawing.Point(125, 80);
            this.cboCourseID.Name = "cboCourseID";
            this.cboCourseID.Size = new System.Drawing.Size(205, 23);
            this.cboCourseID.TabIndex = 8;
            // 
            // cboAccountID
            // 
            this.cboAccountID.FormattingEnabled = true;
            this.cboAccountID.Location = new System.Drawing.Point(125, 134);
            this.cboAccountID.Name = "cboAccountID";
            this.cboAccountID.Size = new System.Drawing.Size(205, 23);
            this.cboAccountID.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbAttendanceStatus
            // 
            this.cbAttendanceStatus.AutoSize = true;
            this.cbAttendanceStatus.Location = new System.Drawing.Point(130, 234);
            this.cbAttendanceStatus.Name = "cbAttendanceStatus";
            this.cbAttendanceStatus.Size = new System.Drawing.Size(74, 19);
            this.cbAttendanceStatus.TabIndex = 12;
            this.cbAttendanceStatus.Text = "Available";
            this.cbAttendanceStatus.UseVisualStyleBackColor = true;
            // 
            // frmAttendanceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbAttendanceStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboAccountID);
            this.Controls.Add(this.cboCourseID);
            this.Controls.Add(this.txtSlot);
            this.Controls.Add(this.txtAttendID);
            this.Controls.Add(this.lbAttStatus);
            this.Controls.Add(this.lbSlot);
            this.Controls.Add(this.lbAccountID);
            this.Controls.Add(this.lbCourseID);
            this.Controls.Add(this.lbAttendID);
            this.Name = "frmAttendanceDetail";
            this.Text = "frmAttendanceDetail";
            this.Load += new System.EventHandler(this.frmAttendanceDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAttendID;
        private Label lbCourseID;
        private Label lbAccountID;
        private Label lbSlot;
        private Label lbAttStatus;
        private TextBox txtAttendID;
        private TextBox txtSlot;
        private ComboBox cboCourseID;
        private ComboBox cboAccountID;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox cbAttendanceStatus;
    }
}