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

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FormLocal formLocal = new FormLocal(local);
            formLocal.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas = new FormEstadisticas(local);
            formEstadisticas.ShowDialog();
        }
    }
}
