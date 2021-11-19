using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace CaroDL
{
    class MayTinh
    {
        public int count;
        private int level;
        private int Xcm;
        private int Ycm;

        public MayTinh()
        {
            count = -1;
            level = 2;//hard

            Xcm = -1;
            Ycm = -1;
        }
        public void set_level(int lv)
        {
            level = lv;
        }

        public int get_mycost(int[] a,int myvar)
        {
            a[6] = myvar;

            //duong 5
            for (int i = 1; i < 6; i++)
                if (a[i + 1] + a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 5*myvar && (a[i] == 0 || a[i + 6] == 0) && a[i] != myvar && a[i + 6] != myvar)
                    return 2000;

            for (int i = 1; i < 5; i++)
                if (a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 4*myvar && a[i + 1] == 0 && a[i] == 0 && a[i + 6] == 0 && a[i + 7] == 0)
                    return 600;

            //duong 4 lien
            for (int i = 1; i < 5; i++)
                if (a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 4*myvar && ((a[i] == 0 && a[i + 1] == 0) || (a[i + 6] == 0 && a[i + 7] == 0)))
                    return 300;

            //duong 4 khong lien

            for (int i = 1; i <= 5; i++)
                if (a[i + 1] + a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 4*myvar && (a[i + 6] == 0 || a[i] == 0) && a[i] != myvar && a[i + 6] != myvar)
                    return 260;

            //duong 3 trong lien
            for (int i = 1; i < 4; i++)
                if (a[i + 3] + a[i + 4] + a[i + 5] == 3*myvar && a[i + 1] == 0 && a[i + 2] == 0 && a[i + 6] == 0 && a[i + 7] == 0)
                    return 200;


            for (int i = 1; i < 5; i++)
                if (a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 3*myvar && a[i + 1] == 0 && a[i + 6] == 0 && a[i] == 0 && a[i + 7] == 0)
                    return 180;

            //duong 3 bit
            for (int i = 1; i < 4; i++)
                if (a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 3*myvar && (a[i] + a[i + 1] == 0 || a[i + 6] + a[i + 7] == 0))
                    return 80;
            //----------------------------------------------------------------------------
            if (a[7] + a[8] == myvar && a[9] <= 0 && a[10] <= 0 && a[4] <= 0 && a[5] <= 0)
                return 60;

            if (a[5] + a[4] == myvar && a[3] <= 0 && a[2] <= 0 && a[7] <= 0 && a[8] <= 0)
                return 60;

            if (a[9] == myvar && a[5] == 0 && a[4] <= 0 && a[7] <= 0 && a[8] <= 0 && a[10] <= 0)
                if (count> 5)
                    return 60;
            if (a[3] == myvar && a[7] == 0 && a[8] <= 0 && a[4] <= 0 && a[5] <= 0 && a[2] <= 0)
                if (count > 5)
                    return 60;
            //----------------------------------------------------------------------------

            return 0;
        }

        public int get_yourcost(int[] a,int var)
        {
            a[6] = var;
            //////////////////////////////
            //chan duong 4 bit 1 dau
            for (int i = 1; i < 6; i++)
                if (a[i + 1] + a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 5*var && (a[5] + a[7] == 2*var || a[5] + a[7] == var) && (a[i] == 0 || a[i + 6] == 0) && a[i] != var && a[i + 6] != var)
                    return 1000;

            if (a[1] + a[2] + a[3] + a[4] + a[5] == 4*var && a[0] == -var && a[7] != var)
                return 920;

            if (a[7] + a[8] + a[9] + a[10] + a[11] == 4*var && a[12] == -var && a[5] != var)
                return 920;

            for (int i = 1; i < 5; i++)
                if (a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 4*var && a[i + 1] == 0 && a[i + 6] == 0 && a[i] == 0 && a[i + 7] == 0)
                    return 360;
            //xo oo    xoo o

            if (a[6] + a[7] + a[8] + a[9] + a[10] == 4*var && a[4] == 0 && a[5] == 0 && a[11] == 0 && a[12] == 0)
                return 300;

            if (a[6] + a[5] + a[4] + a[3] + a[2] == 4*var && a[7] == 0 && a[8] == 0 && a[1] == 0 && a[0] == 0)
                return 300;


            //chan duong 3 bit 1 dau
            for (int i = 1; i < 5; i++)
                if (a[i + 2] + a[i + 3] + a[i + 4] + a[i + 5] == 4*var && ((a[i] == 0 && a[i + 1] == 0) || (a[i + 6] == 0 && a[i + 7] == 0)) && (a[5] + a[7] == 2 * var || a[5] + a[7] == var))
                    return 160;
            //x ooo 
            if (a[6] + a[7] + a[8] + a[9] + a[10] == 4*var && a[5] == 0 && a[11] == 0)
                return 160;

            if (a[6] + a[5] + a[4] + a[3] + a[2] == 4*var && a[7] == 0 && a[1] == 0)
                return 160;

            //chan duong 2
            if (a[6] + a[7] + a[8] + a[9] == 3*var && a[4] == 0 && a[11] == 0 && (a[5] + a[10] == var))
                return 160;

            if (a[6] + a[5] + a[4] + a[3] == 3*var && a[1] == 0 && a[8] == 0 && (a[2] + a[7] == var))
                return 160;

            //oxo
            if (a[5] + a[6] + a[7] == 3*var && a[3] == 0 && a[4] == 0 && a[8] == 0 && a[9] == 0)
                return 120;

            //xoo_
            if (a[6] + a[7] + a[8] + a[9] == 3*var && a[5] == 0 && a[10] == 0 && a[4] == 0 && a[11] == 0)
                return 120;

            //_oox
            if (a[6] + a[5] + a[4] + a[3] == 3*var && a[2] == 0 && a[1] == 0 && a[7] == 0 && a[8] == 0)
                return 120;

            //chan duong 1
            if (a[7] == var && a[8] == 0 && a[9] == 0 && a[5] == 0 && a[4] == 0)
                return 40;

            if (a[5] == var && a[4] == 0 && a[3] == 0 && a[7] == 0 && a[8] == 0)
                return 40;

            if (a[6] + a[7] + a[8] == 2*var && a[4] == 0 && a[5] == 0 && a[9] == 0 && a[10] == 0)
                if (count > 2)
                    return 40;


            if (a[6] + a[5] + a[4] == 2*var && a[2] == 0 && a[3] == 0 && a[7] == 0 && a[8] == 0)
                if (count > 2)
                    return 40;


            return 0;
        }
        public Point DanhCo_luat_VietNam(int[][] A,int width,int height,int myvar)
        {
            Point P = new Point();
            count++;

            if (count == 0 && myvar == 1)
            {
                P.X = 6+width / 2;
                P.Y = 6+height / 2;
                if(A[P.X][P.Y]==0)
                    return P;
            }

            //bon mang ung voi 4 duong ngang,doc,cheo 1,cheo 2.
            //tam anh huong la 6 quan co
            int[][] a = new int[4][];
            for (int i = 0; i < 4; i++)
                a[i] = new int[13];

            int costmax = 0;

            List<int> X = new List<int>();
            List<int> Y = new List<int>();
            List<int> UT = new List<int>();

            int[][] cost = new int[width+12][];

            for (int i = 0; i < width+12; i++)
                cost[i] = new int[height+12];

            for(int x=6;x<width+6;x++)
                for (int y = 6; y < height + 6; y++)
                {
                    cost[x][y] = 0;

                    bool oooo = false;
                    bool ooo = false;
                    bool oo = false;

                    bool xxxxx = false;
                    bool xxxx = false;
                    bool xxx = false;

                    bool Ytwo = false;
                    bool Ctwo = false;

                    if (A[x][y] == 0)
                    {
                        int num_of_line_two_of_Computer = 0;
                        int num_of_line_two_of_You = 0;
                        int you = 0;
                        int com = 0;

                        for (int i = 0; i < 4; i++)
                        {
                            get_array(A, x, y, a[i], i);

                            you = this.get_yourcost(a[i],-myvar);
                            com = this.get_mycost(a[i],myvar);


                            if (com <= 80 && com > 0)
                                num_of_line_two_of_Computer++;

                            if (you == 40)
                                num_of_line_two_of_You++;

                            cost[x][y] += you;
                            cost[x][y] += com;


                            if (com >= 180 && count <= 8 && myvar==-1)
                                cost[x][y] -= com / 4;

                            //------------------------
                            if (com == 2000)
                            {
                                P.X = x;
                                P.Y = y;

                                return P;
                            }
                            //------------------------
                            if (you > 900)
                            {
                                oooo = true;
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(0);
                            }
                            //------------------------
                            if (com == 600)
                            {
                                xxxxx = true;
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(1);
                            }
                            //------------------------
                            if (com >= 260)
                            {
                                xxxx = true;
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(2);
                            }
                            //------------------------
                            if (you >= 300)
                            {
                                ooo = true;
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(2);
                            }

                            //------------------------
                            if (xxx == true && (com >= 180 && com <= 300))
                            {
                                Ctwo = true;
                                cost[x][y] += 60;//bonus
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(3);
                            }
                            //------------------------
                            if (com >= 180)
                            {
                                xxx = true;
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(4);
                            }
                            //------------------------
                            if (oo == true && you >= 120)
                            {
                                cost[x][y] += 60;//bonus
                                Ytwo = true;
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(4);
                            }
                            if (you >= 120)
                                oo = true;


                        }
                        //------------------------------------------------------------------

                        if (num_of_line_two_of_Computer >= 3)
                                cost[x][y] += 60;
                   
                        if (num_of_line_two_of_You >= 3)
                                cost[x][y] += 60;

                        if (num_of_line_two_of_You == 2 && num_of_line_two_of_Computer == 2)
                                cost[x][y] += 60;

                            if (count > 6)
                            {
                                //------------------------
                                if (A[x + 1][y + 2] == 1 || A[x + 1][y + 2] == -1)
                                    cost[x][y] += 10;
                                if (A[x - 1][y + 2] == 1 || A[x - 1][y + 2] == -1)
                                    cost[x][y] += 10;
                                if (A[x + 1][y - 2] == 1 || A[x + 1][y - 2] == -1)
                                    cost[x][y] += 10;
                                if (A[x - 1][y - 2] == 1 || A[x - 1][y - 2] == -1)
                                    cost[x][y] += 10;

                                if (A[x + 2][y + 1] == 1 || A[x + 2][y + 1] == -1)
                                    cost[x][y] += 10;
                                if (A[x - 2][y + 1] == 1 || A[x - 2][y + 1] == -1)
                                    cost[x][y] += 10;
                                if (A[x + 2][y - 1] == 1 || A[x + 2][y - 1] == -1)
                                    cost[x][y] += 10;
                                if (A[x - 2][y - 1] == 1 || A[x - 2][y - 1] == -1)
                                    cost[x][y] += 10;
                                //---------------------------
                            }

                            if (cost[x][y] > costmax)
                            {
                                costmax = cost[x][y];
                                Xcm = x;
                                Ycm = y;
                            }

                    }
     
                }
            //CAP DO EXTREME----------------------------------------------
            if (level > 2)
            {
            }
            //CAP DO EXTREME----------------------------------------------


            int min = 5;

             for (int i = 0; i < UT.Count; i++)
                 if (UT[i] < min)
                     min = UT[i];
            //CAP DO HARD-------------------------------------------------
             if (min <= 4 && level > 1)
             {
                 int index = -1;

                 Random ranClass = new Random();
                 int ran = (int)Math.Floor(30 * ranClass.NextDouble());

                 if (ran % 2 == 0)
                 {
                     for (int i = 0; i < UT.Count; i++)
                         if ((UT[i] == min) && (index == -1 || cost[X[index]][Y[index]] < cost[X[i]][Y[i]]))
                             index = i;
                 }
                 else
                 {
                     for (int i = UT.Count - 1; i >= 0; i--)
                         if ((UT[i] == min) && (index == -1 || cost[X[index]][Y[index]] < cost[X[i]][Y[i]]))
                             index = i;
                 }

                 P.X = X[index];
                 P.Y = Y[index];

                 return P;
             }
             //CAP DO HARD-------------------------------------------------
             else
             {
                 Random ranClass = new Random();

                 int ran = (int)Math.Floor(30 * ranClass.NextDouble());

                 int choice = 0;

                 for (int x = 5; x <= 23; x++)
                     for (int y = 5; y <= 23; y++)
                         if (costmax <= cost[x][y] + 30)
                             choice++;

                 choice = ran % choice;

                 for (int x = 5; x <= 23; x++)
                     for (int y = 5; y <= 23; y++)
                         if (costmax <= cost[x][y] + 30)
                         {
                             if (choice == 0)
                             {

                                 P.X = x;
                                 P.Y = y;
                                 //MessageBox.Show("max:" + costmax + ",choose:" + cost[x][y]);
                                 return P;
                             }
                             choice--;
                         }
             }


            return P;
        }

        public void get_array(int [][]A,int x, int y, int[] a, int dir)
        {
            //var is:ooooooOoooooo

            switch (dir)
            {
                case 0://nam ngang
                    for (int i = 0; i < 13; i++)
                        a[i] = A[x - 6 + i][y];
                    break;
                case 1://duong cheo 1
                    for (int i = 0; i < 13; i++)
                        a[i] = A[x - 6 + i][y - 6 + i];
                    break;
                case 2://duong cheo 2
                    for (int i = 0; i < 13; i++)
                        a[i] = A[x - 6 + i][y + 6 - i];
                    break;
                case 3://nam doc
                    for (int i = 0; i < 13; i++)
                        a[i] = A[x][y - 6 + i];
                    break;
            }
        }
        ///////////////////////////////////////////////////////////////////////
        //////////////GOMOKU///////////////////////////////////////////////////
        public int get_mycost_GMK(int []a,int myvar)
        {
            a[6] = myvar;

            int i;
            //5 win
            for(i=0;i<5;i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] + a[i + 2] == 5 * myvar)
                    return 200;

            for (i = 0; i < 4; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] == 4 * myvar)
                    return 100;

            for(i=0;i<5;i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] + a[i + 2] == 4 * myvar)
                    return 60;
            for(i=0;i<4;i++)
                if(a[i+6]+a[i+5]+a[i+4]+a[i+3]==3*myvar&&(a[i+7]==0||a[i+2]==0))
                    return 50;
            for (i = 0; i < 4; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] == 3 * myvar)
                    return 30;
            for (i = 0; i < 3; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] == 2 * myvar && (a[i + 7] == 0 || a[i + 3] == 0) && (a[i + 8] == 0 || a[i + 2] == 0))
                    return 20;

            return 0;
        }
        public int get_yourcost_GMK(int []a,int myvar)
        {
            a[6] = myvar;

            int i;

            for (i = 0; i < 5; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] + a[i + 2] == 5 * myvar)
                    return 100;

            for (i = 0; i < 5; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] + a[i + 2] == 4 * myvar&&(a[i+6]==0||a[i+2]==0))
                    return 50;


            for (i = 0; i < 5; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] + a[i + 2] == 4 * myvar)
                    return 30;

            for (i = 0; i < 4; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] == 3 * myvar && (a[i + 7] == 0 || a[i + 2] == 0))
                    return 30;

            for (i = 0; i < 4; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] + a[i + 3] == 3 * myvar)
                    return 20;
            for (i = 0; i < 3; i++)
                if (a[i + 6] + a[i + 5] + a[i + 4] == 2 * myvar && (a[i + 7] == 0 || a[i + 3] == 0) && (a[i + 8] == 0 || a[i + 2] == 0))
                    return 20;


            return 0;
        }
        public Point DanhCo_luat_Gomoku(int[][] A,int width,int height,int myvar)
        {
            Point P=new Point();

            count++;
           

            if (count == 0 && myvar == 1)
            {
                P.X = 6 + width / 2;
                P.Y = 6 + height / 2;
                if (A[P.X][P.Y] == 0)
                    return P;
            }
            ///////////////////////////////////////////////
            int[][] a = new int[4][];
            for (int i = 0; i < 4; i++)
                a[i] = new int[13];

            int[][] cost = new int[width + 12][];

            for (int i = 0; i < width + 12; i++)
                cost[i] = new int[height + 12];

            int costmax = 0;

            List<int> X = new List<int>();
            List<int> Y = new List<int>();
            List<int> UT = new List<int>();

            ///////////////////////////////////////////////

            for(int x=6;x<width+6;x++)
                for (int y = 6; y < height + 6; y++)
                {
                    if (A[x][y] == 0)
                    {
                        cost[x][y] = 0;
                        int you = 0;
                        int com = 0;
                        int twoline=0;

                        for (int i = 0; i < 4; i++)
                        {
                            get_array(A, x, y, a[i], i);

                            you = this.get_yourcost_GMK(a[i], -myvar);
                            com = this.get_mycost_GMK(a[i], myvar);

                            if (you == 20 || you == 30 ||you==50|| com == 20 ||com==30|| com == 50)
                                twoline++;

                            cost[x][y] += you;
                            cost[x][y] += com;

                            if (com == 200||you==100)
                            {
                                Point w= new Point(x, y);
                                return w;
                            }
                            if (com == 100)
                            {
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(0);
                            }

                            if (com == 60 || you == 50)//danh 4 hay chan 3
                            {
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(1);
                            }
                            if (com == 50)
                            {
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(2);
                            }
                            if (com == 20 || you == 20||you==30)
                            {
                                X.Add(x);
                                Y.Add(y);
                                UT.Add(3);
                            }
                            
                        }
                        cost[x][y] += twoline * 10;
                       
                    }
                }

            
            int min = 3;

             for (int i = 0; i < UT.Count; i++)
                 if (UT[i] < min)
                     min = UT[i];
          
            int index = -1;

            Random ranClass = new Random();

            int ran = (int)Math.Floor(30 * ranClass.NextDouble());

                 if (ran % 2 == 0)
                 {
                     for (int i = 0; i < UT.Count; i++)
                         if ((UT[i] == min) && (index == -1 || cost[X[index]][Y[index]] < cost[X[i]][Y[i]]))
                             index = i;
                 }
                 else
                 {
                     for (int i = UT.Count - 1; i >= 0; i--)
                         if ((UT[i] == min) && (index == -1 || cost[X[index]][Y[index]] < cost[X[i]][Y[i]]))
                             index = i;
                 }

                 P.X = X[index];
                 P.Y = Y[index];

                 return P;

            return P;
        }
        //////////////GOMOKU///////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////
    }
}
