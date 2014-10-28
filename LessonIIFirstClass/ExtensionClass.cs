using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIIFirstClass
{
    public static class ExtensionClass
    {
        public static int NumberOfDigits(this string text)
        {
            int number = 0;
            foreach(var chara in text.ToCharArray())
            {
                if (char.IsDigit(chara))
                    number++;
            }
            return number;
        }
    }
}
