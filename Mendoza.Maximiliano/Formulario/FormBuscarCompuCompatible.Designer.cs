
namespace Formulario
{
    partial class FormBuscarCompuCompatible
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
            this.lsbListaDeCompusCompatibles = new System.Windows.Forms.ListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.rtbPeticiones = new System.Windows.Forms.RichTextBox();
            this.lblCompus = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbListaDeCompusCompatibles
            // 
            this.lsbListaDeCompusCompatibles.FormattingEnabled = true;
            this.lsbListaDeCompusCompatibles.ItemHeight = 15;
            this.lsbListaDeCompusCompatibles.Location = new System.Drawing.Point(137, 49);
            this.lsbListaDeCompusCompatibles.Name = "lsbListaDeCompusCompatibles";
            this.lsbListaDeCompusCompatibles.Size = new System.Drawing.Size(183, 319);
            this.lsbListaDeCompusCompatibles.TabIndex = 0;
            this.lsbListaDeCompusCompatibles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbListaDeCompusCompatibles_MouseDoubleClick);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(353, 60);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(125, 40);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // rtbPeticiones
            // 
            this.rtbPeticiones.Location = new System.Drawing.Point(353, 152);
            this.rtbPeticiones.Name = "rtbPeticiones";
            this.rtbPeticiones.Size = new System.Drawing.Size(220, 216);
            this.rtbPeticiones.TabIndex = 2;
            this.rtbPeticiones.Text = "";
            // 
            // lblCompus
            // 
            this.lblCompus.AutoSize = true;
            this.lblCompus.Location = new System.Drawing.Point(137, 16);
            this.lblCompus.Name = "lblCompus";
            this.lblCompus.Size = new System.Drawing.Size(118, 15);
            this.lblCompus.TabIndex = 3;
            this.lblCompus.Text = "Compus disponibles:";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(353, 124);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(50, 15);
            this.lblPedidos.TabIndex = 4;
            this.lblPedidos.Text = "Cliente: ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(137, 31);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(96, 15);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "(info doble click)";
            // 
            // FormBuscarCompuCompatible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblCompus);
            this.Controls.Add(this.rtbPeticiones);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lsbListaDeCompusCompatibles);
            this.Name = "FormBuscarCompuCompatible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListaDeCompusCompatibles;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.RichTextBox rtbPeticiones;
        private System.Windows.Forms.Label lblCompus;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblInfo;
    }
}