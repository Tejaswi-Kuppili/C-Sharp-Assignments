using System;
class Program
{
    public static void Details(in int id1, Employee obj1, out Employee obj2, out int id2)
    {
        Console.WriteLine("ID 1: " + id1);
        id2 = id1 + 250;
        Console.WriteLine("ID 2: " + id2);
        obj1 = new Employee();
        obj2 = new Employee();
        obj1.num = 30;
        obj2.num = 40;
    }
    public static void Main(string[] args)
    {
        int temp1 = 100;
        int temp2;
        Employee emp1 = new Employee();
        Employee emp2 = new Employee();
        emp1.num = 500;
        Details(temp1, emp1, out emp2, out temp2);
        Console.WriteLine("Employee 2: " + emp2.num);
        Console.ReadKey();
    }
}
class Employee
{
    public int num;
}
