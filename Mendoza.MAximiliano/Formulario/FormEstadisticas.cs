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
    public partial class FormEstadisticas : Form
    {
        Local local = new Local(20);
        public FormEstadisticas(Local l)
        {
            InitializeComponent();
            this.local = l;
        }

        /// <summary>
        /// boton que muestra ListaPcOrdenadasPorTiempoDeUso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {          
            rtbEstadisticas.Text = local.ListaPcOrdenadasPorTiempoDeUso(local);          
        }

        /// <summary>
        /// boton que muestra ListaCabinasOrdenadasPorTiempoDeUso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCabinasOrdenadasPorTiempoDeUso_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.ListaCabinasOrdenadasPorTiempoDeUso(local);
        }

        /// <summary>
        /// boton que muestra GananciasTotales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGananciasTotales_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.GananciasTotales();
        }

        /// <summary>
        /// boton que muestra Horas_totales_Y_La_Recaudación_Por_Tipo_De_Llamada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHorasTotales_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.HorasGananciasPorLlamada();
        }

        /// <summary>
        /// boton que muestra PetisionesMasPedidas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMasPedidos_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.PetisionesMasPedidas();
        }




        private void btnCompusCabinasRecaudacion_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.ListaComputadorasOrdenadasPorRecaudacionsTotal(local).ToString();
        }

        private void btnCabinasRecaudacion_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.ListaCabinasOrdenadasPorRecaudacionsTotal(local).ToString();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada boton proporcionará los datos estadisticos del local");
        }

       
    }
}
