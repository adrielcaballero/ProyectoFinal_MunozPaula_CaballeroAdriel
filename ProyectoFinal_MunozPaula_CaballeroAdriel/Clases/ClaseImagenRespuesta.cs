using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClaseImagenRespuesta
    {
        public Image Imagen { get; set; }

        public ClaseTipoRespuesta Tipo { get; set; }

        public ClaseImagenRespuesta(Image imagen, ClaseTipoRespuesta tipo)
        {
            Imagen = imagen;
            Tipo = tipo;
        }
    }
}
