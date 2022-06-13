using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CapaEntidades_CONTROLADOR
{

 
    public class E_Dashboard
    {


        ArrayList Categoria = new ArrayList();
        ArrayList CantProd = new ArrayList();
        ArrayList Producto = new ArrayList();
        ArrayList Cant = new ArrayList();

        string totalVentas;
        string CantCategorias;
        string CantMarcas;
        string CantProductos;
        string CantClientes;
        string CantEmpleados;
        string CantProveedores;

        public ArrayList Categoria1 { get => Categoria; set => Categoria = value; }
        public ArrayList CantProd1 { get => CantProd; set => CantProd = value; }
        public ArrayList Producto1 { get => Producto; set => Producto = value; }
        public ArrayList Cant1 { get => Cant; set => Cant = value; }
        public string TotalVentas { get => totalVentas; set => totalVentas = value; }
        public string CantCategorias1 { get => CantCategorias; set => CantCategorias = value; }
        public string CantMarcas1 { get => CantMarcas; set => CantMarcas = value; }
        public string CantProductos1 { get => CantProductos; set => CantProductos = value; }
        public string CantClientes1 { get => CantClientes; set => CantClientes = value; }
        public string CantEmpleados1 { get => CantEmpleados; set => CantEmpleados = value; }
        public string CantProveedores1 { get => CantProveedores; set => CantProveedores = value; }
    }

 
}
