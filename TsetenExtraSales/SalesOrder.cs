namespace TsetenExtraSales;

public class SalesOrder
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<SalesOrderLine> OrderLines { get; set; }
    public double Discount { get; set; }
    public DateTime OrderDate { get; set; }

    public SalesOrder(int id, Customer customer, double discount = 0)
    {
        Id = id;
        Customer = customer;
        Discount = discount;
        OrderLines = new List<SalesOrderLine>();
        OrderDate = DateTime.Now;
    }

    public double GetSubtotal()
    {
        return OrderLines.Sum(x => x.TotalPrice);
    }

    public double GetTotal()
    {
        return GetSubtotal() * (1 - Discount);
    }

    public void PrintInvoice()
    {
        Console.WriteLine("\n===== FACTUUR =====");
        Console.WriteLine($"Klant: {Customer.Name}");

        foreach (var line in OrderLines)
        {
            Console.WriteLine($"{line.Product.Name} x {line.Quantity} = €{line.TotalPrice}");
        }

        Console.WriteLine($"Totaal: €{GetTotal()}");
    }
}