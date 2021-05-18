using System.Collections.Generic;
using MySqlConnector;

namespace PortifolioMVC.Models
{
    public class AulaRepository : Repository
    {
        public void Insert(Aula novaAula)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "INSERT INTO AULA(Nome, ImagemUrl, VideoUrl, Duracao, Preco) VALUES (@Nome, @ImagemUrl, @VideoUrl, @Duracao, @Preco)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", novaAula.Nome);
            comando.Parameters.AddWithValue("@ImagemUrl", novaAula.ImagemUrl);
            comando.Parameters.AddWithValue("@VideoUrl", novaAula.VideoUrl);
            comando.Parameters.AddWithValue("@Duracao", novaAula.Duracao);
            comando.Parameters.AddWithValue("@Preco", novaAula.Preco);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public List<Aula> Query()
        {
            conexao.Open();

            string sql = "SELECT * FROM AULA ";

            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);

            MySqlDataReader reader = comandoQuery.ExecuteReader();
            List<Aula> lista = new List<Aula>();

            while (reader.Read())
            {
                Aula aula = new Aula();

                if(!reader.IsDBNull(reader.GetOrdinal("idaula")))
                aula.idaula = reader.GetInt32("idaula");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                aula.Nome = reader.GetString("Nome");

                if(!reader.IsDBNull(reader.GetOrdinal("ImagemUrl")))
                aula.ImagemUrl = reader.GetString("ImagemUrl");

                if(!reader.IsDBNull(reader.GetOrdinal("VideoUrl")))
                aula.VideoUrl = reader.GetString("VideoUrl");

                if(!reader.IsDBNull(reader.GetOrdinal("Duracao")))
                aula.Duracao = reader.GetInt32("Duracao");

                if(!reader.IsDBNull(reader.GetOrdinal("Preco")))
                aula.Preco = reader.GetDouble("Preco");

                lista.Add(aula);
            }

            conexao.Close();
            return lista;
        }

         public void Atualizar(Aula novaAula)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "UPDATE AULA SET Nome=@Nome, ImagemUrl=@ImagemUrl, VideoUrl=@VideoUrl, Duracao=@Duracao, Preco=@Preco WHERE idaula=@idaula";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", novaAula.Nome);
            comando.Parameters.AddWithValue("@ImagemUrl", novaAula.ImagemUrl);
            comando.Parameters.AddWithValue("@VideoUrl", novaAula.VideoUrl);
            comando.Parameters.AddWithValue("@Duracao", novaAula.Duracao);
            comando.Parameters.AddWithValue("@Preco", novaAula.Preco);
            comando.Parameters.AddWithValue("@idaula", novaAula.idaula);
            comando.ExecuteNonQuery();
            conexao.Close();            
        }

         public void Remover(int Id)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "DELETE FROM AULA WHERE idaula=@idaula";
            MySqlCommand Comando = new MySqlCommand(sql, conexao);
            Comando.Parameters.AddWithValue("@idaula", Id);
            Comando.ExecuteNonQuery();
            conexao.Close();  
        }

         public Aula BuscarPorId(int Id)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM aula WHERE idaula=@idaula";
            MySqlCommand Comando = new MySqlCommand(sql, conexao);
            Comando.Parameters.AddWithValue("@idaula", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();

            Aula aula= new Aula();

            if(Reader.Read())
            {
                aula.idaula = Reader.GetInt32("idaula");
                
               if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                aula.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("ImagemUrl")))
                aula.ImagemUrl= Reader.GetString("ImagemUrl");

                if (!Reader.IsDBNull(Reader.GetOrdinal("VideoUrl")))
                aula.VideoUrl = Reader.GetString("VideoUrl");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Duracao")))
                aula.Duracao= Reader.GetInt32("Duracao");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Preco")))
                aula.Preco = Reader.GetDouble("Preco");

            }
            conexao.Close();
            return aula;            
        }
    }
}