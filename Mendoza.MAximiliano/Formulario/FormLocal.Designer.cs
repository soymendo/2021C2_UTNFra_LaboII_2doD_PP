
namespace Formulario
{
    partial class FormLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbCompusDisponibles = new System.Windows.Forms.ListBox();
            this.lsbCompusOcupadas = new System.Windows.Forms.ListBox();
            this.btnFinalizarTarea = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbSofware = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblSofware = new System.Windows.Forms.Label();
            this.lblPerisfericos = new System.Windows.Forms.Label();
            this.cmbPerisfericos = new System.Windows.Forms.ComboBox();
            this.lblJuego = new System.Windows.Forms.Label();
            this.cmbJuego = new System.Windows.Forms.ComboBox();
            this.lsbListaClientes = new System.Windows.Forms.ListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGuion2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblGuion = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.rbtComputadora = new System.Windows.Forms.RadioButton();
            this.rbtCabina = new System.Windows.Forms.RadioButton();
            this.rtbInfoMaquinas = new System.Windows.Forms.RichTextBox();
            this.lblListaCompusDisponibles = new System.Windows.Forms.Label();
            this.lblListaCompusOcupadas = new System.Windows.Forms.Label();
            this.tiempoActualDeUso = new System.Windows.Forms.Button();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.lsbCabinasDisponibles = new System.Windows.Forms.ListBox();
            this.lsbCasbinasOcupadas = new System.Windows.Forms.ListBox();
            this.btnFinalizarTareaCabina = new System.Windows.Forms.Button();
            this.btnTiempoActualDeUsoCabina = new System.Windows.Forms.Button();
            this.lblCabinasDisponibles = new System.Windows.Forms.Label();
            this.lblCabinasOcupadas = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfoclic = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbCompusDisponibles
            // 
            this.lsbCompusDisponibles.FormattingEnabled = true;
            this.lsbCompusDisponibles.ItemHeight = 15;
            this.lsbCompusDisponibles.Location = new System.Drawing.Point(894, 41);
            this.lsbCompusDisponibles.Name = "lsbCompusDisponibles";
            this.lsbCompusDisponibles.Size = new System.Drawing.Size(140, 244);
            this.lsbCompusDisponibles.TabIndex = 0;
            this.lsbCompusDisponibles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbCompusDisponibles_MouseDoubleClick);
            // 
            // lsbCompusOcupadas
            // 
            this.lsbCompusOcupadas.FormattingEnabled = true;
            this.lsbCompusOcupadas.ItemHeight = 15;
            this.lsbCompusOcupadas.Location = new System.Drawing.Point(1058, 41);
            this.lsbCompusOcupadas.Name = "lsbCompusOcupadas";
            this.lsbCompusOcupadas.Size = new System.Drawing.Size(140, 244);
            this.lsbCompusOcupadas.TabIndex = 1;
            this.lsbCompusOcupadas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbCompusOcupadas_MouseDoubleClick);
            // 
            // btnFinalizarTarea
            // 
            this.btnFinalizarTarea.Location = new System.Drawing.Point(1204, 70);
            this.btnFinalizarTarea.Name = "btnFinalizarTarea";
            this.btnFinalizarTarea.Size = new System.Drawing.Size(116, 38);
            this.btnFinalizarTarea.TabIndex = 2;
            this.btnFinalizarTarea.Text = "FinalizarTarea";
            this.btnFinalizarTarea.UseVisualStyleBackColor = true;
            this.btnFinalizarTarea.Click += new System.EventHandler(this.btnFinalizarTarea_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(93, 186);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbSofware
            // 
            this.cmbSofware.FormattingEnabled = true;
            this.cmbSofware.Location = new System.Drawing.Point(101, 26);
            this.cmbSofware.Name = "cmbSofware";
            this.cmbSofware.Size = new System.Drawing.Size(173, 23);
            this.cmbSofware.TabIndex = 5;
            this.cmbSofware.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSofware_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 23);
            this.txtApellido.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 49);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(93, 70);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(173, 23);
            this.txtEdad.TabIndex = 10;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(21, 78);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(93, 99);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(173, 23);
            this.txtDni.TabIndex = 12;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 107);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(25, 15);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "Dni";
            // 
            // lblSofware
            // 
            this.lblSofware.AutoSize = true;
            this.lblSofware.Location = new System.Drawing.Point(29, 34);
            this.lblSofware.Name = "lblSofware";
            this.lblSofware.Size = new System.Drawing.Size(49, 15);
            this.lblSofware.TabIndex = 13;
            this.lblSofware.Text = "Sofware";
            // 
            // lblPerisfericos
            // 
            this.lblPerisfericos.AutoSize = true;
            this.lblPerisfericos.Location = new System.Drawing.Point(29, 63);
            this.lblPerisfericos.Name = "lblPerisfericos";
            this.lblPerisfericos.Size = new System.Drawing.Size(67, 15);
            this.lblPerisfericos.TabIndex = 15;
            this.lblPerisfericos.Text = "Perisfericos";
            // 
            // cmbPerisfericos
            // 
            this.cmbPerisfericos.FormattingEnabled = true;
            this.cmbPerisfericos.Location = new System.Drawing.Point(101, 55);
            this.cmbPerisfericos.Name = "cmbPerisfericos";
            this.cmbPerisfericos.Size = new System.Drawing.Size(173, 23);
            this.cmbPerisfericos.TabIndex = 14;
            this.cmbPerisfericos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPerisfericos_KeyPress);
            // 
            // lblJuego
            // 
            this.lblJuego.AutoSize = true;
            this.lblJuego.Location = new System.Drawing.Point(29, 95);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(38, 15);
            this.lblJuego.TabIndex = 17;
            this.lblJuego.Text = "Juego";
            // 
            // cmbJuego
            // 
            this.cmbJuego.FormattingEnabled = true;
            this.cmbJuego.Location = new System.Drawing.Point(101, 87);
            this.cmbJuego.Name = "cmbJuego";
            this.cmbJuego.Size = new System.Drawing.Size(173, 23);
            this.cmbJuego.TabIndex = 16;
            this.cmbJuego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbJuego_KeyPress);
            // 
            // lsbListaClientes
            // 
            this.lsbListaClientes.FormattingEnabled = true;
            this.lsbListaClientes.ItemHeight = 15;
            this.lsbListaClientes.Location = new System.Drawing.Point(12, 289);
            this.lsbListaClientes.Name = "lsbListaClientes";
            this.lsbListaClientes.Size = new System.Drawing.Size(158, 319);
            this.lsbListaClientes.TabIndex = 18;
            this.lsbListaClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbListaClientes_MouseDoubleClick);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(187, 289);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(62, 57);
            this.btnAsignar.TabIndex = 21;
            this.btnAsignar.Text = "AsignarMaquina";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPerisfericos);
            this.panel1.Controls.Add(this.cmbSofware);
            this.panel1.Controls.Add(this.lblSofware);
            this.panel1.Controls.Add(this.lblPerisfericos);
            this.panel1.Controls.Add(this.cmbJuego);
            this.panel1.Controls.Add(this.lblJuego);
            this.panel1.Location = new System.Drawing.Point(303, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 130);
            this.panel1.TabIndex = 22;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(29, 39);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 23;
            this.lblTelefono.Text = "Telefono";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGuion2);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.lblGuion);
            this.panel2.Controls.Add(this.txtLocal);
            this.panel2.Controls.Add(this.txtArea);
            this.panel2.Controls.Add(this.lblTelefono);
            this.panel2.Location = new System.Drawing.Point(303, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 100);
            this.panel2.TabIndex = 25;
            // 
            // lblGuion2
            // 
            this.lblGuion2.AutoSize = true;
            this.lblGuion2.Location = new System.Drawing.Point(186, 39);
            this.lblGuion2.Name = "lblGuion2";
            this.lblGuion2.Size = new System.Drawing.Size(12, 15);
            this.lblGuion2.TabIndex = 41;
            this.lblGuion2.Text = "-";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(204, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(70, 23);
            this.txtNumero.TabIndex = 27;
            // 
            // lblGuion
            // 
            this.lblGuion.AutoSize = true;
            this.lblGuion.Location = new System.Drawing.Point(133, 39);
            this.lblGuion.Name = "lblGuion";
            this.lblGuion.Size = new System.Drawing.Size(12, 15);
            this.lblGuion.TabIndex = 40;
            this.lblGuion.Text = "-";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(151, 36);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(29, 23);
            this.txtLocal.TabIndex = 26;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(101, 36);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(26, 23);
            this.txtArea.TabIndex = 25;
            // 
            // rbtComputadora
            // 
            this.rbtComputadora.AutoSize = true;
            this.rbtComputadora.Location = new System.Drawing.Point(50, 150);
            this.rbtComputadora.Name = "rbtComputadora";
            this.rbtComputadora.Size = new System.Drawing.Size(65, 19);
            this.rbtComputadora.TabIndex = 26;
            this.rbtComputadora.TabStop = true;
            this.rbtComputadora.Text = "Compu";
            this.rbtComputadora.UseVisualStyleBackColor = true;
            this.rbtComputadora.CheckedChanged += new System.EventHandler(this.rbtComputadora_CheckedChanged);
            // 
            // rbtCabina
            // 
            this.rbtCabina.AutoSize = true;
            this.rbtCabina.Location = new System.Drawing.Point(204, 150);
            this.rbtCabina.Name = "rbtCabina";
            this.rbtCabina.Size = new System.Drawing.Size(62, 19);
            this.rbtCabina.TabIndex = 27;
            this.rbtCabina.TabStop = true;
            this.rbtCabina.Text = "Cabina";
            this.rbtCabina.UseVisualStyleBackColor = true;
            this.rbtCabina.CheckedChanged += new System.EventHandler(this.rbtCabina_CheckedChanged);
            // 
            // rtbInfoMaquinas
            // 
            this.rtbInfoMaquinas.Location = new System.Drawing.Point(391, 364);
            this.rtbInfoMaquinas.Name = "rtbInfoMaquinas";
            this.rtbInfoMaquinas.Size = new System.Drawing.Size(186, 244);
            this.rtbInfoMaquinas.TabIndex = 28;
            this.rtbInfoMaquinas.Text = "";
            // 
            // lblListaCompusDisponibles
            // 
            this.lblListaCompusDisponibles.AutoSize = true;
            this.lblListaCompusDisponibles.Location = new System.Drawing.Point(894, 12);
            this.lblListaCompusDisponibles.Name = "lblListaCompusDisponibles";
            this.lblListaCompusDisponibles.Size = new System.Drawing.Size(115, 15);
            this.lblListaCompusDisponibles.TabIndex = 29;
            this.lblListaCompusDisponibles.Text = "Compus disponibles";
            // 
            // lblListaCompusOcupadas
            // 
            this.lblListaCompusOcupadas.AutoSize = true;
            this.lblListaCompusOcupadas.Location = new System.Drawing.Point(1058, 12);
            this.lblListaCompusOcupadas.Name = "lblListaCompusOcupadas";
            this.lblListaCompusOcupadas.Size = new System.Drawing.Size(106, 15);
            this.lblListaCompusOcupadas.TabIndex = 30;
            this.lblListaCompusOcupadas.Text = "Compus ocupadas";
            // 
            // tiempoActualDeUso
            // 
            this.tiempoActualDeUso.Location = new System.Drawing.Point(1204, 131);
            this.tiempoActualDeUso.Name = "tiempoActualDeUso";
            this.tiempoActualDeUso.Size = new System.Drawing.Size(62, 57);
            this.tiempoActualDeUso.TabIndex = 31;
            this.tiempoActualDeUso.Text = "Tiempo actual de uso";
            this.tiempoActualDeUso.UseVisualStyleBackColor = true;
            this.tiempoActualDeUso.Click += new System.EventHandler(this.tiempoActualDeUso_Click);
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Location = new System.Drawing.Point(12, 261);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(90, 15);
            this.lblListaClientes.TabIndex = 33;
            this.lblListaClientes.Text = "Lista de clientes";
            // 
            // lsbCabinasDisponibles
            // 
            this.lsbCabinasDisponibles.FormattingEnabled = true;
            this.lsbCabinasDisponibles.ItemHeight = 15;
            this.lsbCabinasDisponibles.Location = new System.Drawing.Point(894, 372);
            this.lsbCabinasDisponibles.Name = "lsbCabinasDisponibles";
            this.lsbCabinasDisponibles.Size = new System.Drawing.Size(140, 244);
            this.lsbCabinasDisponibles.TabIndex = 34;
            this.lsbCabinasDisponibles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbCabinasDisponibles_MouseDoubleClick);
            // 
            // lsbCasbinasOcupadas
            // 
            this.lsbCasbinasOcupadas.FormattingEnabled = true;
            this.lsbCasbinasOcupadas.ItemHeight = 15;
            this.lsbCasbinasOcupadas.Location = new System.Drawing.Point(1058, 372);
            this.lsbCasbinasOcupadas.Name = "lsbCasbinasOcupadas";
            this.lsbCasbinasOcupadas.Size = new System.Drawing.Size(140, 244);
            this.lsbCasbinasOcupadas.TabIndex = 35;
            this.lsbCasbinasOcupadas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbCsbinasOcupadas_MouseDoubleClick);
            // 
            // btnFinalizarTareaCabina
            // 
            this.btnFinalizarTareaCabina.Location = new System.Drawing.Point(1204, 399);
            this.btnFinalizarTareaCabina.Name = "btnFinalizarTareaCabina";
            this.btnFinalizarTareaCabina.Size = new System.Drawing.Size(121, 38);
            this.btnFinalizarTareaCabina.TabIndex = 36;
            this.btnFinalizarTareaCabina.Text = "FinalizarTarea";
            this.btnFinalizarTareaCabina.UseVisualStyleBackColor = true;
            this.btnFinalizarTareaCabina.Click += new System.EventHandler(this.btnFinalizarTareaCabina_Click);
            // 
            // btnTiempoActualDeUsoCabina
            // 
            this.btnTiempoActualDeUsoCabina.Location = new System.Drawing.Point(1204, 462);
            this.btnTiempoActualDeUsoCabina.Name = "btnTiempoActualDeUsoCabina";
            this.btnTiempoActualDeUsoCabina.Size = new System.Drawing.Size(62, 57);
            this.btnTiempoActualDeUsoCabina.TabIndex = 37;
            this.btnTiempoActualDeUsoCabina.Text = "Tiempo actual de uso";
            this.btnTiempoActualDeUsoCabina.UseVisualStyleBackColor = true;
            this.btnTiempoActualDeUsoCabina.Click += new System.EventHandler(this.btnTiempoActualDeUsoCabina_Click);
            // 
            // lblCabinasDisponibles
            // 
            this.lblCabinasDisponibles.AutoSize = true;
            this.lblCabinasDisponibles.Location = new System.Drawing.Point(894, 344);
            this.lblCabinasDisponibles.Name = "lblCabinasDisponibles";
            this.lblCabinasDisponibles.Size = new System.Drawing.Size(112, 15);
            this.lblCabinasDisponibles.TabIndex = 38;
            this.lblCabinasDisponibles.Text = "Cabinas disponibles";
            // 
            // lblCabinasOcupadas
            // 
            this.lblCabinasOcupadas.AutoSize = true;
            this.lblCabinasOcupadas.Location = new System.Drawing.Point(1058, 344);
            this.lblCabinasOcupadas.Name = "lblCabinasOcupadas";
            this.lblCabinasOcupadas.Size = new System.Drawing.Size(105, 15);
            this.lblCabinasOcupadas.TabIndex = 39;
            this.lblCabinasOcupadas.Text = "Cabinas Ocupadas";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(389, 310);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(94, 15);
            this.lblInfo.TabIndex = 40;
            this.lblInfo.Text = "Info de maquina";
            // 
            // lblInfoclic
            // 
            this.lblInfoclic.AutoSize = true;
            this.lblInfoclic.Location = new System.Drawing.Point(389, 331);
            this.lblInfoclic.Name = "lblInfoclic";
            this.lblInfoclic.Size = new System.Drawing.Size(106, 15);
            this.lblInfoclic.TabIndex = 41;
            this.lblInfoclic.Text = "(doble clic en lista)";
            // 
            // FormLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 653);
            this.Controls.Add(this.lblInfoclic);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCabinasOcupadas);
            this.Controls.Add(this.lblCabinasDisponibles);
            this.Controls.Add(this.btnTiempoActualDeUsoCabina);
            this.Controls.Add(this.btnFinalizarTareaCabina);
            this.Controls.Add(this.lsbCasbinasOcupadas);
            this.Controls.Add(this.lsbCabinasDisponibles);
            this.Controls.Add(this.lblListaClientes);
            this.Controls.Add(this.tiempoActualDeUso);
            this.Controls.Add(this.lblListaCompusOcupadas);
            this.Controls.Add(this.lblListaCompusDisponibles);
            this.Controls.Add(this.rtbInfoMaquinas);
            this.Controls.Add(this.rbtCabina);
            this.Controls.Add(this.rbtComputadora);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lsbListaClientes);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFinalizarTarea);
            this.Controls.Add(this.lsbCompusOcupadas);
            this.Controls.Add(this.lsbCompusDisponibles);
            this.Name = "FormLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLocal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbCompusDisponibles;
        private System.Windows.Forms.ListBox lsbCompusOcupadas;
        private System.Windows.Forms.Button btnFinalizarTarea;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbSofware;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblSofware;
        private System.Windows.Forms.Label lblPerisfericos;
        private System.Windows.Forms.ComboBox cmbPerisfericos;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.ComboBox cmbJuego;
        private System.Windows.Forms.ListBox lsbListaClientes;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtComputadora;
        private System.Windows.Forms.RadioButton rbtCabina;
        private System.Windows.Forms.RichTextBox rtbInfoMaquinas;
        private System.Windows.Forms.Label lblListaCompusDisponibles;
        private System.Windows.Forms.Label lblListaCompusOcupadas;
        private System.Windows.Forms.Button tiempoActualDeUso;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.ListBox lsbCabinasDisponibles;
        private System.Windows.Forms.ListBox lsbCasbinasOcupadas;
        private System.Windows.Forms.Button btnFinalizarTareaCabina;
        private System.Windows.Forms.Button btnTiempoActualDeUsoCabina;
        private System.Windows.Forms.Label lblCabinasDisponibles;
        private System.Windows.Forms.Label lblCabinasOcupadas;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblGuion;
        private System.Windows.Forms.Label lblGuion2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInfoclic;
    }
}