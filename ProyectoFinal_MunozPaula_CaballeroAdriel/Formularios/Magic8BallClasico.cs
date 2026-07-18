using ProyectoFinal_MunozPaula_CaballeroAdriel.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_MunozPaula_CaballeroAdriel
{
    public partial class Magic8BallClasico : Form
    {
        // Objetos del formulario
        private ClaseLogicaClasico magicBall;
        private ClaseUsuario usuarioActivo;
        private ClaseHistorial historial;

        // Variables auxiliares
        private ClaseImagenRespuesta imagenRespuesta;
        private string preguntaActual;

        // Tiempo de espera (2 segundos)
        private const int TIEMPO_ANIMACION = 2000;
        public Magic8BallClasico(ClaseUsuario usuario, ClaseHistorial historialCompartido)
        {
            InitializeComponent();
            BackColor = ClaseConfiguracion.ColorFondo;
            usuarioActivo = usuario;
            historial = historialCompartido;
            btPreguntar.Enabled = false;
            tbPregunta.TextChanged += ValidarCampos;
            magicBall = new ClaseLogicaClasico();
            pbBola.Image = Properties.Resources.inicio;
            pbBola.SizeMode = PictureBoxSizeMode.Zoom;
            timerAgitar.Interval = TIEMPO_ANIMACION;
        }
        private void ValidarCampos(object sender, EventArgs e)
        {
            btPreguntar.Enabled = ValidarPregunta();
        }
        private bool ValidarPregunta()
        {
            if (tbPregunta.Text.Trim().Length < 5)
            {
                errorProvider1.SetError(tbPregunta, "Ingrese una pregunta válida.");
                return false;
            }

            errorProvider1.SetError(tbPregunta, "");

            return true;
        }
        private void btPreguntar_Click(object sender, EventArgs e)
        {
            try
            {
                preguntaActual = tbPregunta.Text.Trim();

                imagenRespuesta = magicBall.GenerarRespuesta();

                btPreguntar.Enabled = false;

                pbBola.Image = null;

                timerAgitar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerAgitar_Tick_1(object sender, EventArgs e)
        {
            timerAgitar.Stop();

            pbBola.SizeMode = PictureBoxSizeMode.Zoom;
            pbBola.Image = imagenRespuesta.Imagen;

            ClasePregunta pregunta = new ClasePregunta(
                preguntaActual,
                "Clásico");

            ClaseRespuesta respuesta = new ClaseRespuesta(
                "Respuesta visual",
                imagenRespuesta.Tipo);

            historial.AgregarPregunta(
                usuarioActivo,
                pregunta,
                respuesta);

            btPreguntar.Enabled = true;
        }
    }
}
