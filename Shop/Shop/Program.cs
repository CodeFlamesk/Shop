using System;
using System.Collections.Generic;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            List<Product> products = productRepository.GetAllProducts();

            ConsoleRead consoleRead = new ConsoleRead();
            List<ClientInfo> users = consoleRead.UserInfo();

            ProductPrinter productPrinter = new ProductPrinter();

            Payment payment = new Payment();

            int userNumber = 1;

            foreach (ClientInfo user in users)
            {
                Console.WriteLine($"\n(№{userNumber}) Виберіть продукти, які {user.Name} буде купувати:");
                productPrinter.PrintAll();

                Basket basket = new Basket();
                List<Product> basketUser = basket.AddProductsToBasket(products);

                Console.WriteLine($"\nКошик користувача {user.Name}:");
                int c = 1;
                foreach (Product product in basketUser)
                {
                    Console.WriteLine($"{c++}: {product.Name} {product.Price} грн");
                }

                Console.WriteLine("\nОплата:");
                payment.Pay(user, basketUser);

                Console.WriteLine($"\nЗалишок  {user.Name}: {user.MyWallet.Money} грн");

                userNumber++;
            }
        }
    }
}