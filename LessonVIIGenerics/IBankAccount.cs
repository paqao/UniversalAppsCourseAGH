using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonVIIGenerics
{
    class IBankAccount : IBankSystem
    {
        public decimal Money { get; set; }
    }
}
