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
    public partial class ucempleados : UserControl
    {
        empleados emp = new empleados();
        public ucempleados()
        {
            InitializeComponent();
        }

        private void ucempleados_Load(object sender, EventArgs e)
        {
            emp.getListEmpleados(dtgload);
        }
    }
}
