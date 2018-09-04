using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_10_3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHours_Click(object sender, EventArgs e)
        {
            string name, id, track;

            name = txtName.Text;
            id = txtID.Text;

            if (rbInfoSystems.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            lblRequiredHours.Text = csStudent.RequiredHours.ToString("n1");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
