using MySql.Data.MySqlClient;
using SistemaFarmacia.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBarbearia.Forms
{
    public partial class FormVisualizar : Form
    {
        public FormVisualizar()
        {
            InitializeComponent();
        }

        private void FormVisualizar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregarMedicamentos()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = "SELECT Id, Horarios, nome, tipo, preco from Serviços";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewListadodia.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Serviços: " + ex.Message);
            }
        }
    }
}
