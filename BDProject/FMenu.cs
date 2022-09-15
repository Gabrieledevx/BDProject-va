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
    public partial class FMenu : Form
    {
        UserControlsHandler ch=new UserControlsHandler();
        public FMenu(string user)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucpersonas uc=new ucpersonas();
            ch.addUserControl(uc, mypanel);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucregisterpersona uc=new ucregisterpersona();
            ch.addUserControl(uc, mypanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucempleados uc = new ucempleados();
            ch.addUserControl(uc, mypanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucrelacionarempleado uc=new ucrelacionarempleado();
            ch.addUserControl(uc, mypanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucclientes uc = new ucclientes();
            ch.addUserControl(uc, mypanel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uclinkclient uc=new uclinkclient();
            ch.addUserControl(uc, mypanel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            uclistreservaciones uc=new uclistreservaciones();
            ch.addUserControl(uc, mypanel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ucreservaciones uc = new ucreservaciones();
            ch.addUserControl(uc, mypanel);
        }
    }
}
