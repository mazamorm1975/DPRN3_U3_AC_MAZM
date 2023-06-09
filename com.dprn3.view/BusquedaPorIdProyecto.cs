﻿
using iTextSharp.text;
using iTextSharp.text.pdf;
//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Element;
using System;
using System.IO;
using System.Windows.Forms;


namespace DPRNIII_U2_A1_MAZM.com.dprn3.view
{
    public partial class BusquedaPorIdProyecto : Form
    {
        clsAltaInformacion consultaProyecto = null;
        public static string fechaAuxiliar = "";
        public string fechaDesfase = "";


        public BusquedaPorIdProyecto()
        {
            InitializeComponent();
            FillGridViewRezagados();
            dgvProyectosFinalizadosMes.Visible = false;
            dgvProyectosSinAsignar.Visible = false;
            dgvFiltradoPorProyectos.Visible = false;
            dgvProyectosFueraTiempo.Visible = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtAuxiliarFecha.Visible = false;
            this.ttMensajesAyudaUsuario.SetToolTip(this.lblEstatus, "Estatus 1 = Concluido, Estatus 0 = Disponible");
            this.ttMensajesAyudaUsuario.SetToolTip(this.txtEstatus, "Estatus 1 = Concluido, Estatus 0 = Disponible");
            this.ttMensajesAyudaUsuario.SetToolTip(this.txtFechaActual, "Tambien puedes modificar la Fecha_Actual");
            this.ttMensajesAyudaUsuario.SetToolTip(this.btnFiltroProyectos, "Tambien puedes modificar la Fecha_Actual");
            btnFiltroProyectos.Enabled = false;



            /*
            //Establece los componentes de tipo datetimepicker en el formato año/mes/dia Hora, min, seg.
            dtpFechaInicial.Format = DateTimePickerFormat.Custom;
            dtpFechaInicial.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            dtpFechaFinal.CustomFormat = "yyyy-MM-dd HH:mm:ss";*/

            FillGridView();
        }

        public void FillGridView()
        {
            consultaProyecto = new clsAltaInformacion();
            dgvIdProyecto.DataSource = consultaProyecto.ConsultarDatosProyecto();
        }

        public void FillGridViewReportePorMes()
        {
            int mes = Convert.ToInt32(cboFiltradoPorMes.Text);
            TablasDataGridView tabla = new TablasDataGridView();
            dgvProyectosFinalizadosMes.DataSource = consultaProyecto.consultaProyectosFinalizadosPorMes(mes);
        }

        

        public void FillGridViewPersonalAsignadoPorProyecto()
        {

            dgvFiltradoPorProyectos.DataSource = consultaProyecto.FiltraPorProyecto(Convert.ToInt32(cboProyectos.Text));

        }


        public void FillGridViewFiltroProyectos()
        {
            clsAltaInformacion filtradoProyectos = new clsAltaInformacion();
            dgvFiltradoProyectos.DataSource = filtradoProyectos.consultaProyectosPorFinalizar(Convert.ToDateTime(txtFechaActual.Text), Convert.ToDateTime(txtFechaLimite.Text));
        }

        public void FillGridViewProyectosSinAsignacion()
        {
            clsAltaInformacion proyectosSinAsignar = new clsAltaInformacion();
            dgvProyectosSinAsignar.DataSource = proyectosSinAsignar.ConsultaProyectosSinAsignacion();
        }

        public void FillGridViewRezagados()
        {
            clsAltaInformacion proyectosFueraDeTiempo = new clsAltaInformacion();
            dgvProyectosFueraTiempo.DataSource = proyectosFueraDeTiempo.ConsultarProyectosRezagados();
        }


