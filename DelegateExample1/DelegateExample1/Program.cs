using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample1
{
    class Program
    {
        public delegate int Calc(int x, int y);

        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            int z = 0;
            Calculator calculator = new Calculator();
            Calc Calc1 = new Calc(calculator.Add);
            z = Calc1(x, y);
            Console.WriteLine(z);

            

       
        
        }
        class Calculator
        {
            public void Report(string str)
            {
                Console.WriteLine(str);
            }
            public int Add(int x ,int y)
            {
                return  x + y;
            }
            public int Sub(int x, int y)
            {
                return x - y;
            }
            public int Mul(int x, int y)
            {
                return x * y;
            }
            public int Dev(int x, int y)
            {
                return x / y;
            }
        }
    }
}
