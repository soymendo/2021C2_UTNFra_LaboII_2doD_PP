﻿using Entidades.Clases_especializadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_generales
{
   public class Local
    {
        //------------------Atributos----------------------
        private string nombreDelQueAtiende;
        private int limite;

        private Queue<Cliente> ColaClientes;
        private List<Cliente> ListaClientes;
        private List<Maquinas> compusCabinas;

        private List<Computadora> ListaCompusDisponibles;
        private List<Computadora> ListaCompusOcupadas;
        private List<Computadora> ListaCompusFinalizadas;
        private List<Computadora> ListaCompusDisponiblesParaElClienteSegunsSusPetisiones;


        private List<Cabina> ListaCabinasDisponibles;
        private List<Cabina> ListaCabinasOcupadas;
        private List<Cabina> ListaCabinasFinalizadas;


        private int contadorSofwareOffice = 0;
        private int contadorSofwaremessenger = 0;
        private int contadorSofwareicq = 0;
        private int contadorSofwareares = 0;

        private int contadorPeriféricosCamara = 0;
        private int contadorPeriféricosAuriculares = 0;
        private int contadorPeriféricosMicrófono = 0;

        private int contadorJuegosCS = 0;
        private int contadorJuegosDiablo = 0;
        private int contadorJuegosMu = 0;
        private int contadorJuegosLinege = 0;

        private float contadorGananciasDelDiaPC = 0;
        private float contadorGananciasDelDiaCabina = 0;

        //----------------------------CONTADORES-----------------------------------------------
        public int ContadorSofwareOffice
        {
            get { return this.contadorSofwareOffice; }
            set { this.contadorSofwareOffice = value; }
        }
        public int ContadorSofwaremessenger
        {
            get { return this.contadorSofwaremessenger; }
            set { this.contadorSofwaremessenger = value; }
        }
        public int ContadorSofwareicq
        {
            get { return this.contadorSofwareicq; }
            set { this.contadorSofwareicq = value; }
        }
        public int ContadorSofwareares
        {
            get { return this.contadorSofwareares; }
            set { this.contadorSofwareares = value; }
        }



        public int ContadorPeriféricosCamara
        {
            get { return this.contadorPeriféricosCamara; }
            set { this.contadorPeriféricosCamara = value; }
        }

        public int ContadorPeriféricosAuriculares
        {
            get { return this.contadorPeriféricosAuriculares; }
            set { this.contadorPeriféricosAuriculares = value; }
        }
        public int ContadorPeriféricosMicrófono
        {
            get { return this.contadorPeriféricosMicrófono; }
            set { this.contadorPeriféricosMicrófono = value; }
        }


        public int ContadorJuegosCS
        {
            get { return this.contadorJuegosCS; }
            set { this.contadorJuegosCS = value; }
        }
        public int ContadorJuegosDiablo
        {
            get { return this.contadorJuegosDiablo; }
            set { this.contadorJuegosDiablo = value; }
        }
        public int ContadorJuegosMu
        {
            get { return this.contadorJuegosMu; }
            set { this.contadorJuegosMu = value; }
        }
        public int ContadorJuegosLinege
        {
            get { return this.contadorJuegosLinege; }
            set { this.contadorJuegosLinege = value; }
        }


        public float ContadorGananciasDelDiaPC
        {
            get { return this.contadorGananciasDelDiaPC; }
            set { this.contadorGananciasDelDiaPC = value; }
        }

        public float ContadorGananciasDelDiaCabina
        {
            get { return this.contadorGananciasDelDiaCabina; }
            set { this.contadorGananciasDelDiaCabina = value; }
        }


        public List<Computadora>Lista_CompusDisponibles
        {
            get { return this.ListaCompusDisponibles; }
        }
        public List<Computadora> Lista_CompusOcupadas
        {
            get { return this.ListaCompusOcupadas; }
            set { this.ListaCompusOcupadas = value; }
        }
        public List<Computadora> Lista_CompusFinalizadas
        {
            get { return this.ListaCompusFinalizadas; }
        }
        public List<Computadora> Lista_CompusDisponiblesParaElClienteSegunsSusPetisiones
        {
            get { return this.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones; }
        }


        public List<Cabina>Lista_cabinas_disponibles
        {
            get { return this.ListaCabinasDisponibles; }
            set { this.ListaCabinasDisponibles = value; }
        }

        public List<Cabina>Lista_cabinas_ocupadas
        {
            get { return this.ListaCabinasOcupadas; }
            set { this.ListaCabinasOcupadas = value; }
        }

        public Queue<Cliente> Cola_Clientes
        {
            get { return this.ColaClientes; }
            set { this.ColaClientes = value; }
        }

        public List<Cliente>Lista_Clientes
        {
            get { return this.ListaClientes; }
        }
        /// <summary>
        /// constructro , inicializo las listas
        /// </summary>
        private Local()
        {
            this.ListaClientes = new List<Cliente>();
            this.compusCabinas = new List<Maquinas>();

            this.ListaCompusDisponibles = new List<Computadora>()
            {
             new Computadora("C01", Petisiones.SoftwareInstalado.todos, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.todos),
            new Computadora("C02", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.todos, Petisiones.JuegosDisponibles.todos),
            new Computadora("C03", Petisiones.SoftwareInstalado.todos, Petisiones.PeriféricosDisponibles.todos, Petisiones.JuegosDisponibles.todos),
            new Computadora("C04", Petisiones.SoftwareInstalado.office, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.MuOnline),
            new Computadora("C05", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.todos, Petisiones.JuegosDisponibles.CounterStrike),
            new Computadora("C06", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.DiabloII),
            new Computadora("C07", Petisiones.SoftwareInstalado.ares, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.LineageII),
            new Computadora("C08", Petisiones.SoftwareInstalado.office, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.MuOnline),
            new Computadora("C09", Petisiones.SoftwareInstalado.messenger, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.DiabloII),
            new Computadora("C10", Petisiones.SoftwareInstalado.messenger, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.CounterStrike),
            new Computadora("C11", Petisiones.SoftwareInstalado.ares, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.DiabloII),
            new Computadora("C12", Petisiones.SoftwareInstalado.office, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.CounterStrike),
            new Computadora("C13", Petisiones.SoftwareInstalado.icq, Petisiones.PeriféricosDisponibles.micrófono, Petisiones.JuegosDisponibles.MuOnline),
            new Computadora("C14", Petisiones.SoftwareInstalado.office, Petisiones.PeriféricosDisponibles.camara, Petisiones.JuegosDisponibles.CounterStrike),
            new Computadora("C15", Petisiones.SoftwareInstalado.ares, Petisiones.PeriféricosDisponibles.auriculares, Petisiones.JuegosDisponibles.todos)
        };



            //Panasonic

            this.ListaCompusOcupadas = new List<Computadora>();
            this.ListaCompusFinalizadas = new List<Computadora>();
            this.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones = new List<Computadora>();

            this.ColaClientes = new Queue<Cliente>();
            this.ListaClientes = new List<Cliente>();

          
            this.ListaCabinasDisponibles = new List<Cabina>()
            {
                new Cabina("T01",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T02",Cabina.TipoTelefono.ACuerda,"Siemens"),
                new Cabina("T03",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T04",Cabina.TipoTelefono.ACuerda,"Siemens"),
                new Cabina("T05",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T06",Cabina.TipoTelefono.ACuerda,"Siemens"),
                new Cabina("T07",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T08",Cabina.TipoTelefono.ACuerda,"Siemens"),
                new Cabina("T09",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T10",Cabina.TipoTelefono.ACuerda,"Siemens")
            };


            this.ListaCabinasOcupadas = new List<Cabina>();
            this.ListaCabinasFinalizadas = new List<Cabina>();

        }

        public Local(int limite)
        {

        }
        public Local(string nombre, int limite)
        : this()
        {
            this.nombreDelQueAtiende = nombre;
            this.limite = limite;
        }








        /// <summary>
        /// muestra si la maquina esta en el local
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Local loc, Maquinas c)
        {
            bool retorno = false;
            if (loc is not null && c is not null)
            {
                foreach (Maquinas item in loc.compusCabinas)
                {

                    if (item is Computadora && c is Computadora && ((Computadora)item == (Computadora)c))
                    {
                        retorno = true;
                        break;
                    }
                    else if (item is Cabina && c is Cabina && ((Cabina)item == (Cabina)c))
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }




        /// <summary>
        /// muestra si la maquina no esta en el local
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator !=(Local loc, Maquinas c)
        {
            return !(loc == c);
        }



        /// <summary>
        /// agrega un amaquina al local, lo suma a disponibles
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Local loc, Maquinas c)
        {
            bool retorno = false;
            if (loc != c && loc.limite <= 20)
            {
                loc.compusCabinas.Add(c);
                if (c is Computadora)
                {
                    loc.ListaCompusDisponibles.Add((Computadora)c);
                }
                if (c is Cabina)
                { loc.ListaCabinasDisponibles.Add((Cabina)c); }

                retorno = true;
            }
            return retorno;
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// veo si la ccompu esta en ListaCompusDisponiblesParaElClienteSegunsSusPetisiones
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones)
            {
                if (item.PetisionesDePc == c.PetisionesDePc)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo la compu en ListaCompusDisponiblesParaElClienteSegunsSusPetisiones
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCompuEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(Local l, Computadora c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(l, c)))
            {
                foreach (Computadora item in l.ListaCompusDisponibles)
                {
                    if (item.PetisionesDePc == c.PetisionesDePc)
                    {
                        l.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones.Add(item);
                        retorno = true;
                    }
                }
                //l.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones.Add(c);
                // retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// Devuelve true si guardo la compu en ListaCompusDisponiblesParaElClienteSegunsSusPetisiones
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCompuSolamenteEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(Local l, Computadora c)
        {

            bool retorno = false;

           // if (!(Local.AlmacenadoEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(l, c)))
           // {
                
                l.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones.Add(c);
                 
                retorno = true;
          //  }

            return retorno;
        }



        /// <summary>
        /// Elimina la compu de ListaCompusDisponiblesParaElClienteSegunsSusPetisiones
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarCompuEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(Local l, Computadora c)
        {
            bool retorno = false;
            if (Local.AlmacenadoEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(l, c))
            {
                l.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones.Remove(c);
                retorno = true;
            }

            return retorno;
        }

        //---------------------------------------------------------------------------------


        /// <summary>
        /// veo si la ccompu esta en ListaCompusDisponibles
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaCompusDisponibles(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.ListaCompusDisponibles)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo la compu en la lista de compus disponibles
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCompuEnListaCompusDisponibles(Local l, Computadora c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaCompusDisponibles(l, c)))
            {
                l.ListaCompusDisponibles.Add(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina la compu de la lista dispónible
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarCompuEnListaCompusDisponibles(Local l, Computadora c)
        {
            bool retorno = false;
            if(Local.AlmacenadoEnListaCompusDisponibles(l,c))
            {
                l.ListaCompusDisponibles.Remove(c);
                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// veo si la ccompu esta en ListaCompusOcupadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaCompusOcupadas(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.ListaCompusOcupadas)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo la compu en ListaCompusOcupadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCompuEnListaCompusOcupadas(Local l, Computadora c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaCompusOcupadas(l, c)))
            {
                l.ListaCompusOcupadas.Add(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina la compu de ListaCompusOcupadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarCompuEnListaCompusOcupadas(Local l, Computadora c)
        {
            bool retorno = false;
            if (Local.AlmacenadoEnListaCompusOcupadas(l, c))
            {
                l.ListaCompusOcupadas.Remove(c);
                retorno = true;
            }

            return retorno;

        }


        /// <summary>
        /// veo si la ccompu esta en ListaCompusFinalizadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaCompusFinalizadas(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.ListaCompusFinalizadas)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo la compu en ListaCompusFinalizadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCompuEnListaCompusFinalizadas(Local l, Computadora c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaCompusFinalizadas(l, c)))
            {
                l.ListaCompusFinalizadas.Add(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina la compu de ListaCompusFinalizadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarCompuEnListaCompusFinalizadas(Local l, Computadora c)
        {
            bool retorno = false;
            if (Local.AlmacenadoEnListaCompusFinalizadas(l, c))
            {
                l.ListaCompusFinalizadas.Remove(c);
                retorno = true;
            }

            return retorno;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
       


        /// <summary>
        /// veo si la cabina esta en ListaCabinasDisponibles
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaCabinasDisponibles(Local l, Cabina c)
        {
            bool retorno = false;

            foreach (Cabina item in l.ListaCabinasDisponibles)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo la cabina en ListaCabinasDisponibles
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCabinaEnListaCabinasDisponibles(Local l, Cabina c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaCabinasDisponibles(l, c)))
            {
                l.ListaCabinasDisponibles.Add(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina la CABINA de la ListaCabinasDisponibles
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarCabinaEnListaCabinasDisponibles(Local l, Cabina c)
        {
            bool retorno = false;
            if (Local.AlmacenadoEnListaCabinasDisponibles(l, c))
            {
                l.ListaCabinasDisponibles.Remove(c);
                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// veo si la cabinaesta en ListaCabinasOcupadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaCabinasOcupadas(Local l, Cabina c)
        {
            bool retorno = false;

            foreach (Cabina item in l.ListaCabinasOcupadas)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo la cabina en ListaCabinasOcupadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCabinaEnListaCabinasOcupadas(Local l, Cabina c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaCabinasOcupadas(l, c)))
            {
                l.ListaCabinasOcupadas.Add(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina la cabina de ListaCompusOcupadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarCabinaEnListaCabinasOcupadas(Local l, Cabina c)
        {
            bool retorno = false;
            if (Local.AlmacenadoEnListaCabinasOcupadas(l, c))
            {
                l.ListaCabinasOcupadas.Remove(c);
                retorno = true;
            }

            return retorno;

           
        }


        /// <summary>
        /// veo si la cabina esta en ListaCompusFinalizadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaCabinasFinalizadas(Local l, Cabina c)
        {
            bool retorno = false;

            foreach (Cabina item in l.ListaCabinasFinalizadas)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo la cabina en ListaCabinasFinalizadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarCabinaEnListaCabinasFinalizadas(Local l, Cabina c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaCabinasFinalizadas(l, c)))
            {
                l.ListaCabinasFinalizadas.Add(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina la cabina de ListaCabinasFinalizadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarCabinaEnListaCabinasFinalizadas(Local l, Cabina c)
        {
            bool retorno = false;
            if (Local.AlmacenadoEnListaCabinasFinalizadas(l, c))
            {
                l.ListaCabinasFinalizadas.Remove(c);
                retorno = true;
            }

            return retorno;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// veo si la cliente esta en ListaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnListaClientes(Local l, Cliente c)
        {
            bool retorno = false;

            foreach (Cliente item in l.ListaClientes)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo cliente  en ListaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarClienteEnListaClientes(Local l, Cliente c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnListaClientes(l, c)))
            {
                l.ListaClientes.Add(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina cliente de ListaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarClienteEnListaClientes(Local l, Cliente c)
        {
            bool retorno = false;
            if (Local.AlmacenadoEnListaClientes(l, c))
            {
                l.ListaClientes.Remove(c);
                retorno = true;
            }

            return retorno;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //private Queue<Cliente> ColaClientes;

        /// <summary>
        /// veo si cliente esta en ColaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool AlmacenadoEnColaClientes(Local l, Cliente c)
        {
            bool retorno = false;

            foreach (Cliente item in l.ColaClientes)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Devuelve true si guardo cliente en ColaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool GuardarClienteEnColaClientes(Local l,Cliente c)
        {

            bool retorno = false;

            if (!(Local.AlmacenadoEnColaClientes(l, c)))
            {
                l.ColaClientes.Enqueue(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Elimina la cliente en ColaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarClienteEnColaClientes(Local l)
        {
            bool retorno = false;
            //if (Local.AlmacenadoEnColaClientes(l, c))
            //{
            //    l.ColaClientes.Dequeue();
            //    retorno = true;
            //}
            l.Cola_Clientes.Dequeue();
            return retorno;
        }




        //-------------------------------------------------------------------------------------------------------
        /// <summary>
        /// busca la pc que coincida con lo del cliente en la lista de compus disponibles
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>

        public bool BuscarCompuEnLaLista(Computadora c)
        {
            bool retorno = false;
            foreach (Computadora item in this.ListaCompusDisponibles)
            {
                if (item.PetisionesDePc ==c.PetisionesDePc)
                {
                    retorno = true;
                }
            }
            return retorno;
        }




        /// <summary>
        /// Asigna una compu al cliente, true si lo asigno
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AsignarCompuAlCliente(Local l, Computadora c)
        {
            bool retorno = false;

            if(Local.AlmacenadoEnListaCompusDisponibles(l,c))
            {
                Local.EliminarCompuEnListaCompusDisponibles(l, c);
                Local.EliminarCompuEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(l, c);
                Local.GuardarCompuEnListaCompusOcupadas(l, c);


                c.TiempoInicial = DateTime.Now;
                c.sw.Start();

                if (c.PetisionesDePc.Sofware.ToString() == "office") { l.ContadorSofwareOffice += 1; }
                if (c.PetisionesDePc.Sofware.ToString() == "messenger") { l.ContadorSofwaremessenger += 1; }
                if (c.PetisionesDePc.Sofware.ToString() == "icq") { l.ContadorSofwareicq += 1; }
                if (c.PetisionesDePc.Sofware.ToString() == "ares") { l.ContadorSofwareares += 1; }

                if (c.PetisionesDePc.Periféricos.ToString() == "camara") { l.ContadorPeriféricosCamara += 1; }
                if (c.PetisionesDePc.Periféricos.ToString() == "auriculares") { l.ContadorPeriféricosAuriculares += 1; }
                if (c.PetisionesDePc.Periféricos.ToString() == "micrófono") { l.ContadorPeriféricosMicrófono += 1; }

                if (c.PetisionesDePc.Juegos.ToString() == "CounterStrike") { l.ContadorJuegosCS += 1; }
                if (c.PetisionesDePc.Juegos.ToString() == "DiabloII") { l.ContadorJuegosDiablo += 1; }
                if (c.PetisionesDePc.Juegos.ToString() == "MuOnline") { l.ContadorJuegosMu += 1; }
                if (c.PetisionesDePc.Juegos.ToString() == "LineageII") { l.ContadorJuegosLinege += 1; }

                if (c.PetisionesDePc.Sofware.ToString() == "todos") { l.ContadorSofwareOffice += 1; l.ContadorSofwaremessenger += 1; l.ContadorSofwareicq += 1; l.ContadorSofwareares += 1; }
                if (c.PetisionesDePc.Periféricos.ToString() == "todos") { l.ContadorPeriféricosCamara += 1; l.ContadorPeriféricosAuriculares += 1; l.ContadorPeriféricosMicrófono += 1; }
                if (c.PetisionesDePc.Sofware.ToString() == "todos") { l.ContadorJuegosCS += 1; l.ContadorJuegosDiablo += 1; l.ContadorJuegosMu += 1; l.ContadorJuegosLinege += 1; }


                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// asigna una cabian al cliente
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AsignarCabinaAlCliente(Local l, Cabina c)
        {
            bool retorno = false;
            if(Local.AlmacenadoEnListaCabinasDisponibles(l,c))
            {
                Local.EliminarCabinaEnListaCabinasDisponibles(l, c);
                Local.GuardarCabinaEnListaCabinasOcupadas(l, c);
                c.TiempoInicial = DateTime.Now;
                c.sw.Start();

            }

            return retorno;

        }


        //----------------------------------------------------------------------------------
        public static bool AsignarClienteAListaDeEspera(Local l, Cliente c)
        {
            bool retorno = false;


            return retorno;
        }


        /// <summary>
        /// finaliza la compu y le asigna un tiempo final para calcular el costo
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool FinalizarTareaCompu(Local l, Computadora c)
        {
            bool retorno = false;

            if(AlmacenadoEnListaCompusOcupadas(l,c))
            {
                Local.EliminarCompuEnListaCompusOcupadas(l, c);
                Local.GuardarCompuEnListaCompusDisponibles(l, c);
                Local.GuardarCompuEnListaCompusFinalizadas(l, c);
                //Local.GuardarCompuEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(l, c);
                Local.GuardarCompuSolamenteEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(l,c);

                c.TiempoFinal = DateTime.Now;
                c.sw.Stop();
                l.ContadorGananciasDelDiaPC += c.CalcularCosto();
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// finaliza la cabina y le asigna un tiempo final para calcular el costo
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool FinalizarTareaCabina(Local l, Cabina c)
        {
            bool retorno = false;

            if (AlmacenadoEnListaCabinasOcupadas(l, c))
            {
                Local.EliminarCabinaEnListaCabinasOcupadas(l, c);
                Local.GuardarCabinaEnListaCabinasDisponibles(l, c);
                Local.GuardarCabinaEnListaCabinasFinalizadas(l, c);

                c.TiempoFinal = DateTime.Now;
                c.sw.Stop();
                l.ContadorGananciasDelDiaCabina += c.CalcularCosto();
                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// muestra las cosas mas usadas de compu
        /// </summary>
        /// <returns></returns>
        public string PetisionesMasPedidas()
        {
            string retornoS = "";
            string retornoP = "";
            string retornoJ = "";

            List<string> retornosS = new List<string>();
            List<string> retornosP = new List<string>();
            List<string> retornosJ = new List<string>();

            int[] sofware = { ContadorSofwareOffice, ContadorSofwaremessenger, ContadorSofwareicq, ContadorSofwareares };
            int[] Perisfericos = { ContadorPeriféricosCamara, ContadorPeriféricosAuriculares, ContadorPeriféricosMicrófono };
            int[] Juegos = { ContadorJuegosCS, ContadorJuegosDiablo, ContadorJuegosMu, ContadorJuegosLinege };

            int maxs = sofware[0];


            int maxP = Perisfericos[0];
            int maxJ = Juegos[0];

            for (int i = 0; i < 4; i++)
            {
                if (sofware[i] > maxs) { maxs = sofware[i]; }

            }

            for (int i = 0; i < 3; i++)
            {
                if (Perisfericos[i] > maxP) { maxP = Perisfericos[i]; }
            }

            for (int i = 0; i < 4; i++)
            {
                if (Juegos[i] > maxJ) { maxJ = Juegos[i]; }

            }


            if (maxs == sofware[0]) { retornoS = "Office"; retornosS.Add(retornoS); }
            if (maxs == sofware[1]) { retornoS = "Messenger"; retornosS.Add(retornoS); }
            if (maxs == sofware[2]) { retornoS = "Icq"; retornosS.Add(retornoS); }
            if (maxs == sofware[3]) { retornoS = "Ares"; retornosS.Add(retornoS); }



            if (maxP == Perisfericos[0]) { retornoP = "Camara"; retornosP.Add(retornoP); }
            if (maxP == Perisfericos[1]) { retornoP = "Auriculares"; retornosP.Add(retornoP); }
            if (maxP == Perisfericos[2]) { retornoP = "Microfono"; retornosP.Add(retornoP); }

            if (maxs == Juegos[0]) { retornoJ = "CounterStrike"; retornosJ.Add(retornoJ); }
            if (maxs == Juegos[1]) { retornoJ = "DiabloII"; retornosJ.Add(retornoJ); }
            if (maxs == Juegos[2]) { retornoJ = "MuOnline"; retornosJ.Add(retornoJ); }
            if (maxs == Juegos[3]) { retornoJ = "LineageII"; retornosJ.Add(retornoJ); }




            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************El/los sofware mas pedido es/son: ****************");

            foreach (string item in retornosS)
            {
                sb.AppendLine($"{item}");
            }
            sb.AppendLine($"Cantidad: { maxs}");
            //sb.AppendLine($"{retorno1}\n{retorno2}\n{retorno3}\n{retorno4} \ncantidad: {maxs}" );
            sb.AppendLine();
            sb.AppendLine("****************El/los perisferico mas pedido es/son: ****************");
            foreach (string item in retornosP)
            {
                sb.AppendLine($"{item}");
            }
            sb.AppendLine($"Cantidad: { maxP}");

            sb.AppendLine();
            sb.AppendLine("****************El/los juego mas pedido es/son: ****************");
            foreach (string item in retornosJ)
            {
                sb.AppendLine($"{item}");
            }
            sb.AppendLine($"Cantidad: {maxJ}");

            return sb.ToString();

        }





        /// <summary>
        /// ordena las pc segun su tiempo de uso.
        /// https://www.youtube.com/watch?v=cZNcJ3enNmU
        /// </summary>
        public string ListaPcOrdenadasPorTiempoDeUso(Local loc)
        {
           

            IEnumerable<Computadora> ListaPCOrdenadas = this.ListaCompusFinalizadas.OrderByDescending(user => user.TiempoDeUso);
            StringBuilder sb = new StringBuilder();
            foreach (Computadora item in ListaPCOrdenadas)
            {
                sb.Append($"{item.Mostrar()} ");
                sb.AppendLine($"Tiempo de uso: {item.TiempoDeUso}");
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine();
            }
            return sb.ToString();
        }



        /// <summary>
        /// ordena las cabina segun su tiempo de uso.
        /// https://www.youtube.com/watch?v=cZNcJ3enNmU
        /// </summary>
        public string ListaCabinasOrdenadasPorTiempoDeUso(Local loc)
        {
           

            IEnumerable<Cabina> ListaCabinasOrdenadas = this.ListaCabinasFinalizadas.OrderByDescending(user => user.TiempoDeUso);
            StringBuilder sb = new StringBuilder();
            foreach (Cabina item in ListaCabinasOrdenadas)
            {
                sb.Append(item.Mostrar());
                sb.AppendLine($"Tiempo de uso: {item.TiempoDeUso.ToString()}");
                sb.AppendLine();
            }
            return sb.ToString();
        }







        /// <summary>
        /// tiempo total y recaudacion por tipo de llamada
        /// </summary>
        /// <returns></returns>
        public string Horas_totales_Y_La_Recaudación_Por_Tipo_De_Llamada()
        {
            float acumLocal = 0;
            float acumLargaDistancia = 0;
            float acumInternacional = 0;
            StringBuilder sb = new StringBuilder();

            foreach (Cabina item in this.ListaCabinasFinalizadas)
            {
                if (item.Destino() == TipoLlamada.local.ToString())
                {
                    acumLocal += item.CostoLocal();
                }

                if (item.Destino() == TipoLlamada.largaDistancia.ToString())
                {
                    acumLargaDistancia += item.CostoLargaDistancia();
                }
                if (item.Destino() == TipoLlamada.internacional.ToString())
                {
                    acumInternacional += item.CostoInternacional();
                }
            }


            sb.AppendLine($"Tiempo total de llamadas: {TiempoTotalCabinas()}");

            sb.AppendLine($"Ganancias de llamadas locales: {acumLocal}");
            sb.AppendLine($"Ganancias de llamadas larga distancia: {acumLargaDistancia}");
            sb.AppendLine($"Ganancias de llamadas Internacionales: {acumInternacional}");

            return sb.ToString();
        }






        /// <summary>
        /// muestra el tiempo de uso d elas cabianas en la lista cabinas finalizadas
        /// </summary>
        /// <returns></returns>
        public double TiempoTotalCabinas()
        {
            double acum = 0;
            foreach (Cabina item in this.ListaCabinasFinalizadas)
            {
                acum += item.TiempoDeUso;
            }

            return acum;
        }









        /// <summary>
        /// ganancias recaudadas del dia tanto de pc como de cabinas
        /// </summary>
        public string GananciasTotales()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ganancias de Computadoras: ");
            sb.AppendLine(this.ContadorGananciasDelDiaPC.ToString());
            sb.AppendLine();
            sb.AppendLine("Ganancias de Cabinas: ");
            sb.AppendLine(this.ContadorGananciasDelDiaCabina.ToString());

            return sb.ToString();
        }




        /// <summary>
        ///verifica si hay pc disponibles (en la lista de pc desponibles) que cumplan con los requisitos del cliente
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public string MostrarCompusDisponiblesParaElClienteSegunsSusPetisiones(Computadora c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Maquinas: ");

            foreach (Computadora item in this.ListaCompusDisponibles)
            {
                if (item.PetisionesDePc == c.PetisionesDePc /*|| c.PetisionesDePc.Juegos.ToString()=="todos"*/)
                {
                    sb.AppendLine(item.Mostrar());
                }
            }
            return sb.ToString();
        }





        /// <summary>
        ///verifica si hay pc disponibles (en la lista de pc desponibles) que cumplan con los requisitos del cliente
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public string MostrarListaCompusDisponiblesParaElClienteSegunsSusPetisiones(Computadora c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Maquinas: ");

            foreach (Computadora item in this.ListaCompusDisponiblesParaElClienteSegunsSusPetisiones)
            {
                
              
                    sb.AppendLine(item.Mostrar());
             
            }
            return sb.ToString();
        }




        /// <summary>
        /// Muestra las compus disponibles
        /// </summary>
        /// <returns></returns>

        public string MostrarCompusDisponibles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del que atiende: {this.nombreDelQueAtiende}");
            sb.AppendLine("Maquinas: ");
            foreach (Computadora item in this.ListaCompusDisponibles)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }



        /// <summary>
        /// muetra las pc ocupadas
        /// </summary>
        /// <returns></returns>
        public string MostrarCompusOcupadas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del que atiende: {this.nombreDelQueAtiende}");
            sb.AppendLine("Maquinas: ");
            foreach (Computadora item in this.ListaCompusOcupadas)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }

        //---------------------------------------------------------------------------------
        /// <summary>
        /// Muestra las cabinas disponibles
        /// </summary>
        /// <returns></returns>

        public string MostrarCabinasDisponibles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del que atiende: {this.nombreDelQueAtiende}");
            sb.AppendLine("Maquinas: ");
            foreach (Cabina item in this.ListaCabinasDisponibles)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }



        /// <summary>
        /// muetra las cabinas ocupadas
        /// </summary>
        /// <returns></returns>
        public string MostrarCabinasOcupadas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del que atiende: {this.nombreDelQueAtiende}");
            sb.AppendLine("Maquinas: ");
            foreach (Cabina item in this.ListaCabinasOcupadas)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }



        //--------------------------------------------------------------------------------



        /// <summary>
        /// muestra los clientes disponibles
        /// </summary>
        /// <returns></returns>
        public string MostrarClientesDisponiblesLista()
        {
            StringBuilder sb = new StringBuilder();
          
            foreach (Cliente item in this.ListaClientes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }


        /// <summary>
        /// muestra los clientes disponibles
        /// </summary>
        /// <returns></returns>
        public string MostrarClientesDisponiblesCola()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cliente item in this.ColaClientes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }



        /// <summary>
        /// muetra todas las pc y cabinas
        /// </summary>
        /// <returns></returns>
        public string MostrarCompusYCabinasDelLocal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del que atiende: {this.nombreDelQueAtiende}");
            sb.AppendLine("Maquinas: ");
            foreach (Maquinas item in this.compusCabinas)
            {
                if (item is Computadora)
                {
                    sb.AppendLine(item.Mostrar());
                }
                if (item is Cabina)
                {
                    sb.AppendLine(item.Mostrar());
                }

            }
            return sb.ToString();
        }


        

        //public Computadora DevolverCompu(Computadora c)
        //{
        //    Computadora comp=new Computadora();
        //    foreach (Computadora item in this.ListaCompusOcupadas)
        //    {
        //        if (item.PetisionesDePc == c.PetisionesDePc)
        //            comp = c;
        //    }

        //    return comp;
        //}

    }
}