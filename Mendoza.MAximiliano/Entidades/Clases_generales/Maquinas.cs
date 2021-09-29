using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_generales
{
    public enum Tipo
    {
        Telefono, Computadora
    }


    public abstract class Maquinas
    {
        //----------------------Atributos--------------------------------------
        private string identificador;
        private DateTime tiempoInicial;
        private DateTime tiempoFinal;
        public Stopwatch sw = new Stopwatch();



        //--------------------Propiedades--------------------------------------
        /// <summary>
        /// indica el tiempo inicial desde que entra a la lista de disponibles
        /// </summary>
        public DateTime TiempoInicial
        {
            get { return this.tiempoInicial; }
            set { this.tiempoInicial = value; }
        }

        /// <summary>
        /// inidca el tiempo final desde que sale de finalizados
        /// </summary>
        public DateTime TiempoFinal
        {
            get { return this.tiempoFinal; }
            set { this.tiempoFinal = value; }
        }


        /// <summary>
        /// Devuelve el nombre de la maquina
        /// </summary>
        public string Identificador
        {
            get { return this.identificador; }
            set { this.identificador = value; }
        }




        //---------------Propiedades Abstractas------------------------------
        
        public abstract Tipo TipoDeMaquina { get; }
        public abstract double TiempoDeUso { get; }
        public abstract float CalcularCosto();



        //--------------Constructores---------------------------------------
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Maquinas()
        {

        }

        /// <summary>
        /// conntructor donde recibe un nombre
        /// </summary>
        /// <param name="nombre"></param>
        public Maquinas(string nombre)
        {
            this.identificador = nombre;
        }

        //-----------------Metodos------------------------------------------------------
        /// <summary>
        /// Muestra tipo de maquina y su nombre
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de maquina: {this.TipoDeMaquina}");
            sb.AppendLine($"Nombre: {Identificador}");
            return sb.ToString();
        }

    }


}

