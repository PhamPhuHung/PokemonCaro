using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCaro
{
    public class Theme
    {
        private int code;
        private string name;
        private string background;
        private string serverMark;
        private string clientMark;

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Background { get => background; set => background = value; }
        public string ServerMark { get => serverMark; set => serverMark = value; }
        public string ClientMark { get => clientMark; set => clientMark = value; }
    }
}
