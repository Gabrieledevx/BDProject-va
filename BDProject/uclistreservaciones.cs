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
    public partial class uclistreservaciones : UserControl
    {
        Reservaciones res = new Reservaciones();
        public uclistreservaciones()
        {
            InitializeComponent();
        }

        private void uclistreservaciones_Load(object sender, EventArgs e)
        {
            res.getListReservaciones(dtgload);
        }
    }
}
