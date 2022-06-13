using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string CustomerID="FOLKO";
            SqlCommand command;

            // Objeto para elctura de datos
            SqlDataReader dataReader;
            List<string> listaClientes2 = new List<string>();
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-QOH7Q921\\MSSQLSERVER2;Initial Catalog=Northwind;User ID=di;Password=1234");


                string customerID = string.Empty;
                string companyName = string.Empty;
                conexion.Open();
                String consultaSQL = "select * from orders where CustomerID = '"+CustomerID+"'";
                command = new SqlCommand(consultaSQL, conexion);

                dataReader = command.ExecuteReader();
            string respuesta = string.Empty;
                while (dataReader.Read())
                {
                    respuesta+=(dataReader.GetString(1)+" " +dataReader.GetInt32(2).ToString()+"\n");
                }

                dataReader.Close();
                command.Dispose();
            MessageBox.Show(respuesta);

        
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

        }
    }
}
