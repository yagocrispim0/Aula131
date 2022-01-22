using Aula131.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

List<Employee> Employees = new List<Employee>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Employee #" + i + " data:");
    Console.Write("Outsorced: (y/n)? ");
    char outsourced = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Aditional charge: ");

    if (outsourced == 'y')
    {
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Employee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
        Employees.Add(outsourcedEmployee);
    }
    else
    {
        Employee employee = new Employee(name, hours, valuePerHour);
        Employees.Add(employee);
    }

    

}

Console.WriteLine();
Console.WriteLine("PAYMENTS:");

foreach (Employee element in Employees)
{
    StringBuilder sb = new StringBuilder();
    sb.Append(element.Name + " - $ ");
    sb.Append(element.Payment().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine(sb);

}
