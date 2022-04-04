using System;
namespace PersonDataMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPerson = new List<Person>();
            AddRecord(listOfPerson);
            CheckFirstName(listOfPerson);
            CheckLastName(listOfPerson);
            CheckEmail(listOfPerson);
            CheckMobile(listOfPerson);
            CheckPassword(listOfPerson);
        }
        private static void AddRecord(List<Person> listPerson)
        {
            listPerson.Add(new Person( "Prateek", "Pai", "prateekpai@gmail.com", 9945007207, "123"));
            listPerson.Add(new Person("suhas", "Manchi", "suhasManchi@gmail.Com", 7760054592, "456"));
            listPerson.Add(new Person("Manjesh", "Gowda", "ManjeshGowda@gmail.com", 8256351495, "789" ));
        }

        private static void CheckFirstName(List<Person> listPerson)
        {
            bool val = listPerson.Any(x => x.FirstName == "Prateek");

            if (val)
            {
                Console.WriteLine("First Name is Matched");
            }
            else
            {
                Console.WriteLine("First Name is not Matched");
            }
        }
        private static void CheckLastName(List<Person> listPerson)
        {
            bool val = listPerson.Any(x => x.LastName == "Pai");

            if (val)
            {
                Console.WriteLine("Last Name is Matched");
            }
            else
            {
                Console.WriteLine("Last Name is not Matched");
            }
        }
        private static void CheckEmail(List<Person> listPerson)
        {
            bool val = listPerson.Any(x => x.Email == "Prateekpai@gmail.com");

            if (val)
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is not Valid");
            }
        }
        private static void CheckMobile(List<Person> listPerson)
        {
            bool val = listPerson.Any(x => x.Mobile == 9945007207);

            if (val)
            {
                Console.WriteLine("Mobile Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobile Number is not Valid");
            }
        }
        private static void CheckPassword(List<Person> listPerson)
        {
            bool val = listPerson.Any(x => x.Password == "123");

            if (val)
            {
                Console.WriteLine("Password is Correct");
            }
            else
            {
                Console.WriteLine("Entered Password is not Correct");
            }
        }
    }
}
