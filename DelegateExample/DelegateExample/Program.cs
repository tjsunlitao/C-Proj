using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class program
    {

        delegate void DelegateTest(int s);
        //static void A(string s)
        //{
        //    Console.WriteLine("A:"+s);
        //}
    
         
        static void Main(string[] args)
        {
            DelegateTest testDelC = (s) => { Console.WriteLine(s); };
            //DelegateTest testDelB = delegate(string s){ Console.WriteLine(s); };
            testDelC(12345789);
            
        }
    }
}