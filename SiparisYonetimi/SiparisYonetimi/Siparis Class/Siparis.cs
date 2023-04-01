using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi
{
    public class Siparis
    {
        public Siparis()
        {
            Menu = new();
            Soslar = new();
        }
        
        public Menu Menu { get; set; }
        public List<Sos> Soslar { get; set; }
        public int MenuAdet { get; set; }
        public double ToplamFiyat { get; private set; }

        public override string ToString()
        {
            ToplamFiyat = 0;
            string soslar = "";
            foreach (var sos in Soslar)
            {
                soslar += sos.Ad + ",";
                ToplamFiyat += sos.Fiyat*MenuAdet;
            }
            ToplamFiyat += Menu.Fiyat*MenuAdet;
           
            string siparis = $"{MenuAdet} adet {Menu} , {soslar} => Toplam Fiyat: {ToplamFiyat} TL";
            return siparis;
        }






    }
}
