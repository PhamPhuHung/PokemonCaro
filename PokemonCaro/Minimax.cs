using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCaro
{
    public class Minimax
    {
        #region Properties
        private int depth;
        private ChessBoardManager chessBoard;

        public int Depth { get => depth; set => depth = value; }
        public ChessBoardManager ChessBoard { get => chessBoard; set => chessBoard = value; }

        public Minimax(int depth, ChessBoardManager chessBoard)
        {
            this.Depth = depth;
            this.ChessBoard = chessBoard;
        }

        #endregion

        #region Method
        public Point MinimaxSearch(int depth, ChessBoardManager chessBoard)
        {
            Point chosenPoint = new Point();
            Heuristic heuristic = new Heuristic(ChessBoard);

            if (depth == 0) chosenPoint = heuristic.MaxScorePoint();
            else
            {
                List<List<List<Button>>> chessMatrix = GenerateNextMove();
                foreach (var item in chessMatrix)
                {

                }

            }
            return chosenPoint;
        }

        private List<List<List<Button>>> GenerateNextMove()
        {
            List<List<List<Button>>> chessMatrix = new List<List<List<Button>>>();

            int k = 0;
            for (int i = 0; i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Constant.CHESSBOARD_WIDTH; j++)
                {
                    List<List<Button>> chessClient = new List<List<Button>>(ChessBoard.ChessMatrix);
                    if (chessClient[i][j].BackgroundImage != null)
                    {
                        chessClient[i][j].BackgroundImage = ChessBoard.ClientPlayer.Mark;
                        for (int a = 0; a < Constant.CHESSBOARD_HEIGHT; a++)
                        {
                            for (int b = 0; b < Constant.CHESSBOARD_WIDTH; b++)
                            {
                                List<List<Button>> chessServer = new List<List<Button>>(ChessBoard.ChessMatrix);
                                if (chessServer[i][j].BackgroundImage != null)
                                {
                                    chessServer[i][j].BackgroundImage = ChessBoard.ServerPlayer.Mark;
                                    chessMatrix.Add(chessServer);
                                }
                            }
                        }
                    }
                }
            }

            return chessMatrix;
        }
        #endregion
    }
}
