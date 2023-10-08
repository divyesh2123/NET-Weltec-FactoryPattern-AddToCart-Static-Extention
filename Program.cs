// See https://aka.ms/new-console-template for more information
using ConsoleApp16;





//Console.WriteLine("Hello, World!");

//INotificationFactory notificationFactory = new NotificationFactory();

//var obj =notificationFactory.GetFactory("Email");



//obj.SendNotification();


//Employee employee = new Employee();

//employee.employeeId = 1;

//employee.addNumbers("64");

//employee.display();

//Employee employee2 = new Employee();

//employee2.addNumbers("66");

//employee2.employeeId = 2;

//var d = Employee.phonenumbers;

//employee2.display();

//string mynumber = "E00001";

//Console.WriteLine (mynumber.HRNID());

IProductRepository productRepository = new ProductRepository();


for(int i=0; i<5;i++)
{
    Product product = new Product();

    Console.WriteLine("Enter ProductName");
    product.ProductNme = Console.ReadLine();

    Console.WriteLine("Enter Price");
    product.Price = Convert.ToInt32(Console.ReadLine());

    productRepository.Add(product);



}

var p = productRepository.TotalDiscount();

Console.WriteLine("discount" + p);
var g = productRepository.GetCartWithDiscount();

foreach(var c in g)
{
    Console.WriteLine(c.Key);

    Console.WriteLine(c.Value);
}
