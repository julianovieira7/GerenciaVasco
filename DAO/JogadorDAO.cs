    using GerenciaVasco.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaVasco.DAO
{
    class JogadorDAO : Conexao
    {
        SqlCommand comando = null;

        public void Create(Jogador jogador) {
            try
            {
                Conectar();
                comando = new SqlCommand("INSERT INTO Jogador(nome, posicao, numero_camisa, perna_boa, fim_contrato, cep, endereco1, complemento, cidade, bairro, estado) VALUES (@nome, @posicao, @numeroCamisa, @pernaBoa, @fimContrato, @cep, @endereco1, @complemento, @cidade, @bairro, @estado)", conexao);
                comando.Parameters.AddWithValue("@nome", jogador.Nome);
                comando.Parameters.AddWithValue("@posicao", jogador.Posicao);
                comando.Parameters.AddWithValue("@numeroCamisa", jogador.NumeroCamisa);
                comando.Parameters.AddWithValue("@pernaBoa", jogador.PernaBoa);
                comando.Parameters.AddWithValue("@fimContrato", jogador.FimContrato);
                comando.Parameters.AddWithValue("@cep", jogador.Endereco.Cep);
                comando.Parameters.AddWithValue("@endereco1", jogador.Endereco.Endereco1);
                comando.Parameters.AddWithValue("@complemento", jogador.Endereco.Complemento);
                comando.Parameters.AddWithValue("@cidade", jogador.Endereco.Cidade);
                comando.Parameters.AddWithValue("@bairro", jogador.Endereco.Bairro);
                comando.Parameters.AddWithValue("@estado", jogador.Endereco.Estado);

                comando.ExecuteNonQuery();
            }
            catch (Exception) {
                throw;
            }
            finally
            {
                Desconectar();
            }

        }

        public void Update(Jogador jogador)
        {
            try
            {
                
                Conectar();
                comando = new SqlCommand("UPDATE Jogador SET nome = @nome, posicao = @posicao, numero_camisa = @numeroCamisa, perna_boa = @pernaboa, fim_contrato = @fimContrato, cep = @cep, endereco1 = @endereco1, complemento = @complemento, cidade = @cidade, bairro = @bairro, estado = @estado WHERE id_jogador = @id", conexao);

                comando.Parameters.AddWithValue("@id", jogador.Id);
                comando.Parameters.AddWithValue("@nome", jogador.Nome); 
                comando.Parameters.AddWithValue("@posicao", jogador.Posicao);
                comando.Parameters.AddWithValue("@numeroCamisa", jogador.NumeroCamisa);
                comando.Parameters.AddWithValue("@pernaBoa", jogador.PernaBoa);
                comando.Parameters.AddWithValue("@fimContrato", jogador.FimContrato);
                comando.Parameters.AddWithValue("@cep", jogador.Endereco.Cep);
                comando.Parameters.AddWithValue("@endereco1", jogador.Endereco.Endereco1);
                comando.Parameters.AddWithValue("@complemento", jogador .Endereco.Complemento);
                comando.Parameters.AddWithValue("@cidade", jogador.Endereco.Cidade);
                comando.Parameters.AddWithValue("@bairro", jogador.Endereco.Bairro);
                comando.Parameters.AddWithValue("@estado", jogador.Endereco.Estado);

                comando.ExecuteNonQuery();
                
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                Desconectar();
            }

        }

        public void Delete(Jogador jogador)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("DELETE FROM Jogador WHERE id_jogador = @id", conexao);

                comando.Parameters.AddWithValue("@id", jogador.Id);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable Listar()
        {
            try
            {
                Conectar();

                comando = new SqlCommand("SELECT * FROM Jogador ORDER BY nome", conexao);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = comando;

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable PesquisarNome(Jogador jogador)
        {
            try
            {
                Conectar();

                comando = new SqlCommand("SELECT * FROM Jogador WHERE nome LIKE @nome", conexao);

                comando.Parameters.AddWithValue("@nome", "%" + jogador.Nome + "%");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = comando;

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable PesquisarPosicao(Jogador jogador
            )
        {
            try
            {
                Conectar();

                comando = new SqlCommand("SELECT * FROM Jogador WHERE posicao LIKE @posicao", conexao);

                comando.Parameters.AddWithValue("@posicao", "%" + jogador.Posicao + "%");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = comando;

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                Desconectar();
            }
        }


    }
}
