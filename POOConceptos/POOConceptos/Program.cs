

using POOConceptos;
using System;

Console.WriteLine("Hello World!");

Date date1 = new Date(2022, 2, 11);

try
{
    Console.WriteLine(new Date(2022, 2, 11));
    Console.WriteLine(new Date(2022, 2, 11));
    Console.WriteLine(new Date(2022, 2, 29));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}