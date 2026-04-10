namespace TsetenExtraProduct;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public ProductCategory Category { get; set; }

    public Product(int id, string name, double price, ProductCategory category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }
}