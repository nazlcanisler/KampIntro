using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerManager (IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true)
                Console.WriteLine("doğrulama ve kayıt başarılı");
            else
                Console.WriteLine("doğrulama ve kayıt başrısız");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("delete işlemi yapıldı");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("update işlemi yapıld");
        }
    }
}
