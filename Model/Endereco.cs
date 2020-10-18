using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaVasco.Model
{
    class Endereco
    {
        private int id;
        private String cep;
        private String endereco1;
        private String complemento;
        private String cidade;
        private String bairro;
        private String estado;

        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco1 { get => endereco1; set => endereco1 = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Estado { get => estado; set => estado = value; }

    }
}
