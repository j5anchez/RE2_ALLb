using System;
using System.Windows.Forms;
using CapaNegocio_CONTROLADOR;
using CapaEntidades_CONTROLADOR;
using System.Windows.Forms.DataVisualization.Charting;
using Reportes;
namespace CapaPresentacion_VISTA
{
    public partial class Form1 : Form
    {
        PU_circular pu_circular = new PU_circular();
        FormularioGeneradorReportes formreports = new FormularioGeneradorReportes();
        private TableLayoutPanel tlp;
        private Chart grafico1;
        private Chart grafico2;

        public Form1()
        {
            InitializeComponent();
            tlp = tlpGrafico;
            grafico1 = chartProdxCategoria;
            grafico2 = chartProdPreferidos;
            tlp.Controls.Remove(grafico2);
            tlp.Controls.Remove(grafico1);
            ttMensaje.SetToolTip(botonTop5Vendidos, "Clic aqui para ver el top 5 de los productos mas vendidos en un grafico circular");
            ttMensaje.SetToolTip(botonProductosPorCategoria, "Clic aqui para ver el numero de productos por categoria en un histograma");
            ttMensaje.SetToolTip(botonBorrar, "Clic aqui para quitar el grafico activo");
            ttMensaje.SetToolTip(botonCrystalReports, "Clic aqui para ver los informes en Crystal Reports");
            ttMensaje.SetToolTip(botonReportViewer, "Clic aqui para ver los informes en Report Viewer");
            ttMensaje.SetToolTip(botonReiniciar, "Clic aqui para reiniciar el programa");
            ttMensaje.SetToolTip(botonSalir, "Clic aqui para salir del programa");
            ttMensaje.SetToolTip(pictureBox1, "Numero total de ventas");
            ttMensaje.SetToolTip(pictureBox8, "Numero de productos");
            ttMensaje.SetToolTip(pictureBox6, "Numero de categorias");
            ttMensaje.SetToolTip(pictureBox4, "Numero de marcas");
            ttMensaje.SetToolTip(pictureBox10, "Numero de clientes");
            ttMensaje.SetToolTip(pictureBox12, "Numero de empleados");
            ttMensaje.SetToolTip(pictureBox14, "Numero de proveedores");


        }
        private void botonProductosPorCategoria_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(grafico2);
            tlp.Controls.Remove(grafico1);
            tlp.Controls.Add(grafico1, 0, 0);
            grafico1.Visible = true;
            grafico2.Visible = false;

        }
        private void botonTop5Vendidos_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(grafico2);
            tlp.Controls.Remove(grafico1);
            tlp.Controls.Add(grafico2, 0, 0);
            grafico2.Visible = true;
            grafico1.Visible = false;
            pu_circular.ShowDialog();
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(grafico2);
            tlp.Controls.Remove(grafico1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Dashboard();
        }


        private void Dashboard()
        {
            N_Dashboard neg = new N_Dashboard();
            E_Dashboard obj = new E_Dashboard();
            neg.Dashboard(obj);

            // recuperar datos de la entidad para cargar los datos del dashboard
            chartProdPreferidos.Series[0].Points.DataBindXY(obj.Producto1, obj.Cant1);
            chartProdxCategoria.Series[0].Points.DataBindXY(obj.Categoria1, obj.CantProd1);
            lblCantCateg.Text = obj.CantCategorias1;
            lblCantProd.Text = obj.CantProductos1;
            lblCantClient.Text = obj.CantClientes1;
            lblCantEmple.Text = obj.CantEmpleados1;
            lblCantMarcas.Text = obj.CantMarcas1;
            lblCantProve.Text = obj.CantProveedores1;
            lblTotalVentas.Text = obj.TotalVentas;
        }

        private void botonCrystalReports_Click(object sender, EventArgs e)
        {
            formreports.ShowDialog();
        }



        private void botonReportViewer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\..\ReportViewer\Report_Viewer.exe");
        }

        private void botonReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\..\..\CHMhelpers\ficheroschm.chm");
        }
    }
}
