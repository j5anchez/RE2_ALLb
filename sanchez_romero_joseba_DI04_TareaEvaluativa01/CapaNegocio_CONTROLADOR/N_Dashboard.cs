using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CapaDatos_MODELO;
using CapaEntidades_CONTROLADOR;

namespace CapaNegocio_CONTROLADOR
{
    public class N_Dashboard
    {
        public void Dashboard(E_Dashboard obj)
        {
            D_Dashboard accesDB = new D_Dashboard();
            accesDB.ProdPorCategoria(obj);
            accesDB.ProdPreferidos(obj);
            accesDB.SumarioDatos(obj);
        }
    

    }
}
