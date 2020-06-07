using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.Contracts;

namespace ABZaliczenieObiektowe
{
    class Employees
    {
        public List<Employee> employee = new List<Employee>();

        public Employee this[int i] //indeksator dla pracowników 
        {
            get { return employee[i]; }
            set { employee[i] = value; }
        }

        public Employee this[string name, string surname] //indeksator z imienia i nazwiska 
        {
            get { return employee.Find(employee => employee.name == name); }
            set
            {
                Employee e = employee.Find(person => person.name == name && person.surname == surname);
                e = value;
            }
        }


        // walidacja czy osoba istnieje: 
        public bool does_exist(string name, string surname)
        {
            return employee.Any(person => person.name == name && person.surname == surname);
        }

        //dodawanie, usuwanie, wyswietlanie: 
        public void add_employee(string name, string surname)
        {
            if (does_exist(name, surname) == false)
            {
                employee.Add(new Employee()
                {
                    name = name,
                    surname = surname,
                });
                Console.WriteLine("Dodano " + name + " " + surname);
            }
            else
                Console.WriteLine("Taka osoba juz istnieje");
        }

        public void remove_employee(string name, string surname)
        {
            if (does_exist(name, surname)==true)
            {
                Console.WriteLine("Usunieto " + name + " " + surname);
                Employee e = employee.Find(person => person.name == name && person.surname == surname);
                //tutaj mozna byloby zastosowac indeksator ale nie umiem
                employee.Remove(e);
            }
            else
                Console.WriteLine("Nie ma takiej osoby");
        }

        public List<Employee> get_employees()
        {
            return this.employee;
        }
    }
}
