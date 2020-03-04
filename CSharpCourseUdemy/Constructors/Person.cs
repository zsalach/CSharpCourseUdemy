using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstName = "Jan";
            lastName = "Kowalski";
            age = 20;
        }

        public Person(int id, string firstName, string lastName, string address, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = "Katowice";
        }

        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }






    }
}
