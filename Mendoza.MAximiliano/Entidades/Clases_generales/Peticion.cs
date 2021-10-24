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
      
        private List<string> listaSofware;
        private List<string> listaPerifericos;
        private List<string> listaJuegos;

       
        //------------PROPIEDADES----------------------

        public List<string> ListaSofware
        {
            get { return this.listaSofware; }
            set { this.listaSofware = value; }
        }
        public List<string> ListaPerifericos
        {
            get { return this.listaPerifericos; }
            set { this.listaPerifericos = value; }
        }
        public List<string> ListaJuegos
        {
            get { return this.listaJuegos; }
            set { this.listaJuegos = value; }

        }

        //---------------CONSTRUCTOR------------------------------------------------
        public Peticion(List<string> sofware, List<string> perisfericos, List<string> juegos)
     
        {
            this.ListaSofware = sofware;
            this.ListaPerifericos = perisfericos;
            this.ListaJuegos = juegos;
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

            if (p1.listaSofware.Count == p2.listaSofware.Count)
            {
                if (p1.listaSofware.Count == 1)
                {
                    if (p1.listaSofware[0] == p2.listaSofware[0]) { retornoS = true; }                  
                }
                if (p1.listaSofware.Count == 2)
                {
                   if (p1.listaSofware[0] == p2.listaSofware[0] && p1.listaSofware[1] == p2.listaSofware[1]) { retornoS = true; }                   
                }
                if (p1.listaSofware.Count == 3)
                {
                    if (p1.listaSofware[0] == p2.listaSofware[0] && p1.listaSofware[1] == p2.listaSofware[1] && p1.listaSofware[2] == p2.listaSofware[2]) { retornoS = true; }                
                }
                if (p1.listaSofware.Count == 4)
                {
                    if (p1.listaSofware[0] == p2.listaSofware[0] && p1.listaSofware[1] == p2.listaSofware[1] && p1.listaSofware[2] == p2.listaSofware[2] && p1.listaSofware[3] == p2.listaSofware[3]) { retornoS = true; }               
                }
            }
       
            if(p1.listaPerifericos.Count==p2.listaPerifericos.Count)
            {
                if (p1.listaPerifericos.Count == 1)
                {
                    if (p1.listaPerifericos[0] == p2.listaPerifericos[0]) { retornoP = true; }
                }
                if (p1.listaPerifericos.Count ==2)
                {
                    if(p1.listaPerifericos[0]==p2.listaPerifericos[0] && p1.listaPerifericos[1] == p2.listaPerifericos[1]) { retornoP = true; }
                }
                if (p1.listaPerifericos.Count == 3)
                {
                    if (p1.listaPerifericos[0] == p2.listaPerifericos[0] && p1.listaPerifericos[1] == p2.listaPerifericos[1] && p1.listaPerifericos[2]==p2.listaPerifericos[2]) { retornoP = true; }
                }
            }

            if(p1.ListaJuegos.Count==p2.ListaJuegos.Count)
            {
                if(p1.ListaJuegos.Count==1)
                {
                    if (p1.ListaJuegos[0] == p2.ListaJuegos[0]) { retornoJ = true; }
                }
                if (p1.ListaJuegos.Count == 2)
                {
                    if (p1.ListaJuegos[0] == p2.ListaJuegos[0] && p1.ListaJuegos[1]==p2.ListaJuegos[1]) { retornoJ = true; }
                }
                if (p1.ListaJuegos.Count == 3)
                {
                    if (p1.ListaJuegos[0] == p2.ListaJuegos[0] && p1.ListaJuegos[1] == p2.ListaJuegos[1] && p1.ListaJuegos[2]==p2.ListaJuegos[2]) { retornoJ = true; }
                }
                if (p1.ListaJuegos.Count == 4)
                {
                    if (p1.ListaJuegos[0] == p2.ListaJuegos[0] && p1.ListaJuegos[1] == p2.ListaJuegos[1] && p1.ListaJuegos[2] == p2.ListaJuegos[2] && p1.ListaJuegos[3]== p2.ListaJuegos[3]) { retornoJ = true; }
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
            
                foreach (string item in ListaSofware)
                {
                    sb.AppendLine(item.ToString());
                }
                
            sb.AppendLine("\nPERIFERICOS");
            foreach (string item in ListaPerifericos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("\nJUEGOS");
            foreach (string item in ListaJuegos)
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
            return otraPeticion is not null && this == otraPeticion;
        }

        /// <summary>
        /// sobrecarga GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (ListaSofware, listaPerifericos, ListaJuegos).GetHashCode();
        }

    }
}
