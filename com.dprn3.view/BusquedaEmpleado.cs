using System;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.view
{
    public partial class frmBusquedaEmpleado : Form
    {
        clsAltaInformacion dgv2 = new clsAltaInformacion();

        //public int string idEmpleado;

        public frmBusquedaEmpleado()
        {
            InitializeComponent();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            FillGridView_2();

            this.ttMensajesAyuda.SetToolTip(this.btnModificar, "Presiona para modificar información del empleado");
            this.ttMensajesAyuda.SetToolTip(this.btnSalir, "Finaliza Sesión");
            this.ttMensajesAyuda.SetToolTip(this.btnEliminar, "Elimina registro de un empleado");
        }


        public void FillGridView_2()
        {
            dgvDespliegaInformacionEmpleado.DataSource = dgv2.ConsultarDatosGeneralesDelEmpleado();

        }


        public void dgvDespliegaInformacionEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtLDAP.Text = dgvDespliegaInformacionEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvDespliegaInformacionEmpleado.CurrentRow.Cells[2].Value.ToString();
            txtApellidoP.Text = dgvDespliegaInformacionEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtApellidoM.Text = dgvDespliegaInformacionEmpleado.CurrentRow.Cells[4].Value.ToString();
            txtEstatus.Text = dgvDespliegaInformacionEmpleado.CurrentRow.Cells[5].Value.ToString();
            txtPerfil.Text = dgvDespliegaInformacionEmpleado.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvDespliegaInformacionEmpleado.Rows.Remove(dgvDespliegaInformacionEmpleado.CurrentRow);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(dgvDespliegaInformacionEmpleado.CurrentRow.Cells[0].Value.ToString());
            clsAltaInformacion.actualizaInformaciónEmpleado(idEmpleado, txtLDAP.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtEstatus.Text, Convert.ToInt32(txtPerfil.Text));

            //Borra ese registro del componente DataGridView = dgvDespliegaInformacionEmpleado
            dgvDespliegaInformacionEmpleado.Rows.Remove(dgvDespliegaInformacionEmpleado.CurrentRow);


            //Agrega información al componente DataGridView = dgvDespliegaInformacionEmpleado
            int rowEscribir = dgvDespliegaInformacionEmpleado.Rows.Count - 1;
            //dgvDespliegaInformacionEmpleado.Rows.Add(1);

            dgvDespliegaInformacionEmpleado.Rows[rowEscribir].Cells[1].Value = txtLDAP.Text;
            dgvDespliegaInformacionEmpleado.Rows[rowEscribir].Cells[2].Value = txtNombre.Text;
            dgvDespliegaInformacionEmpleado.Rows[rowEscribir].Cells[3].Value = txtApellidoP.Text;
            dgvDespliegaInformacionEmpleado.Rows[rowEscribir].Cells[4].Value = txtApellidoM.Text;
            dgvDespliegaInformacionEmpleado.Rows[rowEscribir].Cells[5].Value = txtEstatus.Text;
            dgvDespliegaInformacionEmpleado.Rows[rowEscribir].Cells[6].Value = txtPerfil.Text;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmBusquedaEmpleado_Load(object sender, EventArgs e)
        {

        }


    }
}
