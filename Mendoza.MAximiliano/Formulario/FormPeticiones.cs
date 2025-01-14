﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases_especializadas;
namespace Formulario
{
    public partial class FormPeticiones : Form
    {
        Computadora comp;
        List<string> sofware = new List<string>();
        List<string> perifericos = new List<string>();
        List<string> juegos = new List<string>();

        public Computadora compuAfura
        {
            get { return this.comp; }
            set { this.comp = value; }
        }


        public FormPeticiones()
        {
            InitializeComponent();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if(btnCargar.Text=="Cerrar")
            {
                this.Close();
            }
            else
            {
              
                    foreach (var item in lsbSofware.SelectedItems)
                    {

                    if(lsbSofware.SelectedItem is null) { }
                    else { sofware.Add((string)item); }

                    }

                    foreach (var item in lsbPerisfericos.SelectedItems)
                    {

                    if (lsbPerisfericos.SelectedItems is null) { }
                    else { perifericos.Add((string)item); }
                       
                    }
                    foreach (var item in lsbJuegos.SelectedItems)
                    {

                    if (lsbJuegos.SelectedItems is null) { }
                    else { juegos.Add((string)item); } 

                    }

                    comp = new Computadora(sofware, perifericos, juegos);
                    MessageBox.Show("Peticiones cargadas!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCargar.Text = "Cerrar";
                    rtbMostrarPeticiones.Text = comp.Mostrar();
               
            }

                   

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberá y podrá elegir de entre las listas disponibles una o todas las opciones para cumplir con las peticiones del cliente, al terminar cerrar el formulario");
        }
    }
}
