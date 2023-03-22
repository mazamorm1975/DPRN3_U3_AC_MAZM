using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    public partial class FormularioConexionBaseDeDatos : Form
    {
        public FormularioConexionBaseDeDatos()
        {
            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {

        }




        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(conectarBase.conectarBaseDatos());
            MessageBox.Show("Conexion exitosa con la base de datos = base_test");

            AsignacionEmpleadosAProyecto asignacion = new AsignacionEmpleadosAProyecto();
            asignacion.ShowDialog();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; database=base_test;  user id=root; password=Cu213lona1973;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Close();
            Application.Exit();

        }
    }
}
