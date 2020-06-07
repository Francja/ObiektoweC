using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace ABZaliczenieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {

            // Zadanie 1
            Console.WriteLine("Zadanie 1");
            Person person = new Person();
            person.name = "Adam";
            person.surname = "Bielewicz";
            Console.WriteLine(person);

            Employee employee = new Employee();
            employee.name = "Krzysztof";
            employee.surname = "Krawczyk";
            employee.contract = Employee.Contract.FullTime;
            Console.WriteLine(employee);

            DateTime date1 = new DateTime(2018, 8, 18);
            employee.add_operation(2247, 17, 500, date1);
            employee.add_operation(3300, 4, 100, DateTime.Now);

            // Zadanie 2
            Console.WriteLine("\n\nZadanie 2");

            Console.WriteLine("\nWyswietlenie wszystkich operacji:\n");
            employee.display_operations();

            Console.WriteLine("\nOperacje z zakresu 2019-2020:\n");
            DateTime d1 = new DateTime(2019, 1, 1);
            DateTime d2 = new DateTime(2020, 12, 31);
            employee.display_operation_from_range(d1, d2);

            Console.WriteLine("\nSuma operacji: " + employee.display_sum());

            // Zadanie 3

            Console.WriteLine("\n\nZadanie 3");
            Console.WriteLine("\nBonus przed zmiana indeksatorem:");
            Console.WriteLine(employee[0].bonus);
            employee[0].pay = 40000;
            Console.WriteLine("Bonus po zmianie indeksatorem:");
            Console.WriteLine(employee[0].bonus);


            Employees employees = new Employees();
            employees.add_employee(employee.name,employee.surname);

            Console.WriteLine("Imie przed zmiana indeksatorem:");
            Console.WriteLine(employees[0].name);
            employees[0].name = "Pszemek";
            Console.WriteLine("Imie po zmianie indeksatorem:");
            Console.WriteLine(employees[0].name);
            Console.WriteLine("Sprawdzenie kontraktu indeksatorem po imieniu i nazwisku:");
            Console.WriteLine(employees["Pszemek", "Krawczyk"].contract);


            // Zadanie 4
            Console.WriteLine("\n\nZadanie 4");

            EmployeesFactory.add_emp1(employees.employee);
            EmployeesFactory.add_emp2(employees.employee);
            employees[1].contract = Employee.Contract.Contract;
            employees[2].contract = Employee.Contract.PartTime;

            //listowanie pracowników:
            foreach (Employee e in employees.get_employees())
            {
                Console.WriteLine(e.ToString());
            }

            // Zadanie 5
            Console.WriteLine("\n\nZadanie 5");
            Console.WriteLine("Porownania:");
            employees[0].salary = 5000; 
            employees[1].salary = 10000; 
            Console.WriteLine(employees[0] < employees[1]);
            Console.WriteLine(employees[0] > employees[1]);
            Console.WriteLine("Zwiekszenie pensji o 1000:");
            Console.WriteLine(employees[0] + 1000);

            // Zadanie 6

            Console.ReadKey();
        }
    }

}


