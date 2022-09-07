using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _00P001
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        //public string Email { get; set; }
        public string Password { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DoB.Year;
            if (today < new DateTime(today.Year, DoB.Month, DoB.Day)) age--;
            return age;
        }
        public string email
        {
            get { return email; }
            set
            {
                if (value.Contains("@") && value.Contains("."))
                {
                    value = email;
                }
                else
                {
                    Console.WriteLine("Email must contain @ or .");
                    value = null;
                }
            }
        }
        public string password
        {
            get { return password; }
            set
            {
                if(value.Length < 6)
                {
                    Console.WriteLine("Must be at least 6 charatchers");
                }
                if (!password.Any(char.IsUpper))

                {
                    Console.WriteLine("The passwords needs at least 1 upper character");

                }
                if (!password.Any(char.IsLower))

                {
                    Console.WriteLine("The passwords needs at least 1 lower character");

                }
            }
        }
    }

}

