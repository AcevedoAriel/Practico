namespace Practico_4
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
            LDesde = new Label();
            LHasta = new Label();
            TDesde = new TextBox();
            THasta = new TextBox();
            listBox1 = new ListBox();
            LListaNumero = new Label();
            BGenerarFuncion = new Button();
            BNroPar = new Button();
            BNroImpar = new Button();
            BNroPrimo = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(12, 74);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(39, 15);
            LDesde.TabIndex = 0;
            LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(12, 114);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 1;
            LHasta.Text = "Hasta";
            // 
            // TDesde
            // 
            TDesde.Location = new Point(57, 71);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(100, 23);
            TDesde.TabIndex = 2;
            TDesde.KeyPress += TDesde_KeyPress;
            // 
            // THasta
            // 
            THasta.Location = new Point(57, 111);
            THasta.Name = "THasta";
            THasta.Size = new Size(100, 23);
            THasta.TabIndex = 3;
            THasta.KeyPress += THasta_KeyPress;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(168, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 259);
            listBox1.TabIndex = 4;
            // 
            // LListaNumero
            // 
            LListaNumero.AutoSize = true;
            LListaNumero.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LListaNumero.Location = new Point(168, 19);
            LListaNumero.Name = "LListaNumero";
            LListaNumero.Size = new Size(181, 30);
            LListaNumero.TabIndex = 5;
            LListaNumero.Text = "Lista de Numeros";
            // 
            // BGenerarFuncion
            // 
            BGenerarFuncion.Location = new Point(37, 150);
            BGenerarFuncion.Name = "BGenerarFuncion";
            BGenerarFuncion.Size = new Size(120, 23);
            BGenerarFuncion.TabIndex = 6;
            BGenerarFuncion.Text = "Generar Funcion";
            BGenerarFuncion.UseVisualStyleBackColor = true;
            BGenerarFuncion.Click += BGenerarFuncion_Click;
            // 
            // BNroPar
            // 
            BNroPar.Location = new Point(37, 226);
            BNroPar.Name = "BNroPar";
            BNroPar.Size = new Size(120, 23);
            BNroPar.TabIndex = 7;
            BNroPar.Text = "Numeros Pares";
            BNroPar.UseVisualStyleBackColor = true;
            BNroPar.Click += BNroPar_Click;
            // 
            // BNroImpar
            // 
            BNroImpar.Location = new Point(37, 255);
            BNroImpar.Name = "BNroImpar";
            BNroImpar.Size = new Size(120, 23);
            BNroImpar.TabIndex = 8;
            BNroImpar.Text = "Numeros Impares";
            BNroImpar.UseVisualStyleBackColor = true;
            BNroImpar.Click += BNroImpar_Click;
            // 
            // BNroPrimo
            // 
            BNroPrimo.Location = new Point(37, 284);
            BNroPrimo.Name = "BNroPrimo";
            BNroPrimo.Size = new Size(120, 23);
            BNroPrimo.TabIndex = 9;
            BNroPrimo.Text = "Numeros Primos";
            BNroPrimo.UseVisualStyleBackColor = true;
            BNroPrimo.Click += BNroPrimo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 313);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 10;
            button1.Text = "Graficar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 398);
            Controls.Add(button1);
            Controls.Add(BNroPrimo);
            Controls.Add(BNroImpar);
            Controls.Add(BNroPar);
            Controls.Add(BGenerarFuncion);
            Controls.Add(LListaNumero);
            Controls.Add(listBox1);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Controls.Add(LHasta);
            Controls.Add(LDesde);
            Name = "Form1";
            Text = "Formulario 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LDesde;
        private Label LHasta;
        private TextBox TDesde;
        private TextBox THasta;
        private ListBox listBox1;
        private Label LListaNumero;
        private Button BGenerarFuncion;
        private Button BNroPar;
        private Button BNroImpar;
        private Button BNroPrimo;
        private Button button1;
    }
}