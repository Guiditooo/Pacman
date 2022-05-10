using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.IntTwo;

namespace Pacman
{
    class Game
    {
        private List<Player> playerList;
        static private TileMap tm = new TileMap();

        public Game()
        {
            playerList = new List<Player>();
        }

        public void RunGame()
        {

        }

        private void Loop()
        {
            do
            {
                Update();
                Draw();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private void Update()
        {

        }

        private void Draw()
        {

        }

        private void Input()
        {

        }

    }
}
