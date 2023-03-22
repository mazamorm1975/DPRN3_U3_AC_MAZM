using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using DPRNIII_U2_A1_MAZM.com.dprn3.model;
using DPRNIII_U2_A1_MAZM.com.dprn3.view;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    class clsAltaInformacion
    {
        protected internal DataTable Tabla;
        protected MySqlDataAdapter buscar;
        public static int result;
        public static int noRows;

        //Consultar tipo y rol del empleado   
        public DataTable ConsultarDatosGeneralesDelEmpleado()
        {

            Tabla = new DataTable();

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT * FROM tb_empleado";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }


        //Metodo que filtra los proyectos por vencer a partir de la fecha establecida por el usuario
        public DataTable consultaProyectosPorFinalizar(DateTime fechaInicial, DateTime fechaLimite)
        {
            Tabla = new DataTable();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String filtradoProyectos = "SELECT * FROM tb_proyecto WHERE fecha_terminacion BETWEEN '" + fechaInicial.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + fechaLimite.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                buscar = new MySqlDataAdapter(filtradoProyectos, conn);
                buscar.Fill(Tabla);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Tabla;

        }

        //Listado de proyectos finalizados por mes
        public DataTable consultaProyectosFinalizadosPorMes(int mes)
        {
            Tabla = new DataTable();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String filtradoProyectos = "SELECT * FROM tb_proyecto WHERE fecha_final != '0000-00_00 00:00:00' AND (SELECT MONTH(fecha_final) = '"+mes+"') ORDER BY id_proyecto;";
                buscar = new MySqlDataAdapter(filtradoProyectos, conn);
                buscar.Fill(Tabla);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Tabla;

        }



        //Consultar tipo y rol del empleado   
        public DataTable ConsultarDatosProyecto()
        {

            Tabla = new DataTable();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT * FROM tb_proyecto";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Tabla;
        }

        //Consultar tipo y rol del empleado   
        public DataTable ConsultarDatosEmpleado()
        {

            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT tipo, rol FROM tb_perfil WHERE id_perfil =" + Convert.ToInt32(perfil) + ";";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }


        //Consultar cantidad de desarrolladores   
        public int MatrixToFilterProgrammersOnly()
        {
            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT idEmpleado FROM empleado_proyecto INNER JOIN tb_empleado ON empleado_proyecto.idEmpleado = tb_empleado.ldap_empleado WHERE tb_empleado.tb_perfil_id_perfil > 4 AND tb_empleado.tb_perfil_id_perfil < 9 AND empleado_proyecto.idProyecto = '" + frmAsignacionProyectos.idProyecto + "';";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
                noRows = Tabla.Rows.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return noRows;
        }

        //Consultar cantidad de Lideres de proyecto   
        public int MatrixToFilterProjectLeadersOnly()
        {
            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT idEmpleado FROM empleado_proyecto INNER JOIN tb_empleado ON empleado_proyecto.idEmpleado = tb_empleado.ldap_empleado WHERE tb_empleado.tb_perfil_id_perfil > 8 AND tb_empleado.tb_perfil_id_perfil < 13 AND empleado_proyecto.idProyecto = '" + frmAsignacionProyectos.idProyecto + "';";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
                noRows = Tabla.Rows.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return noRows;
        }

        //Consultar cantidad de analistas en un proyecto   
        public int MatrixToFilterAnalystOnly()
        {
            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT idEmpleado FROM empleado_proyecto INNER JOIN tb_empleado ON empleado_proyecto.idEmpleado = tb_empleado.ldap_empleado WHERE tb_empleado.tb_perfil_id_perfil > 0 AND tb_empleado.tb_perfil_id_perfil < 5 AND empleado_proyecto.idProyecto = '" + frmAsignacionProyectos.idProyecto + "';";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
                noRows = Tabla.Rows.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return noRows;
        }


        //Cuenta total de registros de la tabla empleado_proyecto
        public static int contarTotalRegistrosEmpleadosAsignados()
        {
            MySqlConnection contar = null;
            contar = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM empleado_proyecto", contar);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        //Se comparan fechas para validar que la fecha de inicio NUNCA sea mayor a la fecha final
        public static bool IsStartDateLessOrEqualsToFinishDate(DateTime fechaInicial, DateTime fechaFinal)
        {
            if (fechaInicial <= fechaFinal)
            {
               return true;
            }
            return false;
        }

        public static bool isDateValid(string fechaInicial, string fechaFinal)
        {
            DateTime temp, temp2;
            if (DateTime.TryParse(fechaInicial, out temp) && DateTime.TryParse(fechaFinal, out temp2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Valida si la fecha ingresada es menor a la fecha actual
        public static bool isDateBeforeToday(DateTime fechaInicial)
        {
            if (fechaInicial.Date > DateTime.Today)
            {
                return false;
            }

            return true;
        }

       //Extra el año de la fecha de finalizacion de proyecto ingresada por el usuario
       public static int getYearOfGivenDate(DateTime fechaFin)
        {
            DateTime test = Convert.ToDateTime(fechaFin);
            int anio = test.Year;
            return anio;    
        }

        //Valida si se puede realizar la asignacion acorde a las reglas del negocio
        public static int isAssigned()
        {
            MySqlConnection conn = null;
            //Valida conexion con base de datos: base_test
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT asignado FROM empleado_proyecto WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'", conn);
            int result = (int)cmd.ExecuteScalar();

            return result;
        }





        public static void actualizaStatus(string noEmp)
        {
            //Se valida si se sacara a este empleado del proyecto actual
            if (clsAltaInformacion.isAssigned() == 1 && frmAsignacionProyectos.isAsignacion == 0)
            {
                clsAltaInformacion.actualizaInformaciónProyecto();

            }
        }


        //Ubica si el empleado existe en la tabla:tb_empleado_proyecto
        public static Boolean ubicaEmpleado()
        {
            MySqlConnection conn = null;
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT idEmpleado FROM empleado_proyecto WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'", conn);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                reg["idEmpleado"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }


        //Valida si el id_proyecto de la tabla: tb_proyecto tiene o no fecha_final
        public static string fechaFinalExist()
        {
            MySqlConnection conn = null;
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT fecha_final FROM tb_proyecto WHERE nombre = '" + frmAsignacionProyectos.idProyecto + "'", conn);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["fecha_final"].ToString();
            }
            else
            {
                return null;
            }
        }

        //Verifica si el perfil del empleado es de programador y arroja true o false
        public static Boolean ValidaSiesRolDeProgramador()
        {
            MySqlConnection connection = null;
            connection = conectarBase.conectarBaseDatos();
            MySqlCommand command = new MySqlCommand("SELECT tb_perfil_id_perfil FROM tb_empleado WHERE tb_perfil_id_perfil > 4 AND tb_perfil_id_perfil < 9 AND ldap_empleado ='" + frmAsignacionProyectos.noEmpleado + "' ", connection);
            MySqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                /*En caso de requerir que se devuelva el perfil del empleado se tendra que poner
                (int)lector["tb_perfil_id_perfil"];*/
                return true;
            }

            return false;
        }


        //Verifica si el perfil del empleado es de lider de proyecto y arroja true o false
        public static Boolean ValidaSiesRolDeLiderDeProyecto()
        {
            MySqlConnection connection = null;
            connection = conectarBase.conectarBaseDatos();
            MySqlCommand command = new MySqlCommand("SELECT tb_perfil_id_perfil FROM tb_empleado WHERE tb_perfil_id_perfil > 8 AND tb_perfil_id_perfil < 13 AND ldap_empleado ='" + frmAsignacionProyectos.noEmpleado + "' ", connection);
            MySqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                /*En caso de requerir que se devuelva el perfil del empleado se tendra que poner
                (int)lector["tb_perfil_id_perfil"];*/
                return true;
            }

            return false;
        }


        //Verifica si el perfil del empleado es Analista y arroja true o false
        public static Boolean ValidaSiesRolDeAnalista()
        {
            MySqlConnection connection = null;
            connection = conectarBase.conectarBaseDatos();
            MySqlCommand command = new MySqlCommand("SELECT tb_perfil_id_perfil FROM tb_empleado WHERE tb_perfil_id_perfil > 0 AND tb_perfil_id_perfil < 5 AND ldap_empleado ='" + frmAsignacionProyectos.noEmpleado + "' ", connection);
            MySqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                /*En caso de requerir que se devuelva el perfil del empleado se tendra que poner
                (int)lector["tb_perfil_id_perfil"];*/
                return true;
            }

            return false;
        }


        //Verifica si el numero de empleado esta tomando parte activa en el proyecto
        public static string isIncludedIntoProject()
        {
            MySqlConnection conn = null;
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand comando = new MySqlCommand("SELECT idEmpleado FROM empleado_proyecto WHERE idProyecto='" + frmAsignacionProyectos.idProyecto + "'", conn);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                return reader["idEmpleado"].ToString();
            }

            return " ";
        }


        //Actualiza status del proyecto
        public static void actualizaInformaciónProyecto()
        {
            MySqlConnection connUpdate = null;
            connUpdate = conectarBase.conectarBaseDatos();
            MySqlCommand dataAdapter = new MySqlCommand();
            dataAdapter = new MySqlCommand("UPDATE empleado_proyecto SET asignado = '" + frmAsignacionProyectos.asignacionEmpleado + "', Comentarios = '" + frmAsignacionProyectos.comentarios + "', idProyecto = '" + frmAsignacionProyectos.idProyecto + "' WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'", connUpdate);
            dataAdapter.ExecuteNonQuery();
            Notificacion mensajeOffProject = new Notificacion(new NotificacionGuardar());
            mensajeOffProject.MostrarMensaje();
        }

        //Actualiza datos del empleado
        public static void actualizaInformaciónEmpleado(int idEmpleado, string ldapEmpleado, string nombre, string apellidoP, string apellidoM, string status, int perfil)
        {
            MySqlConnection connUpdate = null;
            connUpdate = conectarBase.conectarBaseDatos();
            MySqlCommand dataAdapter = new MySqlCommand();
            dataAdapter = new MySqlCommand("UPDATE tb_empleado SET ldap_empleado = '" + ldapEmpleado + "', nombre = '" + nombre + "', apellido_paterno = '" + apellidoP + "', apellido_materno = '" + apellidoM + "',Estatus='" + status + "', tb_perfil_id_perfil = '" + perfil + "' WHERE id_empleado = '" + idEmpleado + "'", connUpdate);
            dataAdapter.ExecuteNonQuery();
            Notificacion mensajeOffProject = new Notificacion(new NotificacionGuardar());
            mensajeOffProject.MostrarMensaje();
        }

        //Actualiza datos del empleado
        public static void actualizaProyecto(int idProyecto, string nombre, string descripcion, DateTime fechaInicial, DateTime fechaFinal, int estatus, int departamento)
        {
            MySqlConnection connUpdate = null;
            connUpdate = conectarBase.conectarBaseDatos();

            BusquedaPorIdProyecto busqueda = new BusquedaPorIdProyecto();

            if (BusquedaPorIdProyecto.fechaAuxiliar != " ")
            {
                MySqlCommand dataAdapter2 = new MySqlCommand();
                dataAdapter2 = new MySqlCommand("UPDATE tb_proyecto SET nombre = '" + nombre + "', descripcion = '" + descripcion + "', fecha_inicio='" + fechaInicial.ToString("yyyy-MM-dd HH:mm:ss") + "', fecha_final='" + fechaFinal.ToString("yyyy-MM-dd HH:mm:ss") + "', comentarios='Concluido' , estatus ='" + estatus + "', id_departamento = '" + departamento + "' WHERE id_proyecto ='" + idProyecto + "' ", connUpdate);
                dataAdapter2.ExecuteNonQuery();

                //Despliega notificación de guardado exitoso
                Notificacion mensajeOffProject = new Notificacion(new NotificacionGuardar());
                mensajeOffProject.MostrarMensaje();

            }
            else if (BusquedaPorIdProyecto.fechaAuxiliar == " ")
            {
                MySqlCommand dataAdapter = new MySqlCommand();
                dataAdapter = new MySqlCommand("UPDATE tb_proyecto SET nombre = '" + nombre + "', descripcion = '" + descripcion + "', fecha_inicio ='" + fechaInicial.ToString("yyyy-MM-dd HH:mm:ss") + "', comentarios= 'Disponible', fecha_final =null , estatus ='" + estatus + "', id_departamento = '" + departamento + "' WHERE id_proyecto ='" + idProyecto + "' ", connUpdate);
                dataAdapter.ExecuteNonQuery();

                //Despliega notificación de guardado exitoso
                Notificacion mensajeOffProject = new Notificacion(new NotificacionGuardar());
                mensajeOffProject.MostrarMensaje();
            }
        }


        public static int desfaseDiasTerminacion(DateTime  y, DateTime x)
        {
            TimeSpan difDiasProyectoTerminado = y - x;

            return (int)difDiasProyectoTerminado.TotalDays;
        }


        //Actualiza status del proyecto
        public static void remueveEmpleadoDeProyecto(String noEmpleado)
        {
            MySqlConnection connUpdate = null;
            connUpdate = conectarBase.conectarBaseDatos();
            MySqlCommand dataAdapter = new MySqlCommand();
            dataAdapter = new MySqlCommand("DELETE FROM empleado_proyecto WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'", connUpdate);
            dataAdapter.ExecuteNonQuery();
        }




        //Consultar Departamentos   
        public DataTable ConsultarDatosDepartamento()
        {

            Tabla = new DataTable();


            //Ingresar informacion a base de datos

            string depto = IngresoProyecto.datoProyecto;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password =Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT nombre_depto, sede FROM tb_departamento WHERE id_departamento =" + Convert.ToInt32(depto) + ";";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }

        //Consulta proyectos asignados a los empleados   
        public DataTable ConsultarProyecto_Empleado()
        {
            //Se crea objeto de tipo DataTable
            Tabla = new DataTable();

            //Ingresar informacion a base de datos
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password =Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                string consulta = "SELECT * FROM empleado_proyecto;";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }



        //Metodo que ingresa la información a una base de datos
        public static Boolean insertarDatosEmpleado(String idEmpleado, String nombreEmpleado, String apellidoPaterno, String apellidoMaterno, Char status, int perfil)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO tb_empleado SET ldap_empleado='" + idEmpleado + "' ,nombre='" + nombreEmpleado + "' , apellido_paterno='" + apellidoPaterno + "', apellido_materno='" + apellidoMaterno + "', estatus='" + status + "', tb_perfil_id_perfil='" + perfil + "'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();
                MessageBox.Show("Información Ingresada exitosamente");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        //Metodo que ingresa la información a una base de datos
        public static Boolean insertarDatosProyecto(String nombre, String descripcion, DateTime fechaI, int status, int idDepto, DateTime fechaTermino)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO tb_proyecto SET nombre='" + nombre + "' , descripcion='" + descripcion + "', fecha_inicio='" + fechaI.ToString("yyyy-MM-dd HH:mm:ss") + "' , fecha_final=null, estatus='" + status + "', id_departamento='" + idDepto + "', fecha_terminacion ='" + fechaTermino.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();
                MessageBox.Show("Información Ingresada exitosamente");
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        //Metodo que ingresa la información sobre una nueva asignacion a proyecto de un empleado a una base de datos
        public static Boolean insertarDatosNuevaAsignacionAProyecto(String idEmpleado, String idProyecto, int asignado, String comentarios)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO empleado_proyecto SET idEmpleado='" + idEmpleado + "' , idProyecto='" + idProyecto + "', asignado='" + asignado + "' , comentarios='" + comentarios + "'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();

                MiCajaDeMensajes.GuardadoEnBaseDeDatos("Información Guardada Exitosamente", "Ingreso A Base De Datos");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }


        //Inserta datos en departamento
        //Metodo que ingresa la información a una base de datos
        public static Boolean insertarDatosProyecto(String idEmpleado, String nombreEmpleado, String apellidoPaterno, String apellidoMaterno, Char status, int perfil)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO tb_empleado SET ldap_empleado='" + idEmpleado + "' ,nombre='" + nombreEmpleado + "' , apellido_paterno='" + apellidoPaterno + "', apellido_materno='" + apellidoMaterno + "', estatus='" + status + "', tb_perfil_id_perfil='" + perfil + "'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();
                MessageBox.Show("Información Ingresada exitosamente");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

    }
}
