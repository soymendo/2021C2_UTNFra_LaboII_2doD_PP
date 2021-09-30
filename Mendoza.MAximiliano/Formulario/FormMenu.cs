using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Clases_generales;

namespace Formulario
{
    public partial class FormMenu : Form
    {
        Local local = new Local("Mendo", 16);


        public FormMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// boton que lleval al formLocal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocal_Click(object sender, EventArgs e)
        {
            FormLocal formLocal = new FormLocal(local);
            formLocal.ShowDialog();
        }


        /// <summary>
        /// boton que lleva al formEstadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas = new FormEstadisticas(local);
            formEstadisticas.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Local' abrirá un nuevo formulario donde se getionará las acciones\n 'Estadisticas' abrirá un nuevo formulario donde se visualizaran las estadisticas");
        }
    }
}
