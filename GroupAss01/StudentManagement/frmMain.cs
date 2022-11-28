using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateMyMainMenu();
        }
        public void CreateMyMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;
            ToolStripMenuItem menuFile = new ToolStripMenuItem("&Menu");
            ToolStripMenuItem mnuAccount = new ToolStripMenuItem("&Account");
            ToolStripMenuItem mnuCourse = new ToolStripMenuItem("&Course");
            ToolStripMenuItem mnuAttend = new ToolStripMenuItem("&Attend");
            ToolStripMenuItem mnuExamResult = new ToolStripMenuItem("&Exam Result");
            ToolStripMenuItem mnuSchedule = new ToolStripMenuItem("&Schedule");
            ToolStripSeparator separator = new ToolStripSeparator();
            ToolStripMenuItem mnuExit = new ToolStripMenuItem("&Exit");
            ToolStripMenuItem mnuWindow = new ToolStripMenuItem("&Window");
            // mainMenu 
            mainMenu.Items.AddRange(new ToolStripItem[] { menuFile, mnuWindow });
            mainMenu.MdiWindowListItem = mnuWindow;
            //menuFile 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuAccount, mnuCourse, mnuAttend, mnuExamResult, mnuSchedule, separator, mnuExit });
            //mnuOpen 
            mnuAccount.ShortcutKeys = (Keys)((Keys.Control | Keys.A));
            mnuAccount.Click += new EventHandler(mnuAccount_Click);
            mnuCourse.ShortcutKeys = (Keys)((Keys.Control | Keys.C));
            mnuCourse.Click += new EventHandler(mnuCourse_Click);
         //   mnuProduct.ShortcutKeys = (Keys)((Keys.Control | Keys.P));
           // mnuProduct.Click += new EventHandler(mnuProduct_Click);

            // mnuExit 
            mnuExit.ShortcutKeys = (Keys)((Keys.Alt | Keys.X));
            mnuExit.Click += new EventHandler(mnuExit_Click);

        }
        //end CreateMyMainMenu
        //Show frmChild form 
        private void mnuAccount_Click(object sender, EventArgs e)
        {
          frmAccount frmAccount = new frmAccount();
           frmAccount.Text = $"AccountForm {counter++:D2}";
            frmAccount.MdiParent = this;
            frmAccount.Show();

        }//end mnuOpen_Click 
        private void mnuCourse_Click(object sender, EventArgs e)
        {
            frmCourse frmCourse = new frmCourse();
           frmCourse.Text = $"MemberForm {counter++:D2}";
          frmCourse.MdiParent = this; 
            frmCourse.Show();
        }//end mnuMember_Click 
      /*  private void mnuProduct_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.Text = $"ProductForm {counter++:D2}";
            product.MdiParent = this; product.Show();
        }*/
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//end MainForm
}

