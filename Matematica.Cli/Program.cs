using System;

namespace Matematica.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            double primerNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            var calculadora = new Matematica.Negocio.Calculadora();
            var resultado = calculadora.SumarC(primerNumero, segundoNumero);

            Console.WriteLine("La suma de los dos numeros es:" + resultado);
        }
    }
}
