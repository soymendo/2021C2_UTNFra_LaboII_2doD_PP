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
    public partial class FormMostrarCompu : Form
    {
        Local local = new Local(20);

        /// <summary>
        /// Constructor que recibe una computadora
        /// </summary>
        /// <param name="c"></param>
        public FormMostrarCompu(Computadora c)
        {
            InitializeComponent();
            rtbDatosCompu.ReadOnly = true;
            rtbDatosCompu.Text = c.Mostrar();
        }
    }
}
