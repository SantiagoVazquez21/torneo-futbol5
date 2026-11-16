namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    partial class FormEquipo
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCapitan = new Label();
            grillaJugadores = new GrillaJugadores();
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
            lblTitulo.Text = "Crear equipo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(12, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(143, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del equipo:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(170, 65);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblCapitan
            // 
            lblCapitan.AutoSize = true;
            lblCapitan.Font = new Font("Segoe UI", 11F);
            lblCapitan.Location = new Point(12, 108);
            lblCapitan.Name = "lblCapitan";
            lblCapitan.Size = new Size(372, 20);
            lblCapitan.TabIndex = 3;
            lblCapitan.Text = "Elegí al capitán (solo jugadores que no tienen equipo):";
            // 
            // grillaJugadores
            // 
            grillaJugadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaJugadores.Location = new Point(12, 136);
            grillaJugadores.Name = "grillaJugadores";
            grillaJugadores.Size = new Size(1010, 316);
            grillaJugadores.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Font = new Font("Segoe UI", 11F);
            btnGuardar.Location = new Point(716, 464);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11F);
            btnCancelar.Location = new Point(872, 464);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormEquipo
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1034, 514);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grillaJugadores);
            Controls.Add(lblCapitan);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEquipo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear equipo";
            Load += FormEquipo_Load;
            Shown += FormEquipo_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCapitan;
        private GrillaJugadores grillaJugadores;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
