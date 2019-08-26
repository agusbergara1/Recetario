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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NombreReceta_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarReceta_button_Click(object sender, EventArgs e)
        {
            Controlador.Agregar (NombreReceta_textBox, CantidadReceta_textBox, Ingrediente_comboBox);
        }

        private void Receta_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
