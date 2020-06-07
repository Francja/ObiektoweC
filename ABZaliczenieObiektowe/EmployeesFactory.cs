using System;
using System.Collections.Generic;
using System.Text;

namespace ABZaliczenieObiektowe
{
    class EmployeesFactory
    {
        public static void add_emp1(List<Employee> employee)
        {
            employee.Add(new Employee()
            {
                name = "Filip",
                surname = "Mięso",
            });
        }
        public static void add_emp2(List<Employee> employee)
        {
            employee.Add(new Employee()
            {
                name = "Mateusz",
                surname = "Gryzoń",
            });
        }
    }
}
