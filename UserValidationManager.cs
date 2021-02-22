using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1308 && gamer.BirthYear == 1998 && gamer.FirstName == "Nazlican"
                && gamer.Surname == "ISLER" && gamer.CitizenNumber == 57166282344)
                return true;
            else
                return false;

        }
    }
}
