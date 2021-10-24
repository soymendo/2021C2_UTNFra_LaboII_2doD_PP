using System;
using System.Collections.Generic;
using Entidades;
using Entidades.Clases_especializadas;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sofware = new List<string>();
            List<string> perifericos = new List<string>();
            List<string> juegos = new List<string>();


            sofware.Add("office");
            sofware.Add("messenger");

            perifericos.Add("camara");
            perifericos.Add("auriculares");

            juegos.Add("CounterStrike");
            juegos.Add("DiabloII");
            juegos.Add("MuOnline");
            juegos.Add("LineageII");

            Computadora aux;

         Computadora c1=   new Computadora("C01", new List<string>() { "office", "messenger" }, new List<string>() { "camara", "auriculares" }, new List<string>() { "CounterStrike", "DiabloII", "MuOnline", "LineageII" }, new List<string>() { "Procesador :i3\nRam:4gb\nPlaca de video: gts 250" });

          Cliente cli1=  new Cliente("Lucas", "Heredia", 48657285, 25, new List<string>() { "office", "messenger" }, new List<string>() { "camara", "auriculares" }, new List<string>() { "CounterStrike", "DiabloII", "MuOnline", "LineageII" });

          aux = new Computadora(sofware,perifericos,juegos);

            Console.WriteLine(c1.Peticiones==aux.Peticiones);
        }
    }
}
