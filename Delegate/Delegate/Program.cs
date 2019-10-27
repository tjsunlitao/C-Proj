using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WrapFactory wrapFactory = new WrapFactory();
            ProductFactory productFactory = new ProductFactory();
            Logger logger = new Logger();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Action<Product> log = new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(func1,log);
            Box box2 = wrapFactory.WrapProduct(func2,log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

        }
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Box
{
    public Product Product { get; set; }
}
 
class Logger
{
    public void Log(Product product)
    {
        Console.WriteLine("Product'{0}'created at {1}.Price is {2}",product.Name,DateTime.UtcNow,product.Price);
    } 
}

class WrapFactory
{
    public Box WrapProduct(Func<Product> getProduct,Action<Product>logCallback)
    {
        Box box = new Box();
        Product product = getProduct.Invoke();
        box.Product = product;
        if (product.Price>=50)
        {
            logCallback.Invoke(product);
        }

        return box;
    }
}

class ProductFactory
{
    public Product MakePizza()
    {
        Product product = new Product();
        product.Name = "Pizza";
        product.Price = 24;
        return product;
    }

    public Product MakeToyCar()
    {
        Product product = new Product();
        product.Name = "ToyCar";
        product.Price = 100;
        return product;
    }
}