
namespace DPRNIII_U2_A1_MAZM.com.dprn3.view
{
    partial class frmBusquedaEmpleado
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
            this.dgvDespliegaInformacionEmpleado = new System.Windows.Forms.DataGridView();
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLDAP = new System.Windows.Forms.Label();
            this.txtLDAP = new System.Windows.Forms.TextBox();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.ttMensajesAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespliegaInformacionEmpleado)).BeginInit();
            this.grpEmpleado.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDespliegaInformacionEmpleado
            // 
            this.dgvDespliegaInformacionEmpleado.AllowUserToAddRows = false;
            this.dgvDespliegaInformacionEmpleado.AllowUserToDeleteRows = false;
            this.dgvDespliegaInformacionEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespliegaInformacionEmpleado.Location = new System.Drawing.Point(2, 1);
            this.dgvDespliegaInformacionEmpleado.Name = "dgvDespliegaInformacionEmpleado";
            this.dgvDespliegaInformacionEmpleado.ReadOnly = true;
            this.dgvDespliegaInformacionEmpleado.Size = new System.Drawing.Size(502, 150);
            this.dgvDespliegaInformacionEmpleado.TabIndex = 0;
            this.dgvDespliegaInformacionEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespliegaInformacionEmpleado_CellClick);
            // 
            // grpEmpleado
            // 
            this.grpEmpleado.Controls.Add(this.txtEstatus);
            this.grpEmpleado.Controls.Add(this.lblStatus);
            this.grpEmpleado.Controls.Add(this.txtPerfil);
            this.grpEmpleado.Controls.Add(this.lblPerfil);
            this.grpEmpleado.Controls.Add(this.txtApellidoM);
            this.grpEmpleado.Controls.Add(this.lblApellidoM);
            this.grpEmpleado.Controls.Add(this.txtApellidoP);
            this.grpEmpleado.Controls.Add(this.lblApellidoP);
            this.grpEmpleado.Controls.Add(this.txtNombre);
            this.grpEmpleado.Controls.Add(this.lblNombre);
            this.grpEmpleado.Controls.Add(this.lblLDAP);
            this.grpEmpleado.Controls.Add(this.txtLDAP);
            this.grpEmpleado.Location = new System.Drawing.Point(2, 221);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Size = new System.Drawing.Size(502, 110);
            this.grpEmpleado.TabIndex = 1;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Datos_Empleado";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(324, 80);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(97, 20);
            this.txtEstatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(237, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Estatus";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Location = new System.Drawing.Point(101, 83);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(96, 20);
            this.txtPerfil.TabIndex = 9;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(11, 86);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(324, 50);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(166, 20);
            this.txtApellidoM.TabIndex = 7;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(237, 53);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(86, 13);
            this.lblApellidoM.TabIndex = 6;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(324, 22);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(166, 20);
            this.txtApellidoP.TabIndex = 5;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(237, 25);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(84, 13);
            this.lblApellidoP.TabIndex = 4;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(96, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLDAP
            // 
            this.lblLDAP.AutoSize = true;
            this.lblLDAP.Location = new System.Drawing.Point(11, 25);
            this.lblLDAP.Name = "lblLDAP";
            this.lblLDAP.Size = new System.Drawing.Size(84, 13);
            this.lblLDAP.TabIndex = 1;
            this.lblLDAP.Text = "Ldap_Empleado";
            // 
            // txtLDAP
            // 
            this.txtLDAP.Location = new System.Drawing.Point(101, 22);
            this.txtLDAP.Name = "txtLDAP";
            this.txtLDAP.Size = new System.Drawing.Size(96, 20);
            this.txtLDAP.TabIndex = 0;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.btnSalir);
            this.grpBuscar.Controls.Add(this.btnModificar);
            this.grpBuscar.Controls.Add(this.btnEliminar);
            this.grpBuscar.Location = new System.Drawing.Point(2, 158);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(502, 57);
            this.grpBuscar.TabIndex = 2;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Seleccionar_Empleado_LDAP";
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnSalir.IconColor = System.Drawing.Color.Green;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 35;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(343, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 32);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Terminar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificar.IconColor = System.Drawing.Color.Green;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 35;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(6, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 32);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.Green;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 35;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(174, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmBusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 335);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.dgvDespliegaInformacionEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBusquedaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UBICACION_EMPLEADO_V.2.1";
            this.Load += new System.EventHandler(this.frmBusquedaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespliegaInformacionEmpleado)).EndInit();
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLDAP;
        private System.Windows.Forms.TextBox txtLDAP;
        private System.Windows.Forms.GroupBox grpBuscar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.ToolTip ttMensajesAyuda;
        public System.Windows.Forms.DataGridView dgvDespliegaInformacionEmpleado;
    }
}