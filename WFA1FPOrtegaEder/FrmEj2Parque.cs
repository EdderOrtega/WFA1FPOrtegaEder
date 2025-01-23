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
    public partial class FrmEj2Parque : Form
    {
        public FrmEj2Parque()
        {
            InitializeComponent();
        }
        /* 
        Calcula el total a pagar por la entrada de un grupo
        de personas a un parque de diversiones. 
        Se debe recibir la cantidad de personas con 
        boletos tipo 1 ($90.00), la cantidad para 
        boletos tipo 2 ($150.00) y la cantidad para 
        boletos tipo 3 ($190.00). Al terminar muestra los importes 
        de los siguientes datos:*/
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int boleto1, boleto2, boleto3, cantidadPersonas;
            double subtotal, descuento, total;

            boleto1 = int.Parse(txtb1.Text);
            boleto2 = int.Parse(txtb2.Text);
            boleto3 = int.Parse(txtb3.Text);

            cantidadPersonas = boleto1 + boleto2 + boleto3;
            double sub1,sub2, sub3;
            sub1 = boleto1 * 90;
            sub2 = boleto2 * 150;
            sub3 = boleto3 * 190;
            subtotal = sub1 + sub2 + sub3;
            descuento = subtotal * 0.5;
            total = subtotal - descuento;

            

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
