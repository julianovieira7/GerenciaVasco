using GerenciaVasco.DAO;
using GerenciaVasco.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaVasco.Controller
{
    class JogadorController
    {
        private JogadorDAO jogadorDAO = new JogadorDAO();

        public void Create(Jogador jogador) {
            try
            {
                jogadorDAO.Create(jogador);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Update(Jogador jogador)
        {
            try
            {
                jogadorDAO.Update(jogador);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        public void Delete(Jogador jogador)
        {
            try
            {
                jogadorDAO.Delete(jogador);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public DataTable Listar()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = jogadorDAO.Listar();

                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object PesquisarNome(Jogador jogador)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = jogadorDAO.PesquisarNome(jogador);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public object PesquisarPosicao(Jogador jogador)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = jogadorDAO.PesquisarPosicao(jogador);

                return dataTable;
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
