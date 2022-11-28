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
    public partial class frmSchedule : Form
    {

        IScheduleRepository scheduleRepository = new ScheduleRepository();
        IEnumerable<Schedule> schedules;
        bool InsertOrUpdate = false;
        BindingSource source;

        public frmSchedule()
        {
            InitializeComponent();
        }
        private Schedule GetScheduleObject()

        {

            Schedule schedule = null;

            try
            {
                schedule = new Schedule
                {

                    ScheduleId = int.Parse(txtScheduleID.Text),
                    AccountId = int.Parse(txtAccountID.Text),
                    CourseId = txtCourseID.Text,
                    Time = DateTime.Parse(txtTime.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Schedule");
            }

            return schedule;

        }//end GetCarobject
        public void LoadSchedule()
        {
            var schedule = scheduleRepository.GetAll();
            try
            {
                source = new BindingSource();
                source.DataSource = schedule;
                txtScheduleID.DataBindings.Clear();
                txtAccountID.DataBindings.Clear();
                txtTime.DataBindings.Clear();
                txtCourseID.DataBindings.Clear();
                txtScheduleID.DataBindings.Add("Text", source, "ScheduleId");
                txtAccountID.DataBindings.Add("Text", source, "AccountId");
                txtTime.DataBindings.Add("Text", source, "Time");
                txtCourseID.DataBindings.Add("Text", source, "CourseId");
                dgvSchedule.DataSource = null;
                dgvSchedule.DataSource = source;
                if (schedule.Count() == 0)
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
                MessageBox.Show(ex.Message, "LoadSchedule");
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSchedule();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmScheduleDetail frmScheduleDetails = new frmScheduleDetail
            {
                Text = "Add Schedule",
                InsertOrUpdate = false,
                scheduleRepositorys = scheduleRepository,
            };
            if (frmScheduleDetails.ShowDialog() == DialogResult.OK)
            {
                LoadSchedule();
                //Set focus car inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Schedule = GetScheduleObject();
                scheduleRepository.Remove(Schedule.ScheduleId);
                LoadSchedule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Account");
            }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            LoadSchedule();
        }

        private void dgvSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmScheduleDetail frmScheduleDetails = new frmScheduleDetail
            {
                Text = "Update Schedule",
                InsertOrUpdate = true,
                scheduleRepositorys = scheduleRepository,
                scheduleInfo = GetScheduleObject(),

            };
            if (frmScheduleDetails.ShowDialog() == DialogResult.OK)
            {
                LoadSchedule(); //Set focus car updated 
                source.Position = source.Count - 1;

            }
        }
    }
}
