using GerenciaVasco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaVasco.model
{
    class Jogador
    {
       
        private int id;
        private String nome;
        private String posicao;
        private String numeroCamisa;
        private String pernaBoa;
        private DateTime fimContrato;
        //private String cep;
        //private String endereco1;
        //private String complemento;
        //private String cidade;
        //private String bairro;
        //private String estado;
        private Endereco endereco; 


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Posicao { get => posicao; set => posicao = value; }
        public string NumeroCamisa { get => numeroCamisa; set => numeroCamisa = value; }
        
        public string PernaBoa { get => pernaBoa; set => pernaBoa = value; }
        public DateTime FimContrato { get => fimContrato; set => fimContrato = value; }


        //public string Cep { get => cep; set => cep = value; }
        //public string Endereco1 { get => endereco1; set => endereco1 = value; }
        //public string Complemento { get => complemento; set => complemento = value; }
        //public string Cidade { get => cidade; set => cidade = value; }
        //public string Bairro { get => bairro; set => bairro = value; }
        //public string Estado { get => estado; set => estado = value; }
            public Endereco Endereco { get => endereco; set => endereco = value; }
    }
}
