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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Registrar_usuario registrar_usuarioForm = new Registrar_usuario();
            registrar_usuarioForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario inventarioForm = new Inventario();
            inventarioForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            venta ventaForm = new venta();
            ventaForm.Show();
            this.Hide();
        }
    }
}
