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
            using (var conexao = Conexao.ObterConexao())
            {
                try
                {
                    string sql = "SELECT * FROM Servicos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewListadodia.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                try
                {
                    string sql = "SELECT * FROM Servicos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewListadodia.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }
    }
}
