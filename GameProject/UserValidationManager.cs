using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "Akdeniz"  &&  gamer.LastName == "Akdogan" && gamer.IdentityNumber ==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
