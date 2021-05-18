using MySqlConnector;
namespace PortifolioMVC.Models
{
    public class Repository
    {
        protected const string _strConexao = "Database=PORTIFOLIO;Data Source=localhost;UserId=root;Password=root;";
        //protected const string _strConexao = "Database=PORTIFOLIO;Data Source=localhost;UserId=root; Password=root;";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}