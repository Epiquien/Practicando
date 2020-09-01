using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,contador=0;
            Console.Write("Digite cantidad de numeros a evaluar sin son impares: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n;i++)
            {
                Console.Write("Ingrese numero: " );
                 numero = int.Parse(Console.ReadLine());
                if (numero % 2 != 0)
                {
                    contador++;
                  
                    
                }
               
                
            }
            Console.Write("Cantidad de numeros impares: " + contador);
            Console.ReadKey();
        }
    }
}
