using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Importe;
            double Subtotal;
            double Impuesto;
            double Descuento;
            double Consumo;
            Console.WriteLine("Ingrese el total cosumido");
            Consumo = double.Parse(Console.ReadLine());
            if (Consumo < 100)
            {
                Descuento = (Consumo * 0.1);
                Console.WriteLine("Su total con descuento es: " + Descuento);

                Subtotal = (Consumo - Descuento);
                Console.WriteLine("El Subtotal a pagar es: " + Subtotal);

                Impuesto = (Subtotal * 0.18);
                Console.WriteLine("Su impuesto a pagar es: " + Impuesto);

                Importe = (Subtotal + Impuesto);
                Console.WriteLine("El importe a pagar es: " + Importe);
            }
            else if (Consumo >= 100)
            {
                Descuento = (Consumo * 0.2);
                Console.WriteLine("Su total con descuento es: " + Descuento);

                Subtotal = (Consumo - Descuento);
                Console.WriteLine("El Subtotal a pagar es: " + Subtotal);

                Impuesto = (Subtotal * 0.18);
                Console.WriteLine("Su impuesto a pagar es: " + Impuesto);

                Importe = (Subtotal + Impuesto);
                Console.WriteLine("El importe a pagar es: " + Importe);
            }
            Console.ReadKey();
        }
    }
}
