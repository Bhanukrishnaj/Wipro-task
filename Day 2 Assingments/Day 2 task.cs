using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        double basicSalary = double.Parse(Console.ReadLine());

        Console.Write("Is Contract Employee (true/false): ");
        bool isContractEmployee = bool.Parse(Console.ReadLine());

        Console.Write("Enter Department Number: ");
        int deptNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Email ID: ");
        string emailId = Console.ReadLine();

        
        double HRA = basicSalary % 15; 
        double MA = basicSalary % 10;
        double TA = basicSalary % 15;  

       double netSalary = basicSalary + HRA + MA + TA;

        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine($"ID: {empId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Basic Salary: {basicSalary:C}");
        Console.WriteLine($"Is Contract Employee: {isContractEmployee}");
        Console.WriteLine($"Department Number: {deptNo}");
        Console.WriteLine($"Email ID: {emailId}");
        Console.WriteLine($"Net Salary: {netSalary:C}"); 
    }
}
