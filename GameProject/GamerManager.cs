using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    // bir manager sınıfı içinde başka manager kullanacaksan onu newlememek lazım //micro service
    class GamerManager : IGamerService // bunu interface ekleme sebebimiz hiç bir sınıf çıplak kalmamalı
    {
        IUserValidation _userValidationService; //fake bir sistem kullanmış olduk

        public GamerManager(IUserValidation userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu" + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız kayıt başarısız");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi" + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi" + gamer.FirstName);
        }
    }
}
