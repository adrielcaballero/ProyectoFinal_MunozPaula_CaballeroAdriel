using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClaseLogicaClasico
    {
        private Random random;
        private List<ClaseImagenRespuesta> imagenes;

        public ClaseLogicaClasico()
        {
            random = new Random();
            imagenes = new List<ClaseImagenRespuesta>();

            CargarImagenes();
        }
        private void CargarImagenes()
        {
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.apuntaquesi, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.concentrate, ClaseTipoRespuesta.Indecisa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.confiarenello, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.definitivamenteloes, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.sidefinitivamente, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.esseguro, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.fuentes_no, ClaseTipoRespuesta.Negativa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.lodudomucho, ClaseTipoRespuesta.Negativa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.lomasseguro, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.mejornoahora, ClaseTipoRespuesta.Indecisa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.miparecersi, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.nocuentes, ClaseTipoRespuesta.Negativa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.nopuedoahora, ClaseTipoRespuesta.Indecisa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.perspectivabuena, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.prespectivamala, ClaseTipoRespuesta.Negativa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.preguntamastarde, ClaseTipoRespuesta.Indecisa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.si, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.sinduda, ClaseTipoRespuesta.Positiva));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.respuestano, ClaseTipoRespuesta.Negativa));
            imagenes.Add(new ClaseImagenRespuesta(Properties.Resources.respuestavaga, ClaseTipoRespuesta.Indecisa));
        }
        public ClaseImagenRespuesta GenerarRespuesta()
        {
            int numero = random.Next(imagenes.Count);

            return imagenes[numero];
        }
    }
}
