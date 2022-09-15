using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Jogo21
{

    public partial class Form1 : Form
    {

        public int rodada, SomaP1, SomaP2 = 0;

        public int Pontuacao { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\nPressione \"Iniciar\" para começar o jogo.";

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            txtConsole.Text += "\r\nInforme um valor de 1 a 20";
            txtPlayer1.Focus();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            rodada++;
            txtConsole.Text += $"\r\n{rodada}ª Rodada";
            int PontoP1 = CalculaPontuacao(Pontuacao = Int32.Parse(txtPlayer1.Text));
            SomaP1 += PontoP1;
            txtResultP1.Text += $"\r\nPlayer 1 Ganhou {PontoP1} Pontos";
            Thread.Sleep(500);
            GeraNumeroPlayer2(PontoP1);
        }   

            private void GeraNumeroPlayer2(int P1)
        {            
            Random rd = new Random();
            txtPlayer2.Text = rd.Next(1, 20).ToString();
            int PontoP2 = CalculaPontuacao(Pontuacao = Int32.Parse(txtPlayer2.Text));
            SomaP2 += PontoP2;
            txtResultP2.Text += $"\r\nPlayer 2 Ganhou  {PontoP2} Pontos";

            if (P1 > PontoP2)
            {
                txtConsole.Text += "\r\nPlayer 1 Ganhou....";
            }
            else if (P1 < PontoP2)
            {
                txtConsole.Text += "\r\nPlayer 2 Ganhou....";
            } else
            {
                txtConsole.Text += "\r\nEmpatou....";
            }
            if (rodada.Equals(3))
            {
                VerificaGanhador();
            }
        }

        private void VerificaGanhador()
        {

            btnPlayer1.Enabled = false;

            if (SomaP1 > SomaP2)
            {
              txtConsole.Text += $"\r\nPlayer 1 Venceu o Jogo 21 com {SomaP1} pontos";
            } else if (SomaP1 < SomaP2)
            {
                txtConsole.Text += $"\r\nPlayer 2 Venceu o Jogo 21 com {SomaP2} pontos";
            } else
            {
                txtConsole.Text += $"\r\nEmpatou";
            }

            txtResultP1.Text += $"\r\nPlayer 1 Totalizou {SomaP1} Pontos";
            txtResultP2.Text += $"\r\nPlayer 2 Totalizou {SomaP2} Pontos";
        }
        //Exemplo Metodo retornando valor
        private int CalculaPontuacao(int param1)
        {
            int resultado = 0;

            switch (param1)
            {
                case 7:
                    resultado = 10;
                    break;
                case 14:
                    resultado = 20;
                    break;
                case 21:
                    resultado = 30;
                    break;
                case int n when (n >= 1 && n <= 6):
                    resultado = 1;
                    break;
                case int n when (n >= 8 && n <= 13):
                    resultado = 5;
                    break;
                case int n when (n >= 15 && n <= 20):
                    resultado = 6;
                    break;
                
                default:
                    break;

            }

            return resultado;
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            btnPlayer1.Enabled = true;
            txtPlayer1.Clear();
            txtPlayer2.Clear();
            txtConsole.Text += $"\r\nZERANDO PONTUAÇÕES...";
            rodada = 0;
            SomaP1 = 0;
            SomaP2 = 0;
            txtConsole.Clear();
            txtResultP1.Clear();
            txtResultP2.Clear();
            txtConsole.Text += $"\r\nNOVO JOGO";
            txtConsole.Text += "\r\nInforme um valor de 1 a 20";
            txtPlayer1.Focus();
        }
    }
}
