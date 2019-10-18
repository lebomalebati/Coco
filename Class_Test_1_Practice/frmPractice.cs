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
    public partial class frmPractice : Form
    {
        public frmPractice()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close form

            this.Close();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //message box will appear containing objective of game

            MessageBox.Show("If you clcik on the Hide button, one Spanish and ond Sepedi" + "\n" + "word will be hidden so that you can test yourself." + "\n" + "\n" + "Click show to see the words again." + "\n" + "\n" + "When you are ready to take the text click Exit." + "\n" + "Then click the Test button on the opening form.");
        }

        private void frmPractice_Load(object sender, EventArgs e)
        {
            //add 10 rows to dgv

            dgvLanguage.Rows.Add(10);

            //declare array

            string[] english = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] spanish = { "uno", "dos", "tres", "cuarto", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
            string[] sepedi = { "tee", "pedi", "tharo", "nne", "hlano", "tshela", "supa", "seswai", "senyane", "lesome" };

            //add array to coloumns

            
        }
    }
}
