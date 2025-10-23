using tabuleiro;

namespace Tabuleiro
{
    internal abstract class Peca
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

        public void IncrementarMovimentos()
        {
            QteMovimentos++;
        }

        public void DecrementarMovimentos()
        {
            QteMovimentos--;
        }

        public bool ExisteMovimentoPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
