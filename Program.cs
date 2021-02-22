using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer {
                Id = 1308,
                BirthYear = 1998,
                FirstName ="Nazlican",
                Surname = "ISLER",
                CitizenNumber = 57166282344
            });

        }
    }
}
