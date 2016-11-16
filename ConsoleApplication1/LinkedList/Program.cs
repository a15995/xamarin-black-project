using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class User2
    {
        public string Name { get; set; }
        public int AgeInYears { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
    class Program
    {
        static void Main()
        {
            var users = new LinkedList<User2>();

            var hans = new User2
            {
                Name = "Hans",
                AgeInYears = 30
            };


            users.AddToFront(hans);
            Console.WriteLine("default: " + users.ToString());

            Console.WriteLine("custom: " + users.ToString(FormatUser));

            string userAges = users.ToString((User2 u) => u.AgeInYears.ToString());
            Console.WriteLine("age only: " + userAges);

            Console.ReadKey();
        }

        static string FormatUser(User2 user)
        {
            return user.Name + " (" + user.AgeInYears + ")"; }
    }
}