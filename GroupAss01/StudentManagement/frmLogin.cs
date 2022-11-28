using StudentLib.Repository;

namespace StudentManagement
{
    public partial class frmLogin : Form
    {
        private IAccountRepository accountRepository=new AccountRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int role = accountRepository.CheckLogin(textBox1.Text, textBox2.Text);
            if (role == 1)
            {
                frmMain frmMain  = new frmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Cannot login");
            }
        }
    }
}