using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_6
{
    internal class Address
    {
        public string? city;
        public string? street;
        public byte zipCode ;


        public Address(string? _city , string? _street , byte _zipCode )
        {
            this.city = _city;
            this.street = _street;
            this.zipCode = _zipCode;
        }


        public override string ToString()
        {
            return $"Address:\n\tCity = {city}\n\tStreet = {street}\n\tZipCode = {zipCode}";
        }
    }
}
