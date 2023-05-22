using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestWithDialogWindow
{
    public partial class Form1 : Form
    {
        SmallWindow SW_New = new SmallWindow();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close both windows
            SW_New.ShowDialog();
            Close();

        }
    }
}
