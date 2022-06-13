using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MargenEuros;
using MargenPorcentaje;
using MargenStock;
using CRMejoresClientes;
using CRMejoresVendedores;


namespace Reportes
{
    public partial class FormularioGeneradorReportes : Form
    {

        List<string> nombreColumnas = new List<string>();
        List<string> nombreTablas = new List<string>();

        public void nombresTablas()
        {
            int numeroTabla = 0;
            SqlConnection Conexion = new SqlConnection("Server=LAPTOP-QOH7Q921\\MSSQLSERVER2;Initial Catalog=DASHBOARD;Persist Security Info=True;User ID=di;Password=1234");
            SqlCommand cmdNombresTablas = new SqlCommand("NombresTablas", Conexion);
            cmdNombresTablas.CommandType = CommandType.StoredProcedure;
            using (Conexion)
            {
                Conexion.Open();
                SqlDataReader dr;

                dr = cmdNombresTablas.ExecuteReader();
                while (dr.Read())
                {
                    nombreTablas.Add(dr.GetString(0));
                    numeroTabla++;
                }
                dr.Close();
            }
            //Conexion.Close();

        }
        public void nombresColumnas()
        {
            int numeroColumna = 0;
            SqlConnection ConexionCol = new SqlConnection("Server=LAPTOP-QOH7Q921\\MSSQLSERVER2;Initial Catalog=DASHBOARD;Persist Security Info=True;User ID=di;Password=1234");
            SqlCommand cmdNombresColumnas = new SqlCommand("TablaColumna", ConexionCol);
            cmdNombresColumnas.CommandType = CommandType.StoredProcedure;
            //cmdNombresColumnas.Parameters.Add("@TABLA", SqlDbType.VarChar);
            //cmdNombresColumnas.Parameters["@TABLA"].Value = "@CLIENTES";
            using (ConexionCol)
            {
                ConexionCol.Open();
                SqlDataReader drcol;
                drcol = cmdNombresColumnas.ExecuteReader();
                while (drcol.Read())
                {
                    string nameTable = string.Empty;
                    string nameColumn = string.Empty;
                    nameTable = drcol[0].ToString();
                    nameColumn = drcol[1].ToString();
                    nombreColumnas.Add(nameTable + " " + nameColumn.ToLower());// +" " + drcol.GetString(1));
                    nameTable = string.Empty;
                    nameColumn = string.Empty;
                    numeroColumna++;
                }
                drcol.Close();
            }
            // ConexionCol.Close();

        }
        public FormularioGeneradorReportes()
        {
            InitializeComponent();
        }

        private void FormGeneradorReportes_Load(object sender, EventArgs e)
        {

        }

 

        private void botonMayoresMargenesBeneficioEuros_Click(object sender, EventArgs e)
        {
            MargenEurosProg me = new MargenEurosProg();
            me.Show();
        }

        private void botonMayoresMargenesBeneficioPorcentaje_Click(object sender, EventArgs e)
        {
            MargenPorcentajeProg mp = new MargenPorcentajeProg();
            mp.Show();
        }

        private void botonMayoresMargenesBeneficioStock_Click(object sender, EventArgs e)
        {
            MargenStockProg ms = new MargenStockProg();
            ms.Show();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //Close();
            FormularioGeneradorReportes.ActiveForm.Close();
        }

    

        private void botonMejorComprador_Click(object sender, EventArgs e)
        {
            MejoresClientes mejoresClientes = new MejoresClientes();
            mejoresClientes.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void botonMejorVendedor_Click(object sender, EventArgs e)
        {
            MejoresVendedores mejoresVendedores = new MejoresVendedores();
            mejoresVendedores.Show();
        }
    }
}
