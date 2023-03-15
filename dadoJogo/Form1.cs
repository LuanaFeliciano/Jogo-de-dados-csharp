namespace dadoJogo
{
    public partial class Form1 : Form
    {
        int jogadas = 0;
        int vitoriasUser = 0;
        int vitoriasMachine = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogadas++;

            //a partida vai comecar se nenhum dos jogadores ganhou 2 e se as jogadas ainda não chegou a 3
            if (jogadas <= 3 && (vitoriasUser < 2 && vitoriasMachine < 2))
            {
                
                Random random = new Random();
                jogadaLabel.Text = "Partida: "+jogadas.ToString();

                int jogadaUser = random.Next(1, 7);//jogadores jogam o dado
                int jogadaMachine = random.Next(1, 7);

                dadoUser.Text = jogadaUser.ToString();// é colocado o numero do dado que caiu no form
                dadoMachine.Text = jogadaMachine.ToString();


                // Verifica se o jogador ganhou na partida atribuindo uma vitoria a ele
                if (jogadaUser > jogadaMachine)
                {
                    vitoriasUser++;
                    userPontos.Text = vitoriasUser.ToString();
                }

                if(jogadaMachine > jogadaUser)
                {
                    vitoriasMachine++;
                    maquinaPontos.Text = vitoriasMachine.ToString();
                }
                
                // Verifica o vencedor do jogo,se houve empate e se não houve vencedores
                // colocando uma mensagem avulsa na tela ao usuário e é reiniciado o jogo
                // pode ser que nao chegue a 3 jogadas portanto é colocado >=2 em vez de ==3
                if (jogadas >= 2 && vitoriasUser == 2)
                {
                    MessageBox.Show("Você venceu! Reiniciando Jogo");
                    ReiniciarJogo();
                }
           
                else if (jogadas >= 2 && vitoriasMachine == 2)
                {
                    MessageBox.Show("Máquina venceu! Reiniciando Jogo");
                    ReiniciarJogo();
                }
                else if (jogadas == 3 && vitoriasMachine == vitoriasUser)
                {
                    MessageBox.Show("Empate, Jogue de novo!");
                    ReiniciarJogo();
                }
                else if(jogadas == 3)
                {
                    MessageBox.Show("Ninguem venceu, Joguem de novo!");
                    ReiniciarJogo();
                }

            }    
        }

        // Jogo é reiniciado
        private void ReiniciarJogo()
        {
            vitoriasUser = 0;
            vitoriasMachine = 0;
            jogadas = 0;

            userPontos.Text = "0";
            maquinaPontos.Text = "0";
            jogadaLabel.Text = "";
            dadoUser.Text = "0";
            dadoMachine.Text = "0";
        }
    }
}