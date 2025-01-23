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
    public partial class FrmEJ1Nomina : Form
    {
        public FrmEJ1Nomina()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Hide();
            principal.Show();
        }

        private void lblSueldoDiario_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /* 
             Subtotal (sueldo base diario * 30)
            IMSS (5%)
            ISR (10%)
            Bonos Despensa (2%)
            Premio Puntualidad (5%)
            ISPT (8%)
            Fondo de Ahorro (6%)
            SubTotal de Percepciones (Subtotal +Bonos + Premio Puntualidad)
            SubTotal de Deducciones (suma de los demás conceptos)
            Total a Pagar (Subtotal de Percepciones - Subtotal de Deducciones)
             */
            int sueldoDiario;
            sueldoDiario = int.Parse(txtSueldoDiario.Text);
            double imss, isr, ispt, fondo, subTotalDeducciones, premio, bono, subtotal, subtotalPercepciones, totalAPagar;
            subtotal = sueldoDiario * 30;
            imss = subtotal * 0.05;
            isr = subtotal * 0.10;
            bono = subtotal * 0.02;
            premio = subtotal * 0.05;
            ispt = subtotal * 0.08;
            fondo = subtotal * 0.06;
            subtotalPercepciones = subtotal + bono + premio;
            subTotalDeducciones = imss + isr + ispt + fondo;
            totalAPagar = subtotalPercepciones - subTotalDeducciones;

            listNomina.Items.Add("sueldo diario: " + sueldoDiario.ToString("c"));
            listNomina.Items.Add("Subtotal: " + subtotal.ToString("c"));
            listNomina.Items.Add("IMSS: " + imss.ToString("c"));
            listNomina.Items.Add("ISR: " + isr.ToString("c"));
            listNomina.Items.Add("Bonos: " + bono.ToString("c"));
            listNomina.Items.Add("Premio Puntualidad: " + premio.ToString("c"));
            listNomina.Items.Add("ISPT: " + ispt.ToString("c"));
            listNomina.Items.Add("Fondo de Ahorro: " + fondo.ToString("c"));
            listNomina.Items.Add("Subtotal de Percepciones: " + subtotalPercepciones.ToString("c"));
            listNomina.Items.Add("Subtotal de Deducciones: " + subTotalDeducciones.ToString("c"));
            listNomina.Items.Add("Total a Pagar: " + totalAPagar.ToString("c"));

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldoDiario.Clear();
            listNomina.Items.Clear();
            txtSueldoDiario.Focus();
        }
    }
}
