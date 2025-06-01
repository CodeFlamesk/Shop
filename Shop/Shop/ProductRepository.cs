namespace Shop;

public class ProductRepository
{
    public  List<Product> GetAllProducts()
    {
        return new List<Product>
        {
            new Beer("Tegenseer Hell Beer", 10, 60),
            new Bread("Сiрий хліб з висiвками", 10, 60),
            new Cheese("Сир з плiснявою", 10, 60),
            new Chips("Pringles", 10, 60),
            new Milk("Black Milk", 10, 60),
            new Watermelon("Greate Watermelon", 10, 90),
        };
    }
    
}