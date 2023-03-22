using DPRNIII_U2_A1_MAZM.com.dprn3.view;
using System;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    public partial class frmDatosEmpleados : Form
    {
        clsAltaInformacion nuevoIngreso = new clsAltaInformacion();
        public static string dato;

        public frmDatosEmpleados()
        {
            InitializeComponent();
        }

        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            dato = cboPerfil.Text;

            if (cboPerfil.SelectedItem.Equals(dato))
            {
                FillGridView();

            }
            else
            {
                MessageBox.Show("Ese perfil no es existente en la base de datos");
            }
        }

        private void DatosEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void FillGridView()
        {
            dgvRolEmpleado.DataSource = nuevoIngreso.ConsultarDatosEmpleado();

            //dgvRolEmpleado.Columns[0].Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String idEmpleado = txtIDEmpleado.Text;
            String nombreEmpleado = txtNombre_Empleado.Text;
            String apellidoPaterno = txtApellido__Paterno_Empleado.Text;
            String apellidoMaterno = txtApellido_Materno_Empleado.Text;
            String status = "A";
            int perfilEmpleado = Convert.ToInt32(cboPerfil.Text);

            try
            {
                clsAltaInformacion.insertarDatosEmpleado(idEmpleado, nombreEmpleado, apellidoPaterno, apellidoMaterno, Convert.ToChar(status), perfilEmpleado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpleado ubicaEmpleado = new frmBusquedaEmpleado();
            ubicaEmpleado.Show();
        }
    }
}
