using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        //naming convertion - isimlendirme
        //syntax - yazım şekilleri
        public void Ekle(Urun urun)
        {


            Console.WriteLine("Tebrikler,Sepete eklendi!"+ urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklendi" + urunAdi);
        }

        
    }
}
