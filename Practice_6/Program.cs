using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = InputData("a1=");
            double a2 = InputData("a2=");
            double a3 = InputData("a3=");
            double E = InputData("E=");
            int N = (int)InputData("N=");// приведение типов

            List<double> l = FindItems(E,N,a1,a2,a3);

            for (int i = 0; i < l.Count; i++)
                Console.Write("{0} ", l[i]);
            

        }
        public static double InputData(String prompt)
        {
            bool ok = true;
            double v = 0;
            do
            {
                Console.Write(prompt);
                ok = double.TryParse(Console.ReadLine(), out v);
                if (!ok)
                    Console.WriteLine("Введенный символ не является числом. Повторите ввод.");
            }
            while (!ok);
            return v;
        }

        public static List<double> FindItems(double E, int N, double a1, double a2, double a3)
        {
            List<double> R = new List<double>();
            int count = 0;
            while (count < N)
            {
                double NextItem = a3 + 2 * a2 * a1;
                if (Math.Abs(NextItem - a3) > E)
                {
                    R.Add(NextItem);
                    count++;
                }

                a1 = a2;
                a2 = a3;
                a3 = NextItem;

            }
            return R;
        }
    }
}
