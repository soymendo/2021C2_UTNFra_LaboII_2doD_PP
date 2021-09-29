
namespace Formulario
{
    partial class FormVistaDePetisiones
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
            this.rtbPeticiones = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbPeticiones
            // 
            this.rtbPeticiones.Location = new System.Drawing.Point(0, 1);
            this.rtbPeticiones.Name = "rtbPeticiones";
            this.rtbPeticiones.Size = new System.Drawing.Size(277, 266);
            this.rtbPeticiones.TabIndex = 0;
            this.rtbPeticiones.Text = "";
            // 
            // FormVistaDePetisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 263);
            this.Controls.Add(this.rtbPeticiones);
            this.Name = "FormVistaDePetisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVistaDePetisiones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPeticiones;
    }
}