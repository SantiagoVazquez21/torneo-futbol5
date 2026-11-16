namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5
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
            chkAbono = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            //
            // lblApellido
            //
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 15);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido:";
            //
            // txtApellido
            //
            txtApellido.Location = new Point(90, 12);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(170, 23);
            txtApellido.TabIndex = 1;
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(280, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(345, 12);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 3;
            //
            // lblDni
            //
            lblDni.AutoSize = true;
            lblDni.Location = new Point(535, 15);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI:";
            //
            // txtDni
            //
            txtDni.Location = new Point(600, 12);
            txtDni.MaxLength = 15;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(130, 23);
            txtDni.TabIndex = 5;
            //
            // lblDireccion
            //
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 50);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            //
            // txtDireccion
            //
            txtDireccion.Location = new Point(90, 47);
            txtDireccion.MaxLength = 75;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(170, 23);
            txtDireccion.TabIndex = 7;
            //
            // lblEdad
            //
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(280, 50);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 8;
            lblEdad.Text = "Edad:";
            //
            // txtEdad
            //
            txtEdad.Location = new Point(345, 47);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(60, 23);
            txtEdad.TabIndex = 9;
            txtEdad.TextChanged += ActualizarCategoriaAsignada;
            //
            // lblTelefono
            //
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(535, 50);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono:";
            //
            // txtTelefono
            //
            txtTelefono.Location = new Point(600, 47);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 11;
            //
            // lblSexo
            //
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(12, 85);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 12;
            lblSexo.Text = "Sexo:";
            //
            // rdbMasculino
            //
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(90, 83);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 13;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            rdbMasculino.CheckedChanged += ActualizarCategoriaAsignada;
            //
            // rdbFemenino
            //
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(180, 83);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 14;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            rdbFemenino.CheckedChanged += ActualizarCategoriaAsignada;
            //
            // lblCategoriaTitulo
            //
            lblCategoriaTitulo.AutoSize = true;
            lblCategoriaTitulo.Location = new Point(280, 85);
            lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            lblCategoriaTitulo.Size = new Size(61, 15);
            lblCategoriaTitulo.TabIndex = 15;
            lblCategoriaTitulo.Text = "Categoría:";
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(345, 85);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(15, 15);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "—";
            //
            // chkAbono
            //
            chkAbono.AutoSize = true;
            chkAbono.Location = new Point(600, 84);
            chkAbono.Name = "chkAbono";
            chkAbono.Size = new Size(131, 19);
            chkAbono.TabIndex = 17;
            chkAbono.Text = "Abonó la inscripción";
            chkAbono.UseVisualStyleBackColor = true;
            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(534, 125);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 28);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnCancelar
            //
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(635, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 28);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            //
            // FormJugador
            //
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(744, 166);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkAbono);
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
        private CheckBox chkAbono;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
