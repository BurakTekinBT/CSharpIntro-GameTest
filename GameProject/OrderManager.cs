using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class OrderManager
    {
        void SatisYap()
        {
            Console.WriteLine("Satış yapıldı:");
        }

        void SatisYap(Campaign campaign)
        {
            Console.WriteLine("Kampanyalı satış yapıldı. \n Kampanya Adı :  " + campaign.KampanyaAdi) ;
        }
    }
}
