using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skatteberegner
{
    public class Beregning
    {
        /// <summary>
        /// Beregning af skatpligtig beløb
        /// </summary>
        /// <param name="julegave">Værdi af julegaver</param>
        /// <param name="andenGave">Værdi andre gaver</param>
        /// <returns></returns>
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            
            if (andenGave + julegave <= 1200)
                return 0;
   
            if (julegave <= 900)
                return andenGave;

            return andenGave + julegave;
            
        }
    }
}
