using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_especializadas
{
    public class Coca_cola
    {
        private float precio = 1.5f;
        private long codigoBarras;

        public float Precio
        {
            get { return this.precio; }
            set { this.precio=value; }
        }

        public string MostrarCoca()
        {
            return $"{this.Precio}";
        }
        
        public long CodigoBarras
        {
            get { return this.codigoBarras; }
            set { this.codigoBarras = value; }
        }


        public Coca_cola()
        {

        }
        public Coca_cola(long codigoBarras)
        :this()
        {
            this.codigoBarras = codigoBarras;
        }


        public static bool operator==(Coca_cola c1, Coca_cola c2)
        {
            return (c1.codigoBarras == c2.codigoBarras);
        }

        public static bool operator !=(Coca_cola c1, Coca_cola c2)
        {
            return !(c1 == c2);
        }


        public override string ToString()
        {
            return this.MostrarCoca();
        }


        public override bool Equals(object obj)
        {
            Coca_cola otraCoca = obj as Coca_cola;
            return otraCoca != null && this == otraCoca;
        }

        public override int GetHashCode()
        {
            return (CodigoBarras).GetHashCode();
        }


    }
}
