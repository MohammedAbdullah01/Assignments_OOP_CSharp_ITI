using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lap_Day_6
{
    internal abstract class Person
    {
        protected string? Name ;
        protected byte age ;
        protected Address? address;


        

        public Person(string _name, byte _age, Address _address)
        {
            this.Name = _name;
            this.age = _age;
            this.address = _address;
        }

        public abstract Person Clone();


        public override string ToString()
        {
            return $"Name = {Name}\n\tAge = {age}\n\t{address?.ToString()}";
        }



    }

}
