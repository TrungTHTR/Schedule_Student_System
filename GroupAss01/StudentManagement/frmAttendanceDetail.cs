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
    public partial class frmAttendanceDetail : Form
    {
        public IAttendanceRepository attendanceRepository = new AttendanceRepository();
        IAccountRepository accountRepository = new AccountRepository();
        ICourseRepository courseRepository = new CourseRepository();
        public bool InsertOrUpdate { get; set; }
        public Attendance attendanceInfo { get; set; }

        public frmAttendanceDetail()
        {
            InitializeComponent();
        }

        public void Add()
        {
            var course = courseRepository.GetCourses();
            cboCourseID.DataSource = course.ToList();
            cboCourseID.DisplayMember = "SubjectName";
            var account = accountRepository.GetAll();
            cboAccountID.DataSource = account.ToList();
            cboAccountID.DisplayMember = "Username";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Account accout = cboAccountID.SelectedValue as Account;
                Course course = cboCourseID.SelectedValue as Course;

                var atd = new Attendance
                {

                    AttendanceId = int.Parse(txtAttendID.Text),
                    CourseId = cboCourseID.Text,
                    AccountId = int.Parse(cboAccountID.Text),
                    Slot = int.Parse(txtSlot.Text),
                    AttStatus = cbAttendanceStatus.Checked
                };
                if (InsertOrUpdate != true)
                {
                    attendanceRepository.AddNew(atd);
                }
                else
                {
                    attendanceRepository.Update(atd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you Want to Close ? ", "CAR MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                Close();
            }
        }

        private void frmAttendanceDetail_Load(object sender, EventArgs e)
        {
            Add();

            cboAccountID.SelectedIndex = 0;
            cboCourseID.SelectedIndex = 0;
            if (InsertOrUpdate == true) //Update mode 
            {
                //Show car to perform updating 
                txtAttendID.Text = attendanceInfo.AttendanceId.ToString();
                cboAccountID.Text = attendanceInfo.AccountId.ToString();
                cboCourseID.Text = attendanceInfo.CourseId.ToString();
                txtSlot.Text = attendanceInfo.Slot.ToString();
                cbAttendanceStatus.Text = attendanceInfo.AttStatus.ToString();
            }
        }
    }
}
