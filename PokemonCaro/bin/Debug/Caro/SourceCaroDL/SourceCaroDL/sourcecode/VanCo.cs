using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CaroDL
{
    class VanCo
    {
        public  BanCo banco;
        private MayTinh maytinh;
        private List<Point> mark;
        private int[][] A;
        private int current_player;
        private bool gomoku;
        private int winner;

        public VanCo()
        {
            banco = new BanCo();
            maytinh = new MayTinh();

            mark=new List<Point>();

            A = new int[45][];
            for (int i = 0; i < 45; i++)
                A[i] = new int[45];

            for (int i = 0; i < 45; i++)
                for (int j = 0; j < 45; j++)
                    A[i][j] = 0;

            current_player = 1;

            winner = 0;

            gomoku = false;
        }

        public void SetWin(int win)
        {
            winner = win;
        }
        public void SetChess(int X, int Y, int player)
        {
            A[X+6][Y+6] = player;
            current_player = -player;

            Point P=new Point(X,Y);
            mark.Add(P);
        }
        public void Set_Level(int lv)
        {
            maytinh.set_level(lv);
        }

        public void Undo()
        {
            winner = 0;

            if (mark.Count > 1)
            {
                Point C1 = mark[mark.Count - 1];
                Point C2 = mark[mark.Count - 2];

                A[C1.X + 6][C1.Y + 6] = 0;
                A[C2.X + 6][C2.Y + 6] = 0;

                mark.RemoveAt(mark.Count - 1);
                mark.RemoveAt(mark.Count - 1);
            }
        }

        public bool get_rule()
        {
            return gomoku;
        }
        public void set_rule(bool b)
        {
            gomoku = b;
        }
        public int get_winner()
        {
            return winner;
        }

        public void reset_game()
        {
            winner = 0;

            current_player = 1;

            for (int i = 0; i < 45; i++)
                for (int j = 0; j < 45; j++)
                    A[i][j] = 0;

            while (mark.Count > 0)
                mark.RemoveAt(mark.Count - 1);

            maytinh.count = -1;
            
        }
        public void RePaint(Graphics G)
        {
            banco.DrawGame(G, mark);
        }

        public void SaveGame(string link)
        {
            StreamWriter w = new StreamWriter(link);

            w.WriteLine(winner);
            int chess=1;

            for (int i = 0; i < mark.Count; i ++)
            {
                w.WriteLine(mark[i].X);
                w.WriteLine(mark[i].Y);
                w.WriteLine(chess);
                chess = -chess;
            }

            w.Close();
        }
        public Point LastPoint()
        {
            return banco.LastPoint(mark);
        }

        public Point Process_Point(int x, int y)
        {
            Point P=new Point();

            int ax = (x - banco.Xs - banco.cell / 2) / banco.cell ;
            int ay = (y - banco.Ys - banco.cell / 2) / banco.cell;
            int dx = (x - banco.Xs - banco.cell / 2) % banco.cell;
            int dy = (y - banco.Ys - banco.cell / 2) % banco.cell;


            if (dx > banco.cell/2)
                ax++;

            if (dy > banco.cell/2)
                ay++;

            P.X = ax;
            P.Y = ay;

            for (int i = 0; i < mark.Count; i++)
                if (mark[i].X == ax && mark[i].Y == ay)
                    P.X = P.Y = -100;

            return P;
        }

        public bool Human_Push_Chess(Graphics G,int X, int Y)
        {
            if (winner!=0)
                return false;

            if (X < 0 || X > banco.width || Y < 0 || Y > banco.height)
                return false;

           
            if (A[X + 6][Y + 6] == 0)
            {
                A[X + 6][Y + 6] = current_player;

                Point newchess = new Point(X,Y);
           
                mark.Add(newchess);

                if (current_player > 0)
                    banco.DrawChess(G, newchess.X, newchess.Y, banco.chess1);
                else
                    banco.DrawChess(G, newchess.X, newchess.Y, banco.chess2);

                current_player = -current_player;
                winner = Game_End(gomoku);

            }
            else
                return false;

            return true;
        }

        public void Computer_Push_Chess(Graphics G)
        {

            Point newchess=new Point();

         

            if(gomoku==false)
                newchess= maytinh.DanhCo_luat_VietNam(A, banco.width, banco.height, current_player);
            else
                newchess = maytinh.DanhCo_luat_Gomoku(A, banco.width, banco.height, current_player);

            A[newchess.X][newchess.Y] = current_player;
            newchess.X -= 6;
            newchess.Y -= 6;
            mark.Add(newchess);

            if(current_player>0)
                banco.DrawChess(G, newchess.X, newchess.Y,banco.chess1);
            else
               banco.DrawChess(G, newchess.X, newchess.Y, banco.chess2);

            current_player = -current_player;

            winner = Game_End(gomoku);

        }

        public int Game_End(bool gomoku)
        {
            for(int i=6;i<banco.width+6;i++)
                for (int j = 6; j < banco.height + 6; j++)
                {
                    if (A[i][j] + A[i][j + 1] + A[i][j + 2] + A[i][j + 3] + A[i][j + 4] == 5)
                        if (gomoku==true||(A[i][j - 1] != 1 && A[i][j + 5] != 1 && (A[i][j - 1] == 0 || A[i][j + 5] == 0)))
                        
                        return 1;

                    if (A[i][j] + A[i+1][j + 1] + A[i+2][j + 2] + A[i+3][j + 3] + A[i+4][j + 4] == 5)
                        if(gomoku==true||( A[i-1][j - 1] != 1 && A[i+5][j + 5] != 1 && (A[i-1][j - 1] == 0 || A[i+5][j + 5] == 0)))
                        return 1;

                    if (A[i][j] + A[i-1][j + 1] + A[i-2][j + 2] + A[i-3][j + 3] + A[i-4][j + 4] == 5)
                        if(gomoku==true||(A[i+1][j - 1] != 1 && A[i-5][j + 5] != 1 && (A[i+1][j - 1] == 0 || A[i-5][j + 5] == 0)))
                        return 1;

                    if (A[i][j] + A[i+1][j] + A[i+2][j] + A[i+3][j] + A[i+4][j] == 5)
                        if(gomoku==true||(A[i-1][j] != 1 && A[i+5][j] != 1 && (A[i-1][j] == 0 || A[i+5][j] == 0)))
                        return 1;
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    if (A[i][j] + A[i][j + 1] + A[i][j + 2] + A[i][j + 3] + A[i][j + 4] == -5 )
                        if(gomoku==true||(A[i][j - 1] != -1 && A[i][j + 5] != -1 && (A[i][j - 1] == 0 || A[i][j + 5] == 0)))
                        return -1;

                    if (A[i][j] + A[i + 1][j + 1] + A[i + 2][j + 2] + A[i + 3][j + 3] + A[i + 4][j + 4] == -5 )
                        if(gomoku==true||(A[i - 1][j - 1] != -1 && A[i + 5][j + 5] != -1 && (A[i - 1][j - 1] == 0 || A[i + 5][j + 5] == 0)))
                        return -1;

                    if (A[i][j] + A[i-1][j + 1] + A[i - 2][j + 2] + A[i - 3][j + 3] + A[i - 4][j + 4] == -5 )
                        if(gomoku==true||(A[i + 1][j - 1] != -1 && A[i - 5][j + 5] != -1 && (A[i + 1][j - 1] == 0 || A[i - 5][j + 5] == 0)))
                        return -1;

                    if (A[i][j] + A[i + 1][j] + A[i + 2][j] + A[i + 3][j] + A[i + 4][j] == -5 )
                        if(gomoku==true||(A[i - 1][j] != -1 && A[i + 5][j] != -1 && (A[i - 1][j] == 0 || A[i + 5][j] == 0)))
                        return -1;
                }

            return 0;
        }

    }
}
