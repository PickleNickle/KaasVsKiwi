using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOefn13
{
    internal class Speler
    {
        private string _spelervoornaam;
        private string _spelernaam;

        public Speler()
        {
            SpelerVoornaam = "Bart";
            SpelerNaam = "Badslipper";
        }

        public string SpelerVoornaam
        {
            get { return _spelervoornaam; }
            set { _spelervoornaam = value; }
        }

        public string SpelerNaam
        {
            get { return _spelernaam; }
            set { _spelernaam = value; }
        }

        public string VolNaam()
        {
            return $"De speler noemt {SpelerVoornaam} {SpelerNaam}";
        }
    }
}
