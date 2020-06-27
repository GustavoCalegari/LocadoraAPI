using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LocadoraAPI.Models
{
    public class Locacoes
    {
        public int idLocacao { get; set; }
        public int idCliente { get; set; }
        public int idFilme { get; set; }
        public DateTime dataLocacao { get; set; }
        public DateTime dataDevolucao { get; set; }

        public Locacoes() { }

        public string cadastraLocador(int idCliente, int idFilme, DateTime dataLocacao, DateTime dataDevolucao)
        {

            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();

                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "INSERT INTO Locacoes(idCliente,idFilme,dataLocacao,dataDevolucao) VALUES(@idCliente,@idFilme,@dataLocacao,@dataDevolucao)";
                cmm.Parameters.AddWithValue("@idCliente", idCliente);
                cmm.Parameters.AddWithValue("@idFilme", idFilme);
                cmm.Parameters.AddWithValue("@dataLocacao", dataLocacao);
                cmm.Parameters.AddWithValue("@dataDevolucao", dataDevolucao);

                cmm.ExecuteNonQuery();

                cnn.Desconectar();

                return "Cadastro efetuado com sucesso";
            }
            catch
            {
                return "Ocorreu um erro ao tentar realizar o cadastro";
            }
        }

        public List<Locacoes> retornarLocacoes()
        {
            List<Locacoes> locacoes = new List<Locacoes>();
            Locacoes locador = new Locacoes();
            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();

                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM Locacoes";

                SqlDataReader dr = cmm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        locador.idLocacao = Convert.ToInt32(dr["idLocacao"]);
                        locador.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                        locador.idFilme = Convert.ToInt32(dr["idFilme"].ToString());
                        locador.dataLocacao = Convert.ToDateTime(dr["dataLocacao"]);
                        locador.dataDevolucao = Convert.ToDateTime(dr["dataDevolucao"]);

                        locacoes.Add(locador);
                    }

                    dr.Close();
                    cnn.Desconectar();
                }

                return locacoes;

            }
            catch
            {
                throw;
            }
        }

        public List<Locacoes> retornarLocacao(int id)
        {
            List<Locacoes> locacoes = new List<Locacoes>();
            Locacoes locador = new Locacoes();
            try
            {
                Conexao cnn = new Conexao();
                SqlCommand cmm = new SqlCommand();

                cmm.Connection = cnn.Conectar();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM Locacoes WHERE idLocacao = @idLocacao";
                cmm.Parameters.AddWithValue("@idLocacao", id);

                SqlDataReader dr = cmm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        locador.idLocacao = Convert.ToInt32(dr["idLocacao"]);
                        locador.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                        locador.idFilme = Convert.ToInt32(dr["idFilme"].ToString());
                        locador.dataLocacao = Convert.ToDateTime(dr["dataLocacao"]);
                        locador.dataDevolucao = Convert.ToDateTime(dr["dataDevolucao"]);

                        locacoes.Add(locador);
                    }

                    dr.Close();
                    cnn.Desconectar();
                }

                return locacoes;

            }
            catch
            {
                throw;
            }
        }
    }
}