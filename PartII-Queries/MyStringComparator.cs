using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartII_Queries
{
    class MyStringComparator : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int lengthX = x.Length;
            int lengthY = y.Length;
            if (lengthX > lengthY)
                return 1;
            if (lengthX == lengthY)
                return 0;
            return -1;
        }
    }
}
