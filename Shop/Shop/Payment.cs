namespace Shop;

public class Payment
{
  

    private Random random = new Random();

    public bool Pay(ClientInfo client, List<Product> products)
    {
        decimal total = products.Sum(p => p.Price);

        while (total > client.MyWallet.Money && products.Count > 0)
        {
            int indexToRemove = random.Next(products.Count);
            Product removed = products[indexToRemove];
            products.RemoveAt(indexToRemove);

            Console.WriteLine($"Недостатньо коштів. Видалено випадковий товар: {removed.Name} ({removed.Price} грн)");
            total = products.Sum(p => p.Price);
        }

        if (total <= client.MyWallet.Money && products.Count > 0)
        {
            client.MyWallet.Money -= total;
            Console.WriteLine($"Загальна сума покупки: {total} грн");
            Console.WriteLine($"Залишок на рахунку: {client.MyWallet.Money} грн");
            return true;
        }
        else
        {
            Console.WriteLine($"{client.Name} не зміг оплатити навіть після зменшення кошика.");
            return false;
        }
    }
}