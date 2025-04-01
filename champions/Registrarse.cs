using System;
using System.Windows.Forms;

namespace Champions_League
{
    public partial class btnRegistrase2 : Form
    {
        public btnRegistrase2()
        {
            InitializeComponent();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string direccion = txtDireccion.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

 
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide(); 
        }
    }
}

