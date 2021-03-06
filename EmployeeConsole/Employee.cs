﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsole
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int SalaryLevel { get; set; }
        public string Department { get; set; }
        public double WeeklyWorkHours { get; set; }

        public double CalculatedWorkHoursYear => WeeklyWorkHours * 46;

        public double CalculatedSalary
        {
            get { return SalaryLevel * 700.0; }
        }

        public override string ToString()
        {
            return $" Name: {Name} \t\t\n Email: {Email} \t\t\n SalaryLevel: {SalaryLevel} \t\n Salary: {CalculatedSalary} \t\n WeeklyWorkHours: {WeeklyWorkHours} \t\n Department: {Department} \t\n WorkingHoursPerYear: { CalculatedWorkHoursYear} ";
        }

    }
}
