﻿using Entidades.Clases_generales;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_especializadas
{
    public class  Computadora: Maquina
    {
        //----------------Atributos-------------------------------------
 
        private Peticion peticiones;
        
        //--------------Constructores---------------------------------


        public Computadora(Peticion peticiones)
        {
            this.peticiones = peticiones;
        }

        public Computadora(string identificador,Peticion peticiones)
        :base(identificador)
        {
            this.peticiones = peticiones;
        }


        public Computadora(string identificador,  List<string> sofware, List<string> perisfericos, List<string> juegos)
        :this(identificador,new Peticion(sofware, perisfericos, juegos))
        {
          
        }
    

        public Computadora(List<string> sofware, List<string> perisfericos, List<string> juegos)             
        :this(new Peticion(sofware, perisfericos, juegos))
        {
           
        }




        //----------Propiedades-----------------------------------------


        /// <summary>
        /// indica el tiempo de uso de la compu en la lista de compus ocupadas
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
        /// devuelve el tiempo de uso total de la Computadora dentro de la lista de compus finalizadas
        /// https://www.youtube.com/watch?v=mRZPY2RyGrU
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

        /// <summary>
        /// indica el tipo de maquina
        /// </summary>
        public override Tipo TipoDeMaquina
        {
            get { return Tipo.Computadora; }
        }

        


        public Peticion Peticiones
        {
            get { return this.peticiones; }
            set { this.peticiones = value; }
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
            if (TiempoDeUso <= 30) { retorno = 0.5f; }
            if (TiempoDeUso > 30)
            {
                resultado = tiempo / 30;
                redondeo = (int)Math.Ceiling(resultado);
                retorno = redondeo * 0.5f;
            }

            return retorno;
        }




        /// <summary>
        /// Calcula el costo total entre el tiempo transcurrido de pc y las bebdias consumidas
        /// </summary>
        /// <returns></returns>
        public float CalcularCostoCompuBebida()
        {
            float retorno = 0;
            retorno = CalcularCosto() + (CantidadDeCocasEnLista * this.PrecioBebida);
            CantidadDeCocasEnLista = 0; 
            return retorno;
        }


        /// <summary>
        /// agrega una bebida a la lista de bebidas de computadora
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public override bool AgregarBebida(Bebida c)
        {
            
            bool retorno = false;
            if(c is not null)
            {
                this.ListaBebidas.Add(c);
                CantidadDeCocasEnLista += 1;
                CocasTotales += 1;
                retorno = true;
            }
           
            return retorno;
        }

        /// <summary>
        /// calcula el costo de consumo de las bebidas pedidas
        /// </summary>
        /// <returns></returns>
        public override float CalcularCostoDeConsumoBebidas()
        {
            float acum = 0; ;
            foreach (Bebida item in this.ListaBebidas)
            {
                acum += item.Precio;
            }
            return acum;
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
            sb.AppendLine(Peticiones.ToString());
            sb.AppendLine($"Cantidad de cocas: {this.ListaBebidas.Count}");
            sb.AppendLine($"Costo de consumo de cocas: {this.CalcularCostoDeConsumoBebidas()}");
            return sb.ToString();
        }


        /// <summary>
        /// Muestra un string de los datos de la computadora
        /// </summary>
        /// <returns></returns>
        public  string MostrarRecaudacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Tiempo de uso pc: {this.TiempoTotalDeUso}");
            sb.AppendLine($"Cantidad de cocas: {this.CocasTotales}");
            sb.AppendLine($"Recaudacion:{Recaudacion}");
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
            if(c1 is null || c2 is null)
            {
                return false;
            }
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


        /// <summary>
        /// Sobrecarga del equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Computadora otraCompu = obj as Computadora;
            return otraCompu != null && this == otraCompu;
        }


        /// <summary>
        /// Sobrecarga del GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Identificador).GetHashCode();
        }

    }
}
