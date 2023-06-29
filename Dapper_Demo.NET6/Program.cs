using Dapper_Demo.NET6;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);


var productRepo = new ProductRepository(conn);

var computers = productRepo.GetAllComputers();
var appliances = productRepo.GetAllAppliances();
var phones = productRepo.GetAllPhones();

var cvm = new CustomViewModel();
cvm.Computers = computers;
cvm.Appliances = appliances;
cvm.Phones = phones;

foreach (var product in cvm.Computers)
{
    Console.WriteLine(product.ProductID);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine();
    Console.WriteLine();
}

//Console.WriteLine("===============================");
//Console.WriteLine();

//foreach (var product in cvm.Appliances)
//{
//    Console.WriteLine(product.ProductID);
//    Console.WriteLine(product.Name);
//    Console.WriteLine(product.Price);
//    Console.WriteLine();
//    Console.WriteLine();
//}


//Console.WriteLine("===============================");
//Console.WriteLine();

//foreach (var product in cvm.Phones)
//{
//    Console.WriteLine(product.ProductID);
//    Console.WriteLine(product.Name);
//    Console.WriteLine(product.Price);
//    Console.WriteLine();
//    Console.WriteLine();
//}






















//var departmentRepo = new DepartmentRepository(conn);

////departmentRepo.InsertDepartment("TEST1");
////departmentRepo.UpdateDepartment(15, "UPDATED TEST1");
//departmentRepo.DeleteDepartment(15);

//var departments = departmentRepo.GetAllDepartments();

//foreach (var department in departments)
//{
//    Console.WriteLine(department.DepartmentID);
//    Console.WriteLine(department.Name);
//    Console.WriteLine();
//    Console.WriteLine();
//}







