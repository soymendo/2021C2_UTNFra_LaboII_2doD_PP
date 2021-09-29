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
        Cliente cliAux;//pasa al otor form
        Computadora aux; //GuardarCompuEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones
        Computadora auxListaUnica;//le paso la compu al form
        //Computadora Devuelta;
        Cabina cabinaAux;

        string numeroDeTelefono;

        public Computadora CompuAux
        {
            get { return this.aux; }
        }

        //List<Cliente> aux = new List<Cliente>();

        public FormLocal(Local loc)
        {
            InitializeComponent();

            //Thread.Sleep(4000);
            //MessageBox.Show($"ALGO ESTA PASANDO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.local = loc;
            cmbSofware.DataSource = Enum.GetValues(typeof(Petisiones.SoftwareInstalado));
            cmbPerisfericos.DataSource = Enum.GetValues(typeof(Petisiones.PeriféricosDisponibles));
            cmbJuego.DataSource = Enum.GetValues(typeof(Petisiones.JuegosDisponibles));

            //cmbSofware.Text = "";
            //cmbJuego.Text = "";
            //cmbPerisfericos.Text = "";

            //lsbCompusDisponibles.DataSource = null;
            lsbCompusDisponibles.DataSource = local.Lista_CompusDisponibles;
            lsbCabinasDisponibles.DataSource = local.Lista_cabinas_disponibles;

            lsbCompusOcupadas.DataSource = local.Lista_CompusOcupadas;
            lsbCsbinasOcupadas.DataSource = local.Lista_cabinas_ocupadas;
            //txtTelefono.Enabled = false;

            txtArea.Enabled = false;
            txtLocal.Enabled = false;
            txtNumero.Enabled = false;
            cmbSofware.Enabled = false;
            cmbPerisfericos.Enabled = false;
            cmbJuego.Enabled = false;
        }


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
                //txtTelefono.Enabled = false;
            }
        }
        private void rbtCabina_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtCabina.Checked)
            {
                txtArea.Enabled = true;
                txtLocal.Enabled = true;
                txtNumero.Enabled = true;

                //txtTelefono.Enabled = true;
                cmbSofware.Enabled = false;
                cmbPerisfericos.Enabled = false;
                cmbJuego.Enabled = false;
            }
        }
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
                    }
                    if (Local.GuardarClienteEnColaClientes(local, clienteCompu))
                    {
                        //MessageBox.Show("Agregado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aux = new Computadora(clienteCompu.PetisionesDePc.Sofware, clienteCompu.PetisionesDePc.Periféricos, clienteCompu.PetisionesDePc.Juegos);//usado para buscar la pc compatible
                        if (Local.GuardarCompuEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(local, aux)) { }
                    
                    }


                   
                    lsbListaClientes.DataSource = null;
                    lsbListaClientes.DataSource = local.Lista_Clientes;
                }


                if( rbtCabina.Checked)
                {
                    this.numeroDeTelefono = string.Concat(txtArea.Text,txtLocal.Text,txtNumero.Text);
                    if(numeroDeTelefono.Length<=13)
                    {
                        //Cliente clienteCabina = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text), txtTelefono.Text);
                        Cliente clienteCabina = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text), this.numeroDeTelefono);

                        if (Local.GuardarClienteEnListaClientes(local, clienteCabina)) { MessageBox.Show("Agregado con exito!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        if (Local.GuardarClienteEnColaClientes(local, clienteCabina)) { }

                        lsbListaClientes.DataSource = null;
                        lsbListaClientes.DataSource = local.Lista_Clientes;
                    }else
                    {
                        MessageBox.Show("Numero incorrecto!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                   
                }


            }

            richTextBox1.Text = local.MostrarClientesDisponiblesCola();
            //richTextBox2.Text = clienteCabina

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
               
          }


















        private void cmbSofware_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPerisfericos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }







       
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (local.Cola_Clientes.Count == 0)
            {
                MessageBox.Show("Lista vacia de clientes, debe agregar clientes primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cliente = local.Cola_Clientes.Peek();

                //cabinaAux = new Cabina(cliente.NumeroAMarcar);
                // MessageBox.Show($"Numero de cabina: {cabinaAux.NumeroAMarcar}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



                if (cliente.PetisionesDePc is null)
                {
                    cabinaAux = new Cabina(cliente.NumeroAMarcar);

                    FormBuscarCabina buscaCabina = new FormBuscarCabina(local, cabinaAux);
                    buscaCabina.ShowDialog();
                }
                else
                {
                    auxListaUnica = new Computadora(cliente.PetisionesDePc.Sofware, cliente.PetisionesDePc.Periféricos, cliente.PetisionesDePc.Juegos);
                    FormBuscarCompuCompatible buscaCompu = new FormBuscarCompuCompatible(local, auxListaUnica);
                    buscaCompu.ShowDialog();
                }




                lsbCompusDisponibles.DataSource = null;
                lsbCompusDisponibles.DataSource = local.Lista_CompusDisponibles;

                lsbCompusOcupadas.DataSource = null;
                lsbCompusOcupadas.DataSource = local.Lista_CompusOcupadas;


                lsbCabinasDisponibles.DataSource = null;
                lsbCabinasDisponibles.DataSource = local.Lista_cabinas_disponibles;


                lsbCsbinasOcupadas.DataSource = null;
                lsbCsbinasOcupadas.DataSource = local.Lista_cabinas_ocupadas;


                lsbListaClientes.DataSource = null;
                lsbListaClientes.DataSource = local.Lista_Clientes;

                //local.Cola_Clientes = buscaCompu.GetColaClientes;
                richTextBox1.Text = local.MostrarClientesDisponiblesCola();


            }




        }



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
                    //if (Local.GuardarCompuEnListaCompusDisponiblesParaElClienteSegunsSusPetisiones(local, comp)) { }
                }

                lsbCompusDisponibles.DataSource = null;
                lsbCompusDisponibles.DataSource = local.Lista_CompusDisponibles;

                lsbCompusOcupadas.DataSource = null;
                lsbCompusOcupadas.DataSource = local.Lista_CompusOcupadas;


                //richTextBox2.Text = local.MostrarCompusDisponiblesParaElClienteSegunsSusPetisiones(aux);
               // richTextBox2.Text = local.MostrarListaCompusDisponiblesParaElClienteSegunsSusPetisiones(aux);
            }

            
        }



     
        private void tiempoActualDeUso_Click(object sender, EventArgs e)
        {
            if (lsbCompusOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Computadora comp = (Computadora)lsbCompusOcupadas.SelectedItem;

                MessageBox.Show($" tiempo de uso: {comp.TiempoActualDeUso} ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
      
        private void btnFinalizarTareaCabina_Click(object sender, EventArgs e)
        {
            if (lsbCsbinasOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cabina cab = (Cabina)lsbCsbinasOcupadas.SelectedItem;

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

                lsbCsbinasOcupadas.DataSource = null;
                lsbCsbinasOcupadas.DataSource = local.Lista_cabinas_ocupadas;

            }




           
                

        }

        private void btnTiempoActualDeUsoCabina_Click(object sender, EventArgs e)
        {

            if (lsbCsbinasOcupadas.SelectedItem is null)
            {
                MessageBox.Show("Se debe seleccionar algun elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 

                Cabina cab = (Cabina)lsbCsbinasOcupadas.SelectedItem;

                MessageBox.Show($" tiempo de uso: {cab.TiempoActualDeUso} destino: {cab.Destino()} ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }



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



        private void FormLocal_Load(object sender, EventArgs e)
        {

        }

        private void lblGuion_Click(object sender, EventArgs e)
        {

        }
    }
}
