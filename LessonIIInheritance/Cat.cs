using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIIInheritance
{
    class Cat : Mammal
    {
        public Cat()
        {
            base.Name = "Cat";
        }

        public override void SayHello()
        {
            Console.WriteLine("Mew");
        }

        public override void Move(int x, int y)
        {
            base.Move(x, y);
            Console.WriteLine("czlapie sobie");
        }
    }
}
