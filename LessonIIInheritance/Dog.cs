using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIIInheritance
{
    class Dog : Mammal
    {
         public Dog()
        {
            base.Name = "Dog";
        }

        public override void SayHello()
        {
            Console.WriteLine("Haw Haw");
        }

        public override void Move(int x, int y)
        {
            base.Move(x, y);
            Console.WriteLine("biegne sobie");
        }
    }
}
