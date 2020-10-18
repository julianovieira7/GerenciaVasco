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
        //private Endereco endereco; 


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Posicao { get => posicao; set => posicao = value; }
        public string NumeroCamisa { get => numeroCamisa; set => numeroCamisa = value; }
        
        public string PernaBoa { get => pernaBoa; set => pernaBoa = value; }
        public DateTime FimContrato { get => fimContrato; set => fimContrato = value; }
    //    public Endereco Endereco { get => endereco; set => endereco = value; }
    }
}
