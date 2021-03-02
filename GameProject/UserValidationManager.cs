using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1993 && gamer.FirstName == "Burak" && gamer.LastName=="Tekin" && gamer.IdentityNumber==0000)
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
