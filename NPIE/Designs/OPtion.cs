using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SES
{
    public partial class OPtion : Form
    {
        public OPtion()
        {
            InitializeComponent();
        }

        private void mt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void mt_close_Click(object sender, EventArgs e)
        //{
        //    Mainmenu.choice = 4;
        //    this.Close();
        //}

        //private void mt_add_Click(object sender, EventArgs e)
        //{
        //    Mainmenu.choice = 1;
        //    this.Close();
        //}

        //private void mt_update_Click(object sender, EventArgs e)
        //{
        //    Mainmenu.choice = 2;
        //    this.Close();
        //}

        //private void mt_delete_Click(object sender, EventArgs e)
        //{
        //    Mainmenu.choice = 3;
        //    this.Close();
        //}
    }
}
