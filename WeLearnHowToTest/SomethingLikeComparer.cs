using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearnHowToTest
{
    public class SomethingLikeComparer : IComparer<double>
    {
        private int _counts=0;

        public int Counts
        {
            get { return _counts; }
            set { _counts = value; }
        }

        public int Compare(double x, double y)
        {
            Counts++;
            if (x == y)
                return 0;
            else if (x > y)
                return 1;
            return -1;
        }


    }
}
