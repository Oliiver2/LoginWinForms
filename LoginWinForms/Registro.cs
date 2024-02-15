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
        }
    }
}
