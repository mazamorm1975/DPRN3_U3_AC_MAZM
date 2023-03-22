using DPRNIII_U2_A1_MAZM.com.dprn3.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.view
{
    public partial class TablasDataGridView : Form
    {
        public List<DatosDataGridView> datosDGV = new List<DatosDataGridView>();


        public TablasDataGridView()
        {
            InitializeComponent();
        }

        private void TablasDataGridView_Load(object sender, EventArgs e)
        {
            foreach (var dato in datosDGV)
            {
                dataGridView1.Rows.Add(
                    dato.idEmpleado_Proyecto,
                    dato.idEmpleado,
                    dato.idProyecto,
                    dato.asignado,
                    dato.Comentarios
                    );
            }

        }
    }
}
