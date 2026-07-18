using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClasePregunta
    {
        public string Texto { get; set; }
        public string OrigenCategoria { get; set; }
        public DateTime Fecha { get; set; }
        public ClasePregunta(string texto, string origenCategoria)
        {
            Texto = texto;
            OrigenCategoria = origenCategoria;
            Fecha = DateTime.Now;
        }
    }
}
