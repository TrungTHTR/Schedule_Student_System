namespace StudentManagement
{
    partial class frmAttendace
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
            this.lbAttenanceStatus = new System.Windows.Forms.Label();
            this.txtAttenanceID = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtAttStatus = new System.Windows.Forms.TextBox();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAttendID
            // 
            this.lbAttendID.AutoSize = true;
            this.lbAttendID.Location = new System.Drawing.Point(34, 40);
            this.lbAttendID.Name = "lbAttendID";
            this.lbAttendID.Size = new System.Drawing.Size(79, 15);
            this.lbAttendID.TabIndex = 0;
            this.lbAttendID.Text = "AttendanceID";
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(58, 91);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(55, 15);
            this.lbCourseID.TabIndex = 1;
            this.lbCourseID.Text = "CourseID";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Location = new System.Drawing.Point(50, 138);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(63, 15);
            this.lbAccountID.TabIndex = 2;
            this.lbAccountID.Text = "AccountID";
            // 
            // lbSlot
            // 
            this.lbSlot.AutoSize = true;
            this.lbSlot.Location = new System.Drawing.Point(386, 40);
            this.lbSlot.Name = "lbSlot";
            this.lbSlot.Size = new System.Drawing.Size(27, 15);
            this.lbSlot.TabIndex = 3;
            this.lbSlot.Text = "Slot";
            // 
            // lbAttenanceStatus
            // 
            this.lbAttenanceStatus.AutoSize = true;
            this.lbAttenanceStatus.Location = new System.Drawing.Point(386, 91);
            this.lbAttenanceStatus.Name = "lbAttenanceStatus";
            this.lbAttenanceStatus.Size = new System.Drawing.Size(100, 15);
            this.lbAttenanceStatus.TabIndex = 4;
            this.lbAttenanceStatus.Text = "AttendanceStatus";
            // 
            // txtAttenanceID
            // 
            this.txtAttenanceID.Location = new System.Drawing.Point(131, 37);
            this.txtAttenanceID.Name = "txtAttenanceID";
            this.txtAttenanceID.Size = new System.Drawing.Size(226, 23);
            this.txtAttenanceID.TabIndex = 5;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(131, 91);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(226, 23);
            this.txtCourseID.TabIndex = 6;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(131, 135);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(226, 23);
            this.txtAccountID.TabIndex = 7;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(490, 37);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(226, 23);
            this.txtSlot.TabIndex = 8;
            // 
            // txtAttStatus
            // 
            this.txtAttStatus.Location = new System.Drawing.Point(490, 88);
            this.txtAttStatus.Name = "txtAttStatus";
            this.txtAttStatus.Size = new System.Drawing.Size(226, 23);
            this.txtAttStatus.TabIndex = 9;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(34, 204);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowTemplate.Height = 25;
            this.dgvAttendance.Size = new System.Drawing.Size(604, 223);
            this.dgvAttendance.TabIndex = 10;
            this.dgvAttendance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(678, 216);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(678, 270);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(678, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(678, 392);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 23);
            this.btnExist.TabIndex = 14;
            this.btnExist.Text = "EXIST";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // frmAttendace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.txtAttStatus);
            this.Controls.Add(this.txtSlot);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.txtAttenanceID);
            this.Controls.Add(this.lbAttenanceStatus);
            this.Controls.Add(this.lbSlot);
            this.Controls.Add(this.lbAccountID);
            this.Controls.Add(this.lbCourseID);
            this.Controls.Add(this.lbAttendID);
            this.Name = "frmAttendace";
            this.Text = "frmAttendace";
            this.Load += new System.EventHandler(this.frmAttendace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAttendID;
        private Label lbCourseID;
        private Label lbAccountID;
        private Label lbSlot;
        private Label lbAttenanceStatus;
        private TextBox txtAttenanceID;
        private TextBox txtCourseID;
        private TextBox txtAccountID;
        private TextBox txtSlot;
        private TextBox txtAttStatus;
        private DataGridView dgvAttendance;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnExist;
    }
}