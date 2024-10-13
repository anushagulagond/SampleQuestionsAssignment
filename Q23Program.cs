using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace SampleQuestionsAssignment
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool ValidateEmployeeId()
        {
            string Pattern = @"['EM']{1}[0-9]{3}";
            return Regex.IsMatch(Id,Pattern);  
        }
        public abstract Employee SalaryCalculation();

        protected Employee(string id, string name)
        {
            Id = id;
            Name = name;
        }

        protected Employee(string id, double salary, string name)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }
    public class Permanent : Employee
    {
        public double BasicPay { set; get; }

        public Permanent(string id, string name,  double BasicPay) : base(id, name)
        {
            this.BasicPay= BasicPay;
        }
        public Permanent(string Id, double salary, string Name): base(Id, salary, Name)
        {

        }
        public override Employee SalaryCalculation()
        {
            double DA = BasicPay * (50 / 100d);
            double HRA = BasicPay * (30d / 100);
            double salary = BasicPay + DA + HRA;
            Employee employee = new Permanent(Id, salary, Name);
            return employee;
        }
    }
    public class Temporary : Employee
    {
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }
        public Temporary(string id, string name,int HrsWorked, int HrlyWages) : base(id, name)
        {
            this.HrlyWages = HrlyWages;
            this.HrsWorked = HrsWorked;       
        }
        public Temporary(string Id, double salary, string Name) : base(Id, salary, Name)
        {

        }
        public override Employee SalaryCalculation()
        {
            double salary = HrsWorked * HrlyWages;
            Employee employee = new Temporary(Id, salary, Name);
            return employee;
        }
    }
    public class Q23Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Permanent\n2.Temporary\nChoose the Employee type");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Enter the employee id");
                    string EmpId=Console.ReadLine();
                    Console.WriteLine("Enter the name");
                    string Name=Console.ReadLine();
                    Console.WriteLine("Enter basic pay");
                    double BasicPay=double.Parse(Console.ReadLine());
                    Permanent permanent =new Permanent(EmpId, Name, BasicPay);
                    if (permanent.ValidateEmployeeId())
                    {
                       var ResultObject= permanent.SalaryCalculation();
                        Console.WriteLine($"Employee id: {ResultObject.Id}, Name: {ResultObject.Name}, Salary: {ResultObject.Salary}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Id");
                    }
                    break;
            case 2: Console.WriteLine("Enter the employee id");
                    string Id = Console.ReadLine();
                    Console.WriteLine("Enter the name");
                    string Name2 = Console.ReadLine();
                    Console.WriteLine("Enter the hours worked");
                    int HrsWorked = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the hourly wages");
                    int HrlyWages = int.Parse(Console.ReadLine());
                    Temporary temporary = new Temporary(Id, Name2, HrsWorked, HrlyWages);
                    if (temporary.ValidateEmployeeId())
                    {
                        var ResultObject = temporary.SalaryCalculation();
                        Console.WriteLine($"Employee id: {ResultObject.Id}, Name: {ResultObject.Name}, Salary: {ResultObject.Salary}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Id");
                    }
                    break;
                Default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
