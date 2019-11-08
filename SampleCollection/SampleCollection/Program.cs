using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCollection
{

    public delegate void fdsfsf(string messages);


    class program
    {
        static void Main(string[] agrs)
        {
            fs k = new fs();
            fdsfsf a = k.bcd;
            fdsfsf b = k.bcd;
            b("sdfsdfsdf");
        }




    }
    class fs
    {
        public void bcd(string messages)
        {
            Console.WriteLine(messages);
        }
    }



}