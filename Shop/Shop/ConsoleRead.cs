namespace Shop
{
    public class ConsoleRead
    {
        private decimal ReadDecimalFromConsole(string prompt)
        {
            string textError = "Некоректне число, будь ласка, спробуйте ще раз.";
            decimal value;

            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out value))
                    return value;

                Console.WriteLine(textError);
            }
        }

        public List<ClientInfo> UserInfo()
        {
            Console.WriteLine("Welcome to the Shop!");

            decimal moneyDima = ReadDecimalFromConsole("Вкажiть початкову суму грошей для Дiми");
            ClientInfo user1 = new ClientInfo("Dima", moneyDima);

            decimal moneyYura = ReadDecimalFromConsole("Вкажiть початкову суму грошей для Юри");
            ClientInfo user2 = new ClientInfo("Юра", moneyYura);

            decimal moneyDasha = ReadDecimalFromConsole("Вкажiть початкову суму грошей для Дашi");
            ClientInfo user3 = new ClientInfo("Даша", moneyDasha);

            Console.WriteLine("Бюджет для наших подавнів");
            Console.WriteLine($"{user1.Name} {user1.MyWallet.Money} грн");
            Console.WriteLine($"{user2.Name} {user2.MyWallet.Money} грн");
            Console.WriteLine($"{user3.Name} {user3.MyWallet.Money} грн");

            Console.WriteLine("Тепер посилаєм їх в магазин за монстром i приколюхами для Зеленського");

            return new List<ClientInfo> { user1, user2, user3 };
        }
    }
}