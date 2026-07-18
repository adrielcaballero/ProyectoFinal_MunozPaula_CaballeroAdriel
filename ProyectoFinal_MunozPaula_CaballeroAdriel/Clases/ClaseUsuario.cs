using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClaseUsuario
    {
        public string Nombre { get; private set; }
        public DateTime FechaRegistro { get; private set; }

        public ClaseUsuario(string nombre)
        {
            Nombre = nombre;
            FechaRegistro = DateTime.Now;
        }
    }
}