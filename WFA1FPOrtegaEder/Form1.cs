namespace WFA1FPOrtegaEder
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTotalTetra_Click(object sender, EventArgs e)
        {
            FrmEjTotalTetra totalTetra = new FrmEjTotalTetra();
            this.Hide();
            totalTetra.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmEJ1Nomina nomina = new FrmEJ1Nomina();
            this.Hide();
            nomina.Show();
        }

        private void btnEj2Parqu_Click(object sender, EventArgs e)
        {
            FrmEj2Parque parque = new FrmEj2Parque();
            this.Hide();
            parque.Show();
        }

        private void btnTotalAPagar_Click(object sender, EventArgs e)
        {
            FrmEj3TotalPagar totalPagar = new FrmEj3TotalPagar();
            this.Hide();
            totalPagar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar el programa");
            this.Hide();
            Application.Exit();
        }
    }
} 
