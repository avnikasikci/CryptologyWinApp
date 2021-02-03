using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EuclidExtendedSolutionService
    {

        private long x, y, d;

        public long X
        {
            get
            {
                return this.x;
            }
        }

        public long Y
        {
            get
            {
                return this.y;
            }
        }

        public long D
        {
            get
            {
                return this.d;
            }
        }

        public EuclidExtendedSolutionService(long x, long y, long d)
        {
            this.x = x;
            this.y = y;
            this.d = d;
        }
        /*Örnek Kullanım*/
        //EuclidExtended ee = new EuclidExtended(a, b);
        //EuclidExtendedSolution result = ee.solve();

    }
}
