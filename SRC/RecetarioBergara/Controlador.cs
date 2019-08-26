using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetarioBergara
{
    public static class Controlador
    {
        public static List<Ingrediente> Ingredientes { get; }

        static Controlador()
        {
            Ingredientes = new List<Ingrediente>();
        }

        public static void Agregar(string nombre, decimal stock, decimal precio, int puntodepedido)
        {
            Ingrediente ingrediente = new Ingrediente()
            {
                Nombre = nombre,
                Stock = stock,
                Precio = precio,
                PuntoDePedido = puntodepedido,

            };
            Ingredientes.Add(ingrediente);
            Guardar();
        }

        internal static void Agregar(TextBox nombreReceta_textBox, TextBox cantidadReceta_textBox, ComboBox ingrediente_comboBox)
        {
            throw new NotImplementedException();
        }

        public static void Modificar(string nombre, decimal stock, decimal precio, int puntodepedido, Ingrediente ingrediente)
        {
            ingrediente.Nombre = nombre;
            ingrediente.Stock = stock;
            ingrediente.Precio = precio;
            ingrediente.PuntoDePedido = puntodepedido;
            Guardar();
        }

        public static void Eliminar(Ingrediente ingrediente)
        {
            Ingredientes.Remove(ingrediente);
            Guardar();
        }
        private static void Guardar ()
        {
            using (StreamWriter Escritor = new StreamWriter("Ingredientes.json"))
            {
                string IngredientesJson = JsonConvert.SerializeObject(Ingredientes);
                Escritor.Write(IngredientesJson);
            }
        }
    }
}
