
namespace CapaPresentacion_VISTA
{
    partial class PU_circular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PU_circular));
            this.tb_DefCircular = new System.Windows.Forms.TextBox();
            this.boton_CerrarPU = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // tb_DefCircular
            // 
            this.tb_DefCircular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_DefCircular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpProvider1.SetHelpString(this.tb_DefCircular, "Definicion de un grafico circular");
            this.tb_DefCircular.Location = new System.Drawing.Point(12, 12);
            this.tb_DefCircular.Multiline = true;
            this.tb_DefCircular.Name = "tb_DefCircular";
            this.tb_DefCircular.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.tb_DefCircular, true);
            this.tb_DefCircular.Size = new System.Drawing.Size(430, 58);
            this.tb_DefCircular.TabIndex = 0;
            this.tb_DefCircular.Text = resources.GetString("tb_DefCircular.Text");
            // 
            // boton_CerrarPU
            // 
            this.helpProvider1.SetHelpString(this.boton_CerrarPU, "Clic aqui para cerrar la ventana");
            this.boton_CerrarPU.Location = new System.Drawing.Point(367, 76);
            this.boton_CerrarPU.Name = "boton_CerrarPU";
            this.helpProvider1.SetShowHelp(this.boton_CerrarPU, true);
            this.boton_CerrarPU.Size = new System.Drawing.Size(75, 23);
            this.boton_CerrarPU.TabIndex = 1;
            this.boton_CerrarPU.Text = "Cerrar";
            this.boton_CerrarPU.UseVisualStyleBackColor = true;
            this.boton_CerrarPU.Click += new System.EventHandler(this.boton_CerrarPU_Click);
            // 
            // PU_circular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 109);
            this.Controls.Add(this.boton_CerrarPU);
            this.Controls.Add(this.tb_DefCircular);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PU_circular";
            this.Text = "Grafico Circular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_DefCircular;
        private System.Windows.Forms.Button boton_CerrarPU;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}