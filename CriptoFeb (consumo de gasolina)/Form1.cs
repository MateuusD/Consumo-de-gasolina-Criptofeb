namespace CriptoFeb__consumo_de_gasolina_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double kmPercorrido;
            double kmConsumo;
            double totalCusto;
            double kmGasolina;
            kmPercorrido = Convert.ToDouble(txtKilometros.Text);
            kmConsumo = Convert.ToDouble(txtConsumo.Text);
            kmGasolina = Convert.ToDouble(txtGasolina.Text);

            totalCusto = (kmPercorrido / kmConsumo) * kmGasolina;
            txtCusto.Text = Convert.ToString(totalCusto);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}