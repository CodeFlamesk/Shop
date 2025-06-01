using System;
using System.Collections.Generic;

namespace Shop
{
    public class Basket
    {
        public List<Product> AddProductsToBasket(List<Product> products)
        {
            List<Product> basket = new List<Product>();

            while (true)
            {
                Console.WriteLine("Виберіть продукт по номеру який ви хочете добавити в корзину, напишіть exit для виходу");
                string answerDima = Console.ReadLine().ToLower();

                if (answerDima == "exit")
                {
                    break;
                }

                if (int.TryParse(answerDima, out int productIndex) && productIndex > 0 && productIndex <= products.Count)
                {
                    basket.Add(products[productIndex - 1]);
                }
                else
                {
                    Console.WriteLine("Неправильний номер продукту. Спробуйте ще раз.");
                }
            }

            return basket;
        }
    }
}