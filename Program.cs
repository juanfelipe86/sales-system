using System;

namespace Sales_system
{
   public class Program
    {
        static void Main(string[] args)
        {
            Vendedor v1 = new Vendedor();
            v1.Nombre = "JUAN";
            v1.Edad = 35;

            Vendedor v2 = new Vendedor();
            v2.Nombre = "LUISA";
            v2.Edad = 28;

            Vendedor v3 = new Vendedor();
            v3.Nombre = "juliana";
            v3.Edad = 25;



            Producto P1 = new Producto();
            P1.Nombre = "Arroz";
            P1.Valor = 1800;

            Producto P2 = new Producto();
            P2.Nombre = "panela";
            P2.Valor = 4000;

            Producto p3 = new Producto();
            p3.Nombre = "chocolate";
            p3.Valor = 5000;

            Venta b1 = new Venta();
            v1.Nombre = "JUAN";
            P1.Nombre = "Arroz";
            b1.Comentario = "calidad";

            Venta b2 = new Venta();
            v2.Nombre = "LUISA";
            P2.Nombre = "panela";
            b2.Comentario = "el consumidor";

            Venta b3 = new Venta();
            v3.Nombre = "juliana";
            p3.Nombre = "chocolate";
            b3.Comentario = "mejor sabor";



            double suma;
            suma = 1800 + 4000 + 5000;

            System.Console.WriteLine("informacin de la venta" + b1.Producto, b1.Vendedor, b1.Comentario);
            System.Console.WriteLine("nombre del vendedor:" + v1.Nombre, "edad :" + v1.Edad);
            System.Console.WriteLine("producto:" + P1.Nombre);
            System.Console.WriteLine("presio:" + P1.Valor);
            

            System.Console.WriteLine("informacin de la venta" + b2.Producto, b2.Vendedor, b2.Comentario);
            System.Console.WriteLine("nombre del vendedor:" + v2.Nombre, "edad :" + v2.Edad);
            System.Console.WriteLine("producto:" + P2.Nombre);
            System.Console.WriteLine("presio:" + P2.Valor);

            System.Console.WriteLine("informacin de la venta" + b3.Producto, b3.Vendedor, b3.Comentario);
            System.Console.WriteLine("nombre del vendedor:" + v3.Nombre, "edad :" + v3.Edad);
            System.Console.WriteLine("producto:" +p3.Nombre);
            System.Console.WriteLine("presio:" + p3.Valor);


            System.Console.WriteLine("el valor total de las ventas es :" + suma);














        }





    }

}
