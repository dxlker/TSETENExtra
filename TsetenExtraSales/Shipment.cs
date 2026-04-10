namespace TsetenExtraSales;

public class Shipment
{
    public int Id { get; set; }
    public List<SalesOrder> Orders { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; }
    public string TrackingNumber { get; set; }

    public Shipment(int id, DeliveryMethod method)
    {
        Id = id;
        DeliveryMethod = method;
        Orders = new List<SalesOrder>();
        TrackingNumber = Guid.NewGuid().ToString();
    }

    public double GetTotalWithShipping()
    {
        return Orders.Sum(o => o.GetTotal()) + DeliveryMethod.Price;
    }

    public void PrintShippingLabel()
    {
        var customer = Orders.First().Customer;

        Console.WriteLine("\n===== VERZENDLABEL =====");
        Console.WriteLine($"Naam: {customer.Name}");
        Console.WriteLine($"Adres: {customer.Address}");
        Console.WriteLine($"Tracking: {TrackingNumber}");
    }

    public void PrintPackSlip()
    {
        Console.WriteLine("\n===== PACKSLIP =====");

        foreach (var order in Orders)
        {
            foreach (var line in order.OrderLines)
            {
                Console.WriteLine($"{line.Product.Name} x {line.Quantity}");
            }
        }
    }
}