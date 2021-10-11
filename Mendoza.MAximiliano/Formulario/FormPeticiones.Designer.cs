
namespace Formulario
{
    partial class FormPeticiones
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.lsbSofware = new System.Windows.Forms.ListBox();
            this.lsbPerisfericos = new System.Windows.Forms.ListBox();
            this.lsbJuegos = new System.Windows.Forms.ListBox();
            this.lblSofware = new System.Windows.Forms.Label();
            this.lblPerisfericos = new System.Windows.Forms.Label();
            this.lblJuegos = new System.Windows.Forms.Label();
            this.rtbMostrarPeticiones = new System.Windows.Forms.RichTextBox();
            this.lblVista = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.Location = new System.Drawing.Point(600, 84);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 41);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button4_Click);
            // 
            // lsbSofware
            // 
            this.lsbSofware.FormattingEnabled = true;
            this.lsbSofware.ItemHeight = 15;
            this.lsbSofware.Items.AddRange(new object[] {
            "office",
            "messenger",
            "icq",
            "ares"});
            this.lsbSofware.Location = new System.Drawing.Point(40, 84);
            this.lsbSofware.Name = "lsbSofware";
            this.lsbSofware.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbSofware.Size = new System.Drawing.Size(120, 214);
            this.lsbSofware.TabIndex = 4;
            // 
            // lsbPerisfericos
            // 
            this.lsbPerisfericos.FormattingEnabled = true;
            this.lsbPerisfericos.ItemHeight = 15;
            this.lsbPerisfericos.Items.AddRange(new object[] {
            "camara",
            "auriculares",
            "microfono"});
            this.lsbPerisfericos.Location = new System.Drawing.Point(232, 84);
            this.lsbPerisfericos.Name = "lsbPerisfericos";
            this.lsbPerisfericos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbPerisfericos.Size = new System.Drawing.Size(120, 214);
            this.lsbPerisfericos.TabIndex = 5;
            // 
            // lsbJuegos
            // 
            this.lsbJuegos.FormattingEnabled = true;
            this.lsbJuegos.ItemHeight = 15;
            this.lsbJuegos.Items.AddRange(new object[] {
            "CounterStrike",
            "DiabloII",
            "MuOnline",
            "LinegeII"});
            this.lsbJuegos.Location = new System.Drawing.Point(440, 84);
            this.lsbJuegos.Name = "lsbJuegos";
            this.lsbJuegos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbJuegos.Size = new System.Drawing.Size(120, 214);
            this.lsbJuegos.TabIndex = 6;
            // 
            // lblSofware
            // 
            this.lblSofware.AutoSize = true;
            this.lblSofware.Location = new System.Drawing.Point(40, 48);
            this.lblSofware.Name = "lblSofware";
            this.lblSofware.Size = new System.Drawing.Size(49, 15);
            this.lblSofware.TabIndex = 7;
            this.lblSofware.Text = "Sofware";
            // 
            // lblPerisfericos
            // 
            this.lblPerisfericos.AutoSize = true;
            this.lblPerisfericos.Location = new System.Drawing.Point(232, 48);
            this.lblPerisfericos.Name = "lblPerisfericos";
            this.lblPerisfericos.Size = new System.Drawing.Size(67, 15);
            this.lblPerisfericos.TabIndex = 8;
            this.lblPerisfericos.Text = "Perisfericos";
            // 
            // lblJuegos
            // 
            this.lblJuegos.AutoSize = true;
            this.lblJuegos.Location = new System.Drawing.Point(440, 48);
            this.lblJuegos.Name = "lblJuegos";
            this.lblJuegos.Size = new System.Drawing.Size(43, 15);
            this.lblJuegos.TabIndex = 9;
            this.lblJuegos.Text = "Juegos";
            // 
            // rtbMostrarPeticiones
            // 
            this.rtbMostrarPeticiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMostrarPeticiones.Location = new System.Drawing.Point(600, 159);
            this.rtbMostrarPeticiones.Name = "rtbMostrarPeticiones";
            this.rtbMostrarPeticiones.Size = new System.Drawing.Size(178, 279);
            this.rtbMostrarPeticiones.TabIndex = 10;
            this.rtbMostrarPeticiones.Text = "";
            // 
            // lblVista
            // 
            this.lblVista.AutoSize = true;
            this.lblVista.Location = new System.Drawing.Point(600, 141);
            this.lblVista.Name = "lblVista";
            this.lblVista.Size = new System.Drawing.Size(117, 15);
            this.lblVista.TabIndex = 11;
            this.lblVista.Text = "Peticiones cargadas :";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyuda.Location = new System.Drawing.Point(14, 397);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(158, 41);
            this.btnAyuda.TabIndex = 12;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // FormPeticiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblVista);
            this.Controls.Add(this.rtbMostrarPeticiones);
            this.Controls.Add(this.lblJuegos);
            this.Controls.Add(this.lblPerisfericos);
            this.Controls.Add(this.lblSofware);
            this.Controls.Add(this.lsbJuegos);
            this.Controls.Add(this.lsbPerisfericos);
            this.Controls.Add(this.lsbSofware);
            this.Controls.Add(this.btnCargar);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormPeticiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPeticiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lsbSofware;
        private System.Windows.Forms.ListBox lsbPerisfericos;
        private System.Windows.Forms.ListBox lsbJuegos;
        private System.Windows.Forms.Label lblSofware;
        private System.Windows.Forms.Label lblPerisfericos;
        private System.Windows.Forms.Label lblJuegos;
        private System.Windows.Forms.RichTextBox rtbMostrarPeticiones;
        private System.Windows.Forms.Label lblVista;
        private System.Windows.Forms.Button btnAyuda;
    }
}