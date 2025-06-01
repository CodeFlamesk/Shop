namespace Shop;

public class Product
{
    private string _massageErrorName = "Ім'я вказано некоректно";
    private string _massageErrorQuantity = "Вітаю, вашого товару немає, вам не прийдеться витрачати гроші";
    private string _massageErrorPrice = "Ціна продукту не може йти в мінус";
    
    private string _textNameProduct = "Вас цікавить:";
    private string _textPriceProduct = "Його ціна:";
    private string _textQuantityProduct = "Кількість в магазині:";
    private string _textCurrency = "грн";
    
  private string _name;
    private int _quantity;
    private decimal _price;

    public Product(string name, int quantity, decimal price)
    {
        Name=name;
        Quantity=quantity;
        Price=price;
    }
   
    public string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Length < 40)
            {
                _name = value;
            }
            else
            {
                throw new ArgumentException(_massageErrorName);
            }
        }
    }

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value >= 0)
            {
                _quantity=value;
            }
            else
            {
                Console.WriteLine(_massageErrorQuantity);
            }
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value >= 0)
            {
                _price=value;
            }
            else
            {
                Console.WriteLine(_massageErrorPrice);
            }
        }
    }
    
    public void Information()
    {
     Console.WriteLine(_textNameProduct + Name);   
     Console.WriteLine(_textPriceProduct + Price + _textCurrency);   
     Console.WriteLine(_textQuantityProduct + Quantity);   
    }
    }

class Bread : Product
{
    public Bread(string name, int quantity, decimal price) : base(name, quantity, price){}
}
class Milk : Product
{
    public Milk(string name, int quantity, decimal price) : base(name, quantity, price){}
}
class Beer : Product
{
    public Beer(string name, int quantity, decimal price) : base(name, quantity, price){}
}class Watermelon : Product
{
    public Watermelon(string name, int quantity, decimal price) : base(name, quantity, price){}
}
class Chips : Product
{
    public Chips(string name, int quantity, decimal price) : base(name, quantity, price){}
}
class  Cheese : Product
{
    public Cheese(string name, int quantity, decimal price) : base(name, quantity, price){}
}
