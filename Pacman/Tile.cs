using System;
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
        private Tiles.TileType tileType;

        public Tile()
        {
            pos = new Int2();
            pos.X = 0;
            pos.Y = 0;
            tileType = Tiles.TileType.Default;
        }
        public Tile(int x, int y, Tiles.TileType tileType)
        {
            pos = new Int2();
            pos.X = x;
            pos.Y = y;
            this.tileType = tileType;
        }

        public void Draw()
        {
            Console.SetCursorPosition(pos.X, pos.Y);
            switch (tileType)
            {
                case Tiles.TileType.Floor:
                    Console.WriteLine(".");
                    break;
                case Tiles.TileType.Collectible:
                    Console.WriteLine("©");
                    break;
                case Tiles.TileType.Wall:
                    Console.WriteLine("█");
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
