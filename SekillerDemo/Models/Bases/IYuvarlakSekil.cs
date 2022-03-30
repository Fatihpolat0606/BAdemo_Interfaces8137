using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo.Models.Bases
{
    public interface IYuvarlakSekil : IHesapla
    {
        double Yaricap { get; set; }
        bool PiUcMu { get; set; }

        //double AlanHesapla();
        //double CevreHesapla();
    }
}
