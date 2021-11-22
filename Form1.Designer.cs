
namespace numeros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtposicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstresultado = new System.Windows.Forms.ListBox();
            this.txtresusltado = new System.Windows.Forms.TextBox();
            this.txtpotencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpotencia = new System.Windows.Forms.Button();
            this.btnfactorial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtordenar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbgenerar = new System.Windows.Forms.ListBox();
            this.lbordenar = new System.Windows.Forms.ListBox();
            this.txtcanti = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ordenamiento = new System.Windows.Forms.TabPage();
            this.Recursividad = new System.Windows.Forms.TabPage();
            this.MetodoBurbuja = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.Ordenamiento.SuspendLayout();
            this.Recursividad.SuspendLayout();
            this.MetodoBurbuja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Numero :";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(143, 32);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(165, 25);
            this.txtnumero.TabIndex = 2;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnagregar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(6, 160);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 23);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnmostrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnmostrar.Location = new System.Drawing.Point(6, 189);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(128, 23);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(140, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Insertar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(140, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Eliminar x Posicion";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnEliminarxposicion_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(276, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtposicion
            // 
            this.txtposicion.Location = new System.Drawing.Point(143, 65);
            this.txtposicion.Name = "txtposicion";
            this.txtposicion.Size = new System.Drawing.Size(165, 25);
            this.txtposicion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Posicion :";
            // 
            // lstresultado
            // 
            this.lstresultado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresultado.FormattingEnabled = true;
            this.lstresultado.ItemHeight = 15;
            this.lstresultado.Location = new System.Drawing.Point(6, 231);
            this.lstresultado.Name = "lstresultado";
            this.lstresultado.Size = new System.Drawing.Size(332, 169);
            this.lstresultado.TabIndex = 10;
            // 
            // txtresusltado
            // 
            this.txtresusltado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtresusltado.Location = new System.Drawing.Point(6, 247);
            this.txtresusltado.Multiline = true;
            this.txtresusltado.Name = "txtresusltado";
            this.txtresusltado.Size = new System.Drawing.Size(336, 157);
            this.txtresusltado.TabIndex = 12;
            // 
            // txtpotencia
            // 
            this.txtpotencia.Location = new System.Drawing.Point(107, 71);
            this.txtpotencia.Name = "txtpotencia";
            this.txtpotencia.Size = new System.Drawing.Size(122, 25);
            this.txtpotencia.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Potencia :";
            // 
            // btnpotencia
            // 
            this.btnpotencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpotencia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnpotencia.Location = new System.Drawing.Point(6, 181);
            this.btnpotencia.Name = "btnpotencia";
            this.btnpotencia.Size = new System.Drawing.Size(130, 60);
            this.btnpotencia.TabIndex = 15;
            this.btnpotencia.Text = "Potencia";
            this.btnpotencia.UseVisualStyleBackColor = false;
            this.btnpotencia.Click += new System.EventHandler(this.btnpotencia_Click);
            // 
            // btnfactorial
            // 
            this.btnfactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnfactorial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnfactorial.Location = new System.Drawing.Point(212, 181);
            this.btnfactorial.Name = "btnfactorial";
            this.btnfactorial.Size = new System.Drawing.Size(130, 60);
            this.btnfactorial.TabIndex = 16;
            this.btnfactorial.Text = "Factorial";
            this.btnfactorial.UseVisualStyleBackColor = false;
            this.btnfactorial.Click += new System.EventHandler(this.btnfactorial_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(15, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtordenar
            // 
            this.txtordenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtordenar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtordenar.Location = new System.Drawing.Point(185, 171);
            this.txtordenar.Name = "txtordenar";
            this.txtordenar.Size = new System.Drawing.Size(147, 43);
            this.txtordenar.TabIndex = 18;
            this.txtordenar.Text = "Ordenar";
            this.txtordenar.UseVisualStyleBackColor = false;
            this.txtordenar.Click += new System.EventHandler(this.txtordenar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(55, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Metodo de Burbuja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(84, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Recursividad";
            // 
            // lbgenerar
            // 
            this.lbgenerar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbgenerar.FormattingEnabled = true;
            this.lbgenerar.ItemHeight = 15;
            this.lbgenerar.Location = new System.Drawing.Point(15, 220);
            this.lbgenerar.Name = "lbgenerar";
            this.lbgenerar.Size = new System.Drawing.Size(127, 184);
            this.lbgenerar.TabIndex = 23;
            // 
            // lbordenar
            // 
            this.lbordenar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbordenar.FormattingEnabled = true;
            this.lbordenar.ItemHeight = 15;
            this.lbordenar.Location = new System.Drawing.Point(185, 220);
            this.lbordenar.Name = "lbordenar";
            this.lbordenar.Size = new System.Drawing.Size(147, 184);
            this.lbordenar.TabIndex = 24;
            // 
            // txtcanti
            // 
            this.txtcanti.Location = new System.Drawing.Point(179, 38);
            this.txtcanti.Name = "txtcanti";
            this.txtcanti.Size = new System.Drawing.Size(115, 25);
            this.txtcanti.TabIndex = 25;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(107, 19);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(121, 25);
            this.txtnumero2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = " Numero :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ordenamiento);
            this.tabControl1.Controls.Add(this.Recursividad);
            this.tabControl1.Controls.Add(this.MetodoBurbuja);
            this.tabControl1.Location = new System.Drawing.Point(7, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 436);
            this.tabControl1.TabIndex = 28;
            // 
            // Ordenamiento
            // 
            this.Ordenamiento.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Ordenamiento.Controls.Add(this.groupBox1);
            this.Ordenamiento.Controls.Add(this.label1);
            this.Ordenamiento.Controls.Add(this.btnagregar);
            this.Ordenamiento.Controls.Add(this.btnmostrar);
            this.Ordenamiento.Controls.Add(this.button3);
            this.Ordenamiento.Controls.Add(this.button4);
            this.Ordenamiento.Controls.Add(this.button5);
            this.Ordenamiento.Controls.Add(this.lstresultado);
            this.Ordenamiento.Location = new System.Drawing.Point(4, 22);
            this.Ordenamiento.Name = "Ordenamiento";
            this.Ordenamiento.Padding = new System.Windows.Forms.Padding(3);
            this.Ordenamiento.Size = new System.Drawing.Size(348, 410);
            this.Ordenamiento.TabIndex = 0;
            this.Ordenamiento.Text = "Ordenamiento";
            // 
            // Recursividad
            // 
            this.Recursividad.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Recursividad.Controls.Add(this.groupBox2);
            this.Recursividad.Controls.Add(this.txtresusltado);
            this.Recursividad.Controls.Add(this.btnpotencia);
            this.Recursividad.Controls.Add(this.btnfactorial);
            this.Recursividad.Controls.Add(this.label6);
            this.Recursividad.Location = new System.Drawing.Point(4, 22);
            this.Recursividad.Name = "Recursividad";
            this.Recursividad.Padding = new System.Windows.Forms.Padding(3);
            this.Recursividad.Size = new System.Drawing.Size(348, 410);
            this.Recursividad.TabIndex = 1;
            this.Recursividad.Text = "Recursividad";
            // 
            // MetodoBurbuja
            // 
            this.MetodoBurbuja.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MetodoBurbuja.Controls.Add(this.groupBox3);
            this.MetodoBurbuja.Controls.Add(this.txtordenar);
            this.MetodoBurbuja.Controls.Add(this.button1);
            this.MetodoBurbuja.Controls.Add(this.lbordenar);
            this.MetodoBurbuja.Controls.Add(this.label5);
            this.MetodoBurbuja.Controls.Add(this.lbgenerar);
            this.MetodoBurbuja.Location = new System.Drawing.Point(4, 22);
            this.MetodoBurbuja.Name = "MetodoBurbuja";
            this.MetodoBurbuja.Size = new System.Drawing.Size(348, 410);
            this.MetodoBurbuja.TabIndex = 2;
            this.MetodoBurbuja.Text = "MetodoBurbuja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.txtposicion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnumero2);
            this.groupBox2.Controls.Add(this.txtpotencia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(6, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 117);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 38);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cantidad de Numeros:\r\n(Max. 100)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcanti);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(15, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 102);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Ordenamiento.ResumeLayout(false);
            this.Ordenamiento.PerformLayout();
            this.Recursividad.ResumeLayout(false);
            this.Recursividad.PerformLayout();
            this.MetodoBurbuja.ResumeLayout(false);
            this.MetodoBurbuja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtposicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstresultado;
        private System.Windows.Forms.TextBox txtresusltado;
        private System.Windows.Forms.TextBox txtpotencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnpotencia;
        private System.Windows.Forms.Button btnfactorial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtordenar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbgenerar;
        private System.Windows.Forms.ListBox lbordenar;
        private System.Windows.Forms.TextBox txtcanti;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ordenamiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Recursividad;
        private System.Windows.Forms.TabPage MetodoBurbuja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
    }
}

