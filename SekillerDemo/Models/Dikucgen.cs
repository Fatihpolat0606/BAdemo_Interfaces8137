using SekillerDemo.Models.Bases;

namespace SekillerDemo.Models
{
    public class Dikucgen : IKoseliSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        

        public double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + Genislik + Yukseklik;
        }
    }
}
