using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWinForms
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario(fieldUsuario.Text, fieldPasswd.Text, fieldCorreo.Text);

            Usuario.usuarios.Add(nuevoUsuario);

            fieldUsuario.ResetText();
            fieldPasswd.ResetText();
            fieldPasswd2.ResetText();
            fieldCorreo.ResetText();

            Login login = new Login();
            login.ShowDialog();
        }

        private void fieldUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void fieldCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void fieldPasswd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
