using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.view
{
    public partial class Listados : Form
    {
        clsAltaInformacion listadosMiscelaneous = new clsAltaInformacion();

        public Listados()
        {
            InitializeComponent();

                      
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillGridViewRezagados()
        {
            dgvProyectosFueraTiempo.DataSource = listadosMiscelaneous.ConsultarProyectosRezagados();
        }

        
        private void Listados_Load(object sender, EventArgs e)
        {

        }

        private void btnRezagados_Click(object sender, EventArgs e)
        {
            FillGridViewRezagados();
        }

        private void btnFiltroProyectos_Click(object sender, EventArgs e)
        {
            //FillGridViewPersonalAsignadoPorProyecto();
            
        }
    }
}
