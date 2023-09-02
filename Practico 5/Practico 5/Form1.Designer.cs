namespace Practico_5
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            LNombre = new Label();
            LApellido = new Label();
            LFechaNacimiento = new Label();
            LSexo = new Label();
            LSaldo = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TSaldo = new TextBox();
            TFoto = new TextBox();
            BFoto = new Button();
            BAgregar = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            RBMujer = new RadioButton();
            RBHombre = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            PBHombre = new PictureBox();
            PBMujer = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewImageColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBHombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMujer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = Color.Transparent;
            LNombre.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(20, 11);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(92, 33);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = Color.Transparent;
            LApellido.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(20, 40);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(98, 33);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido:";
            // 
            // LFechaNacimiento
            // 
            LFechaNacimiento.AutoSize = true;
            LFechaNacimiento.BackColor = Color.Transparent;
            LFechaNacimiento.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LFechaNacimiento.ForeColor = Color.White;
            LFechaNacimiento.Location = new Point(20, 84);
            LFechaNacimiento.Name = "LFechaNacimiento";
            LFechaNacimiento.Size = new Size(184, 33);
            LFechaNacimiento.TabIndex = 2;
            LFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.BackColor = Color.Transparent;
            LSexo.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LSexo.ForeColor = Color.White;
            LSexo.Location = new Point(20, 117);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(70, 33);
            LSexo.TabIndex = 3;
            LSexo.Text = "Sexo:";
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.BackColor = Color.Transparent;
            LSaldo.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LSaldo.ForeColor = Color.White;
            LSaldo.Location = new Point(20, 150);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(78, 33);
            LSaldo.TabIndex = 4;
            LSaldo.Text = "Saldo:";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(132, 18);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(225, 23);
            TNombre.TabIndex = 5;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(132, 47);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(225, 23);
            TApellido.TabIndex = 6;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TSaldo
            // 
            TSaldo.Location = new Point(132, 157);
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(225, 23);
            TSaldo.TabIndex = 7;
            TSaldo.KeyPress += TSaldo_KeyPress;
            // 
            // TFoto
            // 
            TFoto.Location = new Point(132, 186);
            TFoto.Name = "TFoto";
            TFoto.Size = new Size(225, 23);
            TFoto.TabIndex = 8;
            // 
            // BFoto
            // 
            BFoto.Location = new Point(23, 185);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(75, 23);
            BFoto.TabIndex = 9;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = true;
            BFoto.Click += BFoto_Click;
            // 
            // BAgregar
            // 
            BAgregar.Image = (Image)resources.GetObject("BAgregar.Image");
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(151, 224);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(104, 57);
            BAgregar.TabIndex = 10;
            BAgregar.Text = "Agregar";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(210, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(81, 23);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(2023, 8, 28, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(RBMujer);
            panel1.Controls.Add(RBHombre);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BFoto);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(TFoto);
            panel1.Controls.Add(LSaldo);
            panel1.Controls.Add(TSaldo);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LFechaNacimiento);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LSexo);
            panel1.Location = new Point(54, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 290);
            panel1.TabIndex = 15;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.BackColor = Color.Transparent;
            RBMujer.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBMujer.ForeColor = Color.White;
            RBMujer.Location = new Point(220, 117);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(88, 37);
            RBMujer.TabIndex = 16;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = false;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.BackColor = Color.Transparent;
            RBHombre.Checked = true;
            RBHombre.Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBHombre.ForeColor = Color.White;
            RBHombre.Location = new Point(96, 117);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(107, 37);
            RBHombre.TabIndex = 15;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = false;
            RBHombre.CheckedChanged += RBHombre_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos PNG(*.png)|*.png|Archivo JPG(*.jpg)|*.jpg";
            // 
            // PBHombre
            // 
            PBHombre.BackgroundImage = Properties.Resources.perfil_hombre;
            PBHombre.BackgroundImageLayout = ImageLayout.Stretch;
            PBHombre.Location = new Point(476, 24);
            PBHombre.Name = "PBHombre";
            PBHombre.Size = new Size(363, 290);
            PBHombre.TabIndex = 16;
            PBHombre.TabStop = false;
            // 
            // PBMujer
            // 
            PBMujer.BackgroundImage = (Image)resources.GetObject("PBMujer.BackgroundImage");
            PBMujer.BackgroundImageLayout = ImageLayout.Stretch;
            PBMujer.Location = new Point(476, 24);
            PBMujer.Name = "PBMujer";
            PBMujer.Size = new Size(363, 290);
            PBMujer.TabIndex = 17;
            PBMujer.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Eliminar });
            dataGridView1.Location = new Point(32, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(807, 150);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Apellido";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Fecha de Nacimiento";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Saldo";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.HeaderText = "Foto";
            Column6.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Width = 64;
            // 
            // Column7
            // 
            Column7.HeaderText = "Ruta";
            Column7.Name = "Column7";
            // 
            // Eliminar
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            Eliminar.DefaultCellStyle = dataGridViewCellStyle5;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 480);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(PBHombre);
            Controls.Add(PBMujer);
            Name = "Form1";
            Text = "Formulario con DataGrid";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBHombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMujer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LNombre;
        private Label LApellido;
        private Label LFechaNacimiento;
        private Label LSexo;
        private Label LSaldo;
        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TSaldo;
        private TextBox TFoto;
        private Button BFoto;
        private Button BAgregar;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private OpenFileDialog openFileDialog1;
        private PictureBox PBHombre;
        private PictureBox PBMujer;
        private RadioButton RBMujer;
        private RadioButton RBHombre;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Eliminar;
    }
}