using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //yeni sistem eklendi varsayalım

            GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1993, FirstName = "Burak", LastName = "Tekin", IdentityNumber = 0000 });

        }
    }
}
