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
    public partial class frmExamResultDetail : Form
    {
   public  IAccountRepository accountRepository=new AccountRepository();
     public   ICourseRepository courseRepository=new CourseRepository();
        public IExamTypeRepository examTypeRepository = new ExamTypeRepository();
       public IExamResultRepository examResultRepository=new ExamResultRepository();
      public  bool InsertOrUpdate { get; set; }
        public ExamResult resultInfo { get; set; }
        public frmExamResultDetail()
        {
            InitializeComponent();
        }
        private void LoadAccount()
        {
            var acc = accountRepository.GetStudent();
            cboAccount.DataSource = acc.ToList();
            cboAccount.DisplayMember = "UserName";
        }
        private void LoadCourse()
        {
            var co = courseRepository.GetCourses();
            cboCourse.DataSource= co.ToList();
            cboCourse.DisplayMember = "SubjectName";
        }
        private void LoadType()
        {
            var type = examTypeRepository.GetTypes();
            cboExamType.DataSource = type.ToList();
            cboExamType.DisplayMember = "ExamTypeName";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmExamResultDetail_Load(object sender, EventArgs e)
        {
            LoadAccount();
            LoadCourse();
            LoadType();
            cboAccount.SelectedIndex = 0;
            cboCourse.SelectedIndex = 0;
            cboExamType.SelectedIndex = 0;
            if (InsertOrUpdate == true)
            {
                txtExamID.Text = resultInfo.ExamId;
                txtTotalTime.Text = resultInfo.Totaltime.ToString();
                txtMarks.Text=resultInfo.Marks.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Account account = cboAccount.SelectedValue as Account;
            Course course = cboCourse.SelectedValue as Course;
            ExamType type=cboExamType.SelectedValue as ExamType;
            try
            {
                var result = new ExamResult
                {
                    ExamId=txtExamID.Text,
                    CourseId=course.CourseId,
                    AccountId=account.AccountId,
                    ExamStartDate=dateTimePicker1.Value,
                    ExamStatus=checkBox1.Checked,
                    ExamType=type.ExamtypeId,
                    Totaltime=int.Parse(txtTotalTime.Text),
                    Marks=int.Parse(txtMarks.Text),
                };
                if (InsertOrUpdate == false)
                {
                    examResultRepository.AddNew(result);
                }
                else
                {
                    examResultRepository.Update(result);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
