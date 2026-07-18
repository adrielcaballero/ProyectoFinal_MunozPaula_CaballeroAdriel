using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClaseLogicaCategorias
    {
        private Dictionary<ClaseCategoria, Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>>> bancoRespuestas;
        private Random random;


        public ClaseLogicaCategorias()
        {
            random = new Random();
            bancoRespuestas = new Dictionary<ClaseCategoria, Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>>>();
            CargarRespuestas();
        }

        private void CargarRespuestas()
        {
            CargarAmor();
            CargarTrabajo();
            CargarEstudios();
            CargarDinero();
        }
        private void CargarAmor()
        {
            Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>> porNivel = new Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>>();

            List<ClaseRespuesta> normal = new List<ClaseRespuesta>();
            normal.Add(new ClaseRespuesta("Sí, esa persona piensa en ti.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Todavía no es el momento.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("Dale una oportunidad.", ClaseTipoRespuesta.Indecisa));
            normal.Add(new ClaseRespuesta("El amor está más cerca de lo que crees.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Esa relación necesita más comunicación.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("Sé paciente, las cosas se acomodarán.", ClaseTipoRespuesta.Indecisa));
            normal.Add(new ClaseRespuesta("Confía en lo que sientes.", ClaseTipoRespuesta.Positiva));

            List<ClaseRespuesta> mistico = new List<ClaseRespuesta>();
            mistico.Add(new ClaseRespuesta("Las estrellas susurran un sí para ti.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("El destino aún no ha escrito ese capítulo.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("El universo pide paciencia antes de responder.", ClaseTipoRespuesta.Indecisa));
            mistico.Add(new ClaseRespuesta("Los astros se alinean a tu favor.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Una sombra cubre ese camino por ahora.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("El corazón conoce la respuesta antes que la mente.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Un ciclo debe cerrarse antes de que otro comience.", ClaseTipoRespuesta.Indecisa));

            List<ClaseRespuesta> caotico = new List<ClaseRespuesta>();
            caotico.Add(new ClaseRespuesta("Pregúntale a tu mamá, ella sabe todo.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("El amor está en llamas, corre.", ClaseTipoRespuesta.Negativa));
            caotico.Add(new ClaseRespuesta("Consulta con una bola de billar, es más confiable.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Sí, pero solo los martes.", ClaseTipoRespuesta.Positiva));
            caotico.Add(new ClaseRespuesta("No tengo señal con Cupido ahora mismo.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Tira una moneda, yo ya perdí la cuenta.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Vuelve a preguntar después del almuerzo.", ClaseTipoRespuesta.Indecisa));

            porNivel[ClaseNivelSabiduria.Normal] = normal;
            porNivel[ClaseNivelSabiduria.Mistico] = mistico;
            porNivel[ClaseNivelSabiduria.Caotico] = caotico;

            bancoRespuestas[ClaseCategoria.Amor] = porNivel;
        }
        private void CargarTrabajo()
        {
            Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>> porNivel = new Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>>();

            List<ClaseRespuesta> normal = new List<ClaseRespuesta>();
            normal.Add(new ClaseRespuesta("Un ascenso está cerca.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("No es el momento.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("Sigue esforzándote.", ClaseTipoRespuesta.Indecisa));
            normal.Add(new ClaseRespuesta("Tu esfuerzo será reconocido pronto.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Revisa bien los detalles antes de avanzar.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("Una oportunidad nueva se acerca.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Ten paciencia con tu equipo.", ClaseTipoRespuesta.Indecisa));

            List<ClaseRespuesta> mistico = new List<ClaseRespuesta>();
            mistico.Add(new ClaseRespuesta("Los astros favorecen tu ambición.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Una puerta se cierra para abrir otra mejor.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("El camino profesional aún se está trazando.", ClaseTipoRespuesta.Indecisa));
            mistico.Add(new ClaseRespuesta("La fortuna laboral llega con la próxima luna.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Las energías del lugar de trabajo están en tensión.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("Escucha tu intuición antes de decidir.", ClaseTipoRespuesta.Indecisa));
            mistico.Add(new ClaseRespuesta("Un mentor aparecerá en tu camino.", ClaseTipoRespuesta.Positiva));

            List<ClaseRespuesta> caotico = new List<ClaseRespuesta>();
            caotico.Add(new ClaseRespuesta("Pregúntale a la fotocopiadora, ella sabe más que yo.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Sí, pero renuncia primero por dramatismo.", ClaseTipoRespuesta.Positiva));
            caotico.Add(new ClaseRespuesta("El café se terminó, y con él tu suerte.", ClaseTipoRespuesta.Negativa));
            caotico.Add(new ClaseRespuesta("Consulta de nuevo después de la reunión eterna.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("El jefe también está confundido, tranquilo.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("No prometo nada, pero suena divertido.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Vuelve a preguntar cuando el WiFi de la oficina funcione.", ClaseTipoRespuesta.Indecisa));

            porNivel[ClaseNivelSabiduria.Normal] = normal;
            porNivel[ClaseNivelSabiduria.Mistico] = mistico;
            porNivel[ClaseNivelSabiduria.Caotico] = caotico;

            bancoRespuestas[ClaseCategoria.Trabajo] = porNivel;
        }
        private void CargarEstudios()
        {
            Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>> porNivel = new Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>>();

            List<ClaseRespuesta> normal = new List<ClaseRespuesta>();
            normal.Add(new ClaseRespuesta("Vas a aprobar.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Necesitas estudiar más.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("Inténtalo nuevamente.", ClaseTipoRespuesta.Indecisa));
            normal.Add(new ClaseRespuesta("Tu esfuerzo dará resultado.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Repasa los temas que más se te dificultan.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("Organiza mejor tu tiempo de estudio.", ClaseTipoRespuesta.Indecisa));
            normal.Add(new ClaseRespuesta("La constancia te llevará al éxito.", ClaseTipoRespuesta.Positiva));

            List<ClaseRespuesta> mistico = new List<ClaseRespuesta>();
            mistico.Add(new ClaseRespuesta("El conocimiento fluye hacia ti como un río.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Las musas del estudio aún no te visitan.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("El examen guarda secretos que debes descubrir.", ClaseTipoRespuesta.Indecisa));
            mistico.Add(new ClaseRespuesta("Tu mente está alineada con la sabiduría.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Una nube de distracción cubre tu enfoque.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("El tiempo dirá si el esfuerzo fue suficiente.", ClaseTipoRespuesta.Indecisa));
            mistico.Add(new ClaseRespuesta("Los libros antiguos aprueban tu camino.", ClaseTipoRespuesta.Positiva));

            List<ClaseRespuesta> caotico = new List<ClaseRespuesta>();
            caotico.Add(new ClaseRespuesta("Pregúntale a Google, yo solo soy una bola.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Sí, si memorizas todo en la madrugada.", ClaseTipoRespuesta.Positiva));
            caotico.Add(new ClaseRespuesta("El profesor también olvidó el tema, tranquilo.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("No estudiaste, pero la suerte podría ayudarte.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Consulta con tu compañero de al lado (con cuidado).", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("El examen se pospuso en otra dimensión.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Vuelve a preguntar cuando termine de reírme.", ClaseTipoRespuesta.Indecisa));

            porNivel[ClaseNivelSabiduria.Normal] = normal;
            porNivel[ClaseNivelSabiduria.Mistico] = mistico;
            porNivel[ClaseNivelSabiduria.Caotico] = caotico;

            bancoRespuestas[ClaseCategoria.Estudios] = porNivel;
        }
        private void CargarDinero()
        {
            Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>> porNivel = new Dictionary<ClaseNivelSabiduria, List<ClaseRespuesta>>();

            List<ClaseRespuesta> normal = new List<ClaseRespuesta>();
            normal.Add(new ClaseRespuesta("Una entrada extra viene en camino.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Cuidado con los gastos.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("Ahorra un poco más.", ClaseTipoRespuesta.Indecisa));
            normal.Add(new ClaseRespuesta("Una inversión dará buenos resultados.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Revisa bien antes de gastar.", ClaseTipoRespuesta.Negativa));
            normal.Add(new ClaseRespuesta("La estabilidad financiera está cerca.", ClaseTipoRespuesta.Positiva));
            normal.Add(new ClaseRespuesta("Es momento de planear un presupuesto.", ClaseTipoRespuesta.Indecisa));

            List<ClaseRespuesta> mistico = new List<ClaseRespuesta>();
            mistico.Add(new ClaseRespuesta("La fortuna llega en la próxima luna llena.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Las monedas del destino aún no caen a tu favor.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("El dinero fluye como el agua, ten paciencia.", ClaseTipoRespuesta.Indecisa));
            mistico.Add(new ClaseRespuesta("Un tesoro inesperado se asoma en tu camino.", ClaseTipoRespuesta.Positiva));
            mistico.Add(new ClaseRespuesta("Las sombras económicas se disipan pronto.", ClaseTipoRespuesta.Negativa));
            mistico.Add(new ClaseRespuesta("El universo pide prudencia con tus recursos.", ClaseTipoRespuesta.Indecisa));
            mistico.Add(new ClaseRespuesta("Los astros bendicen tus finanzas este mes.", ClaseTipoRespuesta.Positiva));

            List<ClaseRespuesta> caotico = new List<ClaseRespuesta>();
            caotico.Add(new ClaseRespuesta("Pregúntale a tu alcancía, ella guarda secretos.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Sí, si ganas la lotería primero.", ClaseTipoRespuesta.Positiva));
            caotico.Add(new ClaseRespuesta("El dinero se fue de vacaciones sin avisar.", ClaseTipoRespuesta.Negativa));
            caotico.Add(new ClaseRespuesta("Consulta con el cajero automático, es más sabio.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("No prometo riqueza, pero sí buenas vibras.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("Vuelve a preguntar después de revisar el sofá.", ClaseTipoRespuesta.Indecisa));
            caotico.Add(new ClaseRespuesta("El universo cobra intereses por tus dudas.", ClaseTipoRespuesta.Indecisa));

            porNivel[ClaseNivelSabiduria.Normal] = normal;
            porNivel[ClaseNivelSabiduria.Mistico] = mistico;
            porNivel[ClaseNivelSabiduria.Caotico] = caotico;

            bancoRespuestas[ClaseCategoria.Dinero] = porNivel;
        }
        public ClaseRespuesta GenerarRespuesta(ClaseCategoria categoria, ClaseNivelSabiduria nivel)
        {
            List<ClaseRespuesta> lista = bancoRespuestas[categoria][nivel];
            int numero = random.Next(lista.Count);
            return lista[numero];
        }
    }
}
