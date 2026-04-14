using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domiino
{
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; } 
        
        public Marca Marca { get; set; }
        //public Categoria Categoria { get; set; }   falta agregar clase y de imagen tmb


    }
}
