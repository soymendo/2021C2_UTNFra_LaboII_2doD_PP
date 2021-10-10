using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_generales
{
    public sealed class Peticion
    {

        //----------------Atributos-----------------------
        private SoftwareInstalado sofware;
        private PerisfericosDisponibles perisfericosDisponibles;
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
        /// indica el perisferico instalado (No me permite cambiarlo)
        /// </summary>
        public PerisfericosDisponibles Periféricos


        {
            get { return this.perisfericosDisponibles; }
            set { this.perisfericosDisponibles = value; }
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

        public enum PerisfericosDisponibles
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
        public Peticion(SoftwareInstalado software, PerisfericosDisponibles perisfericos, JuegosDisponibles juegos)
        {
            this.sofware = software;
            this.perisfericosDisponibles = perisfericos;
            this.juegosDisponibles = juegos;
        }





        /// <summary>
        /// peticiones son iguales si tienen los mismo 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2">compu a igualar</param>
        /// <returns></returns>
        public static bool operator ==(Peticion p1, Peticion p2)
        {
            bool retorno = false;

            if (p2.Sofware != SoftwareInstalado.todos &&  p2.Periféricos != PerisfericosDisponibles.todos && p2.Juegos != JuegosDisponibles.todos)
            {
                if ((p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                    || (p1.Juegos==p2.Juegos && p1.Periféricos==p2.Periféricos && p1.Sofware==p2.Sofware ))
                {
                    retorno = true;
                }
            }


            if (p2.Sofware == SoftwareInstalado.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if(p1.Periféricos==PerisfericosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware && p1.Juegos == p2.Juegos);

                }
                else if(p1.Juegos==JuegosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware && p1.Periféricos == p2.Periféricos);
                }
            }


            if (p2.Periféricos == PerisfericosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
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


            if (p2.Juegos == Peticion.JuegosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos==JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if (p1.Sofware==SoftwareInstalado.todos)
                {
                    retorno = (p1.Periféricos==p2.Periféricos && p1.Juegos== p2.Juegos);
                }

               else if(p1.Periféricos==PerisfericosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware && p1.Juegos==p2.Juegos);
                }
             
            }
            

            if (p2.Sofware == SoftwareInstalado.todos && p2.Periféricos == PerisfericosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if(p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos)
                {
                    retorno = (p1.Juegos == p2.Juegos);
                }
            }
            


            if (p2.Juegos == JuegosDisponibles.todos && p2.Periféricos == PerisfericosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if (p1.Juegos == JuegosDisponibles.todos && p1.Periféricos == PerisfericosDisponibles.todos)
                {
                    retorno = (p1.Sofware == p2.Sofware);
                }
                
                
            }

            if (p2.Sofware==SoftwareInstalado.todos && p2.Juegos==JuegosDisponibles.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
                else if(p1.Sofware == SoftwareInstalado.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = (p1.Periféricos == p2.Periféricos);
                }
              
            }


            if (p2.Juegos == JuegosDisponibles.todos && p2.Periféricos == PerisfericosDisponibles.todos && p2.Sofware == SoftwareInstalado.todos)
            {
                if (p1.Sofware == SoftwareInstalado.todos && p1.Periféricos == PerisfericosDisponibles.todos && p1.Juegos == JuegosDisponibles.todos)
                {
                    retorno = true;
                }
            }


            return retorno;
        }



        /// <summary>
        /// peticiones son diferentes si no son iguales
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Peticion p1, Peticion p2)
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
            Peticion otraPeticion = obj as Peticion;
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
