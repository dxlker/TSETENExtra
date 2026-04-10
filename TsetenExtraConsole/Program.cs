using TsetenExtraProduct;
using TsetenExtraSales;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Products
var category = new ProductCategory(1, "Electronics", "Devices", "Tech");
var laptop = new Product(1, "Laptop", 1000, category);
var mouse = new Product(2, "Mouse", 25, category);

// Customer
var customer = new Customer(1, "Amber", "Amsterdam", "amber@email.com");

// Orders
var order1 = new SalesOrder(1, customer, 0.1);
order1.OrderLines.Add(new SalesOrderLine(1, laptop, 1));
order1.OrderLines.Add(new SalesOrderLine(2, mouse, 2));

// Delivery
var delivery = new DeliveryMethod(1, "PostNL", 2, 5);

// Shipment
var shipment = new Shipment(1, delivery);
shipment.Orders.Add(order1);

// Output
order1.PrintInvoice();
shipment.PrintPackSlip();
shipment.PrintShippingLabel();

Console.WriteLine($"Totaal incl verzending: €{shipment.GetTotalWithShipping()}");