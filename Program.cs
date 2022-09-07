using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            //Type       Referencenavn      Instans (Parentheses is the Constructor)
            myPerson myFirstObject = new myPerson();
            //myFirstObject.str = "Some text";
            myFirstObject.Person();
            myFirstObject.Age = 55;

            //new instance of an object without reference
            new myPerson().MyMethod();

            Personn myyPerson = new Person();
            myyPerson.Name = "Hugo";

            myyPerson.DoB = new DateTime(2000, 1, 1);
            //Console.WriteLine(myPerson.GetAge() ); 
            myyPerson.DoB = new DateTime(2000, 12, 1);
            //Console.WriteLine(myPerson.GetAge() );

            Console.WriteLine(myyPerson.Age);
            Console.ReadKey();
        }
    }
}