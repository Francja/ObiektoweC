using System;
using System.Collections.Generic;
using System.Text;

namespace ABZaliczenieObiektowe
{
    class Employee : Person
    {
        public Employee() //konstruktor klasy Employee
        {
            Console.WriteLine("New Employee added.");
        }

        public override string ToString() //nadpisanie metody ToString()
        {
            return "Imie: " + this.name + " " + this.surname + " - kontrakt: " + this.contract;
        }

        public List<Operation> op_list = new List<Operation>();
        public enum Contract { FullTime, PartTime, Contract }
        public Contract contract;

        //metody działania na klasie Operation: 
        public void add_operation(double p, int o, double b, DateTime d)
        {
            this.op_list.Add(new Operation()
            {
                pay = p,
                overtime = o,
                bonus = b,
                operation_date = d 
            });
        }
        public void display_operations()
        {
            int i = 1; 
            foreach (Operation op in this.op_list)
            {
                Console.WriteLine("|-------Operation number " + i + " -------|");
                Console.WriteLine("   Pay: " + op.pay);
                Console.WriteLine("   Overtime: " + op.overtime);
                Console.WriteLine("   Bonus: " + op.bonus);
                Console.WriteLine("   Date of operation: " + op.operation_date.ToString("dd-MMM-yyyy"));
                i++;
            }
            Console.WriteLine("|---------------------------------|");
        }
        public void display_operation_from_range(DateTime start, DateTime end)
        {
            int i = 1;
            foreach (Operation op in this.op_list)
            {
                if (start < op.operation_date && op.operation_date < end)  
                {
                    Console.WriteLine("|-------Operation number " + i + " -------|");
                    Console.WriteLine("   Pay: " + op.pay);
                    Console.WriteLine("   Overtime: " + op.overtime);
                    Console.WriteLine("   Bonus: " + op.bonus);
                    Console.WriteLine("   Date of operation: " + op.operation_date.ToString("dd-MMM-yyyy"));
                    i++;
                }
            }
            Console.WriteLine("|---------------------------------|");
        }
        public double display_sum()
        {
            double sum = 0;
            foreach (Operation op in this.op_list)
                {
                    sum += op.pay;
                }
            return sum;
        }

        public Operation this[int i] //indeksator dla listy operacji 
        {
            get { return op_list[i]; }
            set { op_list[i] = value; }
        }


        //przeciazanie operatorów: 
        public double salary;

        public static String operator <(Employee a, Employee b)
        {
            if (a.salary < b.salary)
            {
                return("Pensja " + a.name + " jest mniejsza niz " + b.name+"a");
            }
            else return ("Pensja " + a.name + " nie jest mniejsza niz " + b.name+"a");
        }

        public static String operator >(Employee a, Employee b)
        {
            if (a.salary > b.salary)
            {
                return ("Pensja " + a.name+"a" + " jest większa niz " + b.name + "a");
            }
            else return ("Pensja " + a.name+"a" + " nie jest większa niz " + b.name + "a");
        }

        public static double operator +(Employee a, double b)
        {
            return a.salary + b;
        }

        //delegacje:

        public delegate void Delegate(string s);
        public Delegate zmiana = z;
        public static void z(string s)
        {
            Console.WriteLine(s);
        }







    }
}
