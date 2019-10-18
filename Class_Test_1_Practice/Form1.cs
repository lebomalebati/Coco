using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Test_1_Practice
{
    public partial class frmCounting : Form
    {
        public frmCounting()
        {
            InitializeComponent();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            //Link forms
            //Open practice form

            frmPractice myForm = new frmPractice();
            myForm.ShowDialog();

        }

        
    }
}
