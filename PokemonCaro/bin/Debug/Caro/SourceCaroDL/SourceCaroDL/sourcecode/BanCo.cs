using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CaroDL
{
    class BanCo
    {
        public int width;//chieu ngang      
        public int height;//chieu dai
        public int cell;//kich thuoc 1 o

    
        public Image chess1;
        public Image chess2;
 

        public int Xs;//vi tri bat dau 
        public int Ys;//cua ban co tren form

        public BanCo()
        {
            width = 19;
            height = 19;
            cell = 20;
                
            Xs = 140;
            Ys = 30;


        }
        public void SetBoardIM(Image I)
        {

        }
        
        public Point LastPoint(List<Point> mark)
        {
            Point P = new Point(-100,-100);
            if (mark.Count == 0)
                return P;
           
                P.X=mark[mark.Count-1].X * cell + Xs;
                P.Y = mark[mark.Count - 1].Y * cell + Ys;
                return P;
        }
        
        public void SetSize(int w, int h, int c)
        {
            width = w;
            height = h;
            cell = c;
        }
     
        public void SetChess( Image X, Image O)
        {
            chess1 = X;
            chess2 = O;
        }
        public void DrawTable(Graphics G)
        {
            Pen pen = new Pen(Color.Black);

         

            for (int i = 0; i <= width; i++)
                G.DrawLine(pen, Xs, Ys + i * cell, Xs + height * cell, Ys + i * cell);

            for (int i = 0; i <= height; i++)
                G.DrawLine(pen, Xs + i * cell, Ys, Xs + i * cell, Ys + width * cell);
        }
        public void DrawChess(Graphics G, int X, int Y,Image ImC)
        {
                G.DrawImage(ImC, X * cell + Xs, Y * cell + Ys, cell, cell);
         

                
        }
        public void DrawGame(Graphics G, List<Point> mark)
        {
            
            this.DrawTable(G);
            

            for (int i = 0; i < mark.Count; i++)
            {

                if (i % 2 == 0)
                    DrawChess(G, mark[i].X, mark[i].Y,chess1);
                else
                    DrawChess(G, mark[i].X, mark[i].Y,chess2);
                    
            }
            //if (mark.Count > 0)
                //DrawChess(G, mark[mark.Count - 1].X, mark[mark.Count - 1].Y, Im);
             
        }
    }
}
