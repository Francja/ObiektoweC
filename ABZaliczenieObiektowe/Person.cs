using System;
using System.Collections.Generic;
using System.Text;

namespace ABZaliczenieObiektowe
{
    class Person
    {
        public string name;
        public string surname;

        public Person() //konstruktor klasy Person
        {
            Console.WriteLine("New Person added.");
        }
        public override string ToString() //nadpisanie metody ToString()
        {
            return "Imie: " + this.name + " " + this.surname;
        }
    }
}
