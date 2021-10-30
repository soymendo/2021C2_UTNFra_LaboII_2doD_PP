using Entidades.Clases_especializadas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itenso.TimePeriod;


namespace Entidades.Clases_generales
{
    public enum Tipo
    {
        Telefono, Computadora
    }


    public abstract class Maquina
    {
        //----------------------Atributos--------------------------------------
        private string identificador;
        private DateTime tiempoInicial;
        private DateTime tiempoFinal;
        private  Stopwatch stopwacth = new Stopwatch();
        private List<Bebida> listaBebidas=new List<Bebida>();

        public int bebidasTotales = 0;
        public float recaudacion = 0;
        private int cantidadDeBebidasEnLista = 0;

        private  const float precioBebida = 1.5f;
        private float costoFinal;
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


        public List<Bebida>ListaBebidas
        {
            get { return this.listaBebidas; }
            set { this.listaBebidas = value; }
        }

        /// <summary>
        /// Permite saber un determinado tiempo,usado para ver el total de tiempo de la maquina en la lista de finalizados
        /// </summary>
        public Stopwatch Stopwacth
        {
            get { return this.stopwacth; }
            set { this.stopwacth = value; }
        }



        /// <summary>
        /// propiedad qu edevuelve las cocas totasles
        /// </summary>
        public int BebidasTotales
        {
            get { return this.bebidasTotales; }
            set { this.bebidasTotales = value; }
        }

        /// <summary>
        /// propiedad qu edevuelve la recaudacion
        /// </summary>
        public float Recaudacion
        {
            get { return this.recaudacion; }
            set { this.recaudacion = value; }
        }


        /// <summary>
        /// propiedad para saber la cantidad de cocas en la lista
        /// </summary>
        public int CantidadDeBebidasEnLista
        {
            get { return this.cantidadDeBebidasEnLista; }
            set { this.cantidadDeBebidasEnLista = value; }
        }


        public float PrecioBebida
        {
            get { return precioBebida; }
        }

        public float CostoFinal
        {
            get { return this.costoFinal; }
            set { this.costoFinal = value; }

        }


        /// <summary>
        /// indica el tiempo de uso de la compu en la lista de compus ocupadas
        /// </summary>
        public int TiempoDeUsoNugget
        {
            get
            {
                DateDiff dateDiff = new DateDiff(this.TiempoInicial, this.TiempoFinal);
                return dateDiff.Seconds;
            }
        }

        //---------------Propiedades Abstractas------------------------------

        public abstract Tipo TipoDeMaquina { get; }
        public abstract float CalcularCosto();

        //------------Metodos abstractos--------------------------
       // public abstract bool AgregarBebida(Bebida c);
        public abstract float ConsumoFinalIva();
        //--------------Constructores---------------------------------------
        /// <summary>
        /// Constructor sin parametros, si lo saco rompe en constructor Cabina(string numeroAMarcar)
        public Maquina()
        {

        }

        /// <summary>
        /// conntructor donde recibe un nombre
        /// </summary>
        /// <param name="nombre"></param>
        public Maquina(string identificador)
        
        {
            this.identificador = identificador;
        }

        //-----------------Metodos------------------------------------------------------


        /// <summary>
        /// agrega una bebida a la lista de bebidas de computadora
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool AgregarBebida(Bebida c)
        {

            bool retorno = false;
            if (c is not null)
            {
                this.ListaBebidas.Add(c);
                CantidadDeBebidasEnLista += 1;
                BebidasTotales += 1;
                retorno = true;
            }

            return retorno;
        }






        /// <summary>
        /// calcula el costo de consumo de las bebidas pedidas
        /// </summary>
        /// <returns></returns>
        public float CalcularCostoDeConsumoBebidas()
        {
            float acum = 0; ;
            foreach (Bebida item in this.ListaBebidas)
            {
                acum += item.Precio;
            }
            return acum;

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




        //----Sobrecargas----------------------------
        /// <summary>
        /// compara dos maquinas y da true si tienen el mismo nombre
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(Maquina m1, Maquina m2)
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
        public static bool operator !=(Maquina m1, Maquina m2)
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
            Maquina otraMaquina = obj as Maquina;
            return otraMaquina is not null && this == otraMaquina;
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

