namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    partial class FormPrincipal
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
            btnAgregarJugador = new Button();
            btnModificarJugador = new Button();
            btnCrearEquipo = new Button();
            btnSalir = new Button();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(496, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Torneo Fútbol 5";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnAgregarJugador
            //
            btnAgregarJugador.Font = new Font("Segoe UI", 12F);
            btnAgregarJugador.Location = new Point(110, 115);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(300, 60);
            btnAgregarJugador.TabIndex = 1;
            btnAgregarJugador.Text = "Agregar jugador";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            //
            // btnModificarJugador
            //
            btnModificarJugador.Font = new Font("Segoe UI", 12F);
            btnModificarJugador.Location = new Point(110, 195);
            btnModificarJugador.Name = "btnModificarJugador";
            btnModificarJugador.Size = new Size(300, 60);
            btnModificarJugador.TabIndex = 2;
            btnModificarJugador.Text = "Modificar jugador";
            btnModificarJugador.UseVisualStyleBackColor = true;
            btnModificarJugador.Click += btnModificarJugador_Click;
            //
            // btnCrearEquipo
            //
            btnCrearEquipo.Font = new Font("Segoe UI", 12F);
            btnCrearEquipo.Location = new Point(110, 275);
            btnCrearEquipo.Name = "btnCrearEquipo";
            btnCrearEquipo.Size = new Size(300, 60);
            btnCrearEquipo.TabIndex = 3;
            btnCrearEquipo.Text = "Crear equipo";
            btnCrearEquipo.UseVisualStyleBackColor = true;
            btnCrearEquipo.Click += btnCrearEquipo_Click;
            //
            // btnSalir
            //
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(110, 355);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(300, 60);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            //
            // FormPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 440);
            Controls.Add(btnSalir);
            Controls.Add(btnCrearEquipo);
            Controls.Add(btnModificarJugador);
            Controls.Add(btnAgregarJugador);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torneo Fútbol 5";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnAgregarJugador;
        private Button btnModificarJugador;
        private Button btnCrearEquipo;
        private Button btnSalir;
    }
}
