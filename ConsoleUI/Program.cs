using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main()
        {
            CategoryTest();

            Console.WriteLine();

            ProductTest();
        }

        private static void CategoryTest()
        {
            var categoryManager = new CategoryManager(new EfCategoryDal());
            var result = categoryManager.GetAll();

            Console.WriteLine("Category List");
            foreach (var category in result)
            {
                Console.WriteLine(category.Name);
            }
        }

        private static void ProductTest()
        {
            var productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();

            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine("Product List");
            foreach (var p in result.Data)
            {
                Console.WriteLine($"{p.ProductName} (in {p.CategoryName}) ({p.UnitsInStock} in stock)");
            }
        }
    }
}
