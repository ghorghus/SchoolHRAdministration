﻿using HRAdministrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHRAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<Iemployee> employees = new List<Iemployee>();

            SeedData(employees);

            foreach (Iemployee employee in employees)
            {
                totalSalaries += employee.Salary;
            }

            Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");

            Console.ReadKey();
        }


        public static void SeedData(List<Iemployee> employees)
        {
            Iemployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Fisher",
                Salary = 40000
            };

            employees.Add(teacher1);

            Iemployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Thomas",
                Salary = 40000
            };

            employees.Add(teacher2);

            Iemployee HeadOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Brenda",
                LastName = "Mullins",
                Salary = 50000
            };

            employees.Add(HeadOfDepartment);

            Iemployee DeputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Devlin",
                LastName = "Brown",
                Salary = 60000
            };

            employees.Add(DeputyHeadMaster);

            Iemployee HeadMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "Damien",
                LastName = "Jones",
                Salary = 80000
            };

            employees.Add(HeadMaster);
        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary = 0.02m); }

    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary = 0.03m); }

    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary = 0.04m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary = 0.05m); }
    }

}