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
            grillaJugadores = new GrillaJugadores();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            //
            // grillaJugadores
            //
            grillaJugadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaJugadores.Location = new Point(12, 12);
            grillaJugadores.Name = "grillaJugadores";
            grillaJugadores.Size = new Size(1010, 450);
            grillaJugadores.TabIndex = 0;
            grillaJugadores.JugadorDobleClic += grillaJugadores_JugadorDobleClic;
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
            Controls.Add(grillaJugadores);
            MinimizeBox = false;
            MinimumSize = new Size(700, 350);
            Name = "FormListado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inscripciones";
            Shown += FormListado_Shown;
            ResumeLayout(false);
        }

        #endregion

        private GrillaJugadores grillaJugadores;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}
