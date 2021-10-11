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
      
        private List<string> ListaSofware;
        private List<string> ListaPerifericos;
        private List<string> ListaJuegos;

       
        //------------PROPIEDADES----------------------

        public List<string> Lista_Sofware
        {
            get { return this.ListaSofware; }
            set { this.ListaSofware = value; }
        }
        public List<string> Lista_Perifericos
        {
            get { return this.ListaPerifericos; }
            set { this.ListaPerifericos = value; }
        }
        public List<string> Lista_Juegos
        {
            get { return this.ListaJuegos; }
            set { this.ListaJuegos = value; }

        }

        //---------------CONSTRUCTOR------------------------------------------------
        public Peticion(List<string> sofware, List<string> perisfericos, List<string> juegos)
     
        {
            this.Lista_Sofware = sofware;
            this.Lista_Perifericos = perisfericos;
            this.Lista_Juegos = juegos;
        }




       //---------------SOBRECARGAS----------------------------------------------------------------


        /// <summary>
        /// petisiones son iguales si tienen los mismo 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2">compu a igualar</param>
        /// <returns></returns>
        public static bool operator ==(Peticion p1, Peticion p2)
        {
            bool retorno = false;
            bool retornoS = false;
            bool retornoP= false;
            bool retornoJ = false;
            if (p1.ListaSofware.Count == p2.ListaSofware.Count)
            {
                if (p1.ListaSofware.Count == 1)
                {
                    if (p1.ListaSofware[0] == p2.ListaSofware[0]) { retornoS = true; }                  
                }
                if (p1.ListaSofware.Count == 2)
                {
                   if (p1.ListaSofware[0] == p2.ListaSofware[0] && p1.ListaSofware[1] == p2.ListaSofware[1]) { retornoS = true; }                   
                }
                if (p1.ListaSofware.Count == 3)
                {
                    if (p1.ListaSofware[0] == p2.ListaSofware[0] && p1.ListaSofware[1] == p2.ListaSofware[1] && p1.ListaSofware[2] == p2.ListaSofware[2]) { retornoS = true; }                
                }
                if (p1.ListaSofware.Count == 4)
                {
                    if (p1.ListaSofware[0] == p2.ListaSofware[0] && p1.ListaSofware[1] == p2.ListaSofware[1] && p1.ListaSofware[2] == p2.ListaSofware[2] && p1.ListaSofware[3] == p2.ListaSofware[3]) { retornoS = true; }               
                }
            }
       
            if(p1.ListaPerifericos.Count==p2.ListaPerifericos.Count)
            {
                if (p1.ListaPerifericos.Count == 1)
                {
                    if (p1.ListaPerifericos[0] == p2.ListaPerifericos[0]) { retornoP = true; }
                }
                if (p1.ListaPerifericos.Count ==2)
                {
                    if(p1.ListaPerifericos[0]==p2.ListaPerifericos[0] && p1.ListaPerifericos[1] == p2.ListaPerifericos[1]) { retornoP = true; }
                }
                if (p1.ListaPerifericos.Count == 3)
                {
                    if (p1.ListaPerifericos[0] == p2.ListaPerifericos[0] && p1.ListaPerifericos[1] == p2.ListaPerifericos[1] && p1.ListaPerifericos[2]==p2.ListaPerifericos[2]) { retornoP = true; }
                }
            }

            if(p1.Lista_Juegos.Count==p2.Lista_Juegos.Count)
            {
                if(p1.Lista_Juegos.Count==1)
                {
                    if (p1.Lista_Juegos[0] == p2.Lista_Juegos[0]) { retornoJ = true; }
                }
                if (p1.Lista_Juegos.Count == 2)
                {
                    if (p1.Lista_Juegos[0] == p2.Lista_Juegos[0] && p1.Lista_Juegos[1]==p2.Lista_Juegos[1]) { retornoJ = true; }
                }
                if (p1.Lista_Juegos.Count == 3)
                {
                    if (p1.Lista_Juegos[0] == p2.Lista_Juegos[0] && p1.Lista_Juegos[1] == p2.Lista_Juegos[1] && p1.Lista_Juegos[2]==p2.Lista_Juegos[2]) { retornoJ = true; }
                }
                if (p1.Lista_Juegos.Count == 4)
                {
                    if (p1.Lista_Juegos[0] == p2.Lista_Juegos[0] && p1.Lista_Juegos[1] == p2.Lista_Juegos[1] && p1.Lista_Juegos[2] == p2.Lista_Juegos[2] && p1.Lista_Juegos[3]== p2.Lista_Juegos[3]) { retornoJ = true; }
                }
            }
                retorno = (retornoS && retornoP && retornoJ);
                return retorno;
        }



        /// <summary>
        /// petiones son diferentes si no son iguales
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Peticion p1, Peticion p2)
        {
            return !(p1 == p2);
        }




        private string MostrarListas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nSOFWARE");
            foreach (string item in Lista_Sofware)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("\nPERIFERICOS");
            foreach (string item in Lista_Perifericos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("\nJUEGOS");
            foreach (string item in Lista_Juegos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }


        /// <summary>
        /// muestra los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.MostrarListas());
           
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
            return (Lista_Sofware, ListaPerifericos, Lista_Juegos).GetHashCode();
        }

    }
}
