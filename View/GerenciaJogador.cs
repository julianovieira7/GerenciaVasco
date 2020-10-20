using GerenciaVasco.Controller;
using GerenciaVasco.model;
using GerenciaVasco.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciaVasco.View
{
    public partial class GerenciaJogador : Form
    {
        GerenciaJogador entrada;

        Jogador jogador = new Jogador();
        Endereco endereco = new Endereco();
        
        JogadorController jogaController = new JogadorController();
        private int temporalId;


        public GerenciaJogador()
        {
            InitializeComponent();

            jogador.Endereco = endereco;
            btAterar.Enabled = false;
            btExcluir.Enabled = false; 
      }
       
       

        private void Salvar(Jogador jogador)
        {
            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do jogador não pode estar em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                jogador.Nome = tbNome.Text;
                jogador.Posicao = comboPosicao.Text;
                jogador.NumeroCamisa = tbCamisa.Text;
                jogador.PernaBoa = comboPerna.Text;
                jogador.FimContrato = dateContrato.Value;
                
                jogador.Endereco.Cep = tbCep.Text;
                jogador.Endereco.Endereco1 = tbEndereco.Text;
                jogador.Endereco.Complemento = tbComplemento.Text;
                jogador.Endereco.Cidade = tbCidade.Text;
                jogador.Endereco.Bairro = tbBairro.Text;
                jogador.Endereco.Estado = tbEstado.Text;


                jogaController.Create(jogador);

                MessageBox.Show("Hoje tem gol do Ribamar!");

                Listar();
                Limpar();
                btAterar.Enabled = false;
                btExcluir.Enabled = false;


            }
        }
        private void Editar(Jogador jogador)
        {
            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nome do jogador não pode estar em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                jogador.Nome = tbNome.Text;
                jogador.Posicao = comboPosicao.Text;
                jogador.NumeroCamisa = tbCamisa.Text;
                jogador.PernaBoa = comboPerna.Text;
                jogador.FimContrato = dateContrato.Value;
                jogador.Endereco.Cep = tbCep.Text;
                jogador.Endereco.Endereco1 = tbEndereco.Text;
                jogador.Endereco.Complemento = tbComplemento.Text;
                jogador.Endereco.Cidade = tbCidade.Text;
                jogador.Endereco.Bairro = tbBairro.Text;
                jogador.Endereco.Estado = tbEstado.Text;

                jogaController.Update(jogador);

                MessageBox.Show("Jogador alterado com sucesso!");

                Listar();
                Limpar();
                btAterar.Enabled = false;
                btExcluir.Enabled = false;

            }
        }

        private void Excluir(Jogador jogador)
        {
            if (tbNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Não é possivel excluir campos em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse jogador?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                jogador.Id = temporalId;


                jogaController.Delete(jogador);

                MessageBox.Show("Jogador excluido com sucesso!");

                Listar();
                Limpar();
                btAterar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void PesquisarNome(Jogador jogador)
        {
            jogador.Nome = tbNome.Text;

            dataGridView1.DataSource = jogaController.PesquisarNome(jogador);
            btAterar.Enabled = false;
            btExcluir.Enabled = false;
        }

        private void PesquisarPosicao(Jogador jogador)
        {
            jogador.Posicao = comboPosicao.Text;

            dataGridView1.DataSource = jogaController.PesquisarPosicao(jogador);
            btAterar.Enabled = false;
            btExcluir.Enabled = false;
        }
        public void Limpar()
        {
            tbNome.Clear();
            tbCamisa.Clear();
            tbCep.Clear();
            tbEndereco.Clear();
            tbComplemento.Clear();
            tbCidade.Clear();
            tbBairro.Clear();
            tbEstado.Clear();

        }

        private void Listar()
        {
            dataGridView1.DataSource = jogaController.Listar();
        }



        private void btAdicionar_Click_1(object sender, EventArgs e)
        {
            Salvar(jogador);
        }

        private void btAterar_Click(object sender, EventArgs e)

        {
            jogador.Id = temporalId;
            Editar(jogador);
            Listar();
        }

        private void GerenciaJogador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gerenciaVascoDataSet1.jogador'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadorTableAdapter1.Fill(this.gerenciaVascoDataSet1.jogador);
            // TODO: esta linha de código carrega dados na tabela 'gerenciaVascoDataSet.jogador'. Você pode movê-la ou removê-la conforme necessário.
            //this.jogadorTableAdapter.Fill(this.gerenciaVascoDataSet.jogador);

        }

        private void Mouse(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                temporalId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                tbNome.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboPosicao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbCamisa.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboPerna.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                dateContrato.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tbCep.Text= dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tbEndereco.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                tbComplemento.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                tbCidade.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                tbBairro.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                tbEstado.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                btAterar.Enabled = true;
                btExcluir.Enabled = true;
                btAdicionar.Enabled = false;
            }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Excluir(jogador);

        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador();
            PesquisarNome(jogador);
        }

        private void btnPesquisaPosicao_Click(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador();
            PesquisarPosicao(jogador);
        }



        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            using (var ws = new Correios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(tbCep.Text);
                    tbEndereco.Text = resultado.end;
                    tbComplemento.Text = resultado.complemento2;
                    tbCidade.Text = resultado.cidade;
                    tbBairro.Text = resultado.bairro;
                    tbEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
