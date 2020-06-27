using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocadoraAPI.Models
{
    public class Filme
    {
        public int idFilme { get; set; }
        public string nome { get; set; }
        public string genero { get; set; }
        public bool disponivel { get; set; }

        public Filme()
        {
        }

        public string cadastrarFilme(string nomeFilme, string generoFilme, bool disponivel)
        {
            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();


                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "INSERT INTO Filmes(nome,genero,disponivel,habilitado) VALUES(@nome,@genero,@disponivel,@habilitado)";
                cmm.Parameters.AddWithValue("@nome", nomeFilme);
                cmm.Parameters.AddWithValue("@genero", generoFilme);
                cmm.Parameters.AddWithValue("@disponivel", disponivel);
                cmm.Parameters.AddWithValue("@habilitado", 1);
                cmm.ExecuteNonQuery();

                cnn.Desconectar();

                return "Filme cadastrado com sucesso";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Ocorreu um erro ao tentar cadastrar o filme";
            }
        }

        public List<Filme> retornarFilmes()
        {
            List<Filme> filmes = new List<Filme>();
            Filme filme = new Filme();
            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();

                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM Filmes";

                SqlDataReader dr = cmm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        filme.idFilme = Convert.ToInt32(dr["idFilme"]);
                        filme.nome = dr["nome"].ToString();
                        filme.genero = dr["genero"].ToString();
                        filme.disponivel = Convert.ToBoolean(dr["disponivel"]);

                        filmes.Add(filme);
                    }

                    dr.Close();
                    cnn.Desconectar();
                }

                return filmes;

            }
            catch
            {
                throw;
            }
        }

        public List<Filme> retornarFilme(int id)
        {
            List<Filme> filmes = new List<Filme>();
            Filme filme = new Filme();
            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();

                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM Filmes WHERE idFilme = @idFilme";
                cmm.Parameters.AddWithValue("@idFilme", id);

                SqlDataReader dr = cmm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        filme.idFilme = Convert.ToInt32(dr["idFilme"]);
                        filme.nome = dr["nome"].ToString();
                        filme.genero = dr["genero"].ToString();
                        filme.disponivel = Convert.ToBoolean(dr["disponivel"]);

                        filmes.Add(filme);
                    }

                    dr.Close();
                    cnn.Desconectar();
                }

                return filmes;

            }
            catch
            {
                throw;
            }
        }

        public string excluirFilme(int id)
        {
            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();

                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "UPDATE Filmes SET habilitado = 0 WHERE idFilme = @idFilme";
                cmm.Parameters.AddWithValue("@idFilme", id);
                cmm.ExecuteNonQuery();

                cnn.Desconectar();
                return "Deletado com sucesso";

            }
            catch
            {
                return "Não foi possível deletar";
            }
        }

        public string atualizarFilme(int id, string nome, string genero)
        {
            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();

                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "UPDATE Filmes SET nome = @nome, genero = @genero WHERE idFilme = @idFilme";
                cmm.Parameters.AddWithValue("@idFilme", id);
                cmm.Parameters.AddWithValue("@nome", nome);
                cmm.Parameters.AddWithValue("@genero", genero);
                cmm.ExecuteNonQuery();

                cnn.Desconectar();

                return "Filme atualizado com sucesso";

            }
            catch
            {
                return "Não foi possível atualizar o filme";
            }
        }
    }
}