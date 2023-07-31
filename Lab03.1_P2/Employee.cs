using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab03._1_P2
{
    internal class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary;

        public Employee() { }
        public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
            this.basicSalary = basicSalary;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
        public double SalaryLevel { get => salaryLevel; set => salaryLevel = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }


        public double GetIncome()
        {
            return SalaryLevel * BasicSalary;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ma id: ");
            id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            yearOfBirth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma bac luong: ");
            salaryLevel = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban: ");
            basicSalary = Double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("----------Hien thi thong tin------------");
            Console.WriteLine("id:{0}, name:{1}, yearOfBirth:{2}, salaryLevel:{3}, basicSalary:{4}, GetIncome:{5}", Id, Name, YearOfBirth, SalaryLevel,BasicSalary, GetIncome());
        }
    }
}
