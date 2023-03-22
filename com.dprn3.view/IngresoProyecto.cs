using DPRNIII_U2_A1_MAZM.com.dprn3.view;
using System;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    public partial class IngresoProyecto : Form
    {
        public static string datoProyecto;
        public static DateTime fecha;
        public static string nombreProyecto;
        DateTime fechaInicial;
        DateTime fechaFinal;



        clsAltaInformacion nuevoIngreso = new clsAltaInformacion();

        public IngresoProyecto()
        {
            InitializeComponent();
        }


        private void cboDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            datoProyecto = cboDepto.Text;

            if (cboDepto.SelectedItem.Equals(datoProyecto))
            {
                FillGridView();
            }
            else
            {
                MessageBox.Show("Ese perfil no es existente en la base de datos");
            }
        }

        private void FillGridView()
        {
            dgvProyecto.DataSource = nuevoIngreso.ConsultarDatosDepartamento();

            //dgvRolEmpleado.Columns[0].Visible = false;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            nombreProyecto = cboProyecto.Text;
            String descripcion = txtDescripcionProyecto.Text;

            if (clsAltaInformacion.isDateValid(maskedTextBoxFechaInicial.Text, maskedTextBoxFechaFinal.Text).Equals(true))
            {

                if (clsAltaInformacion.IsStartDateLessOrEqualsToFinishDate(Convert.ToDateTime(maskedTextBoxFechaInicial.Text), Convert.ToDateTime(maskedTextBoxFechaFinal.Text)).Equals(true))
                {
                    if (clsAltaInformacion.isDateBeforeToday(Convert.ToDateTime(maskedTextBoxFechaFinal.Text)).Equals(true))
                    {
                        /*
                        int res = clsAltaInformacion.getYearOfGivenDate(Convert.ToDateTime(maskedTextBoxFechaFinal.Text));
                        if(res < 1)
                        {

                        }*/
                    }
                    else
                    {
                        MessageBox.Show("La fecha real de finalización del proyecto no puede ser mayor a la fecha actual");
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final del proyecto. Verifique Por Favor. ");
                    //this.Close();
                }

                if (
                    clsAltaInformacion.isDateValid(maskedTextBoxFechaInicial.Text, maskedTextBoxFechaFinal.Text).Equals(true) &&
                    clsAltaInformacion.IsStartDateLessOrEqualsToFinishDate(Convert.ToDateTime(maskedTextBoxFechaInicial.Text), Convert.ToDateTime(maskedTextBoxFechaFinal.Text)).Equals(true) &&
                    clsAltaInformacion.isDateBeforeToday(Convert.ToDateTime(maskedTextBoxFechaFinal.Text)).Equals(true))
                {
                    int estatus = Convert.ToInt32(txtStatus.Text);
                    int idDepto = Convert.ToInt32(cboDepto.Text);
                    fechaInicial = Convert.ToDateTime(maskedTextBoxFechaInicial.Text);
                    fechaFinal = Convert.ToDateTime(maskedTextBoxFechaFinal.Text);
                    clsAltaInformacion.insertarDatosProyecto(nombreProyecto, descripcion, fechaInicial, estatus, idDepto, fechaFinal);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hay inconvenientes con las fechas ingresadas. Vuelva a intentar. Gracias. ");
                   
                }
                
            }
            else
            {
                MessageBox.Show("La fecha no tiene el formato correcto. Verifique por favor.");
                //this.Close();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
            BusquedaPorIdProyecto abrir = new BusquedaPorIdProyecto();
            abrir.Show();
        }

        private void IngresoProyecto_Load(object sender, EventArgs e)
        {
            maskedTextBoxFechaInicial.Mask = "00/00/0000   00:00";
            maskedTextBoxFechaInicial.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBoxFechaInicial.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);

            maskedTextBoxFechaFinal.Mask = "00/00/0000   00:00";
            maskedTextBoxFechaFinal.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
            maskedTextBoxFechaFinal.KeyDown += new KeyEventHandler(maskedTextBox1_KeyDown);



            this.toolTip2.SetToolTip(this.maskedTextBoxFechaInicial, "El formato para fecha es: dia/mes/año");
            this.toolTip2.SetToolTip(this.maskedTextBoxFechaFinal, "El formato para fecha es: dia/mes/año");
        }

        void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBoxFechaInicial.MaskFull)
            {
                toolTip1.ToolTipTitle = "Entrada No valida - Demasiados Digitos";
                toolTip1.Show("No es posible agregar mas digitos de los permitidos en campo fecha.", maskedTextBoxFechaInicial, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBoxFechaInicial.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Entrada No valida - Fin De Campo";
                toolTip1.Show("No es posible agregar mas digitos al final del campo.", maskedTextBoxFechaInicial, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Entrada Rechazada";
                toolTip1.Show("Solamente puedes agregar digitos del (0-9) dentro del campo fecha.", maskedTextBoxFechaInicial, 0, -20, 5000);
            }
        }

        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(maskedTextBoxFechaInicial);
            toolTip1.Hide(maskedTextBoxFechaFinal);
        }
    }
}
