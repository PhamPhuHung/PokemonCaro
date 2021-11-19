using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCaro
{
    public class Player
    {
        private int code;
        private int password;
        private string name;
        private string description;
        private int gender;
        private string wonGames;
        private string loseGames;
        private int rank;
        private int row;
        private List<string> imageList;
        private Image mark;

        public int Code { get => code; set => code = value; }
        public int Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Gender { get => gender; set => gender = value; }
        public string WonGames { get => wonGames; set => wonGames = value; }
        public string LoseGames { get => loseGames; set => loseGames = value; }
        public int Rank { get => rank; set => rank = value; }
        public int Row { get => row; set => row = value; }
        public List<string> ImageList { get => imageList; set => imageList = value; }
        public Image Mark { get => mark; set => mark = value; }

        public Player(int code, int password, string name, string description, int gender, string wonGames, string loseGames, int rank, int row, List<string> imageList, Image mark)
        {
            this.Code = code;
            this.Password = password;
            this.Name = name;
            this.Description = description;
            this.Gender = gender;
            this.WonGames = wonGames;
            this.LoseGames = loseGames;
            this.Rank = rank;
            this.Row = row;
            this.ImageList = imageList;
            this.Mark = mark;
        }
    }
}
