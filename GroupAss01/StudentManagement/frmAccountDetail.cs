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
using StudentLib.Models;
using System.Dynamic;

namespace StudentManagement
{
    public partial class frmAccountDetail : Form
    {
        public IAccountRepository accountRepository = new AccountRepository();
        IAccountRole roleRepository = new RoleRepository();
        public bool InsertOrUpdate { get; set; }
        public Account accountInfo { get; set; }
        public frmAccountDetail()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Add()
        {
            var role = roleRepository.GetAccountRoles();
            cboRoleID.DataSource = role.ToList();
            cboRoleID.DisplayMember = "Rolename";

        }
        private void frmAccountDetail_Load(object sender, EventArgs e)
        {
            Add();
            
          cboRoleID.SelectedIndex = 0;
            if (InsertOrUpdate == true) //Update mode 
            {
                //Show car to perform updating 
                txtAccountID.Text = accountInfo.AccountId.ToString();
                txtUsername.Text = accountInfo.Username;
                txtPassword.Text = accountInfo.PassWord;
                txtPhoneNumber.Text = accountInfo.PhoneNumber;
                txtDOB.Text = accountInfo.Dob;

            }

        }

  

       

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
               AccountRole accountRole=cboRoleID.SelectedValue as AccountRole;
                var Account = new Account
                {
               
                    Username = txtUsername.Text,
                    PassWord = txtPassword.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Dob = txtDOB.Text,
                    DateOfJoin = dateTimePicker1.Value,
                     Roleid = accountRole.Roleid,
                    AccountStatus = checkBox1.Checked

                };
                if (InsertOrUpdate != true)
                {
                    accountRepository.AddNew(Account);
                }
                else
                {
                    var Account02 = new Account
                    {
                        AccountId=int.Parse(txtAccountID.Text),
                        Username = txtUsername.Text,
                        PassWord = txtPassword.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Dob = txtDOB.Text,
                        DateOfJoin = dateTimePicker1.Value,
                        Roleid = accountRole.Roleid,
                        AccountStatus = checkBox1.Checked

                    };
                    accountRepository.Update(Account02);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

       
    }
}

