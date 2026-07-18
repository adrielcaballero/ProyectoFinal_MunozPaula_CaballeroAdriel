using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClaseRespuesta
    {
        public string Texto { get; private set; }
        public ClaseTipoRespuesta Tipo { get; private set; }

        public ClaseRespuesta(string texto, ClaseTipoRespuesta tipo)
        {
            Texto = texto;
            Tipo = tipo;
        }
    }
}