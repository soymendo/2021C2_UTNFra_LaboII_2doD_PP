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

            rtbInfoMaquinas.ReadOnly = true;

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
            int cocaAux;
            if (lsbCompusOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de compus ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Computadora comp = (Computadora)lsbCompusOcupadas.SelectedItem;
                cocaAux=comp.CantidadDeCocasEnLista;
                if (Local.FinalizarTareaCompu(local, comp))
                {
                    comp.CantidadDeCocasEnLista = cocaAux;
                    MessageBox.Show($"Finalizado con exito!! tiempo de uso: {comp.TiempoDeUso} Costo de Consumo (pc+bebidas): {comp.CalcularCostoCompuBebida()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comp.CantidadDeCocasEnLista = cocaAux;
                    comp.Recaudacion += comp.CalcularCostoCompuBebida();
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
            int cocaAux;

            if (lsbCasbinasOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista  de cabinas ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cabina cab = (Cabina)lsbCasbinasOcupadas.SelectedItem;
                cocaAux = cab.CantidadDeCocasEnLista;
                if (Local.FinalizarTareaCabina(local, cab))
                {
                    cab.CantidadDeCocasEnLista = cocaAux;
                    MessageBox.Show($"Finalizado con exito!!\nTiempo de uso: {cab.TiempoDeUso}\nDestino: {cab.Destino()}\nCosto de Consumo (cabina+bebidas): { cab.CalcularCostoCabinaBebida()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cab.CantidadDeCocasEnLista = cocaAux;
                    cab.recaudacion += cab.CalcularCostoCabinaBebida();

                    if(cab.Destino()==TipoLlamada.local.ToString())
                    {
                        local.totalLocal += cab.CalcularCosto();
                    }
                    if(cab.Destino()==TipoLlamada.largaDistancia.ToString())
                    {
                        local.totalLargaDistancia += cab.CalcularCosto();
                    }
                    if(cab.Destino()==TipoLlamada.internacional.ToString())
                    {
                        local.totalInterncaional += cab.CalcularCosto();
                    }
                   
                }
                else
                {
                    MessageBox.Show($"No funca!! tiempo de uso: {cab.TiempoDeUso} Costo de uso: {cab.CalcularCostoCabinaBebida()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de compus ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de cabinas ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {      
                Cabina cab = (Cabina)lsbCasbinasOcupadas.SelectedItem;
                cab.TiempoFinal = DateTime.Now;
                MessageBox.Show($" tiempo de uso: {cab.TiempoDeUso} destino: {cab.Destino()} ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnAgregarCoca_Click(object sender, EventArgs e)
        {
            if (lsbCompusOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de compus ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Computadora comp = (Computadora)lsbCompusOcupadas.SelectedItem;
              

                if (MessageBox.Show($"Agregar bebida? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(local.Stock_DeBebidas.Count == 0)
                    {
                        MessageBox.Show($" no hay stock ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        comp.AgregarBebida(local.Stock_DeBebidas.Dequeue());// agrego la primera bebida del stock a la lista de bebidas de la computadora y se elimina del stock
                        MessageBox.Show($" Bebida agregada ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }                
                }


            }
        }


        private void btnAgregarBebidaCabina_Click(object sender, EventArgs e)
        {
            if (lsbCasbinasOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de cabinas ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                Cabina cab = (Cabina)lsbCasbinasOcupadas.SelectedItem;

                if (MessageBox.Show($"Agregar bebida? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (local.Stock_DeBebidas.Count == 0)
                    {
                        MessageBox.Show($" no hay stock ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cab.AgregarBebida(local.Stock_DeBebidas.Dequeue());// agrego la primera bebida del stock a la lista de bebidas de la computadora y se elimina del stock
                        MessageBox.Show($" Bebida agregada ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


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
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (lsbCompusDisponibles.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de compus disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbInfoMaquinas.Text = c.Mostrar();
            }
           
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

            if (lsbCompusOcupadas.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de compus ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbInfoMaquinas.Text = c.Mostrar();
            }
            
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

            if (lsbCabinasDisponibles.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de cabinas disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbInfoMaquinas.Text = c.Mostrar();
            }
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

            if (lsbCasbinasOcupadas.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista de cabinas ocupadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbInfoMaquinas.Text = c.Mostrar();
            }
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

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ayuda());          
        }



        /// <summary>
        /// devuelve un string con los datos necesarios para el funcionamientop del local.
        /// </summary>
        /// <returns></returns>
        public string Ayuda()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1° Asigne los datos del cliente (nombre,apellido,edad,dni) dependiendo lo que quiera usar, marque computadora o cabina, se habilitara las opciones correspondiente a las necesidades del cliente.Una vez cargado todos los datos, oprima el boto 'OK'");
            sb.AppendLine();    
            sb.AppendLine("2° El boton 'Asignar' le asignara una maquina al cliente , dichos clientes se pueden observar en la 'lista de clientes'");
            sb.AppendLine();
            sb.AppendLine("3° Se podran observar las maquinas en sus respectivas listas tanto disponibles como ocupadas, el boton 'FinalizarTarea' terminará con la tarea que esté realizando la maquina y proporcionará datos de tiempos y costos correspondientes ");
            sb.AppendLine();
            sb.AppendLine("4° Al hacer doble clic en cualquiera de las listas se le brindará los datos correspondientes de dicha maquina y se vera reflejado en el formulario");
            return sb.ToString();
        }


        /// <summary>
        /// entrada unicamente de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// entrada unicamente de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// entrada unicamente de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// entrada unicamente de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// entrada unicamente de numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
