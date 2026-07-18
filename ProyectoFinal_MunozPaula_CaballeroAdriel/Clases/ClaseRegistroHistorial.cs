using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClaseRegistroHistorial
    {
        public ClaseUsuario Usuario { get; set; }

        public ClasePregunta Pregunta { get; set; }

        public ClaseRespuesta Respuesta { get; set; }

        public ClaseRegistroHistorial(ClaseUsuario usuario, ClasePregunta pregunta, ClaseRespuesta respuesta)
        {
            Usuario = usuario;
            Pregunta = pregunta;
            Respuesta = respuesta;
        }
    }
}
