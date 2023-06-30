namespace Generador_de_contraseñas
{
    public partial class Form1 : Form
    {
        Random _aleatorio = new Random();

        static string mayusList = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        static string minusList = "abcdefghijklmnñopqrstuvwxyz";
        static string numeroList = "0123456789";
        static string simbolList = " !#$%&'()*+,-./:;<=>?@[]^_`{|}~";

        string CaracteresList = string.Empty;
        public Form1()
        {
            InitializeComponent();
            txtTamanoContra.Text = "20";
        }
        private void ConstruirLista()
        {
            CaracteresList = string.Empty;

            if (chkMayus.Checked)
                CaracteresList += mayusList;
            if (chkMinus.Checked)
                CaracteresList += minusList;
            if (chkNum.Checked)
                CaracteresList += numeroList;
            if (chkSimbol.Checked)
                CaracteresList += simbolList;

            if (string.IsNullOrEmpty(CaracteresList))
                CaracteresList = minusList + mayusList + numeroList + simbolList;

        }

        private string GenerarContra(int lenght)
        {
            string nuevaContra = string.Empty;
            if (lenght < 6)
                throw new Exception("Una contraseña fuerte necesita mas de 6 caracteres");

            for (int i = 0; i < lenght; i++)
            {
                nuevaContra += CaracterAleatorio();
            }
            return nuevaContra;
        }

        private string CaracterAleatorio()
        {
            return CaracteresList.ToCharArray()[(int)Math.Floor(_aleatorio.NextDouble() * CaracteresList.Length)].ToString();
        }
        private void btnGC_Click(object sender, EventArgs e)
        {
            try 
            {
                ConstruirLista();
                txtNuevaContra.Text = GenerarContra(int.Parse(txtTamanoContra.Text));
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtTamanoContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
              
        }
    }
}