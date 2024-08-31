using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraJKP.Utilidades
{
    public class Calculadora
    {
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
        public double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Fatorial(double n1)
        {
            double fatorial = 1;
            for (int i = 1; i <= n1; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }
        public double Seno(double n1)
        {
            double seno;
            n1 = (n1 * (Math.PI)) / 180;
            seno = Math.Sin(n1);

            return seno;
        }
        public double Cosseno(double n1)
        {
            double cosseno;
            n1 = (n1 * (Math.PI)) / 180;
            cosseno = Math.Cos(n1);

            return cosseno;
        }
        public double Tangente(double n1)
        {
            double tangente;
            n1 = (n1 * (Math.PI)) / 180;
            tangente = (Math.Tan(n1));

            return tangente;
        }
        public string Binario(int n1)
        {
            string binario = "";
            while (n1 > 0)
            {   
                int r = n1 % 2;
                binario = r + binario;
                n1 /= 2;
            }

            return binario;
        }
    }
}
