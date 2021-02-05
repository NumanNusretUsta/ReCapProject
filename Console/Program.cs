using Business.Concrete;

using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

using DataAccess.Concrete.InMemory;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2002, DailyPrice = 10000, Description = "Dizel" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

                ProductManager productManager = new ProductManager(new InMemoryProductDal());

                foreach (var product in productManager.GetAll())
                {
                    Console.WriteLine(product.Description);

                }
            }
        }
    }
}
