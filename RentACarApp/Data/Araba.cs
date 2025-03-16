using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp.Data
{
    public class Araba : IArac
    {
        public string Marka { get; set; }
        public string Model { get ; set ; }
        public int Yil { get; set; }
        public string Renk { get ; set; }
        public decimal GunlukUcret { get; set; }
        public bool MusaitlikDurumu { get; set; }
        public AracTipi AracTipi { get; set; }
        public decimal ToplamUcret { get; set; }

        public void BilgiGoster()
        {
           
        }
        public override string ToString()
        {
            return Marka + " " + Model + " " + Yil + " " + Renk + " " + GunlukUcret + " " + AracTipi ;
        }
    }
}
