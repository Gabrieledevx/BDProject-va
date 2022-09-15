using BDProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProject
{
    
    public partial class ucreservaciones : UserControl
    {
        Reservaciones res = new Reservaciones();
        public ucreservaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res.registerRes(txtid.Text, txtdir.Text, txtdias.Text, txtmet.Text, txtidclt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdias.ResetText();
            txtdir.ResetText();
            txtid.ResetText();
            txtidclt.ResetText();
            txtmet.ResetText();
        }
    }
}
