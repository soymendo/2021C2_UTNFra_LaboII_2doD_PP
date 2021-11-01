using Entidades.Clases_especializadas;
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

        private float totalLocal = 0;
        private float totalLargaDistancia = 0;
        private float totalInterncaional = 0;
        const float iva = 1.21f;
        private string nombreDelQueAtiende;
        private int limite;

        private Queue<Cliente> colaClientes;
        private List<Cliente> listaClientes;
        private List<Maquina> compusCabinas;

        private List<Computadora> listaCompusDisponibles;
        private List<Computadora> listaCompusOcupadas;
        private List<Computadora> listaCompusFinalizadas;


        private List<Cabina> listaCabinasDisponibles;
        private List<Cabina> listaCabinasOcupadas;
        private List<Cabina> listaCabinasFinalizadas;

        private Queue<Bebida> stockDeBebidas;
       

        private int contadorSofwareOffice = 0;
        private int contadorSofwaremessenger = 0;
        private int contadorSofwareicq = 0;
        private int contadorSofwareares = 0;

        private int contadorPerifericosCamara = 0;
        private int contadorPerifericosAuriculares = 0;
        private int contadorPerifericosMicrofono = 0;

        private int contadorJuegosCS = 0;
        private int contadorJuegosDiablo = 0;
        private int contadorJuegosMu = 0;
        private int contadorJuegosLinege = 0;

        private float contadorGananciasDelDiaPC = 0;
        private float contadorGananciasDelDiaCabina = 0;

        //----------------------------CONTADORES/Propiedades-----------------------------------------------
        
        public int ContadorSofwareOffice
        {
            get { return this.contadorSofwareOffice; }
            set { this.contadorSofwareOffice = value; }
        }
        public int ContadorSofwareMessenger
        {
            get { return this.contadorSofwaremessenger; }
            set { this.contadorSofwaremessenger = value; }
        }
        public int ContadorSofwareIcq
        {
            get { return this.contadorSofwareicq; }
            set { this.contadorSofwareicq = value; }
        }
        public int ContadorSofwareAres
        {
            get { return this.contadorSofwareares; }
            set { this.contadorSofwareares = value; }
        }



        public int ContadorPerifericosCamara
        {
            get { return this.contadorPerifericosCamara; }
            set { this.contadorPerifericosCamara = value; }
        }

        public int ContadorPerifericosAuriculares
        {
            get { return this.contadorPerifericosAuriculares; }
            set { this.contadorPerifericosAuriculares = value; }
        }
        public int ContadorPerifericosMicrofono
        {
            get { return this.contadorPerifericosMicrofono; }
            set { this.contadorPerifericosMicrofono = value; }
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
      

        public float TotalLocal
        {
            get { return this.totalLocal; }
            set { this.totalLocal = value; }
        }
        public float TotalLargaDistancia
        {
            get { return this.totalLargaDistancia; }
            set { this.totalLargaDistancia = value; }
        }
        public float TotalInterncaional
        {
            get { return this.totalInterncaional; }
            set { this.totalInterncaional = value; }
        }

        //---------Propiedades------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista de compus disponibles
        /// </summary>
        public List<Computadora>ListaCompusDisponibles
        {
            get { return this.listaCompusDisponibles; }
        }
        /// <summary>
        /// Devuelve la lista de compus ocupadas
        /// </summary>
        public List<Computadora> ListaCompusOcupadas
        {
            get { return this.listaCompusOcupadas; }
            set { this.listaCompusOcupadas = value; }
        }

        /// <summary>
        /// Devuelve la lista de compus finalizadas
        /// </summary>
        public List<Computadora> ListaCompusFinalizadas
        {
            get { return this.listaCompusFinalizadas; }
        }


       

        /// <summary>
        /// Devuelve la lista de cabinas disponibles
        /// </summary>
        public List<Cabina>ListacCabinasDisponibles
        {
            get { return this.listaCabinasDisponibles; }
            set { this.listaCabinasDisponibles = value; }
        }


        /// <summary>
        /// Devuelve la lista de cabinas ocupadas
        /// </summary>
        public List<Cabina>ListaCabinasOcupadas
        {
            get { return this.listaCabinasOcupadas; }
            set { this.listaCabinasOcupadas = value; }
        }



        public List<Cabina> ListaCabinasFinalizadas
        {
            get { return this.listaCabinasFinalizadas; }
            set { this.listaCabinasFinalizadas= value; }
        }

        /// <summary>
        /// Devuelve la cola de clientes
        /// </summary>
        public Queue<Cliente> ColaClientes
        {
            get { return this.colaClientes; }
            set { this.colaClientes = value; }
        }

        /// <summary>
        /// Devuelve la lista de clientes
        /// </summary>
        public List<Cliente>ListaClientes
        {
            get { return this.listaClientes; }
            set { this.listaClientes = value; }
        }

        /// <summary>
        /// devuelve el stock ed bebidas
        /// </summary>
        public Queue<Bebida>StockDeBebidas
        {
            get { return this.stockDeBebidas; }
            set { this.stockDeBebidas = value; }
        }

        /// <summary>
        /// indexador
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public string this[int indice]
        {
            get { return $"{colaClientes.Peek().Nombre}  {ColaClientes.Peek().Apellido}"; }
        }
      

        //--------Contructores--------------------------------------


        /// <summary>
        /// constructro , inicializo las listas
        /// </summary>
        private Local()
        {
            this.listaClientes = new List<Cliente>();
            this.compusCabinas = new List<Maquina>();

            this.listaCompusDisponibles = new List<Computadora>()
            {



            new Computadora("C01",new List<string>(){"office","messenger" },new List<string>(){"camara","auriculares" },new List<string>(){"CounterStrike","DiabloII","MuOnline","LineageII" },new List<string>(){"Procesador :i3\nRam:4gb\nPlaca de video: gts 250" }),
            new Computadora("C02",new List<string>(){"office","messenger","icq" },new List<string>(){"auriculares","microfono" },new List<string>(){"CounterStrike", "MuOnline", "LineageII"},new List<string>(){"Procesador :i5\nRam:4gb\nPlaca de video: gts 650" }),
            new Computadora("C03",new List<string>(){"office","messenger" ,"icq","ares"},new List<string>(){"camara","auriculares","microfono" },new List<string>(){"CounterStrike", "DiabloII", "MuOnline", "LineageII" },new List<string>(){"Procesador :i5\nRam:8gb\nPlaca de video: Radeon 7" }),
            new Computadora("C04",new List<string>(){"icq","ares" },new List<string>(){"camara","auriculares" },new List<string>(){"CounterStrike", "DiabloII"},new List<string>(){"Procesador :i3\nRam:6gb\nPlaca de video: gts 550" }),
            new Computadora("C05",new List<string>(){"messenger","ares"},new List<string>(){"auriculares" },new List<string>(){"CounterStrike", "DiabloII", "MuOnline", "LineageII" },new List<string>(){"Procesador :i7\nRam:12gb\nPlaca de video: gt 710" }),
            new Computadora("C06",new List<string>(){"office", "messenger", "icq", "ares" },new List<string>(){"camara" },new List<string>(){ "MuOnline", "LineageII" },new List<string>(){"Procesador :i3\nRam:4gb\nPlaca de video: Radeon 3" }),
            new Computadora("C07",new List<string>(){"office", "messenger", "icq", "ares" },new List<string>(){"microfono" },new List<string>(){"CounterStrike",   "LineageII"},new List<string>(){"Procesador :i5\nRam:8gb\nPlaca de video: gt 730" }),
            new Computadora("C08",new List<string>(){"office","messenger","ares" },new List<string>(){"auriculares" },new List<string>(){ "DiabloII", "MuOnline", "LineageII" },new List<string>(){"Procesador :i7\nRam:12gb\nPlaca de video: gtx 550" }),
            new Computadora("C09",new List<string>(){"ares" },new List<string>(){"camara","auriculares" },new List<string>(){ "DiabloII", "MuOnline" },new List<string>(){"Procesador :i7\nRam:12gb\nPlaca de video: gtx 550" }),
            new Computadora("C10",new List<string>(){"messenger","icq" },new List<string>(){"camara","auriculares","microfono" },new List<string>(){"CounterStrike", "DiabloII", "MuOnline", "LineageII"},new List<string>(){"Procesador :i5\nRam:6gb\nPlaca de video: gts 450" }),
            new Computadora("C11",new List<string>(){"office","messenger","icq" },new List<string>(){"auriculares","microfono" },new List<string>(){"CounterStrike", "DiabloII", "MuOnline" },new List<string>(){"Procesador :i3\nRam:8gb\nPlaca de video: Radeon 3" }) ,
            new Computadora("C12",new List<string>(){"icq","ares" },new List<string>(){"camara","auriculares" },new List<string>(){"LineageII" },new List<string>(){"Procesador :i5\nRam:6gb\nPlaca de video: gts 350" }),
            new Computadora("C13",new List<string>(){"office", "messenger", "icq", "ares" },new List<string>(){"camara" },new List<string>(){"DiabloII" },new List<string>(){"Procesador :i3\nRam:4gb\nPlaca de video: No tiene" }),
            new Computadora("C14",new List<string>(){"office","messenger","ares" },new List<string>(){"auriculares" },new List<string>(){"CounterStrike", "DiabloII", "MuOnline", "LineageII" },new List<string>(){"Procesador :i3\nRam:4gb\nPlaca de video: gt 150" }),
            new Computadora("C15",new List<string>(){"messenger","icq" },new List<string>(){"camara","auriculares","microfono" },new List<string>(){"DiabloII", "MuOnline"},new List<string>(){"Procesador :i5\nRam:8gb\nPlaca de video: Radeon 7" }),
        };



           

            this.listaCompusOcupadas = new List<Computadora>();
            this.listaCompusFinalizadas = new List<Computadora>();
          
            this.colaClientes = new Queue<Cliente>();


            colaClientes.Enqueue(new Cliente("Lucas", "Heredia", 48657285, 25, new List<string>() { "office", "messenger" }, new List<string>() { "camara", "auriculares" }, new List<string>() { "CounterStrike", "DiabloII", "MuOnline", "LineageII" }));
            colaClientes.Enqueue(new Cliente("Maxi", "Leiva", 47023687, 24, "5401143258073"));
            colaClientes.Enqueue(new Cliente("Emilia", "Gonzales", 437895205, 23, new List<string>() { "messenger" }, new List<string>() { "camara", "auriculares" }, new List<string>() { "CounterStrike", "DiabloII", "MuOnline", "LineageII" }));
            colaClientes.Enqueue(new Cliente("Silvia", "Diaz", 37048521, 22, "8502214367852"));
            colaClientes.Enqueue(new Cliente("Ramiro", "Ayala", 38974102, 21, new List<string>() { "office", "messenger", "icq", "ares" }, new List<string>() { "camara" }, new List<string>() { "DiabloII" }));
            colaClientes.Enqueue(new Cliente("Esteban", "Chaves", 39854740, 20, "5401279463102"));
            colaClientes.Enqueue(new Cliente("Monica", "Maldonado", 40259671, 21, new List<string>() { "ares" }, new List<string>() { "camara", "auriculares" }, new List<string>() { "DiabloII", "MuOnline" }));
            colaClientes.Enqueue(new Cliente("Lucia", "Liso", 34789652, 24, "5402316487520"));
            colaClientes.Enqueue(new Cliente("Carlos", "Rivas", 35789641, 28, new List<string>() { "office", "messenger", "icq", "ares" }, new List<string>() { "camara", "auriculares", "microfono" }, new List<string>() { "CounterStrike", "DiabloII", "MuOnline", "LineageII" }));
            colaClientes.Enqueue(new Cliente("Ester", "Devo", 37850142, 29, "6851236987452"));

            this.listaClientes = new List<Cliente>();

          
            this.listaCabinasDisponibles = new List<Cabina>()
            {
                new Cabina("T01",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T02",Cabina.TipoTelefono.ADisco,"Siemens"),
                new Cabina("T03",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T04",Cabina.TipoTelefono.ADisco,"Siemens"),
                new Cabina("T05",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T06",Cabina.TipoTelefono.ADisco,"Siemens"),
                new Cabina("T07",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T08",Cabina.TipoTelefono.ADisco,"Siemens"),
                new Cabina("T09",Cabina.TipoTelefono.ConTeclado,"Panasonic"),
                new Cabina("T10",Cabina.TipoTelefono.ADisco,"Siemens")
            };


            this.listaCabinasOcupadas = new List<Cabina>();
            this.listaCabinasFinalizadas = new List<Cabina>();

            this.stockDeBebidas = new Queue<Bebida>();
            StockDeBebidas.Enqueue(new Bebida(913254867));
            StockDeBebidas.Enqueue(new Bebida(147852369));
            StockDeBebidas.Enqueue(new Bebida(654789321));
            StockDeBebidas.Enqueue(new Bebida(265384791));
            StockDeBebidas.Enqueue(new Bebida(735198264));
            StockDeBebidas.Enqueue(new Bebida(468257931));
            StockDeBebidas.Enqueue(new Bebida(137985426));
            StockDeBebidas.Enqueue(new Bebida(741963852));
            StockDeBebidas.Enqueue(new Bebida(587423691));
            StockDeBebidas.Enqueue(new Bebida(932741865));
            StockDeBebidas.Enqueue(new Bebida(987412356));




        }
        /// <summary>
        /// estabkle el limite de maquinas en el local
        /// </summary>
        /// <param name="limite"></param>
        public Local(int limite)
        {

        }
        /// <summary>
        /// establece el nombre y limite de maquinas del local
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="limite"></param>
        public Local(string nombre, int limite)
        : this()
        {
            this.nombreDelQueAtiende = nombre;
            this.limite = limite;
        }




        /// <summary>
        /// agrega un amaquina al local, lo suma a disponibles
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Local loc, Maquina c)
        {
            bool retorno = false;
            if (loc != c && loc.limite <= 20)
            {
                loc.compusCabinas.Add(c);
                if (c is Computadora)
                {
                    loc.listaCompusDisponibles.Add((Computadora)c);
                }
                if (c is Cabina)
                { loc.listaCabinasDisponibles.Add((Cabina)c); }

                retorno = true;
            }
            return retorno;
        }

       


        /// <summary>
        /// veo si la ccompu esta en ListaCompusDisponibles
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool VerificarListaCompusDisponibles(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.listaCompusDisponibles)
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

            if (!(Local.VerificarListaCompusDisponibles(l, c)))
            {
                l.listaCompusDisponibles.Add(c);
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
            if(Local.VerificarListaCompusDisponibles(l,c))
            {
                l.listaCompusDisponibles.Remove(c);
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
        public static bool VerificarListaCompusOcupadas(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.listaCompusOcupadas)
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

            if (!(Local.VerificarListaCompusOcupadas(l, c)))
            {
                l.listaCompusOcupadas.Add(c);
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
            if (Local.VerificarListaCompusOcupadas(l, c))
            {
                l.listaCompusOcupadas.Remove(c);
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
        public static bool VerificarListaCompusFinalizadas(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.listaCompusFinalizadas)
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

            if (!(Local.VerificarListaCompusFinalizadas(l, c)))
            {
                l.listaCompusFinalizadas.Add(c);

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
            if (Local.VerificarListaCompusFinalizadas(l, c))
            {
                l.listaCompusFinalizadas.Remove(c);
                retorno = true;
            }

            return retorno;
        }
        
       


        /// <summary>
        /// veo si la cabina esta en ListaCabinasDisponibles
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool VerificarListaCabinasDisponibles(Local l, Cabina c)
        {
            bool retorno = false;

            foreach (Cabina item in l.listaCabinasDisponibles)
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

            if (!(Local.VerificarListaCabinasDisponibles(l, c)))
            {
                l.listaCabinasDisponibles.Add(c);
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
            if (Local.VerificarListaCabinasDisponibles(l, c))
            {
                l.listaCabinasDisponibles.Remove(c);
                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// veo si la cabina esta en ListaCabinasOcupadas
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool VerificarListaCabinasOcupadas(Local l, Cabina c)
        {
            bool retorno = false;

            foreach (Cabina item in l.listaCabinasOcupadas)
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

            if (!(Local.VerificarListaCabinasOcupadas(l, c)))
            {
                l.listaCabinasOcupadas.Add(c);
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
            if (Local.VerificarListaCabinasOcupadas(l, c))
            {
                l.listaCabinasOcupadas.Remove(c);
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
        public static bool VerificarListaCabinasFinalizadas(Local l, Cabina c)
        {
            bool retorno = false;

            foreach (Cabina item in l.listaCabinasFinalizadas)
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

            if (!(Local.VerificarListaCabinasFinalizadas(l, c)))
            {
                l.listaCabinasFinalizadas.Add(c);
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
            if (Local.VerificarListaCabinasFinalizadas(l, c))
            {
                l.listaCabinasFinalizadas.Remove(c);
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// veo si la cliente esta en ListaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool VerificarListaClientes(Local l, Cliente c)
        {
            bool retorno = false;

            foreach (Cliente item in l.listaClientes)
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

            if (!(Local.VerificarListaClientes(l, c)))
            {
                l.listaClientes.Add(c);
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
            if (Local.VerificarListaClientes(l, c))
            {
                l.listaClientes.Remove(c);
                retorno = true;
            }

            return retorno;
        }
        
       

        /// <summary>
        /// veo si cliente esta en ColaClientes
        /// </summary>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool VerificarColaClientes(Local l, Cliente c)
        {
            bool retorno = false;

            foreach (Cliente item in l.colaClientes)
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

            if (!(Local.VerificarColaClientes(l, c)))
            {
                l.colaClientes.Enqueue(c);
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
            l.ColaClientes.Dequeue();
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

            if(Local.VerificarListaCompusDisponibles(l,c))
            {
                Local.EliminarCompuEnListaCompusDisponibles(l, c);
                Local.GuardarCompuEnListaCompusOcupadas(l, c);


                c.TiempoInicial = DateTime.Now;
                c.Stopwacth.Start();

                if(c.Peticiones.ListaSofware.Contains("office")) { l.ContadorSofwareOffice += 1; }
                if (c.Peticiones.ListaSofware.Contains("messenger")) { l.ContadorSofwareMessenger += 1; }
                if (c.Peticiones.ListaSofware.Contains("icq")) { l.ContadorSofwareIcq += 1; }
                if (c.Peticiones.ListaSofware.Contains("ares")) { l.ContadorSofwareAres += 1; }

                


                if(c.Peticiones.ListaPerifericos.Contains("camara")) { l.ContadorPerifericosCamara += 1; }
                if (c.Peticiones.ListaPerifericos.Contains("auriculares")) { l.ContadorPerifericosAuriculares += 1; }
                if (c.Peticiones.ListaPerifericos.Contains("microfono")) { l.ContadorPerifericosMicrofono += 1; }

            

                if(c.Peticiones.ListaJuegos.Contains("CounterStrike")) { l.ContadorJuegosCS += 1; }
                if (c.Peticiones.ListaJuegos.Contains("DiabloII")) { l.ContadorJuegosDiablo += 1; }
                if (c.Peticiones.ListaJuegos.Contains("MuOnline")) { l.ContadorJuegosMu += 1; }
                if (c.Peticiones.ListaJuegos.Contains("LineageII")) { l.ContadorJuegosLinege += 1; }

             



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
            if(Local.VerificarListaCabinasDisponibles(l,c))
            {
                Local.EliminarCabinaEnListaCabinasDisponibles(l, c);
                Local.GuardarCabinaEnListaCabinasOcupadas(l, c);
                c.TiempoInicial = DateTime.Now;
                c.Stopwacth.Start();

            }

            return retorno;

        }


       

        /// <summary>
        /// finaliza la compu y le asigna un tiempo final para calcular el costo
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool FinalizarTarea(Local l, Computadora c)
        {
            bool retorno = false;

            if(VerificarListaCompusOcupadas(l,c))
            {
                Local.EliminarCompuEnListaCompusOcupadas(l, c);           
                Local.GuardarCompuEnListaCompusDisponibles(l, c);
                Local.GuardarCompuEnListaCompusFinalizadas(l, c);
               
                c.ListaBebidas.Clear();
                c.TiempoFinal = DateTime.Now;
                c.Stopwacth.Stop();
                l.ContadorGananciasDelDiaPC += c.CalcularCostoCompuBebida();

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
        public static bool FinalizarTarea(Local l, Cabina c)
        {
            bool retorno = false;

            if (VerificarListaCabinasOcupadas(l, c))
            {
                Local.EliminarCabinaEnListaCabinasOcupadas(l, c);
                Local.GuardarCabinaEnListaCabinasDisponibles(l, c);
                Local.GuardarCabinaEnListaCabinasFinalizadas(l, c);

                c.ListaBebidas.Clear();
                c.TiempoFinal = DateTime.Now;
                c.Stopwacth.Stop();
                l.ContadorGananciasDelDiaCabina += c.CalcularCostoCabinaBebida();
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

            int[] sofware = { ContadorSofwareOffice, ContadorSofwareMessenger, ContadorSofwareIcq, ContadorSofwareAres };
            int[] Perisfericos = { ContadorPerifericosCamara, ContadorPerifericosAuriculares, ContadorPerifericosMicrofono };
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
           

            IEnumerable<Computadora> ListaPCOrdenadas = this.listaCompusFinalizadas.OrderByDescending(user => user.TiempoTotalDeUso);
            StringBuilder sb = new StringBuilder();
            foreach (Computadora item in ListaPCOrdenadas)
            {
                sb.Append($"{item.MostrarRecaudacion()} ");
                sb.AppendLine($"Tiempo de uso: {item.TiempoTotalDeUso}");
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
           

            IEnumerable<Cabina> ListaCabinasOrdenadas = this.listaCabinasFinalizadas.OrderByDescending(user => user.TiempoTotalDeUso);
            StringBuilder sb = new StringBuilder();
            foreach (Cabina item in ListaCabinasOrdenadas)
            {
                sb.Append(item.MostrarRecaudacion());
                sb.AppendLine($"Tiempo de uso: {item.TiempoTotalDeUso}");
                sb.AppendLine();
            }
            return sb.ToString();
        }


        /// <summary>
        /// ordena las computadora segun su recaudacion.
        /// https://www.youtube.com/watch?v=cZNcJ3enNmU
        /// </summary>
        public string ListaComputadorasOrdenadasPorRecaudacionsTotal(Local loc)
        {


            IEnumerable<Computadora> ListaCompusOrdenadas = this.ListaCompusFinalizadas.OrderByDescending(user => user.Recaudacion);
            StringBuilder sb = new StringBuilder();

            foreach (Computadora item in ListaCompusOrdenadas)
            {
                sb.Append(item.MostrarRecaudacion());
                sb.AppendLine();
            }
            return sb.ToString();
        }



        /// <summary>
        /// ordena las cabina segun su recaudacion.
        /// https://www.youtube.com/watch?v=cZNcJ3enNmU
        /// </summary>
        public string ListaCabinasOrdenadasPorRecaudacionsTotal(Local loc)
        {


            IEnumerable<Cabina> ListaCabinasFinalizadas = this.ListaCabinasFinalizadas.OrderByDescending(user => user.Recaudacion);
            StringBuilder sb = new StringBuilder();

            foreach (Cabina item in ListaCabinasFinalizadas)
            {
                sb.Append(item.MostrarRecaudacion());
                sb.AppendLine();
            }
            return sb.ToString();
        }



        public string HorasGananciasPorLlamada()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tiempo total de llamadas: {TiempoTotalCabinas()}");

            sb.AppendLine($"Ganancias de llamadas locales: {this.totalLocal}");
            sb.AppendLine($"Ganancias de llamadas larga distancia: {this.totalLargaDistancia}");
            sb.AppendLine($"Ganancias de llamadas Internacionales: {this.totalInterncaional}");

            return sb.ToString();
        }



        /// <summary>
        /// muestra el tiempo de uso d elas cabianas en la lista cabinas finalizadas
        /// </summary>
        /// <returns></returns>
        public double TiempoTotalCabinas()
        {
            double acum = 0;
            foreach (Cabina item in this.listaCabinasFinalizadas)
            {
                acum += item.TiempoTotalDeUso;
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
            sb.AppendLine($"{string.Format("{0:0.00}", this.contadorGananciasDelDiaPC * iva)}");
            sb.AppendLine();
            sb.AppendLine("Ganancias de Cabinas: ");
            sb.AppendLine($"{string.Format("{0:0.00}", this.ContadorGananciasDelDiaCabina* iva)}");
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
            foreach (Computadora item in this.listaCompusDisponibles)
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
            foreach (Computadora item in this.listaCompusOcupadas)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra las cabinas disponibles
        /// </summary>
        /// <returns></returns>

        public string MostrarCabinasDisponibles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del que atiende: {this.nombreDelQueAtiende}");
            sb.AppendLine("Maquinas: ");
            foreach (Cabina item in this.listaCabinasDisponibles)
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
            foreach (Cabina item in this.listaCabinasOcupadas)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }


        /// <summary>
        /// muestra los clientes disponibles
        /// </summary>
        /// <returns></returns>
        public string MostrarClientesDisponiblesLista()
        {
            StringBuilder sb = new StringBuilder();
          
            foreach (Cliente item in this.listaClientes)
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

            foreach (Cliente item in this.colaClientes)
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
            foreach (Maquina item in this.compusCabinas)
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




        /// <summary>
        /// muestra si la maquina esta en el local
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Local loc, Maquina c)
        {
            bool retorno = false;
            if (loc is not null && c is not null)
            {
                foreach (Maquina item in loc.compusCabinas)
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
        public static bool operator !=(Local loc, Maquina c)
        {
            return !(loc == c);
        }


        /// <summary>
        /// Sobrecarga del toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarCompusYCabinasDelLocal();
        }

        /// <summary>
        /// Sobrecarga equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Local otroLocal = obj as Local;
            return otroLocal is not null && this == otroLocal;
        }

        public override int GetHashCode()
        {
            return (nombreDelQueAtiende,limite).GetHashCode();
        }

    }
}
