using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._6._0
{
    public class ExpressionBodiedFunctionMembers : IRunnable
    {
        public void Run()
        {
            var employee = new Employee() { Name = "Chuck", SurName = "Norris", Age = 77 };
            var fullName = employee.FullName;
            var description = employee.GetDescription();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string FullName => $"{Name} {SurName}";
        public string GetDescription() => $"{FullName} has {Age} years";
    }
}
