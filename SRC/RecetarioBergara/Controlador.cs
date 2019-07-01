using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public static void Modificar(string nombre, decimal stock, decimal precio, int puntodepedido, Ingrediente ingrediente)
        {
            ingrediente.Nombre = nombre;
            ingrediente.Stock = stock;
            ingrediente.Precio = precio;
            ingrediente.PuntoDePedido = puntodepedido;
        }

        public static void Eliminar(Ingrediente ingrediente)
        {
            Ingredientes.Remove(ingrediente);
        }
    }
}
