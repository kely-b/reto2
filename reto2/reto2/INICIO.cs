using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// fumo  bareta



namespace reto2
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;  
            string clave = textBox2.Text;    

            if (usuario == "user" && clave == "123")
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");

                this.Hide();

                admin adminForm = new admin();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos. Intenta de nuevo.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


