using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                X = 0;
                Y = 0;
            }
            public Int2(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
