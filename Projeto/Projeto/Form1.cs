using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butListarPartidas_Click(object sender, EventArgs e)
        {
            if (rbtAbertas.Checked)
            {
                txbPartidas.Text =  Jogo.ListarPartidas("A");
            }
            else if (rbtFechadas.Checked)
            {
                txbPartidas.Text = Jogo.ListarPartidas("F");
            }
            else if (rbtJogando.Checked)
            {
                txbPartidas.Text = Jogo.ListarPartidas("J");
            }
            else
            {
                txbPartidas.Text = Jogo.ListarPartidas("T");
            }
        }

        private void txbPartidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxAberta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtFechadas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string senha = txbNomePartida.Text;
            string nome = txbSenhaPartida.Text;

            lblIdPartida.Text = Jogo.CriarPartida(nome, senha);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txbIdPartida.Text);
            txbListarJogadores.Text = Jogo.ListarJogadores(idPartida);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbId.Text);
            string senha = txbSenha.Text;
            string nome = txbNome.Text;

            lblInfoJogador.Text = Jogo.EntrarPartida(id, nome, senha); 

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblInfoJogador_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbRef.Text = Jogo.IniciarPartida(Convert.ToInt32(txbIdJogadorInit.Text), txbSenhaJogadorInit.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
