using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_Day_7
{
    
    internal struct Employee
    {
        string Name;
        double salary;
        Role roles;

        public Employee(string _name , double _salary , Role _roles)
        {
            Name = _name;
            salary = _salary;
            roles = _roles;
            
        }


        public void Display()
        {
            Console.WriteLine($"Employee :\nName Employee:{Name}\nSalary Employee: {salary:C}\nRole Employee: {roles}");
        }

        public void AssignRole(Role role)
        {
            //roles ^= role; // if Role Found It will be deleted

            //OR Soluation Another
            roles = roles | role; 

        }


        public bool HasRole (Role role)
        {
            return  ((roles & role) == role); 
        }
    }
}
