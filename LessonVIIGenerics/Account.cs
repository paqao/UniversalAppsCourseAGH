using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonVIIGenerics
{
    class Account : IBankSystem
    {
        public decimal Money { get; set; }
    }
}
