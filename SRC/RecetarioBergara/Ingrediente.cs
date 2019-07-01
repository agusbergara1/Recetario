using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioBergara
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public decimal Stock { get; set; }
        public decimal Precio { get; set; }
        public int PuntoDePedido { get; set; }

    }
}
