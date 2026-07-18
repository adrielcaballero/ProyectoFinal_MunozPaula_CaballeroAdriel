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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            BackColor = ClaseConfiguracion.ColorFondo;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            btIngresar.Enabled = false;
            tbNombre.TextChanged += ValidarCampos;
        }
        private void AplicarFuente(Control control)
        {
            foreach (Control c in control.Controls)
            {
                AplicarFuente(c);
            }
        }
        private void ValidarCampos(object sender, EventArgs e)
        {
            btIngresar.Enabled = ValidarNombre();
        }
        private bool ValidarNombre()
        {
            if (tbNombre.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(tbNombre, "Ingrese un nombre válido.");
                return false;
            }

            foreach (char letra in tbNombre.Text)
            {
                if (char.IsDigit(letra))
                {
                    errorProvider1.SetError(tbNombre, "El nombre no puede contener números.");
                    return false;
                }
            }

            errorProvider1.SetError(tbNombre, "");

            return true;
        }
        private void btIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseUsuario usuarioActivo = new ClaseUsuario(tbNombre.Text.Trim());

                ClaseHistorial historial = new ClaseHistorial();

                MenuPrincipal menu = new MenuPrincipal(usuarioActivo, historial);

                Hide();
                menu.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AbrirMenuPrincipal(ClaseUsuario usuarioActivo, ClaseHistorial historialCompartido)
        {
            MenuPrincipal menu = new MenuPrincipal(usuarioActivo, historialCompartido);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btIngresar.PerformClick();
            }
        }
      
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
