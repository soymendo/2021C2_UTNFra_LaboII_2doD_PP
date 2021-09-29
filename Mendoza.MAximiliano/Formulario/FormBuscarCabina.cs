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
    public partial class FormBuscarCabina : Form
    {
        Local local = new Local(20);
        string numero;


        /// <summary>
        /// Constructor que recibe el local y una cabina
        /// </summary>
        /// <param name="l"></param>
        /// <param name="cabinaDelOtroForm"></param>
        public FormBuscarCabina(Local l, Cabina cabinaDelOtroForm)
        {
            InitializeComponent();
            this.local = l;
            this.lsbCabinasDisponibles.DataSource = local.Lista_cabinas_disponibles;
            this.numero = cabinaDelOtroForm.NumeroAMarcar;           
        }


        /// <summary>
        /// Asigna la cabina a la lista disponible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Cliente cli = local.Cola_Clientes.Peek();
            Cabina c = (Cabina)lsbCabinasDisponibles.SelectedItem;
            c.NumeroAMarcar = numero;

            if (MessageBox.Show($"¿Seguro de querer asignar la cabina  a  { local.Cola_Clientes.Peek() } ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Local.EliminarClienteEnColaClientes(local)) { }
                if (Local.EliminarClienteEnListaClientes(local, cli)) { }
                if (Local.AsignarCabinaAlCliente(local, c)) { }
                MessageBox.Show("Asignado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAsignar.Enabled = false;
            }
          
            lsbCabinasDisponibles.DataSource = null;
            lsbCabinasDisponibles.DataSource = local.Lista_cabinas_disponibles;           
        }
    }
}
