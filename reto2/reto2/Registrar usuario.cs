using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto2
{
    public partial class Registrar_usuario : Form
    {
        public Registrar_usuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(reto2.Trabajador.Rol));
            comboBox1.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre de usuario.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, ingresa una contraseña.");
                return;
            }


            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un rol.");
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una sucursal.");
                return;
            }


            string usuario = textBox1.Text.Trim();
            string contraseña = textBox3.Text.Trim();
            string rol = comboBox1.SelectedItem.ToString();
            string sucursal = comboBox2.SelectedItem.ToString();



            textBox1.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;


            MessageBox.Show($"Usuario registrado con éxito:\nUsuario: {usuario}\nRol: {rol}\nSucursal: {sucursal}");
        }
    }
}
