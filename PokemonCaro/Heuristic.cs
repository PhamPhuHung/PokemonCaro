using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCaro
{
    public class Heuristic
    {
        ChessBoardManager chessboard;

        public ChessBoardManager Chessboard { get => chessboard; set => chessboard = value; }

        public Heuristic(ChessBoardManager chessBoard)
        {
            this.Chessboard = chessBoard;
        }

        List<long> attack = new List<long>() { 0,   3,  20, 160,    20000,      1600000,    128000000 };
        List<long> defense = new List<long>() { 0, 3,  24, 1920, 153600,    12288000,   98304000 };
        #region Method
        public Point MaxScorePoint()
        {
            Point pointResult = new Point();
            long attackValue = 0;
            long defenseValue = 0;
            long value = 0;
            long maxValue = 0;
            for (int i = 0; i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Constant.CHESSBOARD_WIDTH; j++)
                {
                    if(Chessboard.ChessMatrix[i][j].BackgroundImage == null)
                    {
                        attackValue = AttackHorizontal(i, j) + AttackVertical(i, j) + AttackPrimaryDiagonal(i, j) + AttackSubDiagonal(i, j);
                        defenseValue = DefenseHorizontal(i, j) + DefenseVertical(i, j) + DefensePrimaryDiagonal(i, j) + DefenseSubDiagonal(i, j);

                        value = attackValue > defenseValue ? attackValue : defenseValue;
                        if (maxValue < value)
                        {
                            maxValue = value;
                            pointResult.X = i;
                            pointResult.Y = j;
                        }
                    }
                }
            }
            return pointResult;
        }


        #region Attack
        private long AttackHorizontal(int x, int y)
        {
            long attackValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && y - i >= 0; i++)
            {
                if (Chessboard.ChessMatrix[x][y - i].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if(Chessboard.ChessMatrix[x][y - i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    //if (computerQuantity > 0 && computerQuantity < 4) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            for (int i = 1; i <= 5 && y + i < Constant.CHESSBOARD_WIDTH; i++)
            {
                if (Chessboard.ChessMatrix[x][y + i].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if (Chessboard.ChessMatrix[x][y + i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    //if (computerQuantity > 0) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            attackValue += userQuantity == 2 ? 0 : (attack[computerQuantity] - defense[userQuantity]);

            return attackValue;
        }

        private long AttackVertical(int x, int y)
        {
            long attackValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && x - i >= 0; i++)
            {
                if (Chessboard.ChessMatrix[x - i][y].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if (Chessboard.ChessMatrix[x - i][y].BackgroundImage == Chessboard.ServerPlayer.Mark) 
                {
                    //if (computerQuantity > 0) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            for (int i = 1; i <= 5 && x + i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                if (Chessboard.ChessMatrix[x + i][y].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if (Chessboard.ChessMatrix[x + i][y].BackgroundImage == Chessboard.ServerPlayer.Mark) 
                {
                    //if (computerQuantity > 0) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            attackValue += userQuantity == 2 ? 0 : (attack[computerQuantity] - defense[userQuantity ]);

            return attackValue;
        }

        private long AttackPrimaryDiagonal(int x, int y)
        {
            long attackValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && x - i >= 0 && y + i < Constant.CHESSBOARD_WIDTH; i++) 
            {
                if (Chessboard.ChessMatrix[x-i][y + i].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if (Chessboard.ChessMatrix[x-i][y + i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    //if (computerQuantity > 0) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            for (int i = 1; i <= 5 && x + i < Constant.CHESSBOARD_HEIGHT && y - i >= 0; i++)
            {
                if (Chessboard.ChessMatrix[x + i][y - i].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if (Chessboard.ChessMatrix[x + i][y - i].BackgroundImage == Chessboard.ServerPlayer.Mark) 
                {
                    //if (computerQuantity > 0) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            attackValue += userQuantity == 2 ? 0 : (attack[computerQuantity] - defense[userQuantity ]);

            return attackValue;
        }

        private long AttackSubDiagonal(int x, int y)
        {
            long attackValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && x - i >= 0 && y - i >=0 ; i++)
            {
                if (Chessboard.ChessMatrix[x - i][y - i].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if (Chessboard.ChessMatrix[x - i][y - i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    //if (computerQuantity > 0) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            for (int i = 1; i <= 5 && x + i < Constant.CHESSBOARD_HEIGHT && y + i <Constant.CHESSBOARD_WIDTH; i++)
            {
                if (Chessboard.ChessMatrix[x + i][y + i].BackgroundImage == Chessboard.ClientPlayer.Mark) computerQuantity++;
                else if (Chessboard.ChessMatrix[x + i][y + i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    //if (computerQuantity > 0) computerQuantity--;
                    userQuantity++;
                    break;
                }
                else break;
            }

            attackValue += userQuantity == 2 ? 0 : (attack[computerQuantity] - defense[userQuantity ]);

            return attackValue;
        }
        #endregion

        #region Defense
        private long DefenseHorizontal(int x, int y)
        {
            long defenseValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && y - i >= 0; i++)
            {
                if (Chessboard.ChessMatrix[x][y - i].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x][y - i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    userQuantity++;
                }
                else break;
            }

            for (int i = 1; i <= 5 && y + i < Constant.CHESSBOARD_WIDTH; i++)
            {
                if (Chessboard.ChessMatrix[x][y + i].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x][y + i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    userQuantity++;
                }
                else break;
            }

            defenseValue += userQuantity == 2 ? 0 : (defense[userQuantity] - attack[computerQuantity]);

            return defenseValue;
        }

        private long DefenseVertical(int x, int y)
        {
            long defenseValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && x - i >= 0; i++)
            {
                if (Chessboard.ChessMatrix[x - i][y].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x - i][y].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    userQuantity++;
                }
                else break;
            }

            for (int i = 1; i <= 5 && x + i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                if (Chessboard.ChessMatrix[x + i][y].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x + i][y].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    userQuantity++;
                }
                else break;
            }

            defenseValue += userQuantity == 2 ? 0 : (defense[userQuantity] - attack[computerQuantity]);

            return defenseValue;
        }

        private long DefensePrimaryDiagonal(int x, int y)
        {
            long defenseValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && x - i >= 0 && y + i < Constant.CHESSBOARD_WIDTH; i++)
            {
                if (Chessboard.ChessMatrix[x - i][y + i].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x - i][y + i].BackgroundImage == Chessboard.ServerPlayer.Mark) 
                {
                    userQuantity++;
                }
                else break;
            }

            for (int i = 1; i <= 5 && x + i < Constant.CHESSBOARD_HEIGHT && y - i >= 0; i++)
            {
                if (Chessboard.ChessMatrix[x + i][y - i].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x + i][y - i].BackgroundImage == Chessboard.ServerPlayer.Mark) 
                {
                    userQuantity++;
                }
                else break;
            }

            defenseValue += userQuantity == 2 ? 0 : (defense[userQuantity] - attack[computerQuantity]);

            return defenseValue;
        }

        private long DefenseSubDiagonal(int x, int y)
        {
            long defenseValue = 0;
            int userQuantity = 0;
            int computerQuantity = 0;

            for (int i = 1; i <= 5 && x - i >= 0 && y - i >= 0; i++)
            {
                if (Chessboard.ChessMatrix[x - i][y - i].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x - i][y - i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    userQuantity++;
                }
                else break;
            }

            for (int i = 1; i <= 5 && x + i < Constant.CHESSBOARD_HEIGHT && y + i < Constant.CHESSBOARD_WIDTH; i++)
            {
                if (Chessboard.ChessMatrix[x + i][y + i].BackgroundImage == Chessboard.ClientPlayer.Mark)
                {
                    //if (userQuantity > 0) userQuantity--;
                    computerQuantity++;
                    break;
                }
                else if (Chessboard.ChessMatrix[x + i][y + i].BackgroundImage == Chessboard.ServerPlayer.Mark)
                {
                    userQuantity++;
                }
                else break;
            }

            defenseValue += userQuantity == 2 ? 0 : (defense[userQuantity] - attack[computerQuantity]);

            return defenseValue;
        }
        #endregion
        #endregion


    }
}
