namespace Cronometro
{
    public partial class frmCronometro : Form
    {
        int segundos = 0;
        int minutos = 0;
        public frmCronometro()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrCronometro.Enabled = true;
            tmrCronometro.Start();
        }

        private void tmrCronometro_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }

            lblCronometro.Text = $"{minutos:00}:{segundos:00}";
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrCronometro.Stop();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            segundos = 0;
            minutos = 0;
            lblCronometro.Text = "00:00";
        }
    }
}
