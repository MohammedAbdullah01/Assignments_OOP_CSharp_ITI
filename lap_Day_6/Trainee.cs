using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_6
{
    internal class Trainee : Person
    {
        int NID;
        int IntakeNumber;

        public Trainee(string _name, byte _age, int _NID,  Address _address , int IntakeNumber) : base(_name, _age, _address)
        {
            this.NID = _NID;
            this.IntakeNumber = IntakeNumber;

        }

        public override string ToString()
        {
            return $"Trainee :\n\tNID = {NID}\n\tIntakeNumber = {IntakeNumber}\n\t{base.ToString()}";
        }


        public override Person Clone()
        {
            return new Trainee(Name, age, NID,  new Address(address?.city, address?.street, address.zipCode) , IntakeNumber);
        }
    }
}
