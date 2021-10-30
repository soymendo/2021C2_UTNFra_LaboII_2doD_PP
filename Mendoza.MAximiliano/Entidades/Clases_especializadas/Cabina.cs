using Entidades.Clases_generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Itenso.TimePeriod;

namespace Entidades.Clases_especializadas
{
    public enum TipoLlamada
    {
        local, largaDistancia, internacional
    }

    public class Cabina: Maquina
    {
        public enum TipoTelefono
        {
            ADisco, ConTeclado
        }

        //------------Atributos-----------
        private TipoTelefono tipoTelefono;
        private string marca;
        private string numeroAMarcar;       
      
        
     

        //------Propiedades----------------------

        /// <summary>
        /// devuelve el tipo de maquina
        /// </summary>
        public override Tipo TipoDeMaquina
        {
            get { return Tipo.Telefono; }
        }

        

        /// <summary>
        /// especifica que tipo de telefono es
        /// </summary>
        public TipoTelefono TipoDeTelefono
        {
            get { return this.tipoTelefono; }
        }
        /// <summary>
        /// Devuelve la marca
        /// </summary>
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }


        /// <summary>
        /// Devuelve el numero a marcar
        /// </summary>
        public string NumeroAMarcar
        {
            get { return this.numeroAMarcar; }
            set
            {
                if (ValidarDatos(value))
                {
                    this.numeroAMarcar = value;
                }

            }
        }


      



        /// <summary>
        /// devuelve el tiempo de uso total de la cabina , el tiempo total que se acumula en la lista de cabinas finalizadas
        /// </summary>
        public double TiempoTotalDeUso
        {
            get
            {
                double retorno;

                TimeSpan tiempoActual = new TimeSpan(0, (int)Stopwacth.Elapsed.Minutes, (int)Stopwacth.Elapsed.Seconds);
                double seg = tiempoActual.Seconds;
                double min = tiempoActual.Minutes;
                retorno = (min * 60) + seg;

                return retorno;

            }
        }

      

       

        //------------Constructores-----------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        /// <param name="numeroAMarcar"></param>
        public Cabina(string identificador, TipoTelefono tipo, string marca, string numeroAMarcar)
       : base(identificador)
        {
            this.Identificador = identificador;
            this.tipoTelefono = tipo;
            this.marca = marca;
            this.numeroAMarcar = numeroAMarcar;
        }

        /// <summary>
        /// constructor, si no le cargo numero da cargar numero,
        /// usado cuando la validacion da false
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        public Cabina(string identificador, TipoTelefono tipo, string marca)
        : this(identificador, tipo, marca, "Cargar numero")
        {

        }

   


        /// <summary>
        /// Constructor deonde le paso un string de numero
        /// </summary>
        /// <param name="numeroAMarcar"></param>
        public Cabina(string numeroAMarcar)
        {
            this.numeroAMarcar = numeroAMarcar;
        }




        //-------Metodos-------------------------------------------------------------------




        /// <summary>
        /// Calcula el costo total entre el tiempo transcurrido de pc y las bebdias consumidas
        /// </summary>
        /// <returns></returns>
        public float CalcularCostoCabinaBebida()
        {
            float retorno = 0;
            retorno = CalcularCosto() + (CantidadDeBebidasEnLista * this.PrecioBebida);
            CantidadDeBebidasEnLista = 0;
            this.CostoFinal = retorno;
            return retorno;
        }

        public override float ConsumoFinalIva()
        {

            float retorno = 0;

            retorno = this.CostoFinal * 1.21f;

            return retorno;
        }

       
        // <summary>
        /// calcula el costo de todas las llamas hechas
        /// </summary>
        /// <returns></returns>
        public override float CalcularCosto()
        {
            float retorno = 0;
            if (DevolverDestino() ==TipoLlamada.local.ToString()) { retorno = (float)this.TiempoDeUsoNugget * 1; }
            if (DevolverDestino() == TipoLlamada.largaDistancia.ToString()) { retorno = (float)this.TiempoDeUsoNugget * 2.5f; }
            if (DevolverDestino() == TipoLlamada.internacional.ToString()) { retorno = (float)this.TiempoDeUsoNugget * 5; }
            return retorno;
        }





