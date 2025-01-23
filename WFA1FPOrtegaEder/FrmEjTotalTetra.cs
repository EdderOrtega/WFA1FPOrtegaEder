using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA1FPOrtegaEder
{
    public partial class FrmEjTotalTetra : Form
    {
        public FrmEjTotalTetra()
        {
            InitializeComponent();
        }

        private void FrmEjTotalTetra_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaración de variables tipo int y double
            int inscripcion, mensualidad, licencias, libros, estacionamiento;
            double total;
            //asignación de valores a las variables
            inscripcion = int.Parse(txtInicial.Text);
            mensualidad = int.Parse(txtMensualidad.Text);
            licencias = int.Parse(txtLicencias.Text);
            libros = int.Parse(txtLibros.Text);
            estacionamiento = int.Parse(txtEstacionamiento.Text);
            //procesando la operación para obtener el total
            total = inscripcion + (mensualidad*3) + licencias + libros + estacionamiento;

            //mostrar resultados en la lista
            lstResultados.Items.Add("Inscripción: " + inscripcion.ToString("c"));
            lstResultados.Items.Add("Mensualidad: " + mensualidad.ToString("c"));
            lstResultados.Items.Add("Licencias: " + licencias.ToString("c"));
            lstResultados.Items.Add("Libros: " + libros.ToString("c"));
            lstResultados.Items.Add("Estacionamiento: " + estacionamiento.ToString("c"));
            lstResultados.Items.Add("Total: " + total.ToString("c"));


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Hide();
            principal.Show();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInicial_Click(object sender, EventArgs e)
        {

        }

        private void txtEstacionamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEstacionamiento.Clear();
            txtInicial.Clear();
            txtLibros.Clear();
            txtLicencias.Clear();
            txtMensualidad.Clear();
            lstResultados.Items.Clear();
            txtInicial.Focus();
        }
    }
}
