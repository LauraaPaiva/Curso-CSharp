using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E132.Entities
{
    internal class Client
    {
        internal String Name { get; set; }
        internal String Email { get; set; }
        internal DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
