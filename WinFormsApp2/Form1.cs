namespace WinFormsApp2
{
    public partial class FormValidaCampos : Form
    {
        private ErrorProvider _errorProvider;
        public FormValidaCampos()
        {
            InitializeComponent();
            _errorProvider = new ErrorProvider();  
            _errorProvider.BlinkRate = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _errorProvider.SetError(txtConfirmarSenha, "Senha Obrigatorio");
        }
    }
}
