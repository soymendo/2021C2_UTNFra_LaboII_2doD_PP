using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases_especializadas;
using Entidades.Clases_generales;




namespace Formulario
{
    public partial class FormLocal : Form
    {
        Local local = new Local(20);
        Computadora compAux;
        Cabina cabinaAux;

        string numeroDeTelefono;
        string area;
        string localTelefono;
        string numeroTelefono;

        

       
        /// <summary>
        /// Constructor qu erecibe un local
        /// </summary>
        /// <param name="loc"></param>
        public FormLocal(Local loc)
        {
            InitializeComponent();

            this.local = loc;
            cmbSofware.DataSource = Enum.GetValues(typeof(Petisiones.SoftwareInstalado));
            cmbPerisfericos.DataSource = Enum.GetValues(typeof(Petisiones.PeriféricosDisponibles));
            cmbJuego.DataSource = Enum.GetValues(typeof(Petisiones.JuegosDisponibles));

         
            lsbCompusDisponibles.DataSource = local.Lista_CompusDisponibles;
            lsbCabinasDisponibles.DataSource = local.Lista_cabinas_disponibles;

            lsbCompusOcupadas.DataSource = local.Lista_CompusOcupadas;
            lsbCasbinasOcupadas.DataSource = local.Lista_cabinas_ocupadas;

            lsbListaClientes.DataSource = null;
            lsbListaClientes.DataSource = local.Lista_Clientes;
         
            txtArea.Enabled = false;
            txtLocal.Enabled = false;
            txtNumero.Enabled = false;
            cmbSofware.Enabled = false;
            cmbPerisfericos.Enabled = false;
            cmbJuego.Enabled = false;
        }


        /// <summary>
        /// control radiobutton computadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtComputadora_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtComputadora.Checked)
            {
                txtArea.Enabled = false;
                txtLocal.Enabled = false;
                txtNumero.Enabled = false;


                cmbSofware.Enabled = true;
                cmbPerisfericos.Enabled = true;
                cmbJuego.Enabled = true;
               
            }
        }

