using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.IntTwo;


namespace Pacman
{
    class TileMap
    {
        private const int TILE_MAP_WIDTH = 10;
        private const int TILE_MAP_HEIGHT = 10;

        private Tile[,] tiles = new Tile[TILE_MAP_WIDTH,TILE_MAP_HEIGHT];

        public Int2 GetTileMapSize()
        {
            return new Int2(TILE_MAP_WIDTH, TILE_MAP_HEIGHT);
        }
        public int GetTileMapHeight() => TILE_MAP_HEIGHT;
        public int GetTileMapWidth() => TILE_MAP_WIDTH;
        public TileMap()
        {
            SetUpTileMap();
        }
        private void SetUpTileMap()
        {
            for (int y = 0; y < TILE_MAP_HEIGHT; y++)
            {
                for (int x = 0; x < TILE_MAP_WIDTH; x++)
                {
                    if (y == 0 || y == TILE_MAP_HEIGHT - 1 || x == 0 || x == TILE_MAP_WIDTH - 1)
                    {
                        tiles[x, y] = new Tile(x, y, Tiles.TileType.Wall);
                    }
                    else
                    {
                        tiles[x, y] = new Tile(x, y, Tiles.TileType.Floor);
                    }
                }
            }
        }

        public void Draw()
        {
            for (int y = 0; y < TILE_MAP_HEIGHT; y++)
            {
                for (int x = 0; x < TILE_MAP_WIDTH; x++)
                {
                    tiles[x, y].Draw();
                }
            }
        }

    }
}
