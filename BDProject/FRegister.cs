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
    public partial class FRegister : Form
    {
        users us = new users();
        public FRegister()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            us.registerUser(txtid.Text, txtuser.Text, txtclave.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtid.ResetText();
            txtuser.ResetText();
            txtclave.ResetText();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
