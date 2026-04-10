namespace TsetenExtraProduct;

public class Stock
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }

    public Stock(int id, Product product, int quantity, string location)
    {
        Id = id;
        Product = product;
        Quantity = quantity;
        Location = location;
    }
}