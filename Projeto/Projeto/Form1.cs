﻿using System;
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


        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string senha = txbNomePartida.Text;
            string nome = txbSenhaPartida.Text;

            txbIdPartida.Text = Jogo.CriarPartida(nome, senha);

        }



        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(txbIdPartida.Text);
            txbListarJogadores.Text = Jogo.ListarJogadores(idPartida);
        }



        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdPartida.Text);
            string senha = txbSenha.Text;
            string nome = txbNomeJogador.Text;

            string[] jogador = Jogo.EntrarPartida(id, nome, senha).Split(',');


            lblIdJogador.Text = jogador[0];
            lblSenhaJogador.Text = jogador[1];
            lblCorJogador.Text = jogador[2];

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            txbRef.Text = Jogo.IniciarPartida(Convert.ToInt32(txbIdJogadorInit.Text), txbSenhaJogadorInit.Text);
        }

       
        private void BtnMostra_Click(object sender, EventArgs e)
        {
            int id =  Convert.ToInt32(lblIdJogador.Text);
            string senha = lblSenhaJogador.Text;
            lblMostraMao.Text = Jogo.ConsultarMao(id, senha);
        }

        private void BtnExibirTab_Click(object sender, EventArgs e)
        {
            lblExibirTabuleiro.Text = Jogo.ExibirTabuleiro(Convert.ToInt32(txbIdPartida.Text));
        }

        private void ButJogar_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(lblIdJogador.Text);
            string senhaJogador = lblSenhaJogador.Text;
            string carta = txbCarta.Text;
            int posicao = Convert.ToInt32(txbPosicao.Text);

            if (rbtFrente.Checked) Jogo.Jogar(idJogador, senhaJogador, posicao, carta);
            else if (rbtVolta.Checked) Jogo.Jogar(idJogador, senhaJogador, posicao);
            else if (rbtPassa.Checked) Jogo.Jogar(idJogador, senhaJogador);


            
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButTemp_Click(object sender, EventArgs e)
        {
            int idPart = Convert.ToInt32(txbIdPartida.Text);

            txbRef.Text = Jogo.VerificarVez(idPart);
        }
    }
}
