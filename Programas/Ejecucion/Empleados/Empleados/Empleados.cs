using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            TextBox[] textboxi = { textBox1, textBox2 };
            navegador1.textbox = textbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = textboxi;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, textbox, "sin");
        }
    }
}
