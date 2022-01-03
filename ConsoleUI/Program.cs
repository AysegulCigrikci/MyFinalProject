using Business.Concrete;
using DataAccess.Conrete.EntityFramework;
using DataAccess.Conrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    // Open Closed Principle : Gelişime Açık Değişime kapalı mevcut kodlar kalır yeni özellik eklenir.
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);

            }

        }
    }
}
