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
            MessageBox.Show("Hola");
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
            int Inscripcion, mensualidad,licencias,libros,estacionamiento, total;


        }
    }
}
