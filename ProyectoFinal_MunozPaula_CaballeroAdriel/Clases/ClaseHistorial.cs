using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel.Clases
{
    public class ClaseHistorial
    {
        private List<ClaseRegistroHistorial> registros;

        public ClaseHistorial()
        {
            registros = new List<ClaseRegistroHistorial>();
        }
        public void AgregarPregunta(ClaseUsuario usuario, ClasePregunta pregunta, ClaseRespuesta respuesta)
        {
            ClaseRegistroHistorial nuevoRegistro = new ClaseRegistroHistorial(usuario, pregunta, respuesta);

            registros.Add(nuevoRegistro);
        }

        public DataTable ObtenerComoDataTable()
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Origen");
            tabla.Columns.Add("Pregunta");
            tabla.Columns.Add("Respuesta");
            tabla.Columns.Add("Tipo");

            foreach (ClaseRegistroHistorial registro in registros)
            {
                tabla.Rows.Add(
                    registro.Usuario.Nombre,
                    registro.Pregunta.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    registro.Pregunta.OrigenCategoria,
                    registro.Pregunta.Texto,
                    registro.Respuesta.Texto,
                    registro.Respuesta.Tipo.ToString()
                );
            }

            return tabla;
        }

        public void ExportarComoCsv(string rutaArchivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo);

                escritor.WriteLine("Usuario,Fecha,Origen,Pregunta,Respuesta,Tipo");

                foreach (ClaseRegistroHistorial registro in registros)
                {
                    escritor.WriteLine(
                        registro.Usuario.Nombre + "," +
                        registro.Pregunta.Fecha + "," +
                        registro.Pregunta.OrigenCategoria + "," +
                        "\"" + registro.Pregunta.Texto + "\"," +
                        "\"" + registro.Respuesta.Texto + "\"," +
                        registro.Respuesta.Tipo
                    );
                }

                escritor.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(
                    "No se pudo exportar el historial.",
                    ex);
            }
        }
        public void EliminarRegistro(int indice)
        {
            if (indice >= 0 && indice < registros.Count)
            {
                registros.RemoveAt(indice);
            }
        }

        public int ObtenerTotalPreguntas()
        {
            return registros.Count;
        }

        public int ObtenerTotalPositivas()
        {
            int contador = 0;

            foreach (ClaseRegistroHistorial registro in registros)
            {
                if (registro.Respuesta.Tipo == ClaseTipoRespuesta.Positiva)
                {
                    contador++;
                }
            }

            return contador;
        }

        public int ObtenerTotalNegativas()
        {
            int contador = 0;

            foreach (ClaseRegistroHistorial registro in registros)
            {
                if (registro.Respuesta.Tipo == ClaseTipoRespuesta.Negativa)
                {
                    contador++;
                }
            }

            return contador;
        }

        public int ObtenerTotalIndecisas()
        {
            int contador = 0;

            foreach (ClaseRegistroHistorial registro in registros)
            {
                if (registro.Respuesta.Tipo == ClaseTipoRespuesta.Indecisa)
                {
                    contador++;
                }
            }

            return contador;
        }

        public string ObtenerCategoriaMasUsada()
        {
            int contadorClasico = 0;
            int contadorAmor = 0;
            int contadorTrabajo = 0;
            int contadorEstudios = 0;
            int contadorDinero = 0;

            foreach (ClaseRegistroHistorial registro in registros)
            {
                switch (registro.Pregunta.OrigenCategoria)
                {
                    case "Clásico":
                        contadorClasico++;
                        break;

                    case "Amor":
                        contadorAmor++;
                        break;

                    case "Trabajo":
                        contadorTrabajo++;
                        break;

                    case "Estudios":
                        contadorEstudios++;
                        break;

                    case "Dinero":
                        contadorDinero++;
                        break;
                }
            }

            int mayor = contadorClasico;
            string categoria = "Clásico";

            if (contadorAmor > mayor)
            {
                mayor = contadorAmor;
                categoria = "Amor";
            }

            if (contadorTrabajo > mayor)
            {
                mayor = contadorTrabajo;
                categoria = "Trabajo";
            }

            if (contadorEstudios > mayor)
            {
                mayor = contadorEstudios;
                categoria = "Estudios";
            }

            if (contadorDinero > mayor)
            {
                mayor = contadorDinero;
                categoria = "Dinero";
            }

            if (registros.Count == 0)
            {
                categoria = "Sin datos";
            }

            return categoria;
        }

        public List<ClaseRegistroHistorial> ObtenerRegistros()
        {
            return registros;
        }
    }
}
