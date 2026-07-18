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
    public partial class Magic8BallCategorias : Form
    {
        private ClaseLogicaCategorias magicBall;
        private ClaseUsuario usuarioActivo;
        private ClaseHistorial historial;
        private ClaseCategoria categoriaSeleccionada;
        private ClaseRespuesta respuestaGenerada;
        private string preguntaActual;
        private const int TIEMPO_ANIMACION = 2000;

        public Magic8BallCategorias(ClaseUsuario usuario, ClaseHistorial historialCompartido)
        {
            InitializeComponent();
            BackColor = ClaseConfiguracion.ColorFondo;
            magicBall = new ClaseLogicaCategorias();
            usuarioActivo = usuario;
            historial = historialCompartido;
            timerAgitar.Interval = TIEMPO_ANIMACION;
            btPreguntar.Enabled = false;
            AsignarTagsCategorias();
            CargarNivelesSabiduria();
        }
        private void AsignarTagsCategorias()
        {
            rbAmor.Tag = ClaseCategoria.Amor;
            rbTrabajo.Tag = ClaseCategoria.Trabajo;
            rbEstudios.Tag = ClaseCategoria.Estudios;
            rbDinero.Tag = ClaseCategoria.Dinero;
        }
        private void ValidarCampos(object sender, EventArgs e)
        {
            btPreguntar.Enabled = ValidarPregunta() && ValidarCategoria();
        }
        private void CargarNivelesSabiduria()
        {
            cbNiveles.DataSource = Enum.GetValues(typeof(ClaseNivelSabiduria));
        }
        private void ActualizarCategoriaSeleccionada(object sender)
        {
            RadioButton radio = sender as RadioButton;

            if (radio != null && radio.Checked)
            {
                categoriaSeleccionada = (ClaseCategoria)radio.Tag;
            }
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
        private bool ValidarCategoria()
        {
            if (!rbAmor.Checked && !rbTrabajo.Checked && !rbEstudios.Checked && !rbDinero.Checked)
            {
                errorProvider1.SetError(gbCategorias, "Seleccione una categoría.");
                return false;
            }
            errorProvider1.SetError(gbCategorias, "");
            return true;
        }
        private void btPreguntar_Click(object sender, EventArgs e)
        {
            try
            {
                preguntaActual = tbPregunta.Text.Trim();
                ClaseNivelSabiduria nivel = (ClaseNivelSabiduria)cbNiveles.SelectedItem;
                respuestaGenerada = magicBall.GenerarRespuesta(categoriaSeleccionada, nivel);
                lbRespuesta.Text = "Pensando...";
                btPreguntar.Enabled = false;
                timerAgitar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerAgitar_Tick_1(object sender, EventArgs e)
        {
            string texto = respuestaGenerada.Texto;

            switch ((ClaseNivelSabiduria)cbNiveles.SelectedItem)
            {
                case ClaseNivelSabiduria.Mistico:
                    texto += " ✨";
                    break;

                case ClaseNivelSabiduria.Caotico:
                    texto += " 😈";
                    break;
            }
            lbRespuesta.Text = texto;
            ClasePregunta pregunta = new ClasePregunta(preguntaActual, categoriaSeleccionada.ToString());
            historial.AgregarPregunta(usuarioActivo, pregunta, respuestaGenerada);
            ValidarCampos(null, null);
        }

        private void rbAmor_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCampos(sender, e);
            ActualizarCategoriaSeleccionada(sender);
        }

        private void rbEstudios_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCampos(sender, e);
            ActualizarCategoriaSeleccionada(sender);
        }

        private void rbTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCampos(sender, e);
            ActualizarCategoriaSeleccionada(sender);
        }

        private void rbDinero_CheckedChanged(object sender, EventArgs e)
        {
            ValidarCampos(sender, e);
            ActualizarCategoriaSeleccionada(sender);
        }

        private void tbPregunta_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos(sender, e);
        }
    }
}
