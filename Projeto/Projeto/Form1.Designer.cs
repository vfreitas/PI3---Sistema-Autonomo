namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butListarPartidas = new System.Windows.Forms.Button();
            this.txbPartidas = new System.Windows.Forms.TextBox();
            this.rbtTodas = new System.Windows.Forms.RadioButton();
            this.rbtAbertas = new System.Windows.Forms.RadioButton();
            this.rbtFechadas = new System.Windows.Forms.RadioButton();
            this.rbtJogando = new System.Windows.Forms.RadioButton();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txbNomePartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSenhaPartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.txbIdPartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbListarJogadores = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblInfoJogador = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbIdJogadorInit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbSenhaJogadorInit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butListarPartidas
            // 
            this.butListarPartidas.Location = new System.Drawing.Point(12, 12);
            this.butListarPartidas.Name = "butListarPartidas";
            this.butListarPartidas.Size = new System.Drawing.Size(132, 26);
            this.butListarPartidas.TabIndex = 0;
            this.butListarPartidas.Text = "Listar Partidas";
            this.butListarPartidas.UseVisualStyleBackColor = true;
            this.butListarPartidas.Click += new System.EventHandler(this.butListarPartidas_Click);
            // 
            // txbPartidas
            // 
            this.txbPartidas.Location = new System.Drawing.Point(12, 67);
            this.txbPartidas.Multiline = true;
            this.txbPartidas.Name = "txbPartidas";
            this.txbPartidas.ReadOnly = true;
            this.txbPartidas.Size = new System.Drawing.Size(210, 475);
            this.txbPartidas.TabIndex = 1;
            this.txbPartidas.TextChanged += new System.EventHandler(this.txbPartidas_TextChanged);
            // 
            // rbtTodas
            // 
            this.rbtTodas.AutoSize = true;
            this.rbtTodas.Checked = true;
            this.rbtTodas.Location = new System.Drawing.Point(13, 44);
            this.rbtTodas.Name = "rbtTodas";
            this.rbtTodas.Size = new System.Drawing.Size(55, 17);
            this.rbtTodas.TabIndex = 6;
            this.rbtTodas.TabStop = true;
            this.rbtTodas.Text = "Todas";
            this.rbtTodas.UseVisualStyleBackColor = true;
            // 
            // rbtAbertas
            // 
            this.rbtAbertas.AutoSize = true;
            this.rbtAbertas.Location = new System.Drawing.Point(156, 44);
            this.rbtAbertas.Name = "rbtAbertas";
            this.rbtAbertas.Size = new System.Drawing.Size(61, 17);
            this.rbtAbertas.TabIndex = 7;
            this.rbtAbertas.Text = "Abertas";
            this.rbtAbertas.UseVisualStyleBackColor = true;
            // 
            // rbtFechadas
            // 
            this.rbtFechadas.AutoSize = true;
            this.rbtFechadas.Location = new System.Drawing.Point(78, 44);
            this.rbtFechadas.Name = "rbtFechadas";
            this.rbtFechadas.Size = new System.Drawing.Size(72, 17);
            this.rbtFechadas.TabIndex = 8;
            this.rbtFechadas.Text = "Fechadas";
            this.rbtFechadas.UseVisualStyleBackColor = true;
            this.rbtFechadas.CheckedChanged += new System.EventHandler(this.rbtFechadas_CheckedChanged);
            // 
            // rbtJogando
            // 
            this.rbtJogando.AutoSize = true;
            this.rbtJogando.Location = new System.Drawing.Point(156, 17);
            this.rbtJogando.Name = "rbtJogando";
            this.rbtJogando.Size = new System.Drawing.Size(66, 17);
            this.rbtJogando.TabIndex = 9;
            this.rbtJogando.Text = "Jogando";
            this.rbtJogando.UseVisualStyleBackColor = true;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(228, 12);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(100, 26);
            this.btnCriarPartida.TabIndex = 10;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txbNomePartida
            // 
            this.txbNomePartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbNomePartida.Location = new System.Drawing.Point(337, 35);
            this.txbNomePartida.Name = "txbNomePartida";
            this.txbNomePartida.Size = new System.Drawing.Size(86, 20);
            this.txbNomePartida.TabIndex = 11;
            this.txbNomePartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome da Partida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha da Partida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbSenhaPartida
            // 
            this.txbSenhaPartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenhaPartida.Location = new System.Drawing.Point(231, 62);
            this.txbSenhaPartida.Name = "txbSenhaPartida";
            this.txbSenhaPartida.Size = new System.Drawing.Size(126, 20);
            this.txbSenhaPartida.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID da Partida Criada";
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(347, 90);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(10, 13);
            this.lblIdPartida.TabIndex = 16;
            this.lblIdPartida.Text = "-";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(322, 110);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(97, 26);
            this.btnListarJogadores.TabIndex = 17;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // txbIdPartida
            // 
            this.txbIdPartida.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbIdPartida.Location = new System.Drawing.Point(285, 114);
            this.txbIdPartida.Name = "txbIdPartida";
            this.txbIdPartida.Size = new System.Drawing.Size(31, 20);
            this.txbIdPartida.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID Partida";
            // 
            // txbListarJogadores
            // 
            this.txbListarJogadores.Location = new System.Drawing.Point(231, 142);
            this.txbListarJogadores.Multiline = true;
            this.txbListarJogadores.Name = "txbListarJogadores";
            this.txbListarJogadores.Size = new System.Drawing.Size(187, 100);
            this.txbListarJogadores.TabIndex = 20;
            this.txbListarJogadores.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(231, 248);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(97, 26);
            this.btnEntrarPartida.TabIndex = 21;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txbId
            // 
            this.txbId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbId.Location = new System.Drawing.Point(371, 252);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(31, 20);
            this.txbId.TabIndex = 22;
            this.txbId.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Senha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenha.Location = new System.Drawing.Point(228, 293);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(96, 20);
            this.txbSenha.TabIndex = 24;
            // 
            // txbRef
            // 
            this.txbRef.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbRef.Location = new System.Drawing.Point(456, 371);
            this.txbRef.Multiline = true;
            this.txbRef.Name = "txbRef";
            this.txbRef.Size = new System.Drawing.Size(212, 73);
            this.txbRef.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nome Jogador";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txbNome
            // 
            this.txbNome.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbNome.Location = new System.Drawing.Point(327, 293);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(96, 20);
            this.txbNome.TabIndex = 27;
            // 
            // lblInfoJogador
            // 
            this.lblInfoJogador.AutoSize = true;
            this.lblInfoJogador.Location = new System.Drawing.Point(320, 316);
            this.lblInfoJogador.Name = "lblInfoJogador";
            this.lblInfoJogador.Size = new System.Drawing.Size(10, 13);
            this.lblInfoJogador.TabIndex = 29;
            this.lblInfoJogador.Text = "-";
            this.lblInfoJogador.Click += new System.EventHandler(this.lblInfoJogador_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Info Jogador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Iniciar Partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Id Jogador";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txbIdJogadorInit
            // 
            this.txbIdJogadorInit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbIdJogadorInit.Location = new System.Drawing.Point(232, 380);
            this.txbIdJogadorInit.Name = "txbIdJogadorInit";
            this.txbIdJogadorInit.Size = new System.Drawing.Size(96, 20);
            this.txbIdJogadorInit.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Senha";
            // 
            // txbSenhaJogadorInit
            // 
            this.txbSenhaJogadorInit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txbSenhaJogadorInit.Location = new System.Drawing.Point(337, 380);
            this.txbSenhaJogadorInit.Name = "txbSenhaJogadorInit";
            this.txbSenhaJogadorInit.Size = new System.Drawing.Size(96, 20);
            this.txbSenhaJogadorInit.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbSenhaJogadorInit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbIdJogadorInit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblInfoJogador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbRef);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txbListarJogadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIdPartida);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSenhaPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomePartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.rbtJogando);
            this.Controls.Add(this.rbtFechadas);
            this.Controls.Add(this.rbtAbertas);
            this.Controls.Add(this.rbtTodas);
            this.Controls.Add(this.txbPartidas);
            this.Controls.Add(this.butListarPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butListarPartidas;
        private System.Windows.Forms.TextBox txbPartidas;
        private System.Windows.Forms.RadioButton rbtTodas;
        private System.Windows.Forms.RadioButton rbtAbertas;
        private System.Windows.Forms.RadioButton rbtFechadas;
        private System.Windows.Forms.RadioButton rbtJogando;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txbNomePartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSenhaPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.TextBox txbIdPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbListarJogadores;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbRef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblInfoJogador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbIdJogadorInit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbSenhaJogadorInit;
    }
}

