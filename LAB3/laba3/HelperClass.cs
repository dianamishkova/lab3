using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public static class HelperClass
    {
        public static int CheckRange(int thisSize, int maxSize)
        {
            if (thisSize < 0)
            {
                return 0;
            }

            if (thisSize > maxSize)
            {
                return maxSize;
            }

            return thisSize;
        }
    }
}
