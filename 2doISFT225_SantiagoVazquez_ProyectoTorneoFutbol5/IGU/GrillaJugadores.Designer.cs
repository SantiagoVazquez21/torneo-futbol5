namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    partial class GrillaJugadores
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

        #region Component Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvJugadores = new DataGridView();
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
            colEquipo = new DataGridViewTextBoxColumn();
            colAbono = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            //
            // dgvJugadores
            //
            dgvJugadores.AllowUserToAddRows = false;
            dgvJugadores.AllowUserToDeleteRows = false;
            dgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Columns.AddRange(new DataGridViewColumn[] { colNumero, colFecha, colApellido, colNombre, colDni, colEdad, colSexo, colDireccion, colTelefono, colCategoria, colEquipo, colAbono });
            dgvJugadores.Dock = DockStyle.Fill;
            dgvJugadores.Location = new Point(0, 0);
            dgvJugadores.MultiSelect = false;
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.ReadOnly = true;
            dgvJugadores.RowHeadersVisible = false;
            dgvJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJugadores.Size = new Size(1010, 450);
            dgvJugadores.TabIndex = 0;
            dgvJugadores.CellDoubleClick += dgvJugadores_CellDoubleClick;
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
            colDireccion.FillWeight = 120F;
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
            // colEquipo
            //
            colEquipo.FillWeight = 110F;
            colEquipo.HeaderText = "Equipo";
            colEquipo.Name = "colEquipo";
            colEquipo.ReadOnly = true;
            //
            // colAbono
            //
            colAbono.FillWeight = 55F;
            colAbono.HeaderText = "Abonó";
            colAbono.Name = "colAbono";
            colAbono.ReadOnly = true;
            //
            // GrillaJugadores
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvJugadores);
            Name = "GrillaJugadores";
            Size = new Size(1010, 450);
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJugadores;
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
        private DataGridViewTextBoxColumn colEquipo;
        private DataGridViewCheckBoxColumn colAbono;
    }
}
