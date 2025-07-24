using MySql.Data.MySqlClient;

namespace SistemaFarmacia.Database
{
    public class Conexao
    {
        private const string connectionString = "server=mysql-database-estudo.alwaysdata.net;port=3306;database=database-estudo_fb;user=410621;password=Dado_980106523;";

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }
    }
}