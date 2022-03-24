 

using POOConceptos;
using System;
using System.Collections.Generic;

Console.WriteLine("Hello World!");

Employee employee1 = new SalaryEmployee()
{
    Id = 10,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990,10,01),
    HiringDate = new Date(2022,01,01),
    IsActive = true,
    Salary = 75456.45M
};

Employee employee2 = new CommissionEmployee()
{
    Id = 20,
    FirstName = "Patricia",
    LastName = "Martinez",
    BirthDate = new Date(1992, 01, 23),
    HiringDate = new Date(2022, 01, 01),
    IsActive = true,
    Sales = 1000000M,
    CommissionPercentaje = 0.03F
    
};

Employee employee3 = new HourlyEmployee()
{
    Id = 30,
    FirstName = "Juan",
    LastName = "Perez",
    BirthDate = new Date(1993, 03, 12),
    HiringDate = new Date(2022, 01, 01),
    IsActive = true,
    HourValue = 420.23M,
    Hours = 123.5F

};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 40,
    FirstName = "Carla",
    LastName = "Martinez",
    BirthDate = new Date(1994, 05, 22),
    HiringDate = new Date(2022, 01, 01),
    IsActive = true,
    CommissionPercentaje = 0.025F,
    Sales = 500000,
    Base = 35000M

};
//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>
{
    employee1,employee2,employee3,employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                   ========");
Console.WriteLine($"Total             {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "IPhone 12",
    Id = 1,
    Price = 300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Samsung A2",
    Id = 2,
    Price = 60000M,
    Quantity = 4
};

ICollection<Invoice> invoices = new List<Invoice>
{
    invoice1,invoice2
};

foreach(Invoice invoice in invoices)
{
    Console.WriteLine(invoice);
}