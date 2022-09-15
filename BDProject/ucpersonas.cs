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
    public partial class ucpersonas : UserControl
    {
        personas per = new personas();
        public ucpersonas()
        {
            InitializeComponent();
        }

        private void ucpersonas_Load(object sender, EventArgs e)
        {
            per.getListP(dtgload);
        }
    }
}
