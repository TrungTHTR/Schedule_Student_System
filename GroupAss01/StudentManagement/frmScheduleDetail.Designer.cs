namespace StudentManagement
{
    partial class frmScheduleDetail
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
            this.lbScheduleID = new System.Windows.Forms.Label();
            this.lbAcountID = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.cboAccountID = new System.Windows.Forms.ComboBox();
            this.cboCourseID = new System.Windows.Forms.ComboBox();
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbScheduleID
            // 
            this.lbScheduleID.AutoSize = true;
            this.lbScheduleID.Location = new System.Drawing.Point(23, 32);
            this.lbScheduleID.Name = "lbScheduleID";
            this.lbScheduleID.Size = new System.Drawing.Size(66, 15);
            this.lbScheduleID.TabIndex = 0;
            this.lbScheduleID.Text = "ScheduleID";
            // 
            // lbAcountID
            // 
            this.lbAcountID.AutoSize = true;
            this.lbAcountID.Location = new System.Drawing.Point(23, 78);
            this.lbAcountID.Name = "lbAcountID";
            this.lbAcountID.Size = new System.Drawing.Size(63, 15);
            this.lbAcountID.TabIndex = 1;
            this.lbAcountID.Text = "AccountID";
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(26, 125);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(55, 15);
            this.lbCourse.TabIndex = 2;
            this.lbCourse.Text = "CourseID";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(48, 171);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(33, 15);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Time";
            // 
            // cboAccountID
            // 
            this.cboAccountID.FormattingEnabled = true;
            this.cboAccountID.Location = new System.Drawing.Point(122, 75);
            this.cboAccountID.Name = "cboAccountID";
            this.cboAccountID.Size = new System.Drawing.Size(256, 23);
            this.cboAccountID.TabIndex = 4;
            // 
            // cboCourseID
            // 
            this.cboCourseID.FormattingEnabled = true;
            this.cboCourseID.Location = new System.Drawing.Point(122, 125);
            this.cboCourseID.Name = "cboCourseID";
            this.cboCourseID.Size = new System.Drawing.Size(256, 23);
            this.cboCourseID.TabIndex = 5;
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Location = new System.Drawing.Point(122, 24);
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.Size = new System.Drawing.Size(256, 23);
            this.txtScheduleID.TabIndex = 6;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm:ss dddd MMMM dd, yyyy";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(122, 165);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(256, 23);
            this.dtpTime.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmScheduleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtScheduleID);
            this.Controls.Add(this.cboCourseID);
            this.Controls.Add(this.cboAccountID);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbAcountID);
            this.Controls.Add(this.lbScheduleID);
            this.Name = "frmScheduleDetail";
            this.Text = "frmScheduleDetail";
            this.Load += new System.EventHandler(this.frmScheduleDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbScheduleID;
        private Label lbAcountID;
        private Label lbCourse;
        private Label lbTime;
        private ComboBox cboAccountID;
        private ComboBox cboCourseID;
        private TextBox txtScheduleID;
        private DateTimePicker dtpTime;
        private Button btnSave;
        private Button btnCancel;
    }
}