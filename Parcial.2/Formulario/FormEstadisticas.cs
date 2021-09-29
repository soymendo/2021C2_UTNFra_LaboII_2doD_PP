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

        private void button1_Click(object sender, EventArgs e)
        {
           
            rtbEstadisticas.Text = local.ListaPcOrdenadasPorTiempoDeUso(local);
        }

        private void btnCabinasOrdenadasPorTiempoDeUso_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.ListaCabinasOrdenadasPorTiempoDeUso(local);
        }

        private void btnGananciasTotales_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.GananciasTotales();
        }

        private void btnHorasTotales_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.Horas_totales_Y_La_Recaudación_Por_Tipo_De_Llamada();
        }

        private void btnMasPedidos_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = local.PetisionesMasPedidas();
        }
    }
}
