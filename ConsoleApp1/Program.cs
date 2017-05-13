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
            //Si es -1 es error si el dato de entrada fuera String.
            Console.WriteLine("El resultado es: "+ resultado);
            Console.ReadLine();
        }


        class prueba
        {

            //Si la data fuera numerica.
            //Si la data fuera un string habria que validar que cada valor de entrada fuera correcto.


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

            //Funcion para probar si los datos entregados son numeros
            //solo si no tuvieramos la certeza de que lo que nos entregan fuesen numeros.
            public Boolean comprobarData(List<String> data)
            {
                Boolean resultado = true;
                int n;
                for (int x = 0; x < data.Count; x++)
                {
                    if (int.TryParse(data[x], out n) == false)
                    {
                        resultado = false;
                        break;
                    }
                }

                return resultado;
            }
        }
    }
}