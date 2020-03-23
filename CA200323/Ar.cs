using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200323
{
    class Ar
    {
        public DateTime Datum { get; set; }
        public int Benzin { get; set; }
        public int Gazolaj { get; set; }
        public int Kulonbseg => Math.Abs(Benzin - Gazolaj);
        public bool SzokoEv => Datum.Year % 4 == 0;

        public Ar(string s)
        {
            var t = s.Split(';');
            Datum = DateTime.Parse(t[0]);
            Benzin = int.Parse(t[1]);
            Gazolaj = int.Parse(t[2]);
        }
    }
}
