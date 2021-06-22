using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SES.Designs.ResourceScreen
{
    public partial class Scrn_ErrorMessage : Form
    {
        public Scrn_ErrorMessage()
        {
            InitializeComponent();
            ActiveControl = Pbx_Icon;
        }

      
        private void mtbn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pbx_Icon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
