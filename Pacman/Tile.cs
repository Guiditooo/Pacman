using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.IntTwo;

namespace Pacman
{
    namespace Tiles
    {
        enum TileType
        {
            Floor,
            Collectible,
            Wall,
            Default
        }
    }
    class Tile
    {
        private Int2 pos;
        public Int2 Pos
        {
            get
            {
                return pos;
            }
            set
            {
                pos = value;
            }
        }
        
        private Tiles.TileType tileType;
        public Tiles.TileType TileType
        {
            get
            {
                return tileType;
            }
            set
            {
                tileType = value;
            }
        }
        public Tile()
        {
            pos = new Int2();
            Pos.X = 0;
            Pos.Y = 0;
            TileType = Tiles.TileType.Default;
        }
        public Tile(int x, int y, Tiles.TileType tileType)
        {
            pos = new Int2();
            Pos.X = x;
            Pos.Y = y;
            TileType = tileType;
        }

        public void Draw()
        {
            Console.SetCursorPosition(Pos.X, Pos.Y);
            switch (TileType)
            {
                case Tiles.TileType.Floor:
                    Console.WriteLine(" ");
                    break;
                case Tiles.TileType.Collectible:
                    Console.WriteLine("©");
                    break;
                case Tiles.TileType.Wall:
                    Console.WriteLine("■");
                    break;
                case Tiles.TileType.Default:
                    Console.WriteLine("®");
                    break;
                default:
                    break;
            }
        }

    }
}
