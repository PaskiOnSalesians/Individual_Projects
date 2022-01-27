using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missatges
{
    public abstract class MissatgeSimple
    {
        public string salutacio()
        {
            string mis = "Benvingut";
            return mis;
        }

        public string salutacio(string name)
        {
            string mis = "Benvingut " + name;
            return mis;
        }

        public virtual string comiat()
        {
            string mis = "Adeu, fins aviat";
            return mis;
        }
    }
}
