using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLearnHowToTest
{
    public class ClassWeTest
    {
        public double ItIsSomethingLikeDividing(double number1, int number2)
        {
            double result;
            if (number1 >= 1.0f)
                result = (2*(int) number1)/number2;
            else
                result = ((int)number1 + 1)/number2;

            return result;
        }
    }
}
