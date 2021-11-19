using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCaro
{
    public class Constant
    {
        public static string PLAYER_FOLDER_PATH = Directory.GetCurrentDirectory() + "\\Player";
        public static string CHARACTER_FOLDER_PATH = Directory.GetCurrentDirectory() + "\\Character";
        public static string THEME_FOLDER_PATH = Directory.GetCurrentDirectory() + "\\Theme";
        public static string RESOURCES = Directory.GetCurrentDirectory() + "\\Resources";
        public static string BACKGROUND_MEDIA_FOLDER_PATH = Directory.GetCurrentDirectory() + "\\Background_Media";

        public static string PLAYER_FILE_PATH = Directory.GetCurrentDirectory() + "\\Player\\Player.xlsx";
        public static string CHARACTER_FILE_PATH = Directory.GetCurrentDirectory() + "\\Character\\Character.xlsx";

        public static string[] GENDER = { "Male", "Female" };

        public static string[] GENERATION = { "Gen 1: Kanto", "Gen 2: Johto", "Gen 3: Hoenn", "Gen 4: Sinoh", "Gen 5: Kalos" };

        public static int POKEMON_QUANTITY_PER_GENERATION = 20;
        public static int GENERATION_QUANTITY = 5;

        public static int CHARACTER_WIDTH = 60;
        public static int CHARACTER_HEIGHT = 60;

        public static int CHESS_WIDTH = 33;
        public static int CHESS_HEIGHT = 33;

        public static int CHESSBOARD_WIDTH = 19;
        public static int CHESSBOARD_HEIGHT = 19;

        public static int TIMER_INTERVAL = 100;//ms
        public static int COUNTDOWN_TIME = 30000;//ms
        public static int PROGRESSBAR_MAX = COUNTDOWN_TIME;
        public static int PROGRESSBAR_STEP = TIMER_INTERVAL;

        public enum PLAY_MODE
        {
            OnePlayer = 0,
            TwoPlayer = 1,
            Lan = 2
        }

    }
}
