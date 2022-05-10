using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.IntTwo;

namespace Pacman
{
    namespace Collect
    {
        enum CollectibleType
        {
            Point,
            Fruit,
            Power,
            Default=0
        }
    }
    class Collectible
    {
        private char _shape;
        private int _pointsToGive;
        private Int2 _pos;
        private Collect.CollectibleType _collectibleType = Collect.CollectibleType.Default;

        public Collectible(char shape, int pointsToGive, Collect.CollectibleType collectibleType, Int2 pos)
        {
            _shape = shape;
            _pointsToGive = pointsToGive;
            _collectibleType = collectibleType;
            _pos = pos;
        }
        public Collect.CollectibleType GetCollectibleType() => _collectibleType;


        
    }
}
