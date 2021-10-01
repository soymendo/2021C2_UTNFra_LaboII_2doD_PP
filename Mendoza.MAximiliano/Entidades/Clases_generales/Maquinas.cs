using Entidades.Clases_especializadas;
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
        private  Stopwatch sw = new Stopwatch();
        private List<Coca_cola> ListaDeCocas=new List<Coca_cola>();
     



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


        public List<Coca_cola>Lista_Cocas
        {
            get { return this.ListaDeCocas; }
            set { this.ListaDeCocas = value; }
        }

        public Stopwatch SW
        {
            get { return this.sw; }
            set { this.sw = value; }
        }

        //---------------Propiedades Abstractas------------------------------
        
        public abstract Tipo TipoDeMaquina { get; }
        public abstract double TiempoDeUso { get; }
        public abstract float CalcularCosto();

        //------------Metodos abstractos--------------------------
        public abstract bool AgregarBebida(Coca_cola c);
        public abstract float CalcularCostoDeConsumoBebidas();

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




        //----Sobrecargas----------------------------
        /// <summary>
        /// compara dos maquinas y da true si tienen el mismo nombre
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(Maquinas m1, Maquinas m2)
        {
            if(m1 is null || m2 is null)
            {
                return false;
            }
            return (m1.Identificador == m2.Identificador);
        }


        /// <summary>
        /// da fase si son diferentes 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator !=(Maquinas m1, Maquinas m2)
        {
            return !(m1 == m2);
        }


        /// <summary>
        /// sobrecarga tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }


        /// <summary>
        /// sobrecarga equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Maquinas otraMaquina = obj as Maquinas;
            return otraMaquina != null && this == otraMaquina;
        }

        /// <summary>
        /// sobrecarga GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return  (Identificador).GetHashCode();
        }
    }


}

