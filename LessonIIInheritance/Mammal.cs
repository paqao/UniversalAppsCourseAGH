using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIIInheritance
{
    abstract  class Mammal : IAnimal
    {
        private string _name;
        private int positionX;
        private int positionY;
        public virtual void Move(int x, int y)
        {
            positionX = x;
            positionY = y;
            Console.WriteLine("moja pozycja to {0} {1}",x,y);
        }

        public abstract void SayHello();

        public string Name { get { return _name; } protected set { _name = value; } }
    }
}
