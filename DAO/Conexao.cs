using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GerenciaVasco.DAO
{
    class Conexao
    {
        string conecta = "Data Source=DESKTOP-NJSP94U\\SQLEXPRESS;Initial Catalog=GerenciaVasco;Integrated Security=True";
        protected SqlConnection conexao = null;

        
        public void Conectar()
        {
            try
            {
                conexao = new SqlConnection(conecta);
                conexao.Open();

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void Desconectar()
        {
            try
            {
                conexao = new SqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
