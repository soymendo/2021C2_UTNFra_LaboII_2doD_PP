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
        Computadora compuADevolver = new Computadora();

        bool listaVacia;
       



        public List<Computadora> ListaUnica
        {
            get { return this.listaUnica; }
        }




        public FormBuscarCompuCompatible( Local l,Computadora c)
        {
            InitializeComponent();
            this.local = l;
            // richTextBox1.Text = (local.MostrarCompusDisponiblesParaElClienteSegunsSusPetisiones(c));
            //lsbListaDeCompusCompatibles.DataSource = null;

            if (GuardarListaUnica(l, c)) { listaVacia = true; } else { listaVacia = false; }



            //else
            //{ 
            //    MessageBox.Show("Sin coincidencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            //}// es por aca



            // lsbListaDeCompusCompatibles.DataSource = local.Lista_CompusDisponiblesParaElClienteSegunsSusPetisiones;
            //l.Lista_CompusOcupadas = local.Lista_CompusOcupadas;
            lsbListaDeCompusCompatibles.DataSource = ListaUnica;

          
            rtbPeticiones.Text = $"{local.Cola_Clientes.Peek()}\n Peticiones: \n {c.PetisionesDePc}";
        }


        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(listaVacia==false)
            {
                MessageBox.Show("SLsita vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Cliente cli = local.Cola_Clientes.Peek();
                Computadora c = (Computadora)lsbListaDeCompusCompatibles.SelectedItem;


                if (MessageBox.Show($"¿Seguro de querer asignar la computadora a  { local.Cola_Clientes.Peek() } ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Local.EliminarClienteEnColaClientes(local)) { }
                    if (Local.EliminarClienteEnListaClientes(local, cli)) { }//elimino el cliente de la lista igual al de la cola


                    if (Local.AsignarCompuAlCliente(local, c)) { }
                    if (EliminarDeListaUnica(c)) { }
                    MessageBox.Show("Asignado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAsignar.Enabled = false;


                }


                lsbListaDeCompusCompatibles.DataSource = null;
                lsbListaDeCompusCompatibles.DataSource = ListaUnica;
                rtbPeticiones.Text = null;


                //richTextBox1.Text = local.MostrarCompusDisponiblesParaElClienteSegunsSusPetisiones(c);
                //richTextBox1.Text = local.MostrarCompusDisponibles();
                //richTextBox1.Text = local.MostrarCompusOcupadas();
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
                if (item.PetisionesDePc == c.PetisionesDePc)
                {
                    this.ListaUnica.Add(item);
                    retorno = true;
                }
            }
            return retorno;
        }

        public bool EliminarDeListaUnica(Computadora c)
        {
            bool retorno = false;

            this.ListaUnica.Remove(c);
            retorno = true;
            return retorno;
        }

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
    }
}
