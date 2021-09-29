
namespace Formulario
{
    partial class FormBuscarCabina
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
            this.lsbCabinasDisponibles = new System.Windows.Forms.ListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbCabinasDisponibles
            // 
            this.lsbCabinasDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbCabinasDisponibles.FormattingEnabled = true;
            this.lsbCabinasDisponibles.ItemHeight = 15;
            this.lsbCabinasDisponibles.Location = new System.Drawing.Point(69, 74);
            this.lsbCabinasDisponibles.Name = "lsbCabinasDisponibles";
            this.lsbCabinasDisponibles.Size = new System.Drawing.Size(285, 319);
            this.lsbCabinasDisponibles.TabIndex = 0;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignar.Location = new System.Drawing.Point(385, 74);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(110, 40);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // FormBuscarCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lsbCabinasDisponibles);
            this.Name = "FormBuscarCabina";
            this.Text = "FormBuscarCabina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbCabinasDisponibles;
        private System.Windows.Forms.Button btnAsignar;
    }
}