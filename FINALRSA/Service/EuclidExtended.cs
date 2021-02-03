using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
   
        public class EuclidExtended
        {
            private long a, b;

            public EuclidExtended(long a, long b)
            {
                this.a = a;
                this.b = b;
            }

            public EuclidExtendedSolutionService solve()
            {
                long x0 = 1, xn = 1, y0 = 0, yn = 0, x1 = 0, y1 = 1, f, r = a % b;

                while (r > 0)
                {
                    f = a / b;
                    xn = x0 - f * x1;
                    yn = y0 - f * y1;

                    x0 = x1;
                    y0 = y1;
                    x1 = xn;
                    y1 = yn;
                    a = b;
                    b = r;
                    r = a % b;
                }

                return new EuclidExtendedSolutionService(xn, yn, b);
            }
        }
}
