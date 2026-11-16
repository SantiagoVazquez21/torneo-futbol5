namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    partial class FormJugador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblSexo = new Label();
            rdbMasculino = new RadioButton();
            rdbFemenino = new RadioButton();
            lblCategoriaTitulo = new Label();
            lblCategoria = new Label();
            lblEquipoTitulo = new Label();
            cmbEquipo = new ComboBox();
            lblEquipoNota = new Label();
            chkAbono = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1010, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar jugador";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblApellido
            //
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11F);
            lblApellido.Location = new Point(290, 67);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            //
            // txtApellido
            //
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(430, 64);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(320, 27);
            txtApellido.TabIndex = 2;
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(290, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            //
            // txtNombre
            //
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(430, 102);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 27);
            txtNombre.TabIndex = 4;
            //
            // lblDni
            //
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11F);
            lblDni.Location = new Point(290, 143);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 20);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            //
            // txtDni
            //
            txtDni.Font = new Font("Segoe UI", 11F);
            txtDni.Location = new Point(430, 140);
            txtDni.MaxLength = 15;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(320, 27);
            txtDni.TabIndex = 6;
            //
            // lblDireccion
            //
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11F);
            lblDireccion.Location = new Point(290, 181);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección:";
            //
            // txtDireccion
            //
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(430, 178);
            txtDireccion.MaxLength = 75;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 27);
            txtDireccion.TabIndex = 8;
            //
            // lblEdad
            //
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 11F);
            lblEdad.Location = new Point(290, 219);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(45, 20);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad:";
            //
            // txtEdad
            //
            txtEdad.Font = new Font("Segoe UI", 11F);
            txtEdad.Location = new Point(430, 216);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(80, 27);
            txtEdad.TabIndex = 10;
            txtEdad.TextChanged += ActualizarCategoriaAsignada;
            //
            // lblTelefono
            //
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11F);
            lblTelefono.Location = new Point(290, 257);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono:";
            //
            // txtTelefono
            //
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(430, 254);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(320, 27);
            txtTelefono.TabIndex = 12;
            //
            // lblSexo
            //
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 11F);
            lblSexo.Location = new Point(290, 295);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(43, 20);
            lblSexo.TabIndex = 13;
            lblSexo.Text = "Sexo:";
            //
            // rdbMasculino
            //
            rdbMasculino.AutoSize = true;
            rdbMasculino.Font = new Font("Segoe UI", 11F);
            rdbMasculino.Location = new Point(430, 293);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(99, 24);
            rdbMasculino.TabIndex = 14;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            rdbMasculino.CheckedChanged += ActualizarCategoriaAsignada;
            //
            // rdbFemenino
            //
            rdbFemenino.AutoSize = true;
            rdbFemenino.Font = new Font("Segoe UI", 11F);
            rdbFemenino.Location = new Point(560, 293);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(95, 24);
            rdbFemenino.TabIndex = 15;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            rdbFemenino.CheckedChanged += ActualizarCategoriaAsignada;
            //
            // lblCategoriaTitulo
            //
            lblCategoriaTitulo.AutoSize = true;
            lblCategoriaTitulo.Font = new Font("Segoe UI", 11F);
            lblCategoriaTitulo.Location = new Point(290, 333);
            lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            lblCategoriaTitulo.Size = new Size(77, 20);
            lblCategoriaTitulo.TabIndex = 16;
            lblCategoriaTitulo.Text = "Categoría:";
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCategoria.Location = new Point(430, 333);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(19, 20);
            lblCategoria.TabIndex = 17;
            lblCategoria.Text = "—";
            //
            // lblEquipoTitulo
            //
            lblEquipoTitulo.AutoSize = true;
            lblEquipoTitulo.Font = new Font("Segoe UI", 11F);
            lblEquipoTitulo.Location = new Point(290, 371);
            lblEquipoTitulo.Name = "lblEquipoTitulo";
            lblEquipoTitulo.Size = new Size(58, 20);
            lblEquipoTitulo.TabIndex = 18;
            lblEquipoTitulo.Text = "Equipo:";
            //
            // cmbEquipo
            //
            cmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipo.Font = new Font("Segoe UI", 11F);
            cmbEquipo.Location = new Point(430, 368);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(320, 28);
            cmbEquipo.TabIndex = 19;
            cmbEquipo.SelectionChangeCommitted += cmbEquipo_SelectionChangeCommitted;
            //
            // lblEquipoNota
            //
            lblEquipoNota.AutoSize = true;
            lblEquipoNota.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblEquipoNota.ForeColor = SystemColors.GrayText;
            lblEquipoNota.Location = new Point(760, 372);
            lblEquipoNota.Name = "lblEquipoNota";
            lblEquipoNota.Size = new Size(0, 19);
            lblEquipoNota.TabIndex = 20;
            //
            // chkAbono
            //
            chkAbono.AutoSize = true;
            chkAbono.Font = new Font("Segoe UI", 11F);
            chkAbono.Location = new Point(430, 409);
            chkAbono.Name = "chkAbono";
            chkAbono.Size = new Size(163, 24);
            chkAbono.TabIndex = 21;
            chkAbono.Text = "Abonó la inscripción";
            chkAbono.UseVisualStyleBackColor = true;
            //
            // btnGuardar
            //
            btnGuardar.Font = new Font("Segoe UI", 11F);
            btnGuardar.Location = new Point(430, 455);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnCancelar
            //
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11F);
            btnCancelar.Location = new Point(600, 455);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            //
            // FormJugador
            //
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1034, 514);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkAbono);
            Controls.Add(lblEquipoNota);
            Controls.Add(cmbEquipo);
            Controls.Add(lblEquipoTitulo);
            Controls.Add(lblCategoria);
            Controls.Add(lblCategoriaTitulo);
            Controls.Add(rdbFemenino);
            Controls.Add(rdbMasculino);
            Controls.Add(lblSexo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormJugador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar jugador";
            Load += FormJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblSexo;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private Label lblCategoriaTitulo;
        private Label lblCategoria;
        private Label lblEquipoTitulo;
        private ComboBox cmbEquipo;
        private Label lblEquipoNota;
        private CheckBox chkAbono;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
