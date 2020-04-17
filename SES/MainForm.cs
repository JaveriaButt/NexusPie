using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using System.Runtime.InteropServices;
using SES.Designs;
using DAL;
using System.Collections.ObjectModel;

namespace SES
{
    public partial class MainForm : Form
    {
        #region Veriables
        private int childFormNumber = 0;
        private string APPID =  Config.GetKeyValue("APPID");
        public static AppDesign ApplicationDesign = new AppDesign();
        private OrgInfo OrgInformation = new OrgInfo();
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

       


        #endregion
        public MainForm()
        {
            InitializeComponent();
            LoadAppDesign();
               
        }
      
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void picture_Colse_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void pciture_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void LoadAppDesign()
        {
            try
            { 
                //ApplicationDesign = DAL1.LoadApplicaitonDesign();
                //OrgInformation = DAL1.LoadOrgInfo();
                gpb_header.BackgroundImage = Image.FromFile(Application.StartupPath + ApplicationDesign.HeaderImage);
                lbl_Header.Text = OrgInformation.OrgName;
                SetLabelFonts();
                ActiveControl = null;
                lbl_FDateTime.Text = DateTime.Now.ToString("f");
                tmr_MainScreenDateTime.Start();
                lbl_ActiveFormName.Hide();
                
            }
            catch (Exception ex)
            {
            }
        }

        private void gpb_header_Enter(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;

        }


        private void SetLabelFonts()
        {
            if (true)
            {

                Settings ApplicationSetting = new Settings();
                ApplicationSetting.SetFontforControlCollection(this.Controls);
            }


        }

        private void mt_Student_Click(object sender, EventArgs e)
        {
           
            SingleStudents singleStudentsForm = new SingleStudents();
            singleStudentsForm.StartPosition = FormStartPosition.CenterParent;
            singleStudentsForm.MdiParent = this;
            SetParent(singleStudentsForm.Handle, this.Pnl_FormArea.Handle);
            singleStudentsForm.Dock = DockStyle.Fill;
            singleStudentsForm.FormClosing += (send, eve) => { ChildClosed(); };
            singleStudentsForm.Show();
           
            this.Pnl_MainMenu.Visible = false;
            this.Pnl_Strip.Visible = true;
            this.Pnl_Left.Visible = true;
            ActiveChildName();
            BuildMenuItems("Stduent");

        }

        private void Pciture_FullScreen_Click(object sender, EventArgs e)
        {
            

            if (this.WindowState == FormWindowState.Maximized)
            {
                   System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                   this.MaximizedBounds = Screen.GetWorkingArea(this);
                   this.WindowState = FormWindowState.Normal;
                   pciture_FullScreen.Image = Properties.Resources.Full_Screen_Expnd;
                  
            }
            else
            {
                System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                this.MaximizedBounds = Screen.GetWorkingArea(this);
                this.WindowState = FormWindowState.Maximized;
                pciture_FullScreen.Image = Properties.Resources.Full_Screen_Collapse;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_FDateTime.Text = DateTime.Now.ToString("f");
            
        }


        void ActiveChildName()
        {

            try
            {
                Form ActiveChild = this.ActiveMdiChild;
                if (ActiveChild != null)
                {
                    lbl_ActiveFormName.Text = ActiveChild.Text;
                }
                else
                {
                    Pnl_Left.Hide();
                    Pnl_MainMenu.Show();

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void BuildMenuItems(string FromName)
        {

            try
            {
                 MainFormDesign.LoadMenuStripOption(MNS_Top, "Stduent");
              
            }
            catch (Exception ex)
            { }
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            // Take some action based on the Result in clickedItem
        }

        private void mt_StudentLeft_Click(object sender, EventArgs e)
        {
            SingleStudents singleStudentsForm = new SingleStudents();
            singleStudentsForm.StartPosition = FormStartPosition.CenterParent;
            singleStudentsForm.MdiParent = this;
            SetParent(singleStudentsForm.Handle, this.Pnl_FormArea.Handle);
            singleStudentsForm.Dock = DockStyle.Fill;
            singleStudentsForm.FormClosing += (Send, eve) => { ChildClosed(); };
            singleStudentsForm.Show();
            this.Pnl_MainMenu.Visible = false;
            this.Pnl_Strip.Visible = true;
            this.Pnl_Left.Visible = true;
            ActiveChildName();
            BuildMenuItems("Stduent");
        }




        public void ChildClosed()
        {
            try
            {
                MNS_Top.Items.Clear();
                if (!this.Pnl_FormArea.HasChildren)
                {
                    Pnl_Left.Hide();
                    Pnl_MainMenu.Show();

                }
            }
            catch (Exception ex)
            { }
        }
    }
}
