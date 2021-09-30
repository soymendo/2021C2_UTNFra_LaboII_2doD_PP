using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases_generales;
using Entidades.Clases_especializadas;

namespace Formulario
{
    public partial class FormVistaDePetisiones : Form
    {
        Local local = new Local(20);

        /// <summary>
        /// Constructor que recibe un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public FormVistaDePetisiones(Cliente cliente)
        {
            InitializeComponent();
            rtbPeticiones.ReadOnly = true;
            rtbPeticiones.Text = cliente.MostrarCliente();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muestra al cliente, sus datos.");
        }
    }
}
