namespace Shop;

public class Wallet
{
    private string _massageErrorGetMoney = "Недостатньо коштів";
    private string _massageSetErrorGetMoney = "Ви не можете поставити від'ємну суму, він також хоче їсти";
    private decimal _money;

    public Wallet(decimal money)
    {
        Money = money;
    }

    public decimal Money
    {
        get
        {
            if (_money < 0)
            {
                Console.WriteLine(_massageErrorGetMoney);
            }

            return _money;
        }
        set
        {
            if (value > 0)
            {
                _money = value;
            }
            else
            {
                Console.WriteLine(_massageSetErrorGetMoney);
            }
        }
    }
}