namespace Generic
{
    namespace IntTwo
    {
        class Int2
        {
            private int x;
            private int y;

            public int X 
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }
            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }
            }
            public Int2()
            {
                x = 0;
                y = 0;
            }
            public Int2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
