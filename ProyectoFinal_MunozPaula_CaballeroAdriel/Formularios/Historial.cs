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
    public partial class Historial : Form
    {
        private ClaseHistorial historial;
        public Historial(ClaseHistorial historialCompartido)
        {
            InitializeComponent();
            BackColor = ClaseConfiguracion.ColorFondo;
            historial = historialCompartido;
            CargarHistorial();
        }
        private void CargarHistorial()
        {
            dgvHistorial.DataSource = historial.ObtenerComoDataTable();
            dgvHistorial.ReadOnly = true;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string texto = tbBuscar.Text.Trim().ToLower();
            DataTable tablaOriginal = historial.ObtenerComoDataTable();
            DataTable tablaNueva = tablaOriginal.Clone();
            foreach (DataRow fila in tablaOriginal.Rows)
            {
                bool encontrado = false;
                foreach (object dato in fila.ItemArray)
                {
                    if (dato.ToString().ToLower().Contains(texto))
                    {
                        encontrado = true;
                    }
                }
                if (encontrado)
                {
                    tablaNueva.ImportRow(fila);
                }
            }
            dgvHistorial.DataSource = tablaNueva;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro.");

                return;
            }
            DialogResult respuesta =
                MessageBox.Show("¿Deseas eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                int fila = dgvHistorial.SelectedRows[0].Index;
                historial.EliminarRegistro(fila);
                CargarHistorial();
            }
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo CSV|*.csv";
            guardar.FileName = "Historial.csv";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    historial.ExportarComoCsv(guardar.FileName);
                    MessageBox.Show("Historial exportado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}