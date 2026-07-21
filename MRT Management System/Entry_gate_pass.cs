using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRT_Management_System
{
    public partial class Entry_gate_pass : Form
    {
        public Entry_gate_pass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngp_Click(object sender, EventArgs e)
        {

        }

        private void textBoxgp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxgp.Text != "")
            {
                lblgp.Visible = false;
            }
            else
            {
                lblgp.Visible = true;
            }
        }
    }
}
