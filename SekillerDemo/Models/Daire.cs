using SekillerDemo.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo.Models
{
    public class Daire : IYuvarlakSekil
    {
        public double Yaricap { get; set; }
        public bool PiUcMu { get; set; } = true;

        public double AlanHesapla()
        {
            return PiUcMu ? 3 * Math.Pow(Yaricap, 2) : Math.PI * Math.Pow(Yaricap, 2); // ternary operator
        }

        public double CevreHesapla()
        {
            return PiUcMu ? 2 * 3 * Yaricap : 2 * Math.PI * Yaricap;
        }
    }
}
