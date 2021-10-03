using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsReference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lblGreeting.Text = $"Hello, {name}!";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new FrmAbout();
            frmAbout.Show();
        }
    }
}
