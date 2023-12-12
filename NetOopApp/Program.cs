//Employee employee = new() { Name = "Booby", Age = 35 };
//employee.Salary = 100000;
//employee.Info();
//Console.WriteLine();

//Person person = new("Tom", 29);
//person.Info();
//Console.WriteLine();

//person = new Employee() { Name = "Leo", Age = 22, Salary = 70000 };
//person.Info();
//Console.WriteLine();

Person person = new() { Name = "Person", Age = 25 };
Employee employee = new() { Name = "Employee", Age = 31, Salary = 60000 };
Manager manager = new() { Name = "Manager", Age = 34, Department = "Buh" };

// upcasting
person = new Employee() { Name = "Empl-Person", Age = 33, Salary = 55000 };
person = manager;
//employee = (Employee)person;
//((Employee)person).Info();
//(person as Employee)?.Info();

if (person is Employee)
{
    Employee empl1 = (Employee)person;
    empl1.Info();
}


if (person is Employee empl2)
    empl2.Info();






public class Person
{
    int age;

    public string? Name { set; get; }

    public int Age
    {
        set
        {
            if (value >= 0 && value < 120)
                age = value;
            else
                throw new Exception("Age > 0 and ahe < 120");
        }
        get => age;
    }

    public Person() : this("Anonim", 0) { }

    public Person(string? name, int age)
    {
        Age = age;
        Name = name;
    }

    public void Info()
    {
        Console.Write($"Name: {Name}, Age: {Age}");
    }
}

internal class Employee : Person
{
    public decimal Salary { set; get; }

    public Employee() : base() { }

    //public Employee(string? name, int age)
    //    : base(name, age) { }

    new public void Info()
    {
        base.Info();
        Console.Write($", Salary: {Salary}");
    }
}

class Manager : Person
{
    public string? Department { set; get; }
}
//sealed class Saler : Employee
//{

//}
