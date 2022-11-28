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
    public partial class frmCourseDetail : Form
    {
        public frmCourseDetail()
        {
            InitializeComponent();
        }
public ICourseRepository courseRepository=new CourseRepository();
        IAccountRepository AccountRepository = new AccountRepository();
        public Course courseInfo { get; set; }
      public bool InsertOrUpdate { get; set; }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadCombo()
        {
            var name = AccountRepository.GetTeacher();
            cboName.DataSource = name.ToList();
            cboName.DisplayMember = "UserName";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = cboName.SelectedValue as Account;
                var Course = new Course
                {
                    CourseId=txtCourseID.Text,
                    SubjectName=txtSubjectame.Text,
                    TeacherName=account.Username
                };
                if (InsertOrUpdate == false)
                {
                    courseRepository.AddNew(Course);
                }
                else
                {
                    courseRepository.Update(Course);
                }
            } catch(Exception ex)
            {
           MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Course" : "Update Course");
            }
        }

        private void frmCourseDetail_Load(object sender, EventArgs e)
        {
            LoadCombo();
            cboName.SelectedIndex = 0;
            if (InsertOrUpdate == true)
            {
                txtCourseID.Text= courseInfo.CourseId;
                txtSubjectame.Text = courseInfo.SubjectName;
              
            }
        }

    }
}
