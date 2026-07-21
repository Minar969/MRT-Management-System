using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MRT_Management_System
{
    public partial class Exit_gate_pass : Form
    {
        public Exit_gate_pass()
        {
            InitializeComponent();
        }

        private void textBoxegp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxegp.Text != "")
            {
                lblegp.Visible = false;
            }
            else
            {
                lblegp.Visible = true;
            }
        }
    }
}