        /// <summary>
        /// control radiobutton cabina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtCabina_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtCabina.Checked)
            {
                txtArea.Enabled = true;
                txtLocal.Enabled = true;
                txtNumero.Enabled = true;

                
                cmbSofware.Enabled = false;
                cmbPerisfericos.Enabled = false;
                cmbJuego.Enabled = false;
            }
        }


        /// <summary>
        /// Boton que crea un cliente y lo asigna a una cola y a un listbox visible en el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if(rbtComputadora.Checked==false && rbtCabina.Checked==false)
            {
                MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtComputadora.Checked)
                {
                    Cliente clienteCompu = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text), (Entidades.Clases_generales.Petisiones.SoftwareInstalado)cmbSofware.SelectedItem, (Entidades.Clases_generales.Petisiones.PeriféricosDisponibles)cmbPerisfericos.SelectedItem, (Entidades.Clases_generales.Petisiones.JuegosDisponibles)cmbJuego.SelectedItem);

                    if (Local.GuardarClienteEnListaClientes(local, clienteCompu))
                    {
                        MessageBox.Show("Agregado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("La persona ya esta registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (Local.GuardarClienteEnColaClientes(local, clienteCompu)) { }
                            
                    lsbListaClientes.DataSource = null;
                    lsbListaClientes.DataSource = local.Lista_Clientes;
                }

                if( rbtCabina.Checked)
                {
                    this.numeroDeTelefono = string.Concat(txtArea.Text,txtLocal.Text,txtNumero.Text);
                    this.area = txtArea.Text;
                    this.localTelefono = txtLocal.Text;
                    this.numeroTelefono = txtNumero.Text;

                    if(this.area!="" && this.localTelefono!=""&& this.numeroTelefono!="")
                    {
                       
                            Cliente clienteCabina = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text), this.numeroDeTelefono);

                            if (Local.GuardarClienteEnListaClientes(local, clienteCabina)) { MessageBox.Show("Agregado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                            if (Local.GuardarClienteEnColaClientes(local, clienteCabina)) { }

                            lsbListaClientes.DataSource = null;
                            lsbListaClientes.DataSource = local.Lista_Clientes;
          
                    }
                    else
                    {
                        MessageBox.Show("Numero incorrecto!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                  
                }
            }
        }

        
      
       

        /// <summary>
        /// boton que asigna la maquina segun su instancia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (local.Cola_Clientes.Count == 0)
            {
                MessageBox.Show("Lista vacia de clientes, debe agregar clientes primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cliente = local.Cola_Clientes.Peek();

                if (cliente.PetisionesDePc is null)
                {
                    cabinaAux = new Cabina(cliente.NumeroAMarcar);

                    FormBuscarCabina buscaCabina = new FormBuscarCabina(local, cabinaAux);
                    buscaCabina.ShowDialog();
                }
                else
                {
                    compAux = new Computadora(cliente.PetisionesDePc.Sofware, cliente.PetisionesDePc.Periféricos, cliente.PetisionesDePc.Juegos);
                    FormBuscarCompuCompatible buscaCompu = new FormBuscarCompuCompatible(local, compAux);
                    buscaCompu.ShowDialog();
                }

                lsbCompusDisponibles.DataSource = null;
                lsbCompusDisponibles.DataSource = local.Lista_CompusDisponibles;

                lsbCompusOcupadas.DataSource = null;
                lsbCompusOcupadas.DataSource = local.Lista_CompusOcupadas;


                lsbCabinasDisponibles.DataSource = null;
                lsbCabinasDisponibles.DataSource = local.Lista_cabinas_disponibles;


                lsbCasbinasOcupadas.DataSource = null;
                lsbCasbinasOcupadas.DataSource = local.Lista_cabinas_ocupadas;


                lsbListaClientes.DataSource = null;
                lsbListaClientes.DataSource = local.Lista_Clientes;

            }
        }


        /// <summary>
        /// boton que finaliza una compu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarTarea_Click(object sender, EventArgs e)
        {
            if (lsbCompusOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Computadora comp = (Computadora)lsbCompusOcupadas.SelectedItem;

                if (Local.FinalizarTareaCompu(local, comp))
                {
                    MessageBox.Show($"Finalizado con exito!! tiempo de uso: {comp.TiempoDeUso} Costo de uso: {comp.CalcularCosto()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lsbCompusDisponibles.DataSource = null;
                lsbCompusDisponibles.DataSource = local.Lista_CompusDisponibles;

                lsbCompusOcupadas.DataSource = null;
                lsbCompusOcupadas.DataSource = local.Lista_CompusOcupadas;
            }            
        }


        /// <summary>
        /// finaliza la tarea de la cabina seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarTareaCabina_Click(object sender, EventArgs e)
        {
            if (lsbCasbinasOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cabina cab = (Cabina)lsbCasbinasOcupadas.SelectedItem;

                if (Local.FinalizarTareaCabina(local, cab))
                {
                    MessageBox.Show($"Finalizado con exito!! tiempo de uso: {cab.TiempoDeUso} Costo de uso: {cab.CalcularCosto()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No funca!! tiempo de uso: {cab.TiempoDeUso} Costo de uso: {cab.CalcularCosto()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lsbCabinasDisponibles.DataSource = null;
                lsbCabinasDisponibles.DataSource = local.Lista_cabinas_disponibles;

                lsbCasbinasOcupadas.DataSource = null;
                lsbCasbinasOcupadas.DataSource = local.Lista_cabinas_ocupadas;

            }               
        }




        /// <summary>
        /// boton que muestra el tiempo actual de uso de la compu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tiempoActualDeUso_Click(object sender, EventArgs e)
        {
            if (lsbCompusOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Computadora comp = (Computadora)lsbCompusOcupadas.SelectedItem;

                comp.TiempoFinal = DateTime.Now;
                MessageBox.Show($" tiempo de uso: {comp.TiempoDeUso/*TiempoActualDeUso*/} ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        /// <summary>
        /// boton que mestra el tiempo actual de uso de la cabina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTiempoActualDeUsoCabina_Click(object sender, EventArgs e)
        {
            if (lsbCasbinasOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {      
                Cabina cab = (Cabina)lsbCasbinasOcupadas.SelectedItem;
                cab.TiempoFinal = DateTime.Now;
                MessageBox.Show($" tiempo de uso: {cab.TiempoDeUso} destino: {cab.Destino()} ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// al hacer doble clic  muestra la info del cliente en un form nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbListaClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cliente c;
            c = (Cliente)lsbListaClientes.SelectedItem;

            if (lsbListaClientes.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormVistaDePetisiones vista = new FormVistaDePetisiones(c);
                vista.ShowDialog();
            }
        }




        /// <summary>
        /// al hacer doble clic  muestra la info de la computadora en el richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbCompusDisponibles_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Computadora c;
            c = (Computadora)lsbCompusDisponibles.SelectedItem;

            rtbInfoMaquinas.Text = c.Mostrar();
        }


        /// <summary>
        /// al hacer doble clic  muestra la info de la computadora en el richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbCompusOcupadas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Computadora c;
            c = (Computadora)lsbCompusOcupadas.SelectedItem;

            rtbInfoMaquinas.Text = c.Mostrar();
        }

        /// <summary>
        /// al hacer doble clic  muestra la info de la cabina en el richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbCabinasDisponibles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cabina c;
            c = (Cabina)lsbCabinasDisponibles.SelectedItem;

            rtbInfoMaquinas.Text = c.Mostrar();
        }


        /// <summary>
        /// al hacer doble clic  muestra la info de la cabina en el richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbCsbinasOcupadas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cabina c;
            c = (Cabina)lsbCasbinasOcupadas.SelectedItem;

            rtbInfoMaquinas.Text = c.Mostrar();
        }



        /// <summary>
        /// bloque de combobox sofware
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSofware_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// bloque de combobox perisfericos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPerisfericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// bloque de combobox juegos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