        /// <summary>
        /// define si es local, larga llamada o internacional
        /// </summary>
        /// <returns></returns>
        public string DevolverDestino()
        {
            string retono = "";
           

            string larga_distancia = string.Concat(this.NumeroAMarcar[2], this.NumeroAMarcar[3], this.NumeroAMarcar[4]);
            string local = string.Concat(this.NumeroAMarcar[2], this.NumeroAMarcar[3], this.NumeroAMarcar[4]);
            string Internacional = string.Concat(this.NumeroAMarcar[0], this.NumeroAMarcar[1]);

            if (Internacional != "54")
            {
                retono = TipoLlamada.internacional.ToString();
            }

            if (larga_distancia != "011" && Internacional=="54")
            {
                retono = TipoLlamada.largaDistancia.ToString();
            }

            if (Internacional=="54" && larga_distancia=="011")
            {
                retono = TipoLlamada.local.ToString();
            }

            return retono;
        }


        /// <summary>
        /// calcula el costo local
        /// </summary>
        /// <returns></returns>
        public float CostoLocal()
        {
            float retorno = 0;
            if (DevolverDestino() == TipoLlamada.local.ToString() ){ retorno = (float)this.TiempoDeUsoNugget * 1; }
            return retorno;
        }

        /// <summary>
        /// calcula el costo de larga distancia
        /// </summary>
        /// <returns></returns>
        public float CostoLargaDistancia()
        {
            float retorno = 0;
            if (DevolverDestino() == TipoLlamada.largaDistancia.ToString()) { retorno = (float)this.TiempoDeUsoNugget * 2.5f; }
            return retorno;
        }

        /// <summary>
        /// calcla el costo interncaional
        /// </summary>
        /// <returns></returns>
        public float CostoInternacional()
        {
            float retorno = 0;
            if (DevolverDestino() ==  TipoLlamada.internacional.ToString()) { retorno = (float)this.TiempoDeUsoNugget * 5; }
            return retorno;
        }



        /// <summary>
        /// valida que sea un  numero valido
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        private bool ValidarDatos(string doc)
        {


            bool retorno = false;
          
            if(doc.Length<=13)//numeros total de un celular
            {
                retorno = true;
            }
            return retorno;

        }


        //---------Sobrecargas----------------------------------------

        /// <summary>
        /// dos cabinas son iguales si tienen el mismo nombre
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cabina c1, Cabina c2)
        {
            if (c1 is null || c2 is null)
            {
                return false;
            }
            return (c1.Identificador == c2.Identificador);
        }

        /// <summary>
        /// dos cabinas son diferentes si no tienen el mismo nombre
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cabina c1, Cabina c2)
        {
            return !(c1 == c2);
        }




        /// <summary>
        /// Muestra los datos de la cabina
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Tipo de telefono: {TipoDeTelefono}");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Numero: {NumeroAMarcar}");

            sb.AppendLine($"Cantidad de cocas: {this.ListaBebidas.Count}");
            sb.AppendLine($"Costo de consumo de cocas: {this.CalcularCostoDeConsumoBebidas()}");

            return sb.ToString();
        }


        /// <summary>
        /// Muestra un string de los datos de la cabina
        /// </summary>
        /// <returns></returns>
        public string MostrarRecaudacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Tiempo de uso cabina: {this.TiempoTotalDeUso}");
            sb.AppendLine($"Cantidad de cocas: {this.BebidasTotales}");
            sb.AppendLine($"Recaudacion:  {string.Format("{0:0.00}", Recaudacion * 1.21)}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (this.Identificador);
        }


        /// <summary>
        /// Sobrecarga equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Cabina otraCab = obj as Cabina;
            return otraCab is not null && this == otraCab;
        }


        /// <summary>
        /// Sobrecarga GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Identificador).GetHashCode();
        }

        
    }
}
