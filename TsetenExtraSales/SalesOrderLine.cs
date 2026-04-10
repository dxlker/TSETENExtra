using TsetenExtraProduct;

namespace TsetenExtraSales;

public class SalesOrderLine
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public double TotalPrice { get; set; }

    public SalesOrderLine(int id, Product product, int quantity)
    {
        Id = id;
        Product = product;
        Quantity = quantity;
        TotalPrice = product.Price * quantity;
    }
}