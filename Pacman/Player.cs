using Generic.IntTwo;

namespace Pacman
{
    class Player
    {
        Int2 pos;
        int hp;
        int points;
        char avatar;

        static int playerCount = 0;

        ControlKeys controlKeys;

        public Player(char avatar, Int2 spawn)
        {
            pos = spawn;
            hp = 3;
            points = 0;
            this.avatar = avatar;
            playerCount++;
        }

        public void MoveUp()
        {
            pos.Y--;
        }
        public void MoveDown()
        {
            pos.Y++;
        }
        public void MoveLeft()
        {
            pos.X--;
        }
        public void MoveRight()
        {
            pos.X++;
        }

        public void GetHit()
        {
            hp--;
        }

        public void GainPoint()
        {
            points++;
        }

        public char GetAvatar() => avatar;

    }
}