namespace TsetenExtraProduct;

public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Department { get; set; }

    public ProductCategory(int id, string name, string description, string department)
    {
        Id = id;
        Name = name;
        Description = description;
        Department = department;
    }
}