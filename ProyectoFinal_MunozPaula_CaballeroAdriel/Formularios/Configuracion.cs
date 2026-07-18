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
    public partial class Configuracion : Form
    {
        private ClaseHistorial historial;
        public Configuracion()
        {
            InitializeComponent();
            BackColor = ClaseConfiguracion.ColorFondo;
            cbTiempo.Items.Add("1 segundo");
            cbTiempo.Items.Add("2 segundos");
            cbTiempo.Items.Add("3 segundos");
            cbTiempo.Items.Add("5 segundos");

            switch (ClaseConfiguracion.TiempoRespuesta)
            {
                case 1000:
                    cbTiempo.SelectedIndex = 0;
                    break;

                case 2000:
                    cbTiempo.SelectedIndex = 1;
                    break;

                case 3000:
                    cbTiempo.SelectedIndex = 2;
                    break;

                case 5000:
                    cbTiempo.SelectedIndex = 3;
                    break;
            }

            switch (ClaseConfiguracion.ModoColor)
            {
                case 0:
                    rbModoVerde.Checked = true;
                    break;

                case 1:
                    rbModoRojo.Checked = true;
                    break;

                case 2:
                    rbModoAzul.Checked = true;
                    break;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (rbModoVerde.Checked)
            {
                ClaseConfiguracion.ModoColor = 0;
            }
            else if (rbModoRojo.Checked)
            {
                ClaseConfiguracion.ModoColor = 1;
            }
            else if (rbModoAzul.Checked)
            {
                ClaseConfiguracion.ModoColor = 2;
            }

            MessageBox.Show("Configuración guardada.");
        }

        private void btRestablecer_Click(object sender, EventArgs e)
        {
            ClaseConfiguracion.TiempoRespuesta = 2000;
            ClaseConfiguracion.ModoColor = 0;
            cbTiempo.SelectedIndex = 1;      // 2 segundos
            rbModoVerde.Checked = true;
            BackColor = ClaseConfiguracion.ColorFondo;
            MessageBox.Show("La configuración se ha restablecido.");
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
