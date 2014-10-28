using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIIFirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            OurTestClass testClass = new OurTestClass(9);
            testClass.PropertyChanged += TestClassOnPropertyChanged;

        }

        private static void TestClassOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
