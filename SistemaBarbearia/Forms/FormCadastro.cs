using SistemaBarbearia.Forms;

namespace SistemaBarbearia
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e, FormHorarios formHorarios)
        {
            FormHorarios FormHorarios = new FormHorarios();
            FormHorarios.Show();
            this.Close();
        }
    }
}
