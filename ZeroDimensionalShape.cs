using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class ZeroDimensionalShape
    {
        public class Point
        {
            private int cordX;
            private int cordY;
            private int cordZ;

            public int CordX
            {
                get
                {
                    return cordX;
                }
                set
                {
                    cordX = value;
                }
            }

            public int CordY
            {
                get
                {
                    return CordY;
                }
                set
                {
                    CordY = value;
                }
            }

            public int CordZ
            {
                get
                {
                    return cordZ;
                }
                set
                {
                    cordZ = value;
                }
            }

            public void setCordX()
            {
                Console.Write("\nWhat is the x coordinate? ");
                CordX = Convert.ToInt32(Console.ReadLine());
            }

            public void setCordY()
            {
                Console.Write("\nWhat is the y coordinate? ");
                CordY = Convert.ToInt32(Console.ReadLine());
            }

            public void setCordZ()
            {
                Console.Write("\nWhat is the z coordinate? ");
                CordZ = Convert.ToInt32(Console.ReadLine());
            }

            public int getCordX()
            {
                return CordX;
            }

            public int getCordY()
            {
                return CordY;
            }

            public int getCordZ()
            {
                return CordZ;
            }
        }
    }
}
