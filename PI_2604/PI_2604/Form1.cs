using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using CartagenaServer;

namespace PI_2604
{
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
            ListarPartidas();
        }


        //Metodos
        #region Funcoes Basicas
        public string ListarPartidas()
        {
            string statusPartida = null;

            if (rbtTodas.Checked == true) statusPartida = "T";
            else if (rbtJogando.Checked == true) statusPartida = "J";
            else if (rbtAbertas.Checked == true) statusPartida = "A";
            else if (rbtFechadas.Checked == true) statusPartida = "F";

            txbListarPartidas.Text = Jogo.ListarPartidas(statusPartida);

            return txbListarPartidas.Text;

        }

        public void CriarPartida()
        {
            txbIdPartida.Text = Jogo.CriarPartida(txbNomePartida.Text, txbSenhaPartida.Text);
        }

        public void ListarJogadores()
        {
            txbListarJogadores.Text = Jogo.ListarJogadores(Convert.ToInt32(txbIdPartida.Text));
            //string[] textoListarJogadores = txbListarJogadores.Text.Replace("\r\n",",");


        }

        public void EntrarPartida() {
            string textoEntrarPartida = Jogo.EntrarPartida(Convert.ToInt32(txbIdPartida.Text), txbNomeJogador.Text, txbSenhaPartida.Text);

            string[] infoJogador = textoEntrarPartida.Split(',');

            txbIdJogador.Text = infoJogador[0];
            txbSenhajogador.Text = infoJogador[1];
            lblCorJogador.Text = infoJogador[2];

            ListarJogadores();
            timerStatusPartida.Enabled = true;
        }

        public void IniciarPartida()
        {
            Jogo.IniciarPartida(Convert.ToInt32(txbIdJogador.Text), txbSenhajogador.Text);
            ListarJogadores();
            VerificarVez();
            ExibeMao();
            PreencheTabuleiro();

            timerJogo.Enabled = true;


        }

        public string VerificarVez()
        {
            string vez = Jogo.VerificarVez(Convert.ToInt32(txbIdPartida.Text));
            txbVerificarVez.Text = vez;
            return vez;
        }

        public string ExibeMao()
        {
            string mao = Jogo.ConsultarMao(Convert.ToInt32(txbIdJogador.Text), txbSenhajogador.Text);
            lblExibeMao.Text = mao;

            string[] vetMao = mao.Replace("\r\n", "|").Split('|');

            



            for (int i = 0; i < vetMao.Length; i++)
            {
                string[] temp = vetMao[i].Split(',');
                switch (temp[0])
                {
                    case "C":
                        pbxChave.Visible = true;
                        lblChave.Text = "x" + temp[1];
                        lblChave.Visible = true;
                        break;
                    case "T":
                        pbxTricornio.Visible = true;
                        lblTricornio.Text = "x" + temp[1];
                        lblTricornio.Visible = true;
                        break;
                    case "E":
                        pbxEspada.Visible = true;
                        lblEspada.Text = "x" + temp[1];
                        lblEspada.Visible = true;
                        break;
                    case "P":
                        pxbPistola.Visible = true;
                        lblPistola.Text = "x" + temp[1];
                        lblPistola.Visible = true;
                        break;
                    case "F":
                        pbxFaca.Visible = true;
                        lblFaca.Text = "x" + temp[1];
                        lblFaca.Visible = true;
                        break;
                    case "G":
                        pxbGarrafa.Visible = true;
                        lblGarrafa.Text = "x" + temp[1];
                        lblGarrafa.Visible = true;
                        break;
                    
                }

            }
            /*
            string[] n1 = new string[50];

            var list1 = n1.ToList();


            for (int i = 0; i < vetMao.Length; i++)
            {
                if(i % 2 == 0)
                {
                    list1.Add(vetMao[i]);
                }
            }

            foreach (string l in list1)
            {
                if(l != "C")
                {
                    pbxChave.Visible = false;
                    lblChave.Visible = false;
                }
                if (l != "F")
                {
                    pbxFaca.Visible = false;
                    lblFaca.Visible = false;
                }
                if (l != "T")
                {
                    pbxTricornio.Visible = false;
                    lblTricornio.Visible = false;
                }
                if (l != "E")
                {
                    pbxEspada.Visible = false;
                    lblEspada.Visible = false;
                }
                if (l != "G")
                {
                    pxbGarrafa.Visible = false;
                    lblGarrafa.Visible = false;
                }
                if (l != "P")
                {
                    pxbPistola.Visible = false;
                    lblPistola.Visible = false;
                }
            }
            
            */
                return mao;
        }

        public string[] ExibirTabuleiro()
        {
            lblTabuleiro.Text = Jogo.ExibirTabuleiro(Convert.ToInt32(txbIdPartida.Text));
            string tabuleiro = lblTabuleiro.Text;

            tabuleiro = tabuleiro.Replace("\r\n", ",");

            string[] vetTabuleiro = tabuleiro.Split(',');
            string[] itens = new string[40];
            int n = 0;
            
            for(int i = 1; i < vetTabuleiro.Length - 2; i += 2)
            {
                itens[n] = vetTabuleiro[i];
                n++;
            }

            return itens;

        }
        #endregion

        #region Funcoes Preenche Posição
        public void PreenchePosicao(int posicao, string item)
        {
            Image carta = null;
            
            switch (item)
            {
                case "C":
                     carta = Properties.Resources.Chave;
                        break;
                case "E":
                    carta = Properties.Resources.Espada;
                    break;
                case "F":
                    carta = Properties.Resources.Faca;
                    break;
                case "G":
                    carta = Properties.Resources.Garrafa;
                    break;
                case "T":
                    carta = Properties.Resources.Tricornio;
                    break;
                case "P":
                    carta = Properties.Resources.Pistola;
                    break;
            }

            switch (posicao)
            {
                case 1:
                    pbxPosicao1.Image = carta;
                    pbxPosicao1.Visible = true;
                    break;
                case 2:
                    pbxPosicao2.Image = carta;
                    pbxPosicao2.Visible = true;
                    break;
                case 3:
                    pbxPosicao3.Image = carta;
                    pbxPosicao3.Visible = true;
                    break;
                case 4:
                    pbxPosicao4.Image = carta;
                    pbxPosicao4.Visible = true;
                    break;
                case 5:
                    pbxPosicao5.Image = carta;
                    pbxPosicao5.Visible = true;
                    break;
                case 6:
                    pbxPosicao6.Image = carta;
                    pbxPosicao6.Visible = true;
                    break;
                case 7:
                    pbxPosicao7.Image = carta;
                    pbxPosicao7.Visible = true;
                    break;
                case 8:
                    pbxPosicao8.Image = carta;
                    pbxPosicao8.Visible = true;
                    break;
                case 9:
                    pbxPosicao9.Image = carta;
                    pbxPosicao9.Visible = true;
                    break;
                case 10:
                    pbxPosicao10.Image = carta;
                    pbxPosicao10.Visible = true;
                    break;
                case 11:
                    pbxPosicao11.Image = carta;
                    pbxPosicao11.Visible = true;
                    break;
                case 12:
                    pbxPosicao12.Image = carta;
                    pbxPosicao12.Visible = true;                    
                    break;
                case 13:
                    pbxPosicao13.Image = carta;
                    pbxPosicao13.Visible = true;
                    break;
                case 14:
                    pbxPosicao14.Image = carta;
                    pbxPosicao14.Visible = true;
                    break;
                case 15:
                    pbxPosicao15.Image = carta;
                    pbxPosicao15.Visible = true;
                    break;
                case 16:
                    pbxPosicao16.Image = carta;
                    pbxPosicao16.Visible = true;
                    break;
                case 17:
                    pbxPosicao17.Image = carta;
                    pbxPosicao17.Visible = true;
                    break;
                case 18:
                    pbxPosicao18.Image = carta;
                    pbxPosicao18.Visible = true;
                    break;
                case 19:
                    pbxPosicao19.Image = carta;
                    pbxPosicao19.Visible = true;
                    break;
                case 20:
                    pbxPosicao20.Image = carta;
                    pbxPosicao20.Visible = true;
                    break;
                case 21:
                    pbxPosicao21.Image = carta;
                    pbxPosicao21.Visible = true;
                    break;
                case 22:
                    pbxPosicao22.Image = carta;
                    pbxPosicao22.Visible = true;
                    break;
                case 23:
                    pbxPosicao23.Image = carta;
                    pbxPosicao23.Visible = true;
                    break;
                case 24:
                    pbxPosicao24.Image = carta;
                    pbxPosicao24.Visible = true;
                    break;
                case 25:
                    pbxPosicao25.Image = carta;
                    pbxPosicao25.Visible = true;
                    break;
                case 26:
                    pbxPosicao26.Image = carta;
                    pbxPosicao26.Visible = true;
                    break;
                case 27:
                    pbxPosicao27.Image = carta;
                    pbxPosicao27.Visible = true;
                    break;
                case 28:
                    pbxPosicao28.Image = carta;
                    pbxPosicao28.Visible = true;
                    break;
                case 29:
                    pbxPosicao29.Image = carta;
                    pbxPosicao29.Visible = true;
                    break;
                case 30:
                    pbxPosicao30.Image = carta;
                    pbxPosicao30.Visible = true;
                    break;
                case 31:
                    pbxPosicao31.Image = carta;
                    pbxPosicao31.Visible = true;
                    break;
                case 32:
                    pbxPosicao32.Image = carta;
                    pbxPosicao32.Visible = true;
                    break;
                case 33:
                    pbxPosicao33.Image = carta;
                    pbxPosicao33.Visible = true;
                    break;
                case 34:
                    pbxPosicao34.Image = carta;
                    pbxPosicao34.Visible = true;
                    break;
                case 35:
                    pbxPosicao35.Image = carta;
                    pbxPosicao35.Visible = true;
                    break;
                case 36:
                    pbxPosicao36.Image = carta;
                    pbxPosicao36.Visible = true;
                    break;

            }
            
           

        }


        public void PreencheTabuleiro()
        {
            string[] tabuleiro = ExibirTabuleiro();

            for(int i = 1; i < tabuleiro.Length; i++)
            {
                PreenchePosicao(i, tabuleiro[i]);
            }

        }
        #endregion

        #region Jogo
        int cont = 6;

        public void Jogar()
        {
            string idJogador = txbIdJogador.Text;
            string mao = lblExibeMao.Text;
            string vez = txbVerificarVez.Text;
            txbHistorico.Text = mao;

            string posicao = Posicoes();
            if (mao != "")
            {
                
                if(cont != 0)
                {
                    JogarPraFrente(0);
                    cont--;
                }
                else
                {
                    JogarPraFrente(Convert.ToInt32(posicao));
                }
                
            }
            else
            {
                
                jogarPraTras(Convert.ToInt32(posicao));

            }
            


        }


        public void JogarPraFrente(int posicao)
        {
            int idJogador = Convert.ToInt32(txbIdJogador.Text);
            string senhaJogador = txbSenhajogador.Text;

            string textoMao = ExibeMao().Replace("\r\n", ",");

            string[] vetMao = textoMao.Split(',');

            Jogo.Jogar(idJogador, senhaJogador, posicao, vetMao[0]);
            ExibeMao();
            VerificarVez();
            
        }

        public void jogarPraTras(int posicao)
        {
            int idJogador = Convert.ToInt32(txbIdJogador.Text);
            string senhaJogador = txbSenhajogador.Text;

            Jogo.Jogar(idJogador, senhaJogador, posicao);
            ExibeMao();
            VerificarVez();

        }

        public string Posicoes()
        {
            string idJogador = txbIdJogador.Text;
            string mao = lblExibeMao.Text;
            string vez = txbVerificarVez.Text;
            string posicao = null;

            /*tring[] vetVez = vez.Replace("\r\n", "|").Split('|');

            string[] posicoes = new string[30];

            for (int i = vetVez.Length - 2; i <= 0; i--)
            {
                string[] temp = vetVez[i].Split(',');
                if (temp[1] == idJogador)
                {
                    
                }
                
            }*/
            vez = vez.Replace("\r", "");
            string[] linhaVez = vez.Split('\n');

            string[] c1 = new string[200];
            string[] c2 = new string[200];
            string[] c3 = new string[200];

            for (int i = 0; i < linhaVez.Length-1; i++)
            {
                string[] temp = linhaVez[i].Split(',');
                c1[i] = temp[0];
                c2[i] = temp[1];
                c3[i] = temp[2];
            }

            for (int i = c2.Length -1; i >= 0; i--)
            {
                if (c2[i] == idJogador)
                {
                    posicao = c1[i];
                    break;
                }
            }

            return posicao;
        }
        #endregion

        #region Entrega 0505
        public void JogadorDaVez()
        {
            string textoVez = txbVerificarVez.Text.Replace("\r\n", ",");
            string[] vetVez = textoVez.Split(',');

            string idJogadorVez = vetVez[1];


            string listaJogadores = txbListarJogadores.Text.Replace("\r\n","|");
            string[] vetListaJogadores = listaJogadores.Split('|');

            string[] vez = new string[2];
            for(int i = 0; i < vetListaJogadores.Length; i++)
            {
                string[] temp = vetListaJogadores[i].Split(',');
                if (temp[0] == idJogadorVez)
                {
                    vez[0] = temp[1];
                    vez[1] = temp[2];
                    break;
                }                
            }


            lblJogadorDaVez.Text = "Vez do jogador " + vez[0] + ", da cor " + vez[1] + "!";
        }

        public string StatusPartida()
        {
            string idPartida = txbIdPartida.Text;
            string status = null;

            string[] vetPartidas = ListarPartidas().Replace("\r\n", "|").Split('|');

            for (int i = 0; i < vetPartidas.Length; i++)
            {
                string[] temp = vetPartidas[i].Split(',');
                if (temp[0] == idPartida)
                {
                    status = temp[3];
                }

            }

            switch (status)
            {
                case "A":
                    status = "Aberta";
                    break;
                case "J":
                    status = "Jogando";
                    break;
                case "E":
                    status = "Encerrada";
                    timerJogo.Enabled = false;

                    break;
                case "F":
                    status = "Fechada";
                    break;
            }

            lblStatusPartida.Text = status;
            return status;

        }


        #endregion


        //Acoes
        #region Btns
        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            ListarPartidas();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            CriarPartida();
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            EntrarPartida();
        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            ExibirTabuleiro();
            PreencheTabuleiro();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            IniciarPartida();
            ListarJogadores();
            VerificarVez();
            ExibeMao();
            JogadorDaVez();
            timerStatusPartida.Enabled = false;
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            VerificarVez();
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            ExibeMao();
        }

        private void btnJogarFrente_Click(object sender, EventArgs e)
        {
            //jogarPraFrente(0);
            //JogadorDaVez();
            //StatusPartida();
            ExibeMao();
        }
#endregion


        private void timerJogo_Tick(object sender, EventArgs e)
        {
            Jogar();
            StatusPartida();
            JogadorDaVez();
        }

        private void timerStatusPartida_Tick(object sender, EventArgs e)
        {
            switch (StatusPartida())
            {
                case "Jogando":
                    timerJogo.Enabled = true;
                    ListarJogadores();
                    PreencheTabuleiro();
                    timerStatusPartida.Enabled = false;
                    break;
            }
        }
    }
}
