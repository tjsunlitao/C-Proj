using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RestaurantExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.orderEventHandler += waiter.Action;
            customer.cai();
         

     
       
        }
    }



    public delegate void OrderEventHandler(Customer customer);

    public class OrderEventArgs:EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }
       
    public class Customer 
    {
        public event OrderEventHandler orderEventHandler;
        public void cai()
        {
            Console.ReadLine();
            OrderEventArgs cai = new OrderEventArgs();
            cai.DishName = "宫保鸡丁";
            cai.Size = "大份";
            this.orderEventHandler.Invoke(this);
            ;
            Console.ReadLine();

        }

   

    }

    public class Waiter
    {
        public void Action(Customer customer)
        {
            Console.WriteLine("我是Waiter,我要上菜啦！");
           // Console.WriteLine("{0},{1}",e.DishName,e.Size);
        }
    }
}
