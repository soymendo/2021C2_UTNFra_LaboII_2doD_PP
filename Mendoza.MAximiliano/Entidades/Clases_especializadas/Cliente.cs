﻿using Entidades.Clases_generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_especializadas
{
    public class Cliente
    {
        //------------------Atributos---------------------------
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private Peticiones petisiones;
        private string numeroAMarcar;


        //--------------Propiedades--------------------------------
        /// <summary>
        /// devuelve Nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Devuelve Apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// Devuelve Dni
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        /// <summary>
        ///Devuelve Edad 
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }


        /// <summary>
        /// Devuelve la s petisiones
        /// </summary>
        public Peticiones PetisionesDePc
        {
            get { return this.petisiones; }
            set { this.petisiones = value; }
        }


        public string NumeroAMarcar
        {
            get { return this.numeroAMarcar; }
            set { this.numeroAMarcar = value; }
        }



     //--------Constructores------------------------
        /// <summary>
        /// Constructor de instancia
        /// </summary>
        public Cliente()
        {

        }


        /// <summary>
        /// contructor que recibe nombre,apellido, dni y edad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        public Cliente(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;

        }



        /// <summary>
        /// contructor que recibe nombre,apellido, dni,edad y las petisiones
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="pedidos"></param>
        public Cliente(string nombre, string apellido, int dni, int edad, Peticiones pedidos)
        : this(nombre,apellido,dni,edad)
        {
            //this.nombre = nombre;
            //this.apellido = apellido;
            //this.dni = dni;
            //this.edad = edad;
            this.petisiones = pedidos;
        }


        /// <summary>
        ///  contructor que recibe nombre,apellido, dni,edad y las petisiones
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="software"></param>
        /// <param name="periféricos"></param>
        /// <param name="juegos"></param>
        public Cliente(string nombre, string apellido, int dni, int edad, Peticiones.SoftwareInstalado software, Peticiones.PeriféricosDisponibles periféricos, Peticiones.JuegosDisponibles juegos)
        : this(nombre, apellido, dni, edad, new Peticiones(software, periféricos, juegos))
        {

        }


        /// <summary>
        /// contructor que recibe nombre,apellido, dni,edad y el numero 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="numeroAMarcar"></param>
        public Cliente(string nombre, string apellido, int dni, int edad, string numeroAMarcar)
        :this(nombre, apellido, dni, edad)
        {
            this.numeroAMarcar = numeroAMarcar;
        }



        //-------Sobrecargas----------------------------------------------------------


        /// <summary>
        /// Muestro los datos del cliente
        /// </summary>
        /// <returns></returns>
        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Edad: {this.edad}");
           
            if(petisiones is null)
            {
                sb.AppendLine($"Telefono: {this.numeroAMarcar}");
               
            }
            else
            {
                sb.AppendLine($"Requisitos pedidos: ");
                sb.AppendLine($"{petisiones.ToString()}");
            }
          
            return sb.ToString();

        }

        /// <summary>
        /// usado en un listbox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}  || Dni: {this.dni} ");
           
          
            return sb.ToString();
        }


        /// <summary>
        /// clientes iguales si tienen mismo dni
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator==(Cliente c1,Cliente c2)
        {
            if(c1 is null || c2 is null)
            {
                return false;
            }
            return (c1.Dni == c2.Dni);
        }

        /// <summary>
        /// clientes distintos si tienen distinto dni
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }


        // <summary>
        // Sobrecarga del Equals
        // </summary>
        // <param name = "obj" ></ param >
        // < returns ></ returns >
        public override bool Equals(object obj)
        {
            Cliente otroCliente = obj as Cliente;
            return otroCliente != null && this == otroCliente;
        }


        /// <summary>
        /// Sobrecarga GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Nombre, Dni).GetHashCode();
        }
    }
}