        private void BusquedaPorIdProyecto_Load(object sender, EventArgs e)
        {
            
             frmAsignacionProyectos test = new frmAsignacionProyectos();
           
            foreach (DataGridViewRow row in test.dgvConsultaProyectos.Rows)
            {
                row.Selected = true;

            }

            FillGridViewProyectosSinAsignacion();


            DateTime dt = DateTime.Now;
            txtFechaActual.Text = Convert.ToString(dt);

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                //Variables locales auxiliares
                fechaAuxiliar = txtAuxiliarFecha.Text;
                int numeroDiasDesface = clsAltaInformacion.desfaseDiasTerminacion(Convert.ToDateTime(fechaDesfase), Convert.ToDateTime(dtpFechaFinal.Text));

                //Actualiza la información del proyecto
                int idProyecto = Convert.ToInt32(dgvIdProyecto.CurrentRow.Cells[0].Value.ToString());
                clsAltaInformacion.actualizaProyecto(idProyecto, txtProyecto.Text, txtDescripcion.Text, dtpFechaInicial.Value, dtpFechaFinal.Value, Convert.ToInt32(txtEstatus.Text), Convert.ToInt32(txtDepartamento.Text), numeroDiasDesface);

                //Despliega datos actualizados
                FillGridView();
            
         
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvIdProyecto.Rows.Remove(dgvIdProyecto.CurrentRow);

        }

        private void dgvIdProyecto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            dtpFechaFinal.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtProyecto.Text = dgvIdProyecto.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvIdProyecto.CurrentRow.Cells[2].Value.ToString();
            dtpFechaInicial.Text = dgvIdProyecto.CurrentRow.Cells[3].Value.ToString();
            dtpFechaFinal.Text = dgvIdProyecto.CurrentRow.Cells[4].Value.ToString();
            txtDepartamento.Text = dgvIdProyecto.CurrentRow.Cells[6].Value.ToString();
            txtEstatus.Text = dgvIdProyecto.CurrentRow.Cells[7].Value.ToString();
            txtAuxiliarFecha.Text = dtpFechaFinal.Text;
            fechaDesfase = dgvIdProyecto.CurrentRow.Cells[8].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dtpFechaFinal.Format = DateTimePickerFormat.Custom;
            //dtpFechaFinal.CustomFormat = " ";
            txtAuxiliarFecha.Text = " ";
            int idProyecto = Convert.ToInt32(dgvIdProyecto.CurrentRow.Cells[0].Value.ToString());
            clsAltaInformacion.actualizaProyectoSinDesfase(idProyecto, txtProyecto.Text, txtDescripcion.Text, dtpFechaInicial.Value, dtpFechaFinal.Value, Convert.ToInt32(txtEstatus.Text), Convert.ToInt32(txtDepartamento.Text));

            //Despliega datos actualizados
            FillGridView();


        }



