using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCaro
{
    class PlayInfo
    {
        private Point point;
        private bool serverTurn;

        public Point Point { get => point; set => point = value; }
        public bool ServerTurn { get => serverTurn; set => serverTurn = value; }

        public PlayInfo(Point point, bool serverTurn)
        {
            this.Point = point;
            this.ServerTurn = serverTurn;
        }
    }
}
