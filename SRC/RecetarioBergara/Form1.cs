using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetarioBergara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            Controlador.Agregar(Ingrediente_textBox.Text, decimal.Parse(Cantidad_textBox.Text), decimal.Parse(Precio_textBox.Text), int.Parse(pdp_textBox.Text)); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_button_Click(object sender, EventArgs e)
        {
            Ingrediente ingredienteSeleccionado = ListaIngredientes_listBox.SelectedItem as Ingrediente;
            Controlador.Modificar(Ingrediente_textBox.Text, decimal.Parse(Cantidad_textBox.Text), decimal.Parse(Precio_textBox.Text), int.Parse(pdp_textBox.Text));
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            Ingrediente ingredienteSeleccionado = ListaIngredientes_listBox.SelectedItem as Ingrediente;
            Controlador.Eliminar(Ingrediente_textBox.Text, decimal.Parse(Cantidad_textBox.Text), decimal.Parse(Precio_textBox.Text), int.Parse(pdp_textBox.Text));
        }
    }
}
