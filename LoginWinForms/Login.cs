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
            // Obtener el nombre de usuario y la contraseña ingresados
            string nombreIngresado = fieldUsuarioLogin.Text;
            string passwordIngresado = textBox2.Text;

            // Bandera para verificar si se encontró el usuario
            bool usuarioEncontrado = false;

            // Buscar el usuario en la lista
            foreach (Usuario usuario in Usuario.usuarios)
            {
                if (usuario.nombre.Equals(nombreIngresado) && usuario.passwd.Equals(passwordIngresado))
                {
                    // Usuario encontrado y las credenciales son correctas
                    usuarioEncontrado = true;
                    break; // Salir del bucle una vez que se encuentra el usuario
                }
            }

            // Verificar si se encontró el usuario y las credenciales son correctas
            if (usuarioEncontrado)
            {
                MessageBox.Show($"¡Hola, {nombreIngresado}!", "Bienvenido");
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
