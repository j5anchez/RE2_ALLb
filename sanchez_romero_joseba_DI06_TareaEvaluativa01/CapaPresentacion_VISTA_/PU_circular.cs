using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion_VISTA
{
    public partial class PU_circular : Form
    {
        public PU_circular()
        {
            InitializeComponent();
        }

        private void boton_CerrarPU_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
