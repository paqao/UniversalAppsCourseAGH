using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonVIIGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClassExample<String> example = new GenericClassExample<string>("12345");
            Console.WriteLine(example.InnerObject);

            GenericClassExample<int> intExample = new GenericClassExample<int>(1234);
            Console.WriteLine(intExample.InnerObject);

            IntGeneric<IBankSystem> myBankGeneric = new IntGeneric<IBankSystem>();
            IntGeneric<IBankAccount> myIntExample = new IntGeneric<IBankAccount>();
            
            // unfortunate is not working
            // IntGeneric<int> a = new IntGeneric<int>(); 
            Account a = new Account();
            a.Money = 50;
            var tmp = myBankGeneric.GenericMethodG(a);
            Console.ReadKey();
        }
    }
}
