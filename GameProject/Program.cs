using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1996, FirstName = "Akdeniz", LastName = "Akdogan", IdentityNumber = 12345 });
        }
    }
}
