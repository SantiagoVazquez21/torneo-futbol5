namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    partial class FormListado
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
            dgvInscripciones = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colAbono = new DataGridViewCheckBoxColumn();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            //
            // dgvInscripciones
            //
            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.AllowUserToDeleteRows = false;
            dgvInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Columns.AddRange(new DataGridViewColumn[] { colNumero, colFecha, colApellido, colNombre, colDni, colEdad, colSexo, colDireccion, colTelefono, colCategoria, colAbono });
            dgvInscripciones.Location = new Point(12, 12);
            dgvInscripciones.MultiSelect = false;
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.ReadOnly = true;
            dgvInscripciones.RowHeadersVisible = false;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripciones.Size = new Size(1010, 450);
            dgvInscripciones.TabIndex = 0;
            dgvInscripciones.CellDoubleClick += dgvInscripciones_CellDoubleClick;
            //
            // colNumero
            //
            colNumero.FillWeight = 45F;
            colNumero.HeaderText = "N°";
            colNumero.Name = "colNumero";
            colNumero.ReadOnly = true;
            //
            // colFecha
            //
            colFecha.FillWeight = 80F;
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            //
            // colApellido
            //
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            //
            // colNombre
            //
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            //
            // colDni
            //
            colDni.FillWeight = 85F;
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            //
            // colEdad
            //
            colEdad.FillWeight = 50F;
            colEdad.HeaderText = "Edad";
            colEdad.Name = "colEdad";
            colEdad.ReadOnly = true;
            //
            // colSexo
            //
            colSexo.FillWeight = 50F;
            colSexo.HeaderText = "Sexo";
            colSexo.Name = "colSexo";
            colSexo.ReadOnly = true;
            //
            // colDireccion
            //
            colDireccion.FillWeight = 130F;
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            //
            // colTelefono
            //
            colTelefono.FillWeight = 95F;
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            //
            // colCategoria
            //
            colCategoria.FillWeight = 115F;
            colCategoria.HeaderText = "Categoría";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            //
            // colAbono
            //
            colAbono.FillWeight = 55F;
            colAbono.HeaderText = "Abonó";
            colAbono.Name = "colAbono";
            colAbono.ReadOnly = true;
            //
            // btnModificar
            //
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnModificar.Location = new Point(725, 474);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(95, 28);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            //
            // btnEliminar
            //
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(826, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 28);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            //
            // btnVolver
            //
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolver.Location = new Point(927, 474);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 28);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            //
            // FormListado
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 514);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvInscripciones);
            MinimizeBox = false;
            MinimumSize = new Size(700, 350);
            Name = "FormListado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inscripciones";
            Shown += FormListado_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInscripciones;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewCheckBoxColumn colAbono;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}
