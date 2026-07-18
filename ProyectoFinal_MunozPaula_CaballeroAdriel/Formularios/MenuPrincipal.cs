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
    public partial class MenuPrincipal : Form
    {
        private ClaseUsuario usuarioActivo;
        private ClaseHistorial historialCompartido;
        public MenuPrincipal(ClaseUsuario usuario, ClaseHistorial historial)
        {
            InitializeComponent();
            BackColor = ClaseConfiguracion.ColorFondo;
            usuarioActivo = usuario;
            historialCompartido = historial;
            lbSaludo.Text = "Hola " + usuarioActivo.Nombre;
        }

        private void btClasico_Click(object sender, EventArgs e)
        {
            Magic8BallClasico formulario = new Magic8BallClasico(usuarioActivo, historialCompartido);
            formulario.ShowDialog();
        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            Magic8BallCategorias formulario = new Magic8BallCategorias(usuarioActivo, historialCompartido);
            formulario.ShowDialog();
        }

        private void btHistorial_Click(object sender, EventArgs e)
        {
            Historial formulario = new Historial(historialCompartido);
            formulario.ShowDialog();
        }

        private void btEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas formulario = new Estadisticas(historialCompartido);
            formulario.ShowDialog();
        }

        private void btConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion formulario = new Configuracion();
            formulario.ShowDialog();
            BackColor = ClaseConfiguracion.ColorFondo;
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
