using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioBergara
{
    public class Receta
    {
        public string Nombre { get; set; }
        public List<IngredienteReceta> Ingredientes { get; set; } 
    }
}
