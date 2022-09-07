using OOP;
namespace _00P001
{
    public class Program
    {
        public static void Main(string[] args)

        {
            Person myPerson = new Person();
            myPerson.Name = "Usama Abbas";
            myPerson.DoB = new DateTime(1998, 03, 22);
            myPerson.email = "uzzy98@outlook.dk";
            myPerson.Password = "uzzy123";
            myPerson.GetAge();
            //myPerson.email();

            Person myPerson1 = new Person();
            myPerson1.Name = "Selin Chaprazla";
            myPerson1.DoB = new DateTime(1999, 01, 01);
            myPerson1.email = "Selin99@outlook.dk";
            myPerson1.Password = "Selin123";
            myPerson1.GetAge();
            //myPerson1.email();

            Person myPerson2 = new Person();
            myPerson2.Name = "Daniel daniel";
            myPerson2.DoB = new DateTime(2004, 01, 01);
            myPerson2.email = "daniel04@outlook.dk";
            myPerson2.Password = "dani123";
            myPerson2.GetAge();
            //myPerson2.email();

            Person myPerson3 = new Person();
            myPerson3.Name = "Lars Larsen";
            myPerson3.DoB = new DateTime(1945, 05, 15);
            myPerson3.email = "Lars2200@outlook.dk";
            myPerson3.Password = "Lars123";
            myPerson3.GetAge();
            //myPerson3.email();
        }
        
    }
    
}

