using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maashesaplama
{
    class maasHesapla
    {
        public double netMaas { get; set; }

        public double netMaasHesapla(double brutMaas)
        {
            double temp = 0;
            temp = brutMaas - (brutMaas / 10) - (brutMaas * 2 / 10);
            if (Convert.ToInt32(netMaas) ==Convert.ToInt32( temp))
            {
                return brutMaas;
            }
            else if(netMaas<temp)
            {
                return netMaasHesapla(brutMaas-10);
            }
            else
            {
                return netMaasHesapla(brutMaas + 1);
            }
        }
    }
}
