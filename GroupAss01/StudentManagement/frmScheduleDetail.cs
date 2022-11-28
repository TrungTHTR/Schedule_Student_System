using StudentLib.Models;
using StudentLib.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentManagement
{
    public partial class frmScheduleDetail : Form
    {
        public IScheduleRepository scheduleRepositorys = new ScheduleRepository();
        IAccountRepository accountRepository = new AccountRepository();
        ICourseRepository courseRepository = new CourseRepository();


        public bool InsertOrUpdate { get; set; }
        public Schedule scheduleInfo { get; set; }
        public frmScheduleDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account account = cboAccountID.SelectedValue as Account;
            Course course = cboCourseID.SelectedValue as Course;
            try
            {
                var schedule = new Schedule
                {
                    ScheduleId = int.Parse(txtScheduleID.Text),
                    CourseId = course.CourseId,
                    AccountId = account.AccountId,
                    Time = dtpTime.Value,
                };
                if (InsertOrUpdate == false)
                {
                    scheduleRepositorys.AddNew(schedule);
                }
                else
                {
                    scheduleRepositorys.Update(schedule);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void Add()
        {
            var account = accountRepository.GetAll();
            cboAccountID.DataSource = account.ToList();
            cboAccountID.DisplayMember = "Username";
            var course = courseRepository.GetCourses();
            cboCourseID.DataSource = course.ToList();
            cboCourseID.DisplayMember = "SubjectName";
        }
        private void frmScheduleDetail_Load(object sender, EventArgs e)
        {
            Add();
            cboAccountID.SelectedIndex = 0;
            cboCourseID.SelectedIndex = 0;            
            if (InsertOrUpdate == true)
            { 
                txtScheduleID.Text = scheduleInfo.AccountId.ToString();
                cboAccountID.Text = scheduleInfo.AccountId.ToString();
                cboCourseID.Text = scheduleInfo.CourseId.ToString();
                dtpTime.Text = scheduleInfo.Time.ToString();              
            }
        }
    }
}
