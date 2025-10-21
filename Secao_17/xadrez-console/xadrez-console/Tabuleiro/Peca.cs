using tabuleiro;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro1 Tabuleiro { get; protected set; }

        public Peca(Tabuleiro1 tabuleiro, Cor cor)
        {
            Tabuleiro = tabuleiro;
            Cor = cor;
            Posicao = null;
            QteMovimentos = 0;
        }

        public void addMovimento()
        {
            QteMovimentos++;
        }
    }
}
