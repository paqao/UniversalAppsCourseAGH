using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonVIIGenerics
{
    class IntGeneric<T> where T : IBankSystem
    {
        public T BankSystemObject { get; set; }

        public TG GenericMethodG<TG>(TG param) where TG : IBankSystem
        {
            param.Money = param.Money * 2;
            return param;
        } 
    }
}
