using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace CaroDL
{
    public partial class main : Form
    {
        private bool _is_moving;
        private Point PointClicked;
        private VanCo vanco;

        private bool computer1;
        private bool computer2;
        private bool is_playing;
        private int current_player;

        private int T;
        private int thinking;
        private int Time;


        //flag for option dialog:
        private bool soundon;
        private int sizeboard;
        private int skin;
        private int chess;
        private SoundPlayer Sound;
        private bool is_reading;


        private StreamReader FR;


        public main()
        {
            InitializeComponent();

            vanco = new VanCo();

            Sound = new SoundPlayer("Sound\\bloop.wav");

            //xu ly toa do cac thanh phan lien quan
            Point S = new Point( vanco.banco.cell * vanco.banco.height + vanco.banco.Xs+10,vanco.banco.cell * vanco.banco.width + vanco.banco.Ys+16);
            this.Size = new Size(S);
         
            this.quitgame.Location = new Point(S.X - 60, 4);

            //di chuyen form game
            _is_moving = false;
            this.moving.MouseDown += new MouseEventHandler(moving_MouseDown);
            this.moving.MouseUp += new MouseEventHandler(moving_MouseUp);
            this.moving.MouseMove += new MouseEventHandler(moving_MouseMove);

            //di chuyen shape
            this.shape.Size = new Size(vanco.banco.cell, vanco.banco.cell);

            this.MouseMove+=new MouseEventHandler(main_MouseMove);
            this.shape.MouseClick+=new MouseEventHandler(shape_MouseClick);

            vanco.banco.SetChess(this.chessA.Image, this.chessB.Image);
            vanco.banco.SetBoardIM(this.board.Image);
            //ve lai form
            this.Paint+=new PaintEventHandler(main_Paint);

            //xu ly luot di
            Time = 0;
            T = 0;
            computer1 = false;
            computer2 = true;
            current_player = 1;
            thinking = 12;
            is_playing = false;
            //flag for option dialog
            soundon = true;
            sizeboard = 1;
            skin = 2;
            //flag chess dialog
            chess = 1;

            is_reading = false;


        }
        //ve lai form
        private void main_Paint(object sender, PaintEventArgs e)
        {
          

            if (is_playing == false)
            {
                Pen board = new Pen(Color.Black);
                e.Graphics.DrawRectangle(board, vanco.banco.Xs, vanco.banco.Ys, vanco.banco.width * vanco.banco.cell, vanco.banco.height * vanco.banco.cell);
              
                return;
            }

            vanco.RePaint(e.Graphics);
            this.lastchess.Location= vanco.LastPoint();
          
            
        }

        //quit caro
        private void quitgame_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //di chuyen form game
        private void moving_MouseDown(object sender, MouseEventArgs e)
        {
            _is_moving = true;
            PointClicked = new Point(e.X, e.Y);
        }
        private void moving_MouseUp(object sender, MouseEventArgs e)
        {
            _is_moving = false;
        }
        private void moving_MouseMove(object sender, MouseEventArgs e)
        {
          
            if (_is_moving == true)
            {
                Point N = new Point(this.Location.X + e.X - PointClicked.X, this.Location.Y + e.Y - PointClicked.Y);
                this.Location = N;

            }
        }

        //di chuyen shape
         private void main_MouseMove(object sender, MouseEventArgs e)
        {
          
            if (e.X < vanco.banco.Xs || e.X > this.Width || e.Y < vanco.banco.Ys || e.Y > this.Height)
                return;

          
            Point S = vanco.Process_Point(e.X, e.Y);

            S.X = vanco.banco.Xs + S.X * vanco.banco.cell;
            S.Y = vanco.banco.Ys + S.Y * vanco.banco.cell;

            if (this.shape.Location != S)
            {

                this.shape.Location = S;
            }

        }

        //danh co
        private void shape_MouseClick(object sender, EventArgs e)
        {
            if (is_playing == false)
                return;

            if (vanco.get_winner() == 1)
            {
                status.Text = "Player 1 Win!!!";
                return;
            }

            if (vanco.get_winner() == -1)
            {
                status.Text = "Player 2 Win!!!";
                return;
            }

            int X = (shape.Location.X - vanco.banco.Xs) / vanco.banco.cell;
            int Y = (shape.Location.Y - vanco.banco.Ys) / vanco.banco.cell;

            Graphics G = this.CreateGraphics();
            
            if (current_player == 1 && computer1 == false)
            {
                if (vanco.Human_Push_Chess(G, X, Y) == true)
                {
                    current_player = -1;
                    Sound.Play();
                }

                Point P = vanco.LastPoint();
                Rectangle rc = new Rectangle(P.X,P.Y, vanco.banco.cell, vanco.banco.cell);
                Invalidate(rc);
                T = 0;
               

                return; 
            }

            if (current_player == -1 && computer2 == false)
            {
                if (vanco.Human_Push_Chess(G, X, Y) == true)
                {
                    current_player = 1;
                    Sound.Play();
                }

                Point P = vanco.LastPoint();
                Rectangle rc = new Rectangle(P.X, P.Y, vanco.banco.cell, vanco.banco.cell);
                Invalidate(rc);
                T = 0;

                return;
            }

        }

        private void option_Click(object sender, EventArgs e)
        {
            option op = new option();
            op.Location = new Point(this.Location.X + vanco.banco.Xs-6, this.Location.Y + vanco.banco.Ys-6);
            op.set_confirguration(soundon, sizeboard, skin, vanco.get_rule(),thinking);
            op.ShowDialog();

            if (op.DialogResult == DialogResult.OK)
            {
                if (sizeboard != op.size)
                {
                    sizeboard = op.size;
                    resizeGame(op.size);
                }
                soundon = op.sound;
                if (skin != op.skin)
                {
                    skin = op.skin;
                    if (skin == 1)
                    {
                        this.BackgroundImage = themeRed.Image;
                    }
                    else
                    {
                        if (skin == 2)
                            this.BackgroundImage = themeGreen.Image;
                        else
                            this.BackgroundImage = board.Image;
                    }
            
                    Invalidate();
                }
                vanco.set_rule(op.radioButton1.Checked);
                thinking = 2+op.timethinking.Value * 3;
                T = -1;
            }
        }

        private void black_Click(object sender, EventArgs e)
        {
            
            Chess chs=new Chess();
            switch (chess)
            {
                case 1:chs.radioButton1.Checked = true;
                    break;
                case 2:chs.radioButton2.Checked = true;
                    break;
                case 3:chs.radioButton3.Checked = true;
                    break;
                case 4:chs.radioButton4.Checked = true;
                    break;
            }
            chs.ShowDialog();
            if (chs.DialogResult == DialogResult.OK)
            {
                if (chs.radioButton1.Checked == true)
                {
                    chess = 1;
                    vanco.banco.SetChess(chs.pictureBox1.Image, chs.pictureBox2.Image);
                    chessA.Image = chs.pictureBox1.Image;
                    chessB.Image = chs.pictureBox2.Image;

                }
                if (chs.radioButton2.Checked == true)
                {
                    chess = 2;
                    vanco.banco.SetChess(chs.pictureBox3.Image, chs.pictureBox4.Image);
                    chessA.Image = chs.pictureBox3.Image;
                    chessB.Image = chs.pictureBox4.Image;
                }
                if (chs.radioButton3.Checked == true)
                {
                    chess = 3;
                    vanco.banco.SetChess(chs.pictureBox5.Image, chs.pictureBox6.Image);
                    chessA.Image = chs.pictureBox5.Image;
                    chessB.Image = chs.pictureBox6.Image;
                }
                if (chs.radioButton4.Checked == true)
                {
                    chess = 4;
                    vanco.banco.SetChess(chs.pictureBox7.Image, chs.pictureBox8.Image);
                    chessA.Image = chs.pictureBox7.Image;
                    chessB.Image = chs.pictureBox8.Image;
                }
                Graphics G = this.CreateGraphics();
                vanco.RePaint(G);
                Invalidate();
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            black_Click(sender, e);
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();

            if (is_reading == true)
            {
                if (FR.EndOfStream == false)
                {
             
                    string X = FR.ReadLine();
                    string Y = FR.ReadLine();
                    string Var = FR.ReadLine();
                    int i = Convert.ToInt32(X);
                    int j = Convert.ToInt32(Y);
                    int player = Convert.ToInt32(Var);
                    vanco.SetChess(i, j, player);
                    Sound.Play();
                    vanco.RePaint(G);
                    

                }
                else
                {
                    FR.Close();
                    is_reading = false;
                    is_playing = true;
                    this.status.Text = "finish, play now!!!";
                }
            }


            if (is_playing == false)
                return;

            if (vanco.get_winner()== 1)
            {
                status.Text = "Player 1 Win!!!";
                return;
            }

            if (vanco.get_winner() == -1)
            {
                status.Text = "Player 2 Win!!!";
                return;
            }

           

            if (++T >= thinking)
            {
                T = 0;

                if (current_player == 1&&computer1==true)
                {
                    vanco.Computer_Push_Chess(G);
                    current_player = -1;
                    Sound.Play();
                    return;
                }

                if (current_player == -1 && computer2 == true)
                {
                    vanco.Computer_Push_Chess(G);
                    current_player = 1;
                    Sound.Play();
                    return;
                }

            }
         
        }

        private void newgame_Click(object sender, EventArgs e)
        {
           
            if (is_playing == false)
            {
              
                StartGame sg = new StartGame();
                //sg.Location = new Point(this.Location.X+vanco.banco.Xs,this.Location.Y+ vanco.banco.Ys);
                sg.ShowDialog();
                
            }
            is_playing = true;

            Graphics G = this.CreateGraphics();

            current_player = 1;

            vanco.reset_game();

            vanco.RePaint(G);

            status.Text = " ";

            Time = -1;

            Invalidate();
        }

        private void player1_Click(object sender, EventArgs e)
        {

            Graphics G = this.CreateGraphics();

            if (player1.Text.CompareTo("human") == 0)
            {
                player1.Text = "computer";
                computer1 = true;
            }
            else
            {
                player1.Text = "human";
                computer1 = false;
            }
        }

        private void player2_Click(object sender, EventArgs e)
        {
            if (player2.Text.CompareTo("human") == 0)
            {
                player2.Text = "computer";
                computer2 = true;
            }
            else
            {
                player2.Text = "human";
                computer2 = false;
            }

        }

        private void time_playing_Tick(object sender, EventArgs e)
        {
            if (is_playing == false)
                return;

            Time++;

            int h = Time / 3600;
            string hh = "";
            if (h < 10)
                hh = "0";

            int m = Time / 60;
            string mm = "";
            if (m < 10)
                mm = "0";

            int s = Time % 60;
            string ss = "";
            if (s < 10)
                ss = "0";



            if (vanco.get_winner() == 0)
            {
                tplaying.Text = hh + h + ":" + mm + m + ":" + ss + s;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        
            
        }

        private void congatulation_Tick(object sender, EventArgs e)
        {


            if (vanco.get_winner() != 0)
            {
                if (vanco.get_winner() == 1)
                    pictureBox2.Visible = !pictureBox2.Visible;
                else
                    pictureBox1.Visible = !pictureBox1.Visible;
            }

        }

     

        private void resizeGame(int S)
        {
            Graphics G = this.CreateGraphics();

            switch (S)
            {
                case 1: vanco.banco.SetSize(19, 19, 20);
                    
                    break;
                case 2: vanco.banco.SetSize(24, 24, 20);

                    break;
                case 3: vanco.banco.SetSize(19, 29, 20);

                    break;
                case 4: vanco.banco.SetSize(29, 29, 20);

                    break;
            }
            Point SIZE = new Point(vanco.banco.cell * vanco.banco.height + vanco.banco.Xs + 10, vanco.banco.cell * vanco.banco.width + vanco.banco.Ys + 16);
            this.Size = new Size(SIZE);
            this.quitgame.Location = new Point(SIZE.X - 60, 4);
            vanco.RePaint(G);
            Invalidate();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();
            vanco.Undo();
            vanco.RePaint(G);
            Invalidate();
            status.Text = "oh,undo,chicken!!! :))";
        }

        private void normal_CheckedChanged(object sender, EventArgs e)
        {
            vanco.Set_Level(1);
        }

        private void hard_CheckedChanged(object sender, EventArgs e)
        {
            vanco.Set_Level(2);
        }

        private void extreme_CheckedChanged(object sender, EventArgs e)
        {
            vanco.Set_Level(3);
        }

        private void loadtimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.1;
            else
                loadtimer.Enabled = false;
        }

        private void opengame_Click(object sender, EventArgs e)
        {
            is_playing = false;
            this.lastchess.Location = new Point(5, 5);

            OpenFileDialog Op = new OpenFileDialog();
         
              Graphics G = this.CreateGraphics();

            Op.Filter = "Caro file (*.cro)|*.cro|All file (*.*)|*.*";

            Op.ShowDialog();


            if (Op.FileName.CompareTo("") != 0)
            {
                vanco.reset_game();
         
                Invalidate();


                FR = new StreamReader(Op.FileName);
                is_reading = true;
                status.Text = "Please wait, loading game....";

                int win = Convert.ToInt32(FR.ReadLine());
                vanco.SetWin(win);



            }
            
        }

        private void savegame_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sp = new SaveFileDialog();

            Sp.Filter = "Caro file (*.cro)|*.cro|All file (*.*)|*.*";

            Sp.ShowDialog();

            if (Sp.FileName.CompareTo("") != 0)
                vanco.SaveGame(Sp.FileName);
        }

     
    }
}