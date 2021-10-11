using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases_especializadas;
using Entidades.Clases_generales;

namespace Formulario
{
    public partial class FormBuscarCompuCompatible : Form
    {
        Local local = new Local(20);
        List<Computadora> listaUnica = new List<Computadora>();
        bool listaVacia;
       


        /// <summary>
        /// devuelve una lista de compus que sean iguales a las peticiones del cliente
        /// </summary>
        public List<Computadora> ListaUnica
        {
            get { return this.listaUnica; }
        }



        /// <summary>
        /// Constructor que recibe el local y una computadora
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        public FormBuscarCompuCompatible( Local l,Computadora c)
        {
            InitializeComponent();
            this.local = l;
            rtbPeticiones.ReadOnly = true;
            if (GuardarListaUnica(l, c)) { listaVacia = true; } else { listaVacia = false; }

            if (listaVacia == false)
            {
                if (MessageBox.Show($"No hay pc con esos requisitos , desea asigar igualmente una pc? \nElija una desde las pc disponibles...\n(SI , elige pc)\n(NO, elimina el cliente de la cola)", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lsbListaDeCompusCompatibles.DataSource = null;
                    lsbListaDeCompusCompatibles.DataSource = local.Lista_CompusDisponibles;
                }
                else
                {
                    Cliente cli = local.Cola_Clientes.Peek();
                    if (Local.EliminarClienteEnColaClientes(local)) { }
                    if (Local.EliminarClienteEnListaClientes(local, cli)) { }
                }
            }
            else
            {             
                lsbListaDeCompusCompatibles.DataSource = ListaUnica;
                rtbPeticiones.Text = $"{local.Cola_Clientes.Peek()}\n Peticiones: \n {c.Peticiones.ToString()}";
            }           
        }


        /// <summary>
        /// Asigna la compu al cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (listaVacia == false)
            {
                if (btnAsignar.Text == "Cerrar")
                {
                    this.Close();
                }
                else
                {
                    Asignar();
                }
            }
            else
            {
                if (btnAsignar.Text == "Cerrar")
                {
                    this.Close();
                }
                else
                {
                    Asignar();
                }
                
            }
        }



        /// <summary>
        /// para que se vea solo las pc que tienen las petisiones de lo que viene del otro formLocal
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool GuardarListaUnica(Local l, Computadora c)
        {
            bool retorno = false;

            foreach (Computadora item in l.Lista_CompusDisponibles)
            {
                if (item.Peticiones == c.Peticiones)
                {
                    this.ListaUnica.Add(item);
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// elimina la compu de la lista
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool EliminarDeListaUnica(Computadora c)
        {
            bool retorno = false;

            this.ListaUnica.Remove(c);
            retorno = true;
            return retorno;
        }

        /// <summary>
        /// al hace rdoble clic , muestra la info de la compu en un nuevo form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbListaDeCompusCompatibles_MouseDoubleClick(object sender, MouseEventArgs e)
        {          
            Computadora c;
            c = (Computadora)lsbListaDeCompusCompatibles.SelectedItem;
            if (lsbListaDeCompusCompatibles.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormMostrarCompu muestraCompu = new FormMostrarCompu(c);
                muestraCompu.ShowDialog();
            }         
        }

        /// <summary>
        /// usado para achicar codigo, indexador aca
        /// </summary>
        private void Asignar()
        {
            Cliente cli = local.Cola_Clientes.Peek();

            Computadora c = (Computadora)lsbListaDeCompusCompatibles.SelectedItem;
            //Computadora auxCli = new Computadora (c.Identificador,cli.Peticiones.Lista_Sofware,cli.Peticiones.Lista_Perifericos,cli.Peticiones.Lista_Juegos);
            //auxCli.Stopwacth = c.Stopwacth;
            ////auxCli.Recaudacion += c.Recaudacion;
            ////auxCli.CocasTotales += c.CocasTotales;

            if (MessageBox.Show($"¿Seguro de querer asignar la computadora a\n  { local[0]} ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Local.EliminarClienteEnColaClientes(local)) { }
                if (Local.EliminarClienteEnListaClientes(local, cli)) { }
                
                if (Local.AsignarCompuAlCliente(local, c)) { }
                if (EliminarDeListaUnica(c)) { }
                MessageBox.Show("Asignado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                btnAsignar.Text = "Cerrar";
                
            }

            lsbListaDeCompusCompatibles.DataSource = null;
            lsbListaDeCompusCompatibles.DataSource = ListaUnica;
            rtbPeticiones.Text = null;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pueden presentarce dos situaciones: \n\n1° si hay computadoras que cumplen con los requisitos del cliente, se mostrara una lista que contengan dichas pc, elegir alguna y asignarla al cliente\n\n2° Si no hay computadoras con los requisitos pedidos del cliente , se mostrara la lista de las pc disponibles , se le preguntara al ususario si quiere asignarce igualmente una maquina , si la respuesta es si, se le asigna una maquina, si la respuesta es no, se elimina al cliente de la lista");

        }

        private void FormBuscarCompuCompatible_Load(object sender, EventArgs e)
        {

        }
    }
}
