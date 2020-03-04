using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            Person person2 = new Person(1, "Łukasz");
            Person person3 = new Person(2, "Magda", "Kowalska");
            Person person4 = new Person(3,"Weronika", "Nowak", "Myślenice", 25, "k");




        }
    }
}
