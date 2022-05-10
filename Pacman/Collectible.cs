using System;
using Generic.IntTwo;

namespace Pacman
{
    namespace Collect
    {
        enum CollectibleType
        {
            Default = 0,
            Point,
            Fruit,
            Power
        }
    }
    class Collectible
    {
        private char shape;
        private int pointsToGive;
        private Int2 pos;
        private Collect.CollectibleType collectibleType;

        public Collect.CollectibleType CollectibleType { get; set; }

        public Collectible(int pointsToGive, Collect.CollectibleType collectibleType, Int2 pos)
        {
            this.pointsToGive = pointsToGive;
            this.collectibleType = collectibleType;
            this.pos = pos;
            SetShape();
        }

        public void Draw()
        {
            Console.SetCursorPosition(pos.X, pos.Y);
        }

        private void SetShape()
        {
            switch (collectibleType)
            {
                case Collect.CollectibleType.Point:
                    shape = 'o';
                    break;
                case Collect.CollectibleType.Fruit:
                    shape = 'Ó';
                    break;
                case Collect.CollectibleType.Power:
                    shape = '§';
                    break;
                case Collect.CollectibleType.Default:
                default:
                    shape = '½';
                    break;
            }
        }
    }
}
