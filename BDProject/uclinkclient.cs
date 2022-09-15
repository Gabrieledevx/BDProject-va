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
    public partial class uclinkclient : UserControl
    {
        cliente clt=new cliente();
        public uclinkclient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtid.ResetText();
            txtidp.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clt.linkeclt(txtid.Text, txtidp.Text);
        }
    }
}
