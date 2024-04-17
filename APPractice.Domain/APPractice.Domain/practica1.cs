using System;

namespace APPractice.Domain
{
    public abstract class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }

        public Person(string name, int age) {

            Name = name;
            Age = age;

        }

        public abstract void Imprimir();
    }

    public class Employee : Person
    {
        public Employee(string name,int age,double salary): base(name,age){

            Salary = salary;
        
        }
        public double Salary { get; set; }
        public override void Imprimir()
        {
            Console.WriteLine("Name: {0} Salary: {1}",Name,Salary);

        }
    }

    public class Program {

        public static void Main() { 
        
            Person person = new Employee("Juan Ernesto",25,15000);
            person.Imprimir();

            Employee employee = new Employee("Francisco Javier", 30, 50000);
            employee.Imprimir();
        }
    
    }
}
