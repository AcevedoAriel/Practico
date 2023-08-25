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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel1 = new Panel();
            LTarjetaCredito = new Label();
            CBMasterCard = new CheckBox();
            CBVisa = new CheckBox();
            LTelefono = new Label();
            TTelefono = new TextBox();
            CBNaranja = new CheckBox();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            BSalir = new Button();
            LNuevoCliente = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.BackColor = SystemColors.AppWorkspace;
            LNyA.Location = new Point(52, 77);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(107, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.AppWorkspace;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(170, 77);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.BackColor = SystemColors.AppWorkspace;
            LDNI.Location = new Point(52, 112);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(27, 15);
            LDNI.TabIndex = 2;
            LDNI.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = SystemColors.AppWorkspace;
            LApellido.Location = new Point(52, 156);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.AppWorkspace;
            LNombre.Location = new Point(52, 201);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            LNombre.Click += label5_Click;
            // 
            // TDni
            // 
            TDni.Location = new Point(128, 109);
            TDni.Name = "TDni";
            TDni.ShortcutsEnabled = false;
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(128, 153);
            TApellido.Name = "TApellido";
            TApellido.ShortcutsEnabled = false;
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(128, 198);
            TNombre.Name = "TNombre";
            TNombre.ShortcutsEnabled = false;
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Image = (Image)resources.GetObject("BGuardar.Image");
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(52, 403);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(105, 65);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += button1_Click;
            // 
            // BEliminar
            // 
            BEliminar.Image = (Image)resources.GetObject("BEliminar.Image");
            BEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BEliminar.Location = new Point(170, 403);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(105, 65);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(LTarjetaCredito);
            panel1.Controls.Add(CBMasterCard);
            panel1.Controls.Add(CBVisa);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(CBNaranja);
            panel1.Location = new Point(37, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 324);
            panel1.TabIndex = 10;
            // 
            // LTarjetaCredito
            // 
            LTarjetaCredito.AutoSize = true;
            LTarjetaCredito.Location = new Point(18, 238);
            LTarjetaCredito.Name = "LTarjetaCredito";
            LTarjetaCredito.Size = new Size(107, 15);
            LTarjetaCredito.TabIndex = 16;
            LTarjetaCredito.Text = "Tarjeta de Creditos:";
            // 
            // CBMasterCard
            // 
            CBMasterCard.AutoSize = true;
            CBMasterCard.Location = new Point(136, 288);
            CBMasterCard.Name = "CBMasterCard";
            CBMasterCard.Size = new Size(85, 19);
            CBMasterCard.TabIndex = 15;
            CBMasterCard.Text = "Mastercard";
            CBMasterCard.UseVisualStyleBackColor = true;
            // 
            // CBVisa
            // 
            CBVisa.AutoSize = true;
            CBVisa.Location = new Point(136, 263);
            CBVisa.Name = "CBVisa";
            CBVisa.Size = new Size(47, 19);
            CBVisa.TabIndex = 14;
            CBVisa.Text = "Visa";
            CBVisa.UseVisualStyleBackColor = true;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(15, 189);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 11;
            LTelefono.Text = "Telefono";
            LTelefono.Click += label1_Click;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(91, 186);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 12;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // CBNaranja
            // 
            CBNaranja.AutoSize = true;
            CBNaranja.Location = new Point(136, 238);
            CBNaranja.Name = "CBNaranja";
            CBNaranja.Size = new Size(67, 19);
            CBNaranja.TabIndex = 13;
            CBNaranja.Text = "Naranja";
            CBNaranja.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(362, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 139);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(339, 214);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 15;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(450, 214);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 16;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // BSalir
            // 
            BSalir.Image = (Image)resources.GetObject("BSalir.Image");
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(408, 403);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(98, 65);
            BSalir.TabIndex = 17;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // LNuevoCliente
            // 
            LNuevoCliente.AutoSize = true;
            LNuevoCliente.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LNuevoCliente.ForeColor = Color.DodgerBlue;
            LNuevoCliente.Location = new Point(170, -1);
            LNuevoCliente.Name = "LNuevoCliente";
            LNuevoCliente.Size = new Size(198, 37);
            LNuevoCliente.TabIndex = 18;
            LNuevoCliente.Text = "Nuevo Cliente";
            LNuevoCliente.Click += label1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(362, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 139);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 480);
            Controls.Add(LNuevoCliente);
            Controls.Add(BSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
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
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel1;
        private Label LTelefono;
        private TextBox TTelefono;
        private CheckBox CBNaranja;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Label LTarjetaCredito;
        private CheckBox CBMasterCard;
        private CheckBox CBVisa;
        private Button BSalir;
        private Label LNuevoCliente;
        private PictureBox pictureBox2;
    }
}