namespace Practico_2
{
    partial class Form1
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
            LNyA = new Label();
            LModificar = new Label();
            LDNI = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(51, 30);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(107, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(169, 30);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(51, 65);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(27, 15);
            LDNI.TabIndex = 2;
            LDNI.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(51, 109);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(51, 154);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            LNombre.Click += label5_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(127, 62);
            TDni.Name = "TDni";
            TDni.ShortcutsEnabled = false;
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(127, 106);
            TApellido.Name = "TApellido";
            TApellido.ShortcutsEnabled = false;
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(127, 151);
            TNombre.Name = "TNombre";
            TNombre.ShortcutsEnabled = false;
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(51, 212);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += button1_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(152, 212);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 313);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDNI);
            Controls.Add(LModificar);
            Controls.Add(LNyA);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNyA;
        private Label LModificar;
        private Label LDNI;
        private Label LApellido;
        private Label LNombre;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button BGuardar;
        private Button BEliminar;
    }
}