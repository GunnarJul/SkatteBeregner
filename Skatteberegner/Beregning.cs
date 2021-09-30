using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            
            if (andenGave + julegave <= 1200)
                return 0;
            //Overstiger det samlede beloeb 1200 kr skal alt beskattes

            //Selvom det samlede beløb overstiger 1200 bliver julegaven ikke beskattet hvis dem koster 900 eller under

            if (julegave <= 900)
                return andenGave;

            return andenGave + julegave;
            
        }
    }
}
