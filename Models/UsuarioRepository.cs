using System.Collections.Generic;
using MySqlConnector;
namespace PortifolioMVC.Models
{
    public class UsuarioRepository : Repository
    {
     public void Insert(Usuario novoUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "INSERT INTO USUARIO(nomeusuario, login, senha, tipousuario) VALUES (@nomeusuario, @login, @senha, @tipousuario)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nomeusuario", novoUsuario.nomeusuario);
            comando.Parameters.AddWithValue("@login", novoUsuario.login);
            comando.Parameters.AddWithValue("@senha", novoUsuario.senha);
            comando.Parameters.AddWithValue("@tipousuario", novoUsuario.tipousuario);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public List<Usuario> Query()
            {
                MySqlConnection conexao = new MySqlConnection(_strConexao);
                conexao.Open();
                string sql = "SELECT * FROM USUARIO ORDER BY idusuario";
                MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
                MySqlDataReader reader = comandoQuery.ExecuteReader();
                List<Usuario> lista = new List<Usuario>();
                while (reader.Read())
                {
                    Usuario usr = new Usuario();
                    usr.idusuario = reader.GetInt32("idusuario");
                
                    if(!reader.IsDBNull(reader.GetOrdinal("nomeusuario")))
                        usr.nomeusuario = reader.GetString("nomeusuario");

                    
                    if(!reader.IsDBNull(reader.GetOrdinal("login")))
                        usr.login = reader.GetString("login");

                     if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                        usr.senha = reader.GetString("senha");

                     if(!reader.IsDBNull(reader.GetOrdinal("tipousuario")))
                        usr.tipousuario = reader.GetString("tipousuario");                        
                    lista.Add(usr);
                }
                conexao.Close();
                return lista;
            }

        public void Atualizar(Usuario novoUsuario)
                    {
                        MySqlConnection conexao = new MySqlConnection(_strConexao);
                        conexao.Open();
                        string sql = "UPDATE USUARIO SET nomeusuario=@nomeusuario,  login=@login, senha=@senha, tipousuario=@tipousuario WHERE idusuario=@idusuario";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@nomeusuario", novoUsuario.nomeusuario);
                        comando.Parameters.AddWithValue("@login", novoUsuario.login);
                        comando.Parameters.AddWithValue("@senha", novoUsuario.senha);
                        comando.Parameters.AddWithValue("@tipo", novoUsuario.tipousuario);
                        comando.Parameters.AddWithValue("@idusuario", novoUsuario.idusuario);
                        comando.ExecuteNonQuery();
                        conexao.Close();            
                    }
        
         public void Remover(int Id)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "DELETE FROM USUARIO WHERE idusuario=@idusuario";
            MySqlCommand Comando = new MySqlCommand(sql, conexao);
            Comando.Parameters.AddWithValue("@idusuario", Id);
            Comando.ExecuteNonQuery();
            conexao.Close();  
        }

        public Usuario BuscarPorId(int Id)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM usuario WHERE idusuario=@idusuario";
            MySqlCommand Comando = new MySqlCommand(sql, conexao);
            Comando.Parameters.AddWithValue("@idusuario", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario UsuarioEncontrado = new Usuario();

            if(Reader.Read())
            {
                UsuarioEncontrado.idusuario = Reader.GetInt32("idusuario");
                
                if(!Reader.IsDBNull(Reader.GetOrdinal("nomeusuario")))
                    UsuarioEncontrado.nomeusuario = Reader.GetString("nomeusuario");
                if(!Reader.IsDBNull(Reader.GetOrdinal("login")))                    
                    UsuarioEncontrado.login = Reader.GetString("login");
                if(!Reader.IsDBNull(Reader.GetOrdinal("senha")))                    
                    UsuarioEncontrado.senha = Reader.GetString("senha");
            }
            conexao.Close();
            return UsuarioEncontrado;            
        }

        public Usuario QueryLogin(Usuario u)
            {
                MySqlConnection conexao = new MySqlConnection(_strConexao);
                conexao.Open();
                string sql = "SELECT * FROM USUARIO WHERE login = @login AND senha = @senha";
                MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
                comandoQuery.Parameters.AddWithValue("@Login", u.login);
                comandoQuery.Parameters.AddWithValue("@Senha", u.senha);
                MySqlDataReader reader = comandoQuery.ExecuteReader();
                Usuario usr = null;
                if(reader.Read())
                {
                    usr = new Usuario();
                    usr.idusuario = reader.GetInt32("idusuario");
                    if(!reader.IsDBNull(reader.GetOrdinal("nomeusuario")))
                        usr.nomeusuario = reader.GetString("nomeusuario");
                         if(!reader.IsDBNull(reader.GetOrdinal("tipousuario")))
                        usr.tipousuario = reader.GetString("tipousuario");
                
                    if(!reader.IsDBNull(reader.GetOrdinal("login")))
                        usr.login = reader.GetString("login");


                   
                    if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                        usr.senha = reader.GetString("senha");

                   
                }
            
                conexao.Close();
                return usr;
            }

        
    }
}