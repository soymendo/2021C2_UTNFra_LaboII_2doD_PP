using System;
using System.Collections.Generic;
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
        private Tipo tipo;
        private DateTime tiempoInicial;
        private DateTime tiempoFinal;




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
        public Maquinas()
        {

        }

        public Maquinas(string nombre)
        {
            this.identificador = nombre;
        }


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

