using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetor
{
    internal class Pensionato
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Pensionato(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return 
                   $"Nome: {Name}\n" +
                   $"Email: {Email}";
        }
    }
}
