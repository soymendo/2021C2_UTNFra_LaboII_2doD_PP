using Entidades.Clases_generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Entidades.Clases_especializadas
{
    public enum TipoLlamada
    {
        local, largaDistancia, internacional
    }

    public class Cabina: Maquinas
    {
        public enum TipoTelefono
        {
            ACuerda, ConTeclado
        }

        //------------Atributos-----------
        private TipoTelefono tipoTelefono;
        private string marca;
        private string numeroAMarcar;
        private TipoLlamada tipoLlamada;

      
        //------Propiedades----------------------

        /// <summary>
        /// devuelve el tipo de maquina
        /// </summary>
        public override Tipo TipoDeMaquina
        {
            get { return Tipo.Telefono; }
        }

        /// <summary>
        /// especifica que tipo de llamada es
        /// </summary>
        public TipoLlamada TipoDeLlamada
        {
            get { return this.tipoLlamada; }
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
        /// Devuelve el tiempo de uso de la cabina
        /// </summary>
        public override double TiempoDeUso
        {
            get
            {
                double retorno;

                TimeSpan diferenciasSegundos = this.TiempoFinal - this.TiempoInicial;

                double seg = diferenciasSegundos.Seconds;
                double min = diferenciasSegundos.Minutes;

                retorno = (min * 60) + seg;

                return retorno;
            }

        }


        /// <summary>
        /// devuelve el tiempo de uso actual
        /// https://www.youtube.com/watch?v=mRZPY2RyGrU
        /// </summary>
        public double TiempoActualDeUso
        {
            get
            {
                double retorno;

                TimeSpan tiempoActual = new TimeSpan(0, (int)sw.Elapsed.Minutes, (int)sw.Elapsed.Seconds);
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
        public Cabina(string nombre, TipoTelefono tipo, string marca, string numeroAMarcar)
       : base(nombre)
        {
            this.Identificador = nombre;
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
        public Cabina(string nombre, TipoTelefono tipo, string marca)
        : this(nombre, tipo, marca, "Cargar numero")
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

        // <summary>
        /// calcula el costo de todas las llamas hechas
        /// </summary>
        /// <returns></returns>
        public override float CalcularCosto()
        {
            float retorno = 0;
            if (Destino() == "local") { retorno = (float)this.TiempoDeUso * 1; }
            if (Destino() == "largaDistancia") { retorno = (float)this.TiempoDeUso * 2.5f; }
            if (Destino() == "internacional") { retorno = (float)this.TiempoDeUso * 5; }
            return retorno;
        }





        /// <summary>
        /// define si es local, larga llamada o internacional
        /// </summary>
        /// <returns></returns>
        public string Destino()
        {
            string retono = "hola";
           

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
            if (Destino() == "local") { retorno = (float)this.TiempoDeUso * 1; }
            return retorno;
        }

        /// <summary>
        /// calcula el costo de larga distancia
        /// </summary>
        /// <returns></returns>
        public float CostoLargaDistancia()
        {
            float retorno = 0;
            if (Destino() == "largaDistancia") { retorno = (float)this.TiempoDeUso * 2.5f; }
            return retorno;
        }

        /// <summary>
        /// calcla el costo interncaional
        /// </summary>
        /// <returns></returns>
        public float CostoInternacional()
        {
            float retorno = 0;
            if (Destino() == "internacional") { retorno = (float)this.TiempoDeUso * 5; }
            return retorno;
        }



        /// <summary>
        /// valida que sea un  numero valido
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public bool ValidarDatos(string doc)
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
            return sb.ToString();
        }

        public override string ToString()
        {
            return (this.Identificador);
        }

    }
}