        private void btnFiltroProyectos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFechaActual.Text == "" || txtFechaLimite.Text == "")
                {
                    MessageBox.Show("Algun campo de tipo fecha esta vacio. ", "Error Al Intentar Filtrar");
                }
                else
                {
                    FillGridViewFiltroProyectos();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void txtFechaActual_MouseClick(object sender, MouseEventArgs e)
        {
            btnFiltroProyectos.Enabled = true;
        }

        private void txtFechaLimite_MouseClick(object sender, MouseEventArgs e)
        {
            btnFiltroProyectos.Enabled = true;
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
           
            //Exporta a PDF la tabla proyectos de la base de datos
            if (dgvFiltradoProyectos.Rows.Count > 0 )
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible salvar el archivo en la ruta especificada." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            
                            //crear tabla
                            PdfPTable pdfTable = new PdfPTable(dgvFiltradoProyectos.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;


                            foreach (DataGridViewColumn column in dgvFiltradoProyectos.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvFiltradoProyectos.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                //PageSize.A4, 10f, 20f, 20f, 10f
                                Document pdfDoc2 = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter pw = PdfWriter.GetInstance(pdfDoc2, stream);
                                pdfDoc2.Open();

                                PdfPTable tbHeader = new PdfPTable(3);
                                tbHeader.TotalWidth = pdfDoc2.PageSize.Width - pdfDoc2.LeftMargin - pdfDoc2.RightMargin;
                                tbHeader.DefaultCell.Border = 0;
                                tbHeader.AddCell(new Paragraph());
                                PdfPCell _cell = new PdfPCell(new Paragraph("Reporte Proyectos"));
                                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell.Border = 0;

                                //Indicar en donde se va a ubicar la tabla con el header
                                tbHeader.WriteSelectedRows(0, -1, pdfDoc2.LeftMargin, pw.PageSize.GetTop(pdfDoc2.TopMargin) + 40, pw.DirectContent);
                                tbHeader.AddCell(_cell);
                                tbHeader.AddCell(new Paragraph());

                                pdfDoc2.Add(tbHeader);
                                pdfDoc2.Add(pdfTable);

                                pdfDoc2.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Tabla exportada exitosamente !!!", "INFORMACION DE STATUS");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }

                        //


                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro para exportar !!!", "INFORMACION DE STATUS");
            }
        }

        private void btnPDFMasivo_Click(object sender, EventArgs e)
        {

            frmBusquedaEmpleado dgv2 = new frmBusquedaEmpleado();
            frmAsignacionProyectos consultaProyecto = new frmAsignacionProyectos();
            Listados filtroProyectos = new Listados();

            //TablasDataGridView dgv4 = new TablasDataGridView();


            //Exporta a PDF la tabla proyectos de la base de datos
            if (dgvFiltradoProyectos.Rows.Count > 0 || dgvIdProyecto.Rows.Count > 0 )
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible salvar el archivo en la ruta especificada." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {

                            PdfPTable pdfTable = new PdfPTable(dgvFiltradoProyectos.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvFiltradoProyectos.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvFiltradoProyectos.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            //Listado de proyectos fuera de tiempo
                            PdfPTable pdfTable_fuera_Tiempo = new PdfPTable(dgvProyectosFueraTiempo.Columns.Count);
                            pdfTable_fuera_Tiempo.DefaultCell.Padding = 3;
                            pdfTable_fuera_Tiempo.WidthPercentage = 100;
                            pdfTable_fuera_Tiempo.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvProyectosFueraTiempo.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                //En la siguiente linea debera relacionarse el nombre de la tabla, en este caso
                                //pdfTable_fuera_Tiempo
                                pdfTable_fuera_Tiempo.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvProyectosFueraTiempo.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    //En la siguiente linea debera relacionarse el nombre de la tabla, en este caso
                                    //pdfTable_fuera_Tiempo
                                    pdfTable_fuera_Tiempo.AddCell(cell.Value.ToString());
                                }
                            }

                            //Proyectos finalizados por mes
                            PdfPTable pdfTable_mes = new PdfPTable(dgvProyectosFinalizadosMes.Columns.Count);
                            pdfTable_mes.DefaultCell.Padding = 3;
                            pdfTable_mes.WidthPercentage = 100;
                            pdfTable_mes.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvProyectosFinalizadosMes.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                //En la siguiente linea debera relacionarse el nombre de la tabla, en este caso
                                //pdfTable_fuera_Tiempo
                                pdfTable_mes.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvProyectosFinalizadosMes.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    //En la siguiente linea debera relacionarse el nombre de la tabla, en este caso
                                    //pdfTable_fuera_Tiempo
                                    pdfTable_mes.AddCell(cell.Value.ToString());
                                }
                            }


                            //Listado de empleados asignados a un proyecto
                            PdfPTable pdfTable_Migracion = new PdfPTable(dgvFiltradoPorProyectos.Columns.Count);
                            pdfTable_Migracion.DefaultCell.Padding = 3;
                            pdfTable_Migracion.WidthPercentage = 100;
                            pdfTable_Migracion.HorizontalAlignment = Element.ALIGN_LEFT;


                            foreach (DataGridViewColumn column in dgvFiltradoPorProyectos.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable_Migracion.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvFiltradoPorProyectos.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable_Migracion.AddCell(cell.Value.ToString());
                                }
                            }



                            //Listado de proyectos sin asignar
                            PdfPTable pdfProyectosSinAsignacion = new PdfPTable(dgvProyectosSinAsignar.Columns.Count);
                            pdfProyectosSinAsignacion.DefaultCell.Padding = 3;
                            pdfProyectosSinAsignacion.WidthPercentage = 100;
                            pdfProyectosSinAsignacion.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvProyectosSinAsignar.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfProyectosSinAsignacion.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvProyectosSinAsignar.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfProyectosSinAsignacion.AddCell(cell.Value.ToString());
                                }
                            }



                            PdfPTable pdfTable2 = new PdfPTable(dgv2.dgvDespliegaInformacionEmpleado.Columns.Count);
                            pdfTable2.DefaultCell.Padding = 3;
                            pdfTable2.WidthPercentage = 100;
                            pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;


                            foreach (DataGridViewColumn column in dgv2.dgvDespliegaInformacionEmpleado.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable2.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv2.dgvDespliegaInformacionEmpleado.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable2.AddCell(cell.Value.ToString());
                                }
                            }

                            //
                            PdfPTable pdfTableFiltroPorMes = new PdfPTable(dgvProyectosFinalizadosMes.Columns.Count);
                            pdfTableFiltroPorMes.DefaultCell.Padding = 3;
                            pdfTableFiltroPorMes.WidthPercentage = 100;
                            pdfTableFiltroPorMes.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvProyectosFinalizadosMes.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTableFiltroPorMes.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvProyectosFinalizadosMes.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTableFiltroPorMes.AddCell(cell.Value.ToString());
                                }
                            }


                            PdfPTable pdfTable_asignacion_proyectos = new PdfPTable(consultaProyecto.dgvConsultaProyectos.Columns.Count);
                            pdfTable_asignacion_proyectos.DefaultCell.Padding = 3;
                            pdfTable_asignacion_proyectos.WidthPercentage = 100;
                            pdfTable_asignacion_proyectos.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in consultaProyecto.dgvConsultaProyectos.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable_asignacion_proyectos.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in consultaProyecto.dgvConsultaProyectos.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable_asignacion_proyectos.AddCell(cell.Value.ToString());
                                }
                            }


                            //
                            PdfPTable pdfTableIdProyecto = new PdfPTable(dgvIdProyecto.Columns.Count);
                            pdfTableIdProyecto.DefaultCell.Padding = 3;
                            pdfTableIdProyecto.WidthPercentage = 100;
                            pdfTableIdProyecto.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvIdProyecto.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTableIdProyecto.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvIdProyecto.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTableIdProyecto.AddCell(cell.Value.ToString());
                                }
                            }


                            //Se abre el stream
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 0f, 20f, 20f, 10f);
                                PdfWriter pw2 = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                //Agrega celda de espaciado
                                PdfPTable tb_espaciado = new PdfPTable(3);
                                tb_espaciado.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tb_espaciado.DefaultCell.Border = 0;
                                tb_espaciado.AddCell(new Paragraph());
                                PdfPCell _cell_espacio = new PdfPCell(new Paragraph(" "));
                                _cell_espacio.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_espacio.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                tb_espaciado.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tb_espaciado.AddCell(_cell_espacio);
                                tb_espaciado.AddCell(new Paragraph());

                                //

                                PdfPTable tb_espaciado_2 = new PdfPTable(3);
                                tb_espaciado_2.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tb_espaciado_2.DefaultCell.Border = 0;
                                tb_espaciado_2.AddCell(new Paragraph());
                                PdfPCell _cell_espacio_2 = new PdfPCell(new Paragraph(" "));
                                _cell_espacio_2.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_espacio_2.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                tb_espaciado_2.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tb_espaciado_2.AddCell(_cell_espacio);
                                tb_espaciado_2.AddCell(new Paragraph());

                                //Header de filtro Empleados asignados a un mismo proyecto
                                PdfPTable tbFiltroProyectoEmpleado = new PdfPTable(3);
                                tbFiltroProyectoEmpleado.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tbFiltroProyectoEmpleado.DefaultCell.Border = 0;
                                tbFiltroProyectoEmpleado.AddCell(new Paragraph());
                                PdfPCell _cell_filtro_2 = new PdfPCell(new Paragraph("Listado Detalle-Proyecto"));
                                _cell_filtro_2.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_filtro_2.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                tbFiltroProyectoEmpleado.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tbFiltroProyectoEmpleado.AddCell(_cell_filtro_2);
                                tbFiltroProyectoEmpleado.AddCell(new Paragraph());

                                //Header de filtro Empleados asignados a un mismo proyecto
                                PdfPTable HeaderProyectosDesfase = new PdfPTable(3);
                                HeaderProyectosDesfase.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                HeaderProyectosDesfase.DefaultCell.Border = 0;
                                HeaderProyectosDesfase.AddCell(new Paragraph());
                                PdfPCell _cell_desfase = new PdfPCell(new Paragraph("Listado Entregables Extemporaneos"));
                                _cell_desfase.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_desfase.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                HeaderProyectosDesfase.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                HeaderProyectosDesfase.AddCell(_cell_desfase);
                                HeaderProyectosDesfase.AddCell(new Paragraph());


                                //Header para reporte de proyectos
                                PdfPTable tbHeader = new PdfPTable(3);
                                tbHeader.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tbHeader.DefaultCell.Border = 0;
                                tbHeader.AddCell(new Paragraph());
                                PdfPCell _cell = new PdfPCell(new Paragraph("Reporte Proyectos"));
                                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                tbHeader.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tbHeader.AddCell(_cell);
                                tbHeader.AddCell(new Paragraph());

                                //Header para reporte filtrado por mes
                                PdfPTable tbHeaderReportePorMes = new PdfPTable(3);
                                tbHeaderReportePorMes.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tbHeaderReportePorMes.DefaultCell.Border = 0;
                                tbHeaderReportePorMes.AddCell(new Paragraph());
                                PdfPCell _cell_filtradoPorMes = new PdfPCell(new Paragraph("Reporte Proyectos Finalizados"));
                                _cell_filtradoPorMes.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_filtradoPorMes.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                tbHeaderReportePorMes.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tbHeaderReportePorMes.AddCell(_cell_filtradoPorMes);
                                tbHeaderReportePorMes.AddCell(new Paragraph());

                                //Header para reporte de proyectos
                                PdfPTable tbHeader_asignacion_proyectos = new PdfPTable(3);
                                tbHeader_asignacion_proyectos.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tbHeader_asignacion_proyectos.DefaultCell.Border = 0;
                                tbHeader_asignacion_proyectos.AddCell(new Paragraph());
                                PdfPCell _cell_4 = new PdfPCell(new Paragraph("Reporte Asignacion Proyecto-Empleados"));
                                _cell_4.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_4.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                tbHeader_asignacion_proyectos.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tbHeader_asignacion_proyectos.AddCell(_cell_4);
                                tbHeader_asignacion_proyectos.AddCell(new Paragraph());



                                //Header para reporte de IdProyecto
                                PdfPTable tbHeaderIdProyecto = new PdfPTable(3);
                                tbHeaderIdProyecto.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tbHeaderIdProyecto.DefaultCell.Border = 0;
                                tbHeaderIdProyecto.AddCell(new Paragraph());
                                PdfPCell _cell_IdProyecto = new PdfPCell(new Paragraph("Reporte Proyectos Por ID"));
                                _cell_IdProyecto.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_IdProyecto.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header del IdProyecto
                                tbHeaderIdProyecto.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tbHeaderIdProyecto.AddCell(_cell_IdProyecto);
                                tbHeaderIdProyecto.AddCell(new Paragraph());

                                //Header para listado de proyectos sin asignacion
                                PdfPTable tbHeaderProyectoSINAsignar = new PdfPTable(3);
                                tbHeaderProyectoSINAsignar.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                tbHeaderProyectoSINAsignar.DefaultCell.Border = 0;
                                tbHeaderProyectoSINAsignar.AddCell(new Paragraph());
                                PdfPCell _cell_IdProyectoSINAsignar = new PdfPCell(new Paragraph("Proyectos Sin Asignacion"));
                                _cell_IdProyectoSINAsignar.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_IdProyectoSINAsignar.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header del IdProyecto
                                tbHeaderProyectoSINAsignar.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                tbHeaderProyectoSINAsignar.AddCell(_cell_IdProyectoSINAsignar);
                                tbHeaderProyectoSINAsignar.AddCell(new Paragraph());

                                //Header para reporte de empleados
                                PdfPTable header_empleados = new PdfPTable(3);
                                header_empleados.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                header_empleados.DefaultCell.Border = 0;
                                header_empleados.AddCell(new Paragraph());
                                PdfPCell _cell_2 = new PdfPCell(new Paragraph("Reporte_Empleados"));
                                _cell_2.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_2.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                header_empleados.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                header_empleados.AddCell(_cell_2);
                                header_empleados.AddCell(new Paragraph());

                                //Header para reportes desfasados por mes
                                PdfPTable header_mes = new PdfPTable(3);
                                header_mes.TotalWidth = pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin;
                                header_mes.DefaultCell.Border = 0;
                                header_mes.AddCell(new Paragraph());
                                PdfPCell _cell_mes = new PdfPCell(new Paragraph("Listado_Finalizados_Mes"));
                                _cell_mes.HorizontalAlignment = Element.ALIGN_CENTER;
                                _cell_mes.Border = 0;
                                //Indicar en donde se va a ubicar la tabla con el header
                                header_mes.WriteSelectedRows(0, -1, pdfDoc.LeftMargin, pw2.PageSize.GetTop(pdfDoc.TopMargin) + 40, pw2.DirectContent);
                                header_mes.AddCell(_cell_mes);
                                header_mes.AddCell(new Paragraph());


                                //Se asignan al pdfDoc
                                pdfDoc.Add(tbHeader);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(tb_espaciado);

                                pdfDoc.Add(tbHeaderReportePorMes);
                                pdfDoc.Add(tb_espaciado_2);
                                pdfDoc.Add(pdfTableFiltroPorMes);
                                pdfDoc.Add(tb_espaciado_2);

                                pdfDoc.Add(tbHeaderIdProyecto);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfTableIdProyecto);
                                pdfDoc.Add(tb_espaciado);

                                pdfDoc.Add(header_empleados);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfTable2);
                                pdfDoc.Add(tb_espaciado);

                                pdfDoc.Add(tbHeader_asignacion_proyectos);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfTable_asignacion_proyectos);
                                pdfDoc.Add(tb_espaciado);

                                pdfDoc.Add(tbHeaderProyectoSINAsignar);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfProyectosSinAsignacion);
                                pdfDoc.Add(tb_espaciado);

                                pdfDoc.Add(tbFiltroProyectoEmpleado);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfTable_Migracion);
                                pdfDoc.Add(tb_espaciado);

                                pdfDoc.Add(HeaderProyectosDesfase);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfTable_fuera_Tiempo);
                                pdfDoc.Add(tb_espaciado);

                                pdfDoc.Add(header_mes);
                                pdfDoc.Add(tb_espaciado);
                                pdfDoc.Add(pdfTable_mes);
                                pdfDoc.Add(tb_espaciado);


                                


                                pdfDoc.Close();

                                stream.Close();
                            }

                            MessageBox.Show("Tabla exportada exitosamente !!!", "INFORMACION DE STATUS");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro para exportar !!!", "INFORMACION DE STATUS");
            }
        }

        private void cboFiltradoPorMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridViewReportePorMes();
            
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            FillGridViewPersonalAsignadoPorProyecto();
            MessageBox.Show("Filtrado De Proyecto Cargado. ");
        }
    }
}

class Header : PdfPageEventHelper
{

    public override void OnEndPage(PdfWriter writer, Document document)
    {
        //crear tabla
        PdfPTable tbHeader = new PdfPTable(3);
        tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
        tbHeader.DefaultCell.Border = 0;

        tbHeader.AddCell(new Paragraph());
        PdfPCell _cell = new PdfPCell(new Paragraph("Reporte Proyectos"));
        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
        _cell.Border = 0;

        //Indicar en donde se va a ubicar la tabla con el header
        tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin), writer.DirectContent);

        tbHeader.AddCell(_cell);
        tbHeader.AddCell(new Paragraph());

    }


}

