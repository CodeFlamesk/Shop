namespace Shop;

public class ProductPrinter
{
    public void PrintAll()
    {
        ProductRepository productRepository = new ProductRepository();
        List<Product> products = productRepository.GetAllProducts();

        int i = 1;
        foreach (Product product in products)
        {
            Console.WriteLine($"{i++}: {product.Name} {product.Price}");
        }
    }
}