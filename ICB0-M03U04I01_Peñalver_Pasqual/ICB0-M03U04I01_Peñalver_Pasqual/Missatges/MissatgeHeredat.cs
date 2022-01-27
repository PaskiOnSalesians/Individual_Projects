using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missatges
{
    public class MissatgeHeredat : MissatgeSimple
    {
        public string salutacio(string name, string team)
        {
            string mis = "Benvingut " + name + " a la " + team;
            return mis;
        }

        public string comiatCatala()
        {
            string mis = base.comiat();
            return mis;
        }

        public override string comiat()
        {
            string mis = "Bye, see you later";
            return mis;
        }
    }
}
