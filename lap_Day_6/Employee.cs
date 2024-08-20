using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lap_Day_6
{
    internal class Employee : Person

    {
        int NID;
        int Salary;

        public Employee(string _name , byte _age , int _NID ,  Address _address ,  int  _Salary) : base(_name , _age , _address)
        {
            this.NID = _NID;
            this.Salary = _Salary;
             
        }


        public override string ToString()
        {
            return $"Employee :\n\tNID = {NID}\n\tSalary = {Salary}\n\t{base.ToString()}";
        }

        public override Person Clone()
        {
            return new Employee(Name ,age ,NID , new Address(address?.city , address?.street , address.zipCode) , Salary) ;
        }

    }
}
