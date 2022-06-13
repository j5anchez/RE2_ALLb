namespace CapaPresentacion_VISTA
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartProdxCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProdPreferidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantMarcas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantCateg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantProd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCantClient = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCantEmple = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCantProve = new System.Windows.Forms.Label();
            this.tlpGrafico = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.botonProductosPorCategoria = new System.Windows.Forms.Button();
            this.botonTop5Vendidos = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.botonCrystalReports = new System.Windows.Forms.Button();
            this.tlpBotonesGrafico = new System.Windows.Forms.TableLayoutPanel();
            this.botonReportViewer = new System.Windows.Forms.Button();
            this.botonReiniciar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdxCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPreferidos)).BeginInit();
            this.tlpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tlpBotonesGrafico.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartProdxCategoria
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.Name = "ChartArea1";
            this.chartProdxCategoria.ChartAreas.Add(chartArea3);
            this.chartProdxCategoria.Location = new System.Drawing.Point(3, 3);
            this.chartProdxCategoria.Name = "chartProdxCategoria";
            this.chartProdxCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Color = System.Drawing.Color.HotPink;
            series3.IsValueShownAsLabel = true;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Transparent;
            series3.Name = "Series1";
            this.chartProdxCategoria.Series.Add(series3);
            this.chartProdxCategoria.Size = new System.Drawing.Size(805, 485);
            this.chartProdxCategoria.TabIndex = 0;
            this.chartProdxCategoria.Text = "chart1";
            title3.Name = "CantProdxCateg";
            title3.Text = "Cantidad de productos por categoria";
            this.chartProdxCategoria.Titles.Add(title3);
            this.chartProdxCategoria.Visible = false;
            // 
            // chartProdPreferidos
            // 
            chartArea4.Name = "ChartArea1";
            this.chartProdPreferidos.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.chartProdPreferidos.Legends.Add(legend2);
            this.chartProdPreferidos.Location = new System.Drawing.Point(214, 127);
            this.chartProdPreferidos.Name = "chartProdPreferidos";
            this.chartProdPreferidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartProdPreferidos.Series.Add(series4);
            this.chartProdPreferidos.Size = new System.Drawing.Size(808, 491);
            this.chartProdPreferidos.TabIndex = 1;
            this.chartProdPreferidos.Text = "chart2";
            title4.IsDockedInsideChartArea = false;
            title4.Name = "Title1";
            title4.Text = "Top 5 productos mas vendidos";
            this.chartProdPreferidos.Titles.Add(title4);
            this.chartProdPreferidos.Visible = false;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(86, 89);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(57, 20);
            this.lblTotalVentas.TabIndex = 4;
            this.lblTotalVentas.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marcas";
            // 
            // lblCantMarcas
            // 
            this.lblCantMarcas.AutoSize = true;
            this.lblCantMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMarcas.Location = new System.Drawing.Point(519, 89);
            this.lblCantMarcas.Name = "lblCantMarcas";
            this.lblCantMarcas.Size = new System.Drawing.Size(57, 20);
            this.lblCantMarcas.TabIndex = 8;
            this.lblCantMarcas.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Categorias";
            // 
            // lblCantCateg
            // 
            this.lblCantCateg.AutoSize = true;
            this.lblCantCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCateg.Location = new System.Drawing.Point(376, 87);
            this.lblCantCateg.Name = "lblCantCateg";
            this.lblCantCateg.Size = new System.Drawing.Size(57, 20);
            this.lblCantCateg.TabIndex = 12;
            this.lblCantCateg.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Productos";
            // 
            // lblCantProd
            // 
            this.lblCantProd.AutoSize = true;
            this.lblCantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantProd.Location = new System.Drawing.Point(230, 89);
            this.lblCantProd.Name = "lblCantProd";
            this.lblCantProd.Size = new System.Drawing.Size(57, 20);
            this.lblCantProd.TabIndex = 16;
            this.lblCantProd.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Clientes";
            // 
            // lblCantClient
            // 
            this.lblCantClient.AutoSize = true;
            this.lblCantClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClient.Location = new System.Drawing.Point(666, 87);
            this.lblCantClient.Name = "lblCantClient";
            this.lblCantClient.Size = new System.Drawing.Size(57, 20);
            this.lblCantClient.TabIndex = 20;
            this.lblCantClient.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(802, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Empleados";
            // 
            // lblCantEmple
            // 
            this.lblCantEmple.AutoSize = true;
            this.lblCantEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantEmple.Location = new System.Drawing.Point(801, 85);
            this.lblCantEmple.Name = "lblCantEmple";
            this.lblCantEmple.Size = new System.Drawing.Size(57, 20);
            this.lblCantEmple.TabIndex = 24;
            this.lblCantEmple.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(954, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Proveedores";
            // 
            // lblCantProve
            // 
            this.lblCantProve.AutoSize = true;
            this.lblCantProve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantProve.Location = new System.Drawing.Point(953, 85);
            this.lblCantProve.Name = "lblCantProve";
            this.lblCantProve.Size = new System.Drawing.Size(57, 20);
            this.lblCantProve.TabIndex = 28;
            this.lblCantProve.Text = "label1";
            // 
            // tlpGrafico
            // 
            this.tlpGrafico.ColumnCount = 1;
            this.tlpGrafico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tlpGrafico.Controls.Add(this.chartProdxCategoria, 0, 0);
            this.tlpGrafico.Location = new System.Drawing.Point(214, 127);
            this.tlpGrafico.Name = "tlpGrafico";
            this.tlpGrafico.RowCount = 1;
            this.tlpGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 491F));
            this.tlpGrafico.Size = new System.Drawing.Size(811, 491);
            this.tlpGrafico.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::CapaPresentacion_VISTA.Properties.Resources.iconobolsa3;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 75);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox13.Image = global::CapaPresentacion_VISTA.Properties.Resources.iconobolsa3;
            this.pictureBox13.Location = new System.Drawing.Point(878, 12);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(70, 70);
            this.pictureBox13.TabIndex = 27;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Location = new System.Drawing.Point(892, 46);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(130, 75);
            this.pictureBox14.TabIndex = 26;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox11.Image = global::CapaPresentacion_VISTA.Properties.Resources.iconobolsa3;
            this.pictureBox11.Location = new System.Drawing.Point(733, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(70, 70);
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox12.Location = new System.Drawing.Point(742, 46);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(130, 75);
            this.pictureBox12.TabIndex = 22;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox9.Image = global::CapaPresentacion_VISTA.Properties.Resources.iconobolsa3;
            this.pictureBox9.Location = new System.Drawing.Point(593, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(70, 70);
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Location = new System.Drawing.Point(606, 46);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(130, 75);
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.Image = global::CapaPresentacion_VISTA.Properties.Resources.iconobolsa3;
            this.pictureBox7.Location = new System.Drawing.Point(156, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 70);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(169, 46);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(130, 75);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Image = global::CapaPresentacion_VISTA.Properties.Resources.iconobolsa3;
            this.pictureBox5.Location = new System.Drawing.Point(305, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 70);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(314, 46);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 75);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = global::CapaPresentacion_VISTA.Properties.Resources.iconobolsa3;
            this.pictureBox3.Location = new System.Drawing.Point(450, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(457, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 75);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // botonProductosPorCategoria
            // 
            this.botonProductosPorCategoria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botonProductosPorCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonProductosPorCategoria.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProductosPorCategoria.Location = new System.Drawing.Point(3, 3);
            this.botonProductosPorCategoria.Name = "botonProductosPorCategoria";
            this.botonProductosPorCategoria.Size = new System.Drawing.Size(198, 64);
            this.botonProductosPorCategoria.TabIndex = 30;
            this.botonProductosPorCategoria.Text = "Productos por categoria";
            this.botonProductosPorCategoria.UseVisualStyleBackColor = false;
            this.botonProductosPorCategoria.Click += new System.EventHandler(this.botonProductosPorCategoria_Click);
            // 
            // botonTop5Vendidos
            // 
            this.botonTop5Vendidos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botonTop5Vendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonTop5Vendidos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonTop5Vendidos.Location = new System.Drawing.Point(3, 73);
            this.botonTop5Vendidos.Name = "botonTop5Vendidos";
            this.botonTop5Vendidos.Size = new System.Drawing.Size(198, 65);
            this.botonTop5Vendidos.TabIndex = 30;
            this.botonTop5Vendidos.Text = "Top 5 productos mas vendidos";
            this.botonTop5Vendidos.UseVisualStyleBackColor = false;
            this.botonTop5Vendidos.Click += new System.EventHandler(this.botonTop5Vendidos_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botonBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonBorrar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.Location = new System.Drawing.Point(3, 144);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(198, 36);
            this.botonBorrar.TabIndex = 31;
            this.botonBorrar.Text = "BORRAR";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // botonCrystalReports
            // 
            this.botonCrystalReports.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botonCrystalReports.BackgroundImage = global::CapaPresentacion_VISTA.Properties.Resources.images;
            this.botonCrystalReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonCrystalReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonCrystalReports.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrystalReports.ForeColor = System.Drawing.Color.Chocolate;
            this.botonCrystalReports.Location = new System.Drawing.Point(3, 186);
            this.botonCrystalReports.Name = "botonCrystalReports";
            this.botonCrystalReports.Size = new System.Drawing.Size(198, 97);
            this.botonCrystalReports.TabIndex = 32;
            this.botonCrystalReports.UseVisualStyleBackColor = false;
            this.botonCrystalReports.Click += new System.EventHandler(this.botonCrystalReports_Click);
            // 
            // tlpBotonesGrafico
            // 
            this.tlpBotonesGrafico.ColumnCount = 1;
            this.tlpBotonesGrafico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotonesGrafico.Controls.Add(this.botonSalir, 0, 6);
            this.tlpBotonesGrafico.Controls.Add(this.botonReiniciar, 0, 5);
            this.tlpBotonesGrafico.Controls.Add(this.botonReportViewer, 0, 4);
            this.tlpBotonesGrafico.Controls.Add(this.botonCrystalReports, 0, 3);
            this.tlpBotonesGrafico.Controls.Add(this.botonBorrar, 0, 2);
            this.tlpBotonesGrafico.Controls.Add(this.botonTop5Vendidos, 0, 1);
            this.tlpBotonesGrafico.Controls.Add(this.botonProductosPorCategoria, 0, 0);
            this.tlpBotonesGrafico.Location = new System.Drawing.Point(4, 130);
            this.tlpBotonesGrafico.Name = "tlpBotonesGrafico";
            this.tlpBotonesGrafico.RowCount = 7;
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4898F));
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.89796F));
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.69388F));
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.91837F));
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpBotonesGrafico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpBotonesGrafico.Size = new System.Drawing.Size(204, 500);
            this.tlpBotonesGrafico.TabIndex = 31;
            // 
            // botonReportViewer
            // 
            this.botonReportViewer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botonReportViewer.BackgroundImage = global::CapaPresentacion_VISTA.Properties.Resources.rvlogo;
            this.botonReportViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonReportViewer.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReportViewer.ForeColor = System.Drawing.Color.Chocolate;
            this.botonReportViewer.Location = new System.Drawing.Point(3, 289);
            this.botonReportViewer.Name = "botonReportViewer";
            this.botonReportViewer.Size = new System.Drawing.Size(198, 102);
            this.botonReportViewer.TabIndex = 38;
            this.botonReportViewer.UseVisualStyleBackColor = false;
            this.botonReportViewer.Click += new System.EventHandler(this.botonReportViewer_Click);
            // 
            // botonReiniciar
            // 
            this.botonReiniciar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botonReiniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonReiniciar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReiniciar.ForeColor = System.Drawing.Color.Black;
            this.botonReiniciar.Location = new System.Drawing.Point(3, 397);
            this.botonReiniciar.Name = "botonReiniciar";
            this.botonReiniciar.Size = new System.Drawing.Size(198, 41);
            this.botonReiniciar.TabIndex = 45;
            this.botonReiniciar.Text = "Reiniciar";
            this.botonReiniciar.UseVisualStyleBackColor = false;
            this.botonReiniciar.Click += new System.EventHandler(this.botonReiniciar_Click_1);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.botonSalir.BackgroundImage = global::CapaPresentacion_VISTA.Properties.Resources.Exit;
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonSalir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.Color.Chocolate;
            this.botonSalir.Location = new System.Drawing.Point(3, 444);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(198, 53);
            this.botonSalir.TabIndex = 46;
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1034, 642);
            this.Controls.Add(this.chartProdPreferidos);
            this.Controls.Add(this.tlpGrafico);
            this.Controls.Add(this.tlpBotonesGrafico);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCantProve);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCantEmple);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCantClient);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCantProd);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCantCateg);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantMarcas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "CapaPresentacion_VISTA Pepito SL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdxCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPreferidos)).EndInit();
            this.tlpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tlpBotonesGrafico.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdxCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdPreferidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantMarcas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantCateg;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantProd;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCantClient;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCantEmple;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCantProve;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.TableLayoutPanel tlpGrafico;
        private System.Windows.Forms.Button botonProductosPorCategoria;
        private System.Windows.Forms.Button botonTop5Vendidos;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Button botonCrystalReports;
        private System.Windows.Forms.TableLayoutPanel tlpBotonesGrafico;
        private System.Windows.Forms.Button botonReiniciar;
        private System.Windows.Forms.Button botonReportViewer;
        private System.Windows.Forms.Button botonSalir;
    }
}

