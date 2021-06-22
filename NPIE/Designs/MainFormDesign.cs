using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SES.Designs
{
    class MainFormDesign
    {
        public static void LoadMenuStripOption(MenuStrip menuStrip, string ModuleName)
        {


            string Input = string.Empty;
            try
            {
                Input = ModuleName;

                switch (Input)
                {
                    case "Stduent":
                        {

                            ToolStripMenuItem items = new ToolStripMenuItem(); // You would obviously calculate this value at runtime

                            items = new ToolStripMenuItem();   //Add 
                            items.Name = "AddStudent";
                            //  items.Tag = "Add Student info";
                            items.Text = "Add Student";
                            menuStrip.Items.Add(items); 
                            items = new ToolStripMenuItem();  //Update
                            items.Name = "UpddateStudnet";
                            //  items.Tag = "Update Student nifo";
                            items.Text = "Update Student";
                            menuStrip.Items.Add(items);

                            items = new ToolStripMenuItem(); //Delete
                            items.Name = "DeletStudent";
                            //    items.Tag = "Delete Student info";
                            items.Text = "Delete  Student Information ";
                            menuStrip.Items.Add(items);

                            items = new ToolStripMenuItem();  //View
                            items.Name = "ViewStudent";
                            //   items.Tag = "View Student info";
                            items.Text = "View All Student ";
                            menuStrip.Items.Add(items);
                            break;
                        }
                    default:
                        break;

                }

            }
            catch (Exception ex)
            {



            }

        }

    }
}
