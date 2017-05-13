using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            prueba demo = new prueba();
            int[] dato = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int resultado = demo.sumarImpares(dato.OfType<int>().ToList());
            Console.WriteLine("El resultado es: "+ resultado);
            Console.ReadLine();
        }


        class prueba
        {

            public int sumarImpares(List<int> valores)
            {
                int resultado = 0;
                for (int x = 0; x < valores.Count; x++)
                {
                    if ((valores[x] % 2) != 0)
                    {
                        resultado = resultado + valores[x];
                    }
                }
                return resultado;
            }
        }
    }
}