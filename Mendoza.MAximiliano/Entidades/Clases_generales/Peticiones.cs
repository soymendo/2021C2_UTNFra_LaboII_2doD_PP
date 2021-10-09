using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_generales
{
    public sealed class Peticiones
    {

        //----------------Atributos-----------------------
        private SoftwareInstalado sofware;
        private PeriféricosDisponibles periféricosDisponibles;
        private JuegosDisponibles juegosDisponibles;


        /// <summary>
        /// Indica el sofware instalado
        /// </summary>
        public SoftwareInstalado Sofware
        {
            get { return this.sofware; }
            set { this.sofware = value; }
        }

        /// <summary>
        /// indica el perisferico instalado
        /// </summary>
        public PeriféricosDisponibles Periféricos
        {
            get { return this.periféricosDisponibles; }
            set { this.periféricosDisponibles = value; }
        }


        /// <summary>
        /// indica el juego disponible
        /// </summary>
        public JuegosDisponibles Juegos
        {
            get { return this.juegosDisponibles; }
            set { this.juegosDisponibles = value; }
        }




        //------------------Enumerados--------------------
        public enum SoftwareInstalado
        {
            office, messenger, icq, ares,todos
        }

        public enum PeriféricosDisponibles
        {
            camara, auriculares, micrófono,todos
        }

        public enum JuegosDisponibles
        {
            CounterStrike, DiabloII, MuOnline, LineageII,todos
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="software"></param>
        /// <param name="periféricos"></param>
        /// <param name="juegos"></param>
        public Peticiones(SoftwareInstalado software, PeriféricosDisponibles periféricos, JuegosDisponibles juegos)
        {
            this.sofware = software;
            this.periféricosDisponibles = periféricos;
            this.juegosDisponibles = juegos;
        }





        /// <summary>
        /// petisiones son iguales si tienen los mismo 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2">compu a igualar</param>
        /// <returns></returns>
        public static bool operator ==(Peticiones p1, Peticiones p2)
        {
            bool retorno = false;

            if (p2.Sofware != SoftwareInstalado.todos &&  p2.Periféricos != PeriféricosDisponibles.todos && p2.Juegos != JuegosDisponibles.todos)
            {
                if ((p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                    || (p1.Juegos==p2.Juegos && p1.Periféricos==p2.Periféricos && p1.Sofware==p2.Sofware ))
                {
                    retorno = true;
                }
            }


            if (p2.Sofware == SoftwareInstalado.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if(p1.Periféricos==PeriféricosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware && p1.Juegos == p2.Juegos);

                }
                else if(p1.Juegos==JuegosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware && p1.Periféricos == p2.Periféricos);
                }
            }


            if (p2.Periféricos == PeriféricosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if(p1.Sofware==SoftwareInstalado.todos)
                {
                    retorno = (p1.Periféricos==p2.Periféricos && p1.Juegos==p2.Juegos);
                }
                else if(p1.Juegos==JuegosDisponibles.todos)
                {
                    retorno = (p1.Sofware==p2.Sofware && p1.Periféricos==p2.Periféricos);
                }
                
            }


            if (p2.Juegos == Peticiones.JuegosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos==JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if (p1.Sofware==SoftwareInstalado.todos)
                {
                    retorno = (p1.Periféricos==p2.Periféricos && p1.Juegos== p2.Juegos);
                }

               else if(p1.Periféricos==PeriféricosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware && p1.Juegos==p2.Juegos);
                }
             
            }
            

            if (p2.Sofware == SoftwareInstalado.todos && p2.Periféricos == PeriféricosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if(p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos)
                {
                    retorno = (p1.Juegos == p2.Juegos);
                }
            }
            


            if (p2.Juegos == JuegosDisponibles.todos && p2.Periféricos == PeriféricosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if (p1.Juegos == JuegosDisponibles.todos && p1.Periféricos == PeriféricosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware);
                }
                
                
            }

            if (p2.Sofware==SoftwareInstalado.todos && p2.Juegos==JuegosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if(p1.Sofware == SoftwareInstalado.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = (p1.Periféricos == p2.Periféricos);
                }
              
            }


            if (p2.Juegos == JuegosDisponibles.todos && p2.Periféricos == PeriféricosDisponibles.todos && p2.Sofware == SoftwareInstalado.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PeriféricosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
            }


            return retorno;
        }



        /// <summary>
        /// petiones son diferentes si no son iguales
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Peticiones p1, Peticiones p2)
        {
            return !(p1 == p2);
        }


        /// <summary>
        /// muestra los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sofware: {Sofware}");
            sb.AppendLine($"Perisfericos: {Periféricos}");
            sb.AppendLine($"Juegos: {Juegos}");
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Peticiones otraPeticion = obj as Peticiones;
            return otraPeticion != null && this == otraPeticion;
        }

        /// <summary>
        /// sobrecarga GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Sofware,Periféricos,Juegos).GetHashCode();
        }

    }
}
