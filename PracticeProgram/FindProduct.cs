using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class FindProduct
    {
        public int findProduct(int x , int y)
        {

            if (x < y)
            {
                return findProduct(y, x);
            }
            else if (y != 0)
            {
                return (x + findProduct(x, y - 1));
            }
            else
            {
                return 0;
            }
        }
    }
}
