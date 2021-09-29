using Entidades.Clases_generales;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_especializadas
{
    public class  Computadora: Maquinas
    {
        //----------------Atributos-------------------------------------
        private Petisiones petisiones;



        //--------------Constructores---------------------------------
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Computadora()
        {

        }

        /// <summary>
        /// constructor , le paso nombre de compu y las petisiones
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pedidos"></param>
        public Computadora(string nombre, Petisiones pedidos)
        : base(nombre)
        {
            this.Identificador = nombre;
            this.petisiones = pedidos;
        }

        /// <summary>
        /// constructor , le paso nombre de compu y las petisiones
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="software"></param>
        /// <param name="periféricos"></param>
        /// <param name="juegos"></param>
        public Computadora(string nombre, Petisiones.SoftwareInstalado software, Petisiones.PeriféricosDisponibles periféricos, Petisiones.JuegosDisponibles juegos)
        : this(nombre, new Petisiones(software, periféricos, juegos))
        {

        }


        /// <summary>
        /// constructor solo petisiones
        /// </summary>
        /// <param name="petisiones"></param>
        public Computadora(Petisiones petisiones)
        : this()
        {
            this.petisiones = petisiones;
        }

        /// <summary>
        /// constructor. le paso las peticiones del cliente
        /// </summary>
        /// <param name="software"></param>
        /// <param name="periféricos"></param>
        /// <param name="juegos"></param>
        public Computadora(Petisiones.SoftwareInstalado software, Petisiones.PeriféricosDisponibles periféricos, Petisiones.JuegosDisponibles juegos)
        : this(new Petisiones(software, periféricos, juegos))
        {

        }





        //----------Propiedades-----------------------------------------


        /// <summary>
        /// indica el tiempo de uso de la compu
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
        /// devuelve el tiempo de uso total de la Computadora
        /// https://www.youtube.com/watch?v=mRZPY2RyGrU
        /// </summary>
        public double TiempoTotalDeUso
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

        /// <summary>
        /// indica el tipo de maquina
        /// </summary>
        public override Tipo TipoDeMaquina
        {
            get { return Tipo.Computadora; }
        }

        /// <summary>
        /// propiedad para saber las petisiones
        /// </summary>
        public Petisiones PetisionesDePc
        {
            get { return this.petisiones; }
            set { this.petisiones = value; }
        }



      //-----Metodos----------------------------------------------------------------------------------------------   

        /// <summary>
        /// Calcula el costo segun el tiempo transcurrido
        /// </summary>
        /// <returns></returns>
        public override float CalcularCosto()
        {
            float retorno = 0;
            float tiempo = (float)TiempoDeUso;
            int redondeo;

            float resultado;
            if (TiempoDeUso < 30) { retorno = 0.5f; }
            if (TiempoDeUso > 30)
            {
                resultado = tiempo / 30;
                redondeo = (int)Math.Ceiling(resultado);
                retorno = redondeo * 0.5f;
            }

            return retorno;
        }




        /// <summary>
        /// Muestro los datos de la compu
        /// </summary>
        /// <returns></returns>

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"****Detalle****");
            sb.AppendLine($"{petisiones.ToString()}");
            return sb.ToString();
        }


        //---------Sobrecargas-----------------------------------------------------------

        /// <summary>
        /// Iguales si tienen mismo nombre
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Computadora c1, Computadora c2)
        {
            return (c1.Identificador == c2.Identificador);
        }

        public static bool operator !=(Computadora c1, Computadora c2)
        {
            return !(c1 == c2);
        }


        /// <summary>
        /// usado en el list del form
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Identificador}");

            return sb.ToString();
        }


    }
}
