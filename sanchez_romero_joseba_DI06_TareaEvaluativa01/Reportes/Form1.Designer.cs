
namespace Reportes
{
    partial class FormularioGeneradorReportes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonMayoresMargenesBeneficioEuros = new System.Windows.Forms.Button();
            this.botonMayoresMargenesBeneficioPorcentaje = new System.Windows.Forms.Button();
            this.botonMayoresMargenesBeneficioStock = new System.Windows.Forms.Button();
            this.botonMejorVendedor = new System.Windows.Forms.Button();
            this.botonMejorComprador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // botonMayoresMargenesBeneficioEuros
            // 
            this.botonMayoresMargenesBeneficioEuros.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.botonMayoresMargenesBeneficioEuros.Location = new System.Drawing.Point(179, 168);
            this.botonMayoresMargenesBeneficioEuros.Name = "botonMayoresMargenesBeneficioEuros";
            this.botonMayoresMargenesBeneficioEuros.Size = new System.Drawing.Size(301, 23);
            this.botonMayoresMargenesBeneficioEuros.TabIndex = 10;
            this.botonMayoresMargenesBeneficioEuros.Text = "Mayores márgenes de beneficio por producto en €";
            this.botonMayoresMargenesBeneficioEuros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMayoresMargenesBeneficioEuros.UseVisualStyleBackColor = true;
            this.botonMayoresMargenesBeneficioEuros.Click += new System.EventHandler(this.botonMayoresMargenesBeneficioEuros_Click);
            // 
            // botonMayoresMargenesBeneficioPorcentaje
            // 
            this.botonMayoresMargenesBeneficioPorcentaje.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.botonMayoresMargenesBeneficioPorcentaje.Location = new System.Drawing.Point(179, 197);
            this.botonMayoresMargenesBeneficioPorcentaje.Name = "botonMayoresMargenesBeneficioPorcentaje";
            this.botonMayoresMargenesBeneficioPorcentaje.Size = new System.Drawing.Size(301, 23);
            this.botonMayoresMargenesBeneficioPorcentaje.TabIndex = 11;
            this.botonMayoresMargenesBeneficioPorcentaje.Text = "Mayores márgenes de beneficio por producto en %";
            this.botonMayoresMargenesBeneficioPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMayoresMargenesBeneficioPorcentaje.UseVisualStyleBackColor = true;
            this.botonMayoresMargenesBeneficioPorcentaje.Click += new System.EventHandler(this.botonMayoresMargenesBeneficioPorcentaje_Click);
            // 
            // botonMayoresMargenesBeneficioStock
            // 
            this.botonMayoresMargenesBeneficioStock.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.botonMayoresMargenesBeneficioStock.Location = new System.Drawing.Point(179, 226);
            this.botonMayoresMargenesBeneficioStock.Name = "botonMayoresMargenesBeneficioStock";
            this.botonMayoresMargenesBeneficioStock.Size = new System.Drawing.Size(301, 23);
            this.botonMayoresMargenesBeneficioStock.TabIndex = 12;
            this.botonMayoresMargenesBeneficioStock.Text = "Mayores márgenes de beneficio en STOCK €";
            this.botonMayoresMargenesBeneficioStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMayoresMargenesBeneficioStock.UseVisualStyleBackColor = true;
            this.botonMayoresMargenesBeneficioStock.Click += new System.EventHandler(this.botonMayoresMargenesBeneficioStock_Click);
            // 
            // botonMejorVendedor
            // 
            this.botonMejorVendedor.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.botonMejorVendedor.Location = new System.Drawing.Point(180, 284);
            this.botonMejorVendedor.Name = "botonMejorVendedor";
            this.botonMejorVendedor.Size = new System.Drawing.Size(143, 23);
            this.botonMejorVendedor.TabIndex = 18;
            this.botonMejorVendedor.Text = "Mejores Vendedores";
            this.botonMejorVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMejorVendedor.UseVisualStyleBackColor = true;
            this.botonMejorVendedor.Click += new System.EventHandler(this.botonMejorVendedor_Click);
            // 
            // botonMejorComprador
            // 
            this.botonMejorComprador.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.botonMejorComprador.Location = new System.Drawing.Point(180, 255);
            this.botonMejorComprador.Name = "botonMejorComprador";
            this.botonMejorComprador.Size = new System.Drawing.Size(143, 23);
            this.botonMejorComprador.TabIndex = 19;
            this.botonMejorComprador.Text = "Mejores Compradores";
            this.botonMejorComprador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMejorComprador.UseVisualStyleBackColor = true;
            this.botonMejorComprador.Click += new System.EventHandler(this.botonMejorComprador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label1.Location = new System.Drawing.Point(83, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cerrar Ventana";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Reportes.Properties.Resources.logo_cr;
            this.pictureBox3.Location = new System.Drawing.Point(12, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.botonCerrar.Image = global::Reportes.Properties.Resources.Close;
            this.botonCerrar.Location = new System.Drawing.Point(12, 324);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(162, 150);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonCerrar.TabIndex = 13;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Reportes.Properties.Resources.logo1;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(162, 150);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(238, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 42);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "PEPITO SL";
            // 
            // FormularioGeneradorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonMejorComprador);
            this.Controls.Add(this.botonMejorVendedor);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonMayoresMargenesBeneficioStock);
            this.Controls.Add(this.botonMayoresMargenesBeneficioPorcentaje);
            this.Controls.Add(this.botonMayoresMargenesBeneficioEuros);
            this.Name = "FormularioGeneradorReportes";
            this.Text = "Generador de Reportes Crystal Reports";
            this.Load += new System.EventHandler(this.FormGeneradorReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonMayoresMargenesBeneficioEuros;
        private System.Windows.Forms.Button botonMayoresMargenesBeneficioPorcentaje;
        private System.Windows.Forms.Button botonMayoresMargenesBeneficioStock;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.Button botonMejorVendedor;
        private System.Windows.Forms.Button botonMejorComprador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

