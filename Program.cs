using ChellengeApp;

var employee = new Employee("Paweł", "Sawicki");
employee.AddGrade(1);
employee.AddGrade(2);
employee.AddGrade(7);
var statistics = employee.GetStatistics();
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
