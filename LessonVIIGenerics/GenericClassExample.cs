using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonVIIGenerics
{
    public class GenericClassExample<T>
    {
        public GenericClassExample(T param)
        {
            this.InnerObject = param;
        } 

        public T InnerObject { get; set; }
    
    }
}
