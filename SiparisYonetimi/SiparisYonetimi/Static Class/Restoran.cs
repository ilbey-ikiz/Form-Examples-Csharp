using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi
{
    public static class Restoran
    {
        public static int ToplamCiroBul(List<Siparis> siparisler)
        {
            int toplamCiro = 0;
            foreach (var siparis in siparisler)
            {
                foreach (var sos in siparis.Soslar )
                {
                    toplamCiro += sos.Fiyat*siparis.MenuAdet;
                }
            }
            
            foreach (var item in siparisler)
            {
                toplamCiro += (item.Menu.Fiyat)*item.MenuAdet;
            }
            return toplamCiro;
        }

        public static int ToplamSiparisBul(List<Siparis> siparisler)
        {
            int toplamSiparis = 0;
            foreach (var siparis in siparisler)
                toplamSiparis += siparis.MenuAdet;
            return toplamSiparis;
        }

        public static int SatilanUrunAdediBul(List<Siparis> siparisler)
        {
            int satilanUrunAdet = 0;
            foreach (var item in siparisler)
            {
                satilanUrunAdet += (item.MenuAdet*item.Soslar.Count)+item.MenuAdet;
            }
            return satilanUrunAdet;
        }

        public static int ToplamSosKazanciBul(List<Siparis> siparisler)
        {
            int toplamSosCiro = 0;
            foreach (var siparis in siparisler)
            {
                foreach (var sos in siparis.Soslar)
                {
                    toplamSosCiro += sos.Fiyat;
                }
                toplamSosCiro *= siparis.MenuAdet;
            }
            return toplamSosCiro;
        }



    }
}


