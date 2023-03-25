
namespace DPRNIII_U2_A1_MAZM
{
    partial class frmAsignacionProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contenedorAsignacionProyecto = new System.Windows.Forms.GroupBox();
            this.icbRemover = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnIngresarAsignacion = new FontAwesome.Sharp.IconButton();
            this.rdbNoAsignado = new System.Windows.Forms.RadioButton();
            this.rdbAsignado = new System.Windows.Forms.RadioButton();
            this.cboNumeroEmpleado = new System.Windows.Forms.ComboBox();
            this.lblNumeroEmpleado = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.cboFolio = new System.Windows.Forms.ComboBox();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.contenedorComentarios = new System.Windows.Forms.GroupBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.dgvConsultaProyectos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empleadoproyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contenedorAsignacionProyecto.SuspendLayout();
            this.contenedorComentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProyectos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoproyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorAsignacionProyecto
            // 
            this.contenedorAsignacionProyecto.Controls.Add(this.icbRemover);
            this.contenedorAsignacionProyecto.Controls.Add(this.btnConsultar);
            this.contenedorAsignacionProyecto.Controls.Add(this.btnSalir);
            this.contenedorAsignacionProyecto.Controls.Add(this.btnIngresarAsignacion);
            this.contenedorAsignacionProyecto.Controls.Add(this.rdbNoAsignado);
            this.contenedorAsignacionProyecto.Controls.Add(this.rdbAsignado);
            this.contenedorAsignacionProyecto.Controls.Add(this.cboNumeroEmpleado);
            this.contenedorAsignacionProyecto.Controls.Add(this.lblNumeroEmpleado);
            this.contenedorAsignacionProyecto.Controls.Add(this.lblFolio);
            this.contenedorAsignacionProyecto.Controls.Add(this.cboFolio);
            this.contenedorAsignacionProyecto.Location = new System.Drawing.Point(3, 3);
            this.contenedorAsignacionProyecto.Name = "contenedorAsignacionProyecto";
            this.contenedorAsignacionProyecto.Size = new System.Drawing.Size(501, 191);
            this.contenedorAsignacionProyecto.TabIndex = 0;
            this.contenedorAsignacionProyecto.TabStop = false;
            this.contenedorAsignacionProyecto.Text = "Nueva_Asignacion_Empleado";
            this.contenedorAsignacionProyecto.Enter += new System.EventHandler(this.contenedorAsignacionProyecto_Enter);
            // 
            // icbRemover
            // 
            this.icbRemover.IconChar = FontAwesome.Sharp.IconChar.X;
            this.icbRemover.IconColor = System.Drawing.Color.Red;
            this.icbRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbRemover.IconSize = 28;
            this.icbRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbRemover.Location = new System.Drawing.Point(355, 99);
            this.icbRemover.Name = "icbRemover";
            this.icbRemover.Size = new System.Drawing.Size(138, 33);
            this.icbRemover.TabIndex = 9;
            this.icbRemover.Text = "Elimina Registro";
            this.icbRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbRemover.UseVisualStyleBackColor = true;
            this.icbRemover.Click += new System.EventHandler(this.icbRemover_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnConsultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 28;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(355, 60);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(138, 33);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnSalir.IconColor = System.Drawing.Color.Red;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 28;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(355, 138);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 31);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresarAsignacion
            // 
            this.btnIngresarAsignacion.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnIngresarAsignacion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIngresarAsignacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresarAsignacion.IconSize = 38;
            this.btnIngresarAsignacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarAsignacion.Location = new System.Drawing.Point(9, 136);
            this.btnIngresarAsignacion.Name = "btnIngresarAsignacion";
            this.btnIngresarAsignacion.Size = new System.Drawing.Size(277, 34);
            this.btnIngresarAsignacion.TabIndex = 6;
            this.btnIngresarAsignacion.Text = "Ingresar";
            this.btnIngresarAsignacion.UseVisualStyleBackColor = true;
            this.btnIngresarAsignacion.Click += new System.EventHandler(this.btnIngresarAsignacion_Click);
            // 
            // rdbNoAsignado
            // 
            this.rdbNoAsignado.AutoSize = true;
            this.rdbNoAsignado.Location = new System.Drawing.Point(186, 99);
            this.rdbNoAsignado.Name = "rdbNoAsignado";
            this.rdbNoAsignado.Size = new System.Drawing.Size(86, 17);
            this.rdbNoAsignado.TabIndex = 5;
            this.rdbNoAsignado.TabStop = true;
            this.rdbNoAsignado.Text = "No Asignado";
            this.rdbNoAsignado.UseVisualStyleBackColor = true;
            // 
            // rdbAsignado
            // 
            this.rdbAsignado.AutoSize = true;
            this.rdbAsignado.Location = new System.Drawing.Point(28, 99);
            this.rdbAsignado.Name = "rdbAsignado";
            this.rdbAsignado.Size = new System.Drawing.Size(69, 17);
            this.rdbAsignado.TabIndex = 4;
            this.rdbAsignado.TabStop = true;
            this.rdbAsignado.Text = "Asignado";
            this.rdbAsignado.UseVisualStyleBackColor = true;
            // 
            // cboNumeroEmpleado
            // 
            this.cboNumeroEmpleado.FormattingEnabled = true;
            this.cboNumeroEmpleado.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cboNumeroEmpleado.Location = new System.Drawing.Point(165, 59);
            this.cboNumeroEmpleado.Name = "cboNumeroEmpleado";
            this.cboNumeroEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cboNumeroEmpleado.TabIndex = 3;
            // 
            // lblNumeroEmpleado
            // 
            this.lblNumeroEmpleado.AutoSize = true;
            this.lblNumeroEmpleado.Location = new System.Drawing.Point(175, 34);
            this.lblNumeroEmpleado.Name = "lblNumeroEmpleado";
            this.lblNumeroEmpleado.Size = new System.Drawing.Size(69, 13);
            this.lblNumeroEmpleado.TabIndex = 2;
            this.lblNumeroEmpleado.Text = "Id_Empleado";
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(10, 34);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(64, 13);
            this.lblFolio.TabIndex = 1;
            this.lblFolio.Text = "Id_Proyecto";
            // 
            // cboFolio
            // 
            this.cboFolio.FormattingEnabled = true;
            this.cboFolio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cboFolio.Location = new System.Drawing.Point(9, 59);
            this.cboFolio.Name = "cboFolio";
            this.cboFolio.Size = new System.Drawing.Size(121, 21);
            this.cboFolio.TabIndex = 0;
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // contenedorComentarios
            // 
            this.contenedorComentarios.Controls.Add(this.txtComentarios);
            this.contenedorComentarios.Location = new System.Drawing.Point(3, 200);
            this.contenedorComentarios.Name = "contenedorComentarios";
            this.contenedorComentarios.Size = new System.Drawing.Size(501, 52);
            this.contenedorComentarios.TabIndex = 1;
            this.contenedorComentarios.TabStop = false;
            this.contenedorComentarios.Text = "Comentarios_Adicionales";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(7, 20);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(486, 20);
            this.txtComentarios.TabIndex = 0;
            // 
            // dgvConsultaProyectos
            // 
            this.dgvConsultaProyectos.AllowUserToAddRows = false;
            this.dgvConsultaProyectos.AllowUserToDeleteRows = false;
            this.dgvConsultaProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProyectos.Location = new System.Drawing.Point(6, 19);
            this.dgvConsultaProyectos.Name = "dgvConsultaProyectos";
            this.dgvConsultaProyectos.ReadOnly = true;
            this.dgvConsultaProyectos.Size = new System.Drawing.Size(382, 224);
            this.dgvConsultaProyectos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvConsultaProyectos);
            this.groupBox1.Location = new System.Drawing.Point(510, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despliegue_Proyectos_Asignados";
            // 
            // empleadoproyectoBindingSource
            // 
            this.empleadoproyectoBindingSource.DataMember = "empleado_proyecto";
            // 
            // frmAsignacionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contenedorComentarios);
            this.Controls.Add(this.contenedorAsignacionProyecto);
            this.Name = "frmAsignacionProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACION_PROYECTOS. V1";
            this.Load += new System.EventHandler(this.frmAsignacionProyectos_Load);
            this.contenedorAsignacionProyecto.ResumeLayout(false);
            this.contenedorAsignacionProyecto.PerformLayout();
            this.contenedorComentarios.ResumeLayout(false);
            this.contenedorComentarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProyectos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoproyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contenedorAsignacionProyecto;
        private System.Windows.Forms.Label lblNumeroEmpleado;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.RadioButton rdbNoAsignado;
        private System.Windows.Forms.RadioButton rdbAsignado;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.GroupBox contenedorComentarios;
        private System.Windows.Forms.TextBox txtComentarios;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnIngresarAsignacion;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cboNumeroEmpleado;
        public System.Windows.Forms.ComboBox cboFolio;
        private FontAwesome.Sharp.IconButton icbRemover;
        public System.Windows.Forms.DataGridView dgvConsultaProyectos;
        private System.Windows.Forms.BindingSource empleadoproyectoBindingSource;
        
    }
}