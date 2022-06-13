using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appReportViewerMasInstalador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.dataSet1.CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.MargenPorcentaje' Puede moverla o quitarla según sea necesario.
            this.margenPorcentajeTableAdapter.Fill(this.dataSet2.MargenPorcentaje);
        

        }

   
    }
}
