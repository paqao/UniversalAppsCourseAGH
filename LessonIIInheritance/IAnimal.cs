using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIIInheritance
{
    // interfejs - same operacje
    interface IAnimal
    {
        // każde zwierze się porusza
        void Move(int x, int y);

        // ma też cechy
        string Name { get; }
        // set prywatny - ponieważ nazwa nie powinna być nadawana z zewnątrz
    }
}
