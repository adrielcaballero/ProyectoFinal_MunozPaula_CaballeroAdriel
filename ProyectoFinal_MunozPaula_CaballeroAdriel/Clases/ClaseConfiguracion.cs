using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public static class ClaseConfiguracion
    {
        public static int TiempoRespuesta = 2000;

        // true = verde, false = rojo
        public static int ModoColor = 0;

        public static Color ColorFondo
        {
            get
            {
                switch (ModoColor)
                {
                    case 1:
                        return Color.FromArgb(227, 95, 95);   // Rojo

                    case 2:
                        return Color.FromArgb(57, 77, 205);   // Azul

                    default:
                        return Color.FromArgb(32, 140, 113);  // Verde
                }
            }
        }
    }
}
