

using POOConceptos;
using System;

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
Console.WriteLine(employee1);
Console.WriteLine(employee2);