using DAL;
using Models;
using SES.Designs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SES
{
    public partial class HomeScreen : Form
    {

        #region Veriables
        private int childFormNumber = 0;
        private string APPID = DAL.Config.GetKeyValue("APPID"); 

        [DllImport("user32.dll")]        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
       



        #endregion 
         
        public HomeScreen()
        {
            InitializeComponent();
            LoadAppDesign();
        }

        private void LoadAppDesign()
        {
            try
            { 
              
                gpb_header.BackgroundImage = Image.FromFile(Application.StartupPath + DefaultSetting.ApplicationDesign.HeaderImage); 
                lbl_Header.Text = DefaultSetting.OrgInformation.OrgName;
                SetLabelFonts();
                ActiveControl = null; 
                tmr_MainScreenDateTime.Start();
                lbl_ActiveFormName.Hide();
               // DefaultSetting.AppSetting.DepartmentList = DAL1.DepartmentList();
            }
            catch (Exception ex)
            {
            }
        }
         
        private void SetLabelFonts()
        {
            if (true)
            {

                Settings ApplicationSetting = new Settings();
                ApplicationSetting.SetFontforControlCollection(this.Controls);
            }


        } 

        #region DefaultFunctions

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion

        private void Picture_Colse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pciture_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Pciture_FullScreen_Click(object sender, EventArgs e)
        {


            if (this.WindowState == FormWindowState.Maximized)
            {
                System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                this.MaximizedBounds = Screen.GetWorkingArea(this);
                this.WindowState = FormWindowState.Normal;
              //  pciture_FullScreen.Image = Properties.Resources.Full_Screen_Expnd;

            }
            else
            {
                System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                this.MaximizedBounds = Screen.GetWorkingArea(this);
                this.WindowState = FormWindowState.Maximized;
              //  pciture_FullScreen.Image = Properties.Resources.Full_Screen_Collapse;
            }
        }

      

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleStudents singleStudentsForm = new SingleStudents();
            singleStudentsForm.StartPosition = FormStartPosition.CenterParent;
            singleStudentsForm.MdiParent = this;
           
            singleStudentsForm.Dock = DockStyle.Fill;
          
            singleStudentsForm.Show();
        }
        
    }
}
