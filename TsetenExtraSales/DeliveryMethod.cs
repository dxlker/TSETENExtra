namespace TsetenExtraSales;

public class DeliveryMethod
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DeliveryDays { get; set; }
    public double Price { get; set; }

    public DeliveryMethod(int id, string name, int days, double price)
    {
        Id = id;
        Name = name;
        DeliveryDays = days;
        Price = price;
    }
}