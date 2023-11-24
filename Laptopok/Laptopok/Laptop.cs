using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laptopok
{
    internal class Laptop
    {
        public int Azonosito { get; set; }
        public double ProcTipSeb{ get; set; }
        public string Oprendszer { get; set; }
        public string GYartoModell { get; set; }
        public double AkksiElettartam { get; set; }
        public double Suly { get; set; }
        public string VezetekNelkuli { get; set; }

        public Laptop(string r) {


        string[] s = r.Split("|");
            Azonosito = int.Parse(s[0]);
            ProcTipSeb = double.Parse(s[1]);
            Oprendszer= s[2];
            GYartoModell= s[3];
            AkksiElettartam = double.Parse(s[4]);
            Suly= double.Parse(s[5]);
            VezetekNelkuli = s[6];






        }
        public override string ToString()
        {
            return $"Azonosító:{Azonosito}" +
                $",Processzor típusa és sebessége:{ProcTipSeb}" +
                $",Operációs rendszer:{Oprendszer}" +
                $",Gyártó,és modell:{GYartoModell}," +
                $"Akkumlátor élettartama:{AkksiElettartam}," +
                $"Súly:{Suly}," +
                $"Vezeték nélküli kapcsolatok:{VezetekNelkuli}";
        }
    }
}
