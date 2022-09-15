using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProject.Model
{
    public partial class idk : UserControl
    {
        Reservaciones res = new Reservaciones();
        public idk()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
