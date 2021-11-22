using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros
{
    class Recursividad
    {
        public double factorial(double n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return n * factorial(n - 1);




        }
        public double potencia(int n,int p)
        {
            if (p == 0) return 1;
            return n * potencia(n, p - 1);
        }


    }
}

