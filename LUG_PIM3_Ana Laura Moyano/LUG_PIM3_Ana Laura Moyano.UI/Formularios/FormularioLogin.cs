using LUG_PIM3_Ana_Laura_Moyano.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG_PIM3_Ana_Laura_Moyano.UI.Formularios
{
    public partial class FormularioLogin : Form
    {
        private LoginBLL loginBLL;
        public FormularioLogin()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
        }

        private void btn_login_login_Click(object sender, EventArgs e)
        {
            if (loginBLL.Login(txt_usuario_login.Text, txt_contrasenia_login.Text))
            {
                Form1 form = new Form1();
                form.FormClosed += (o, s) => Close();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Password no valido");
            }
        }
    }
}
