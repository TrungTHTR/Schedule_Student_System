using StudentLib.Models;
using StudentLib.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmAttendace : Form
    {

        IAttendanceRepository attendanceRepository = new AttendanceRepository();
        IEnumerable<Attendance> attendances;
        bool InsertOrUpdate = false;
        BindingSource source;

        public void LoadAttendance()
        {
            var atd = attendanceRepository.GetAll();
            try
            {
                source = new BindingSource();
                source.DataSource = atd;
                txtAccountID.DataBindings.Clear();
                txtAttenanceID.DataBindings.Clear();
                txtAttStatus.DataBindings.Clear();
                txtCourseID.DataBindings.Clear();
                txtSlot.DataBindings.Clear();
                txtAccountID.DataBindings.Add("Text", source, "AccountId");
                txtAttenanceID.DataBindings.Add("Text", source, "AttendanceId");
                txtAttStatus.DataBindings.Add("Text", source, "AttStatus");
                txtCourseID.DataBindings.Add("Text", source, "CourseId");
                txtSlot.DataBindings.Add("Text", source, "Slot");
                dgvAttendance.DataSource = null;
                dgvAttendance.DataSource = source;
                if (atd.Count() == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadAccount");
            }
        }
        private Attendance GetAttendance()

        {

            Attendance atd = null;
            try
            {
                atd = new Attendance
                {
                    AttendanceId = int.Parse(txtAccountID.Text),
                    CourseId = txtCourseID.Text,
                    AccountId = int.Parse(txtAccountID.Text),
                    Slot = int.Parse(txtSlot.Text),
                    AttStatus = Boolean.Parse(txtAttStatus.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Attendace");
            }

            return atd;

        }



        public frmAttendace()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAttendanceDetail frmAttendanceDetail = new frmAttendanceDetail
            {
                Text = "Add Attendance",
                InsertOrUpdate = false,
                attendanceRepository = attendanceRepository,
            };
            if (frmAttendanceDetail.ShowDialog() == DialogResult.OK)
            {
                LoadAttendance();
                //Set focus car inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var attend = GetAttendance();
                attendanceRepository.Remove(attend.AttendanceId);
                LoadAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Account");
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAttendance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAttendanceDetail frmAttendanceDetail = new frmAttendanceDetail
            {
                Text = "Update Attend",
                InsertOrUpdate = true,
                attendanceRepository = attendanceRepository,
                attendanceInfo = GetAttendance(),

            };
            if (frmAttendanceDetail.ShowDialog() == DialogResult.OK)
            {
                LoadAttendance();
                source.Position = source.Count - 1;
            }
        }

        private void frmAttendace_Load(object sender, EventArgs e)
        {
            LoadAttendance();
        }
    }
}
