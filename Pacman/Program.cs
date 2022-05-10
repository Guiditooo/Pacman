using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pacman
{
    class Program
    {
        static private TileMap tm = new TileMap();
        static void Main(string[] args)
        {
            do
            {
                Update();
                Draw();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
        static void Update()
        {
            
        }
        static void Draw()
        {
            tm.Draw();
        }

    }
}
