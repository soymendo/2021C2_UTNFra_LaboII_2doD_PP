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
        Computadora compuDePeticiones;
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


            

            lsbCompusDisponibles.DataSource = local.ListaCompusDisponibles;
            lsbCabinasDisponibles.DataSource = local.ListacCabinasDisponibles;

            lsbCompusOcupadas.DataSource = local.ListaCompusOcupadas;
            lsbCasbinasOcupadas.DataSource = local.ListaCabinasOcupadas;

            lsbListaClientes.DataSource = null;
            local.ListaClientes = local.ColaClientes.ToList<Cliente>();
            lsbListaClientes.DataSource = local.ListaClientes;



            rtbInfoMaquinas.ReadOnly = true;

            txtArea.Enabled = false;
            txtLocal.Enabled = false;
            txtNumero.Enabled = false;
          

            btnPeticiones.Enabled = false;
            
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

                nupTiempo.Enabled = true;
                rbtLibre.Enabled = true;

                btnPeticiones.Enabled = true;
               
                btnPeticiones.BackColor = Color.GreenYellow;
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
                btnPeticiones.Enabled = false;
                btnPeticiones.BackColor = Color.OrangeRed;
            }
        }
        /// <summary>
        /// formulario peticiones, agarro la compu creada con las peticiones ya cargadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeticiones_Click(object sender, EventArgs e)
        {
            
            FormPeticiones fPeti = new FormPeticiones();
            fPeti.ShowDialog();
            this.compuDePeticiones = fPeti.compuAfura;
        }


        /// <summary>
        /// Boton que crea un cliente y lo asigna a una cola y a un listbox visible en el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
 
            if ((rbtComputadora.Checked == false && rbtCabina.Checked == false) || txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtEdad.Text == "")
            {
                MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtComputadora.Checked  && this.compuDePeticiones is not null)
                {
                  

                    Cliente clienteCompu = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text),compuDePeticiones.Peticiones.ListaSofware,compuDePeticiones.Peticiones.ListaPerifericos,compuDePeticiones.Peticiones.ListaJuegos);
                  
                    if(nupTiempo.Enabled is true)
                    {
                        clienteCompu.TiempoAsignado = nupTiempo.Value.ToString();
                    }
                    if(rbtLibre.Enabled is true)
                    {
                        clienteCompu.TiempoAsignado = "Libre";
                    }
                   

                    if (Local.GuardarClienteEnListaClientes(local, clienteCompu))
                    {
                        MessageBox.Show("Agregado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La persona ya esta registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                    if (Local.GuardarClienteEnColaClientes(local, clienteCompu)) { }

                    lsbListaClientes.DataSource = null;
                    lsbListaClientes.DataSource = local.ListaClientes;
                   
                }
                else if (rbtComputadora.Checked && this.compuDePeticiones is null)
                {
                    MessageBox.Show("Falta cargar petisiones", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

                    if ( rbtCabina.Checked)
                {
                    this.numeroDeTelefono = string.Concat(txtArea.Text,txtLocal.Text,txtNumero.Text);
                    this.area = txtArea.Text;
                    this.localTelefono = txtLocal.Text;
                    this.numeroTelefono = txtNumero.Text;

                    if(this.area!="" && this.localTelefono!=""&& this.numeroTelefono!="")
                    {
                       
                            Cliente clienteCabina = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text), this.numeroDeTelefono);

                        if (Local.GuardarClienteEnColaClientes(local, clienteCabina)) 
                        {

                        }
                        else
                        {
                            MessageBox.Show("Ya esta agregado!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (Local.GuardarClienteEnListaClientes(local, clienteCabina)) { MessageBox.Show("Agregado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                          

                            lsbListaClientes.DataSource = null;
                            lsbListaClientes.DataSource = local.ListaClientes;
          
                    }
                    else
                    {
                        MessageBox.Show("Numero incorrecto!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                  
                }

                nupTiempo.Enabled = true;
                nupTiempo.Value = 0;
                rbtLibre.Enabled = true;
                if(compuDePeticiones is not null)
                {
                    txtApellido.Text = null;
                    txtNombre.Text = null;
                    txtEdad.Text = null;
                    txtDni.Text = null;
                }
              
                this.compuDePeticiones = null;

                
            }
        }

        
      
       

        /// <summary>
        /// boton que asigna la maquina segun su instancia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (local.ColaClientes.Count == 0)
            {
                MessageBox.Show("Lista vacia de clientes, debe agregar clientes primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cliente = local.ColaClientes.Peek();

                if (!(cliente.NumeroAMarcar is null))
                {
                    cabinaAux = new Cabina(cliente.NumeroAMarcar);

                    FormBuscarCabina buscaCabina = new FormBuscarCabina(local, cabinaAux);
                    buscaCabina.ShowDialog();
                }
                else
                {

                    compAux = new Computadora(cliente.Peticiones.ListaSofware,cliente.Peticiones.ListaPerifericos,cliente.Peticiones.ListaJuegos);
                    compAux.TiempoAsignado = cliente.TiempoAsignado;

                    FormBuscarCompuCompatible buscaCompu = new FormBuscarCompuCompatible(local, compAux);
                    buscaCompu.ShowDialog();
                }

                lsbCompusDisponibles.DataSource = null;
                lsbCompusDisponibles.DataSource = local.ListaCompusDisponibles;

                lsbCompusOcupadas.DataSource = null;
                lsbCompusOcupadas.DataSource = local.ListaCompusOcupadas;


                lsbCabinasDisponibles.DataSource = null;
                lsbCabinasDisponibles.DataSource = local.ListacCabinasDisponibles;


                lsbCasbinasOcupadas.DataSource = null;
                lsbCasbinasOcupadas.DataSource = local.ListaCabinasOcupadas;


                lsbListaClientes.DataSource = null;
                lsbListaClientes.DataSource = local.ListaClientes;

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
                cocaAux = comp.CantidadDeBebidasEnLista;

                if (Local.FinalizarTarea(local, comp))
                {
                    comp.CantidadDeBebidasEnLista = cocaAux;
                    
                    MessageBox.Show($"Finalizado con exito!! tiempo de uso: {comp.TiempoDeUsoNugget} Costo de Consumo (pc+bebidas): {comp.CalcularCostoCompuBebida()}\nPrecio Final iva: {string.Format("{0:0.00}", comp.ConsumoFinalIva())}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comp.CantidadDeBebidasEnLista = cocaAux;
                  
                    comp.Recaudacion += comp.CalcularCostoCompuBebida();
                }

                lsbCompusDisponibles.DataSource = null;
                lsbCompusDisponibles.DataSource = local.ListaCompusDisponibles;

                lsbCompusOcupadas.DataSource = null;
                lsbCompusOcupadas.DataSource = local.ListaCompusOcupadas;
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
                cocaAux = cab.CantidadDeBebidasEnLista;
                if (Local.FinalizarTarea(local, cab))
                {
                    cab.CantidadDeBebidasEnLista = cocaAux;
                    MessageBox.Show($"Finalizado con exito!!\nTiempo de uso: {cab.TiempoDeUsoNugget}\nDestino: {cab.DevolverDestino()}\nCosto de Consumo (cabina+bebidas): { cab.CalcularCostoCabinaBebida()}\nPrecio Final iva: {string.Format("{0:0.00}", cab.ConsumoFinalIva())}","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cab.CantidadDeBebidasEnLista = cocaAux;
                  
                    cab.recaudacion += cab.CalcularCostoCabinaBebida();
                    if(cab.DevolverDestino()==TipoLlamada.local.ToString())
                    {
                        local.TotalLocal += cab.CalcularCosto();
                    }
                    if(cab.DevolverDestino()==TipoLlamada.largaDistancia.ToString())
                    {
                        local.TotalLargaDistancia += cab.CalcularCosto();
                    }
                    if(cab.DevolverDestino()==TipoLlamada.internacional.ToString())
                    {
                        local.TotalInterncaional += cab.CalcularCosto();
                    }
                   
                }
                else
                {
                    MessageBox.Show($"No funca!! tiempo de uso: {cab.TiempoDeUsoNugget} Costo de uso: {cab.CalcularCostoCabinaBebida()}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lsbCabinasDisponibles.DataSource = null;
                lsbCabinasDisponibles.DataSource = local.ListacCabinasDisponibles;

                lsbCasbinasOcupadas.DataSource = null;
                lsbCasbinasOcupadas.DataSource = local.ListaCabinasOcupadas;

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
                MessageBox.Show($" tiempo de uso: {comp.TiempoDeUsoNugget} ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($" tiempo de uso: {cab.TiempoDeUsoNugget} destino: {cab.DevolverDestino()} ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if(local.StockDeBebidas.Count == 0)
                    {
                        MessageBox.Show($" no hay stock ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        comp.AgregarBebida(local.StockDeBebidas.Dequeue());// agrego la primera bebida del stock a la lista de bebidas de la computadora y se elimina del stock
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
                    if (local.StockDeBebidas.Count == 0)
                    {
                        MessageBox.Show($" no hay stock ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cab.AgregarBebida(local.StockDeBebidas.Dequeue());// agrego la primera bebida del stock a la lista de bebidas de la computadora y se elimina del stock
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

        private void rbtLibre_CheckedChanged(object sender, EventArgs e)
        {
            nupTiempo.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            rbtLibre.Enabled = false;
        }
    }
}
