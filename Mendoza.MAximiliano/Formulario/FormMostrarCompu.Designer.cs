
namespace Formulario
{
    partial class FormMostrarCompu
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
            this.rtbDatosCompu = new System.Windows.Forms.RichTextBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDatosCompu
            // 
            this.rtbDatosCompu.Location = new System.Drawing.Point(-1, 0);
            this.rtbDatosCompu.Name = "rtbDatosCompu";
            this.rtbDatosCompu.Size = new System.Drawing.Size(345, 239);
            this.rtbDatosCompu.TabIndex = 0;
            this.rtbDatosCompu.Text = "";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(239, 245);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(93, 27);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // FormMostrarCompu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(344, 284);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.rtbDatosCompu);
            this.Name = "FormMostrarCompu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMostrarCompu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDatosCompu;
        private System.Windows.Forms.Button btnAyuda;
    }
}