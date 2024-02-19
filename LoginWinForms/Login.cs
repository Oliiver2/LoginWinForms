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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreIngresado = textBox2.Text;

            // Buscar el nombre de usuario en la lista
            Usuario usuarioEncontrado = Usuario.usuarios.FirstOrDefault(usuario => usuario.getNombre().Equals(nombreIngresado));

            if (usuarioEncontrado != null)
            {
                MessageBox.Show($"¡Hola, {nombreIngresado}!", "Bienvenido");

                // Puedes realizar otras acciones después de encontrar al usuario, si es necesario.

                // Por ejemplo, cambiar el texto de textBox2 a "hola"
                textBox2.Text = "hola";
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
