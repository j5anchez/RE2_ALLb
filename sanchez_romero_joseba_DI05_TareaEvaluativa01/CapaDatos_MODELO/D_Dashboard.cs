using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades_CONTROLADOR;

namespace CapaDatos_MODELO
{
    public class D_Dashboard
    {

        SqlConnection Conexion = new SqlConnection("Server=LAPTOP-QOH7Q921\\MSSQLSERVER2;Initial Catalog=DASHBOARD;Persist Security Info=True;User ID=di;Password=1234");
        SqlCommand cmd;
        SqlDataReader dr;
        public void ProdPorCategoria(E_Dashboard obj)
        {

            cmd = new SqlCommand("ProdPorCategoria", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Categoria1.Add(dr.GetString(0));
                obj.CantProd1.Add(dr.GetInt32(1));
            }
            dr.Close();
            Conexion.Close();
        }
        public void ProdPreferidos(E_Dashboard obj)
        {
            cmd = new SqlCommand("ProdPreferidos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Producto1.Add(dr.GetString(0));
                obj.Cant1.Add(dr.GetInt32(1));
            }
            dr.Close();
            Conexion.Close();

        }
        public void SumarioDatos(E_Dashboard obj)
        {
            cmd = new SqlCommand("Dashboard", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
          

            SqlParameter total = new SqlParameter("@totVentas", 0); total.Direction = ParameterDirection.Output;
            SqlParameter nprod = new SqlParameter("@nprod", 0); nprod.Direction = ParameterDirection.Output;
            SqlParameter nmarca = new SqlParameter("@nmarc", 0); nmarca.Direction = ParameterDirection.Output;
            SqlParameter ncategora = new SqlParameter("@ncateg", 0); ncategora.Direction = ParameterDirection.Output;
            SqlParameter ncliente = new SqlParameter("@nclient", 0); ncliente.Direction = ParameterDirection.Output;
            SqlParameter nproveedores = new SqlParameter("@nprove", 0); nproveedores.Direction = ParameterDirection.Output;
            SqlParameter nempleados = new SqlParameter("@nemple", 0); nempleados.Direction = ParameterDirection.Output;


            cmd.Parameters.Add(total);
            cmd.Parameters.Add(nprod);
            cmd.Parameters.Add(nmarca);
            cmd.Parameters.Add(ncategora);
            cmd.Parameters.Add(ncliente);
            cmd.Parameters.Add(nproveedores);
            cmd.Parameters.Add(nempleados);

            Conexion.Open();
            cmd.ExecuteNonQuery();

            obj.TotalVentas = cmd.Parameters["@totVentas"].Value.ToString();
            obj.CantCategorias1 = cmd.Parameters["@ncateg"].Value.ToString();
            obj.CantMarcas1 = cmd.Parameters["@nmarc"].Value.ToString();
            obj.CantProductos1 = cmd.Parameters["@nprod"].Value.ToString();
            obj.CantClientes1 = cmd.Parameters["@nclient"].Value.ToString();
            obj.CantEmpleados1 = cmd.Parameters["@nemple"].Value.ToString();
            obj.CantProveedores1 = cmd.Parameters["@nprove"].Value.ToString();


            Conexion.Close();

        }
    }
}
