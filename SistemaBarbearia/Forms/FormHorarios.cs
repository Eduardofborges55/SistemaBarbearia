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
    public partial class FormHorarios : Form
    {
        public FormHorarios()
        {
            InitializeComponent();
        }

        private void FormHorarios_Load(object sender, EventArgs e)
        {
            // Código que você quiser executar quando o formulário abrir
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO medicamentos 
                          (Horarios, Nome, Tipo, Preco) 
                          VALUES 
                          (@horarios @nome, @tipo , @preco)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@horarios", txtHorarios.Text);
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                    cmd.Parameters.AddWithValue("@preco", decimal.Parse(txtPreco.Text)); ;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medicamento salvo com sucesso!");

                    // Limpar campos
                    txtHorarios.Clear();
                    txtNome.Clear();
                    txtTipo.Clear();
                    txtPreco.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }



        private void txtHorarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        FormVisualizar formVisualizar = new FormVisualizar();
        formVisualizar.Show();
        }
    }
}
