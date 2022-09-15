using BDProject.Model;

namespace BDProject
{
    public partial class FrmSesion : Form
    {
        LoginUser logx = new LoginUser();
        users usx=new users();  
        public FrmSesion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean Success = logx.Islogin(txtuser.Text, txtclave.Text);
            logx.isCheck(Success);
            if (Success == true)
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRegister fg = new FRegister();
            fg.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}