using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JhofreZambranoRobalino3B.clases;


namespace AhofreZambranoRobalino3B
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente dato = new cliente();
            gasolina gasolina = new gasolina();
            float subtotal, iva, total;

            Console.WriteLine("Ingrese Apellidos");
            dato.Apellidos = (Console.ReadLine());
            Console.WriteLine("Ingrese Nombres");
            dato.Nombre = (Console.ReadLine());
            Console.WriteLine("Ingrese Cedula de Identidad");
            dato.Cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Direccion ");
            dato.Direccion = (Console.ReadLine());
            Console.WriteLine("Ingrese gasolina que desea");
            gasolina.Tipo = (Console.ReadLine());
            Console.WriteLine("Cuantos Galones desea");
            gasolina.Galones = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio de gasolina");
            gasolina.Precio = float.Parse(Console.ReadLine());
            subtotal = gasolina.Galones * gasolina.Precio;
            iva = subtotal * 0.12f;
            total = subtotal + iva;
            Console.WriteLine("***************************************************");
            Console.WriteLine("+++++++              EMPRESA                 ++++++");
            Console.WriteLine("+++++++       Tercer Nivel Cía. Ltda         ++++++");
            Console.WriteLine("***************************************************");
            Console.WriteLine(">>>>>>>>>>>>         FACTURA           <<<<<<<<<<<<");
            Console.WriteLine();
            Console.WriteLine("INFORMACION DE CLIENTE");
            Console.WriteLine("Nombre:" + dato.Apellidos + dato.Nombre);
            Console.WriteLine("Cedula de identidad" + dato.Cedula);
            Console.WriteLine("Direccion" + dato.Direccion);
            Console.WriteLine("===================================================");
            Console.WriteLine("INFORMACION DE GASOLINA");
            Console.WriteLine("==" + "Tipo de Gasolina:          " + gasolina.Tipo);
            Console.WriteLine("==" + "Valor por galon:           " + gasolina.Precio);
            Console.WriteLine("==" + "Cantidad de Gasolina:      " + gasolina.Galones);
            Console.WriteLine("Subtutal       " + subtotal);
            Console.WriteLine("Iva            " + iva);
            Console.WriteLine("Total          " + total);
            Console.ReadLine();
        }
    }
}

