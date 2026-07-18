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
    public partial class Estadisticas : Form
    {
        private ClaseHistorial historialCompartido;
        public Estadisticas(ClaseHistorial historial)
        {
            InitializeComponent();
            BackColor = ClaseConfiguracion.ColorFondo;
            historialCompartido = historial;
            MostrarEstadisticas();
        }
        private void MostrarEstadisticas()
        {
            try
            {
                lbTotalPreguntas.Text = "Total de preguntas: " + historialCompartido.ObtenerTotalPreguntas();
                lbPositivas.Text = "Respuestas positivas: " + historialCompartido.ObtenerTotalPositivas();
                lbNegativas.Text = "Respuestas negativas: " + historialCompartido.ObtenerTotalNegativas();
                lbIndecisas.Text = "Respuestas indecisas: " + historialCompartido.ObtenerTotalIndecisas();
                lbCategoria.Text = "Categoría más usada: " + historialCompartido.ObtenerCategoriaMasUsada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
