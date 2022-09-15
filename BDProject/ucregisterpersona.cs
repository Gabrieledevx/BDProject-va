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
    public partial class ucregisterpersona : UserControl
    {
        personas per = new personas();
        public ucregisterpersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            per.registerPersona(txtid.Text, txtnom.Text, txtape.Text, txtedad.Text, txtcorreo.Text, txtcelular.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtape.ResetText();
            txtcelular.ResetText();
            txtcorreo.ResetText();
            txtedad.ResetText();
            txtid.ResetText();
            txtnom.ResetText();
        }
    }
}
