using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_especializadas
{
    public class Bebida
    {
        //----------------ATRIBUTOS---------------------------
        private float precio = 1.5f;
        private long codigoBarras;


        //---------------PROPIEDADES----------------------------
        public float Precio
        {
            get { return this.precio; }
            set { this.precio=value; }
        }

        public string MostrarBebida()
        {
            return $"{this.Precio}";
        }
        
        public long CodigoBarras
        {
            get { return this.codigoBarras; }
            set { this.codigoBarras = value; }
        }


     //---------------CONSTRUCTORES------------------------------
        public Bebida(long codigoBarras)   
        {
            this.codigoBarras = codigoBarras;
        }



        //---------SOBRECARGAS------------------------------

        public static bool operator==(Bebida c1, Bebida c2)
        {
            return (c1.codigoBarras == c2.codigoBarras);
        }

        public static bool operator !=(Bebida c1, Bebida c2)
        {
            return !(c1 == c2);
        }


        public override string ToString()
        {
            return this.MostrarBebida();
        }


        public override bool Equals(object obj)
        {
            Bebida otraCoca = obj as Bebida;
            return otraCoca is not null && this == otraCoca;
        }

        public override int GetHashCode()
        {
            return (CodigoBarras).GetHashCode();
        }


    }
}
