namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5
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
            btnSalir = new Button();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(296, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Torneo Fútbol 5";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnAgregarJugador
            //
            btnAgregarJugador.Location = new Point(70, 70);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(180, 36);
            btnAgregarJugador.TabIndex = 1;
            btnAgregarJugador.Text = "Agregar jugador";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            //
            // btnModificarJugador
            //
            btnModificarJugador.Location = new Point(70, 116);
            btnModificarJugador.Name = "btnModificarJugador";
            btnModificarJugador.Size = new Size(180, 36);
            btnModificarJugador.TabIndex = 2;
            btnModificarJugador.Text = "Modificar jugador";
            btnModificarJugador.UseVisualStyleBackColor = true;
            btnModificarJugador.Click += btnModificarJugador_Click;
            //
            // btnSalir
            //
            btnSalir.Location = new Point(70, 162);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 36);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            //
            // FormPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 225);
            Controls.Add(btnSalir);
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
        private Button btnSalir;
    }
}
