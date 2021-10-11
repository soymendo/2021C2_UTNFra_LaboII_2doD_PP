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
            Computadora compuAux;
           Computadora compu=  new Computadora("C01", new List<string>() { "ares", "messenger" }, new List<string>() { "camara", "auriculares" }, new List<string>() { "CounterStrike", "DiabloII", "MuOnline", "LineageII" });

           Cliente cli=  new Cliente("Lucas", "Heredia", 48657285, 25, new List<string>() {"ares","messenger"}, new List<string>() { "camara", "auriculares" }, new List<string>() { "CounterStrike", "DiabloII", "MuOnline", "LineageII" });

            compuAux = new Computadora(cli.Peticiones.Lista_Sofware, cli.Peticiones.Lista_Perifericos, cli.Peticiones.Lista_Juegos);

            Console.WriteLine(compu.Peticiones==compuAux.Peticiones);

        }
    }
}

