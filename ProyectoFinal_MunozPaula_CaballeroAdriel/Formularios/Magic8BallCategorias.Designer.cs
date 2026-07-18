namespace ProyectoFinal_MunozPaula_CaballeroAdriel
{
    partial class Magic8BallCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btPreguntar = new System.Windows.Forms.Button();
            this.cbNivelSabiduria = new System.Windows.Forms.Label();
            this.cbNiveles = new System.Windows.Forms.ComboBox();
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.rbEstudios = new System.Windows.Forms.RadioButton();
            this.rbDinero = new System.Windows.Forms.RadioButton();
            this.rbTrabajo = new System.Windows.Forms.RadioButton();
            this.rbAmor = new System.Windows.Forms.RadioButton();
            this.tbPregunta = new System.Windows.Forms.TextBox();
            this.lbInstruccion = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbRespuesta = new System.Windows.Forms.Label();
            this.timerAgitar = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPreguntar
            // 
            this.btPreguntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btPreguntar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPreguntar.Location = new System.Drawing.Point(26, 375);
            this.btPreguntar.Name = "btPreguntar";
            this.btPreguntar.Size = new System.Drawing.Size(194, 31);
            this.btPreguntar.TabIndex = 11;
            this.btPreguntar.Text = "Preguntar";
            this.btPreguntar.UseVisualStyleBackColor = false;
            this.btPreguntar.Click += new System.EventHandler(this.btPreguntar_Click);
            // 
            // cbNivelSabiduria
            // 
            this.cbNivelSabiduria.AutoSize = true;
            this.cbNivelSabiduria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.cbNivelSabiduria.Location = new System.Drawing.Point(423, 225);
            this.cbNivelSabiduria.Name = "cbNivelSabiduria";
            this.cbNivelSabiduria.Size = new System.Drawing.Size(180, 19);
            this.cbNivelSabiduria.TabIndex = 10;
            this.cbNivelSabiduria.Text = "Nivel de Sabiduría:";
            // 
            // cbNiveles
            // 
            this.cbNiveles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNiveles.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNiveles.FormattingEnabled = true;
            this.cbNiveles.Location = new System.Drawing.Point(427, 251);
            this.cbNiveles.Name = "cbNiveles";
            this.cbNiveles.Size = new System.Drawing.Size(172, 27);
            this.cbNiveles.TabIndex = 9;
            // 
            // gbCategorias
            // 
            this.gbCategorias.Controls.Add(this.rbEstudios);
            this.gbCategorias.Controls.Add(this.rbDinero);
            this.gbCategorias.Controls.Add(this.rbTrabajo);
            this.gbCategorias.Controls.Add(this.rbAmor);
            this.gbCategorias.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.gbCategorias.Location = new System.Drawing.Point(23, 213);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(394, 77);
            this.gbCategorias.TabIndex = 8;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "Categorías";
            // 
            // rbEstudios
            // 
            this.rbEstudios.AutoSize = true;
            this.rbEstudios.Location = new System.Drawing.Point(95, 38);
            this.rbEstudios.Name = "rbEstudios";
            this.rbEstudios.Size = new System.Drawing.Size(99, 23);
            this.rbEstudios.TabIndex = 4;
            this.rbEstudios.TabStop = true;
            this.rbEstudios.Text = "Estudios";
            this.rbEstudios.UseVisualStyleBackColor = true;
            this.rbEstudios.CheckedChanged += new System.EventHandler(this.rbEstudios_CheckedChanged);
            // 
            // rbDinero
            // 
            this.rbDinero.AutoSize = true;
            this.rbDinero.Location = new System.Drawing.Point(300, 38);
            this.rbDinero.Name = "rbDinero";
            this.rbDinero.Size = new System.Drawing.Size(81, 23);
            this.rbDinero.TabIndex = 2;
            this.rbDinero.TabStop = true;
            this.rbDinero.Text = "Dinero";
            this.rbDinero.UseVisualStyleBackColor = true;
            this.rbDinero.CheckedChanged += new System.EventHandler(this.rbDinero_CheckedChanged);
            // 
            // rbTrabajo
            // 
            this.rbTrabajo.AutoSize = true;
            this.rbTrabajo.Location = new System.Drawing.Point(200, 38);
            this.rbTrabajo.Name = "rbTrabajo";
            this.rbTrabajo.Size = new System.Drawing.Size(90, 23);
            this.rbTrabajo.TabIndex = 1;
            this.rbTrabajo.TabStop = true;
            this.rbTrabajo.Text = "Trabajo";
            this.rbTrabajo.UseVisualStyleBackColor = true;
            this.rbTrabajo.CheckedChanged += new System.EventHandler(this.rbTrabajo_CheckedChanged);
            // 
            // rbAmor
            // 
            this.rbAmor.AutoSize = true;
            this.rbAmor.Location = new System.Drawing.Point(19, 38);
            this.rbAmor.Name = "rbAmor";
            this.rbAmor.Size = new System.Drawing.Size(63, 23);
            this.rbAmor.TabIndex = 0;
            this.rbAmor.TabStop = true;
            this.rbAmor.Text = "Amor";
            this.rbAmor.UseVisualStyleBackColor = true;
            this.rbAmor.CheckedChanged += new System.EventHandler(this.rbAmor_CheckedChanged);
            // 
            // tbPregunta
            // 
            this.tbPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.tbPregunta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPregunta.Location = new System.Drawing.Point(210, 316);
            this.tbPregunta.Name = "tbPregunta";
            this.tbPregunta.Size = new System.Drawing.Size(401, 26);
            this.tbPregunta.TabIndex = 7;
            this.tbPregunta.TextChanged += new System.EventHandler(this.tbPregunta_TextChanged);
            // 
            // lbInstruccion
            // 
            this.lbInstruccion.AutoSize = true;
            this.lbInstruccion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lbInstruccion.Location = new System.Drawing.Point(19, 319);
            this.lbInstruccion.Name = "lbInstruccion";
            this.lbInstruccion.Size = new System.Drawing.Size(189, 19);
            this.lbInstruccion.TabIndex = 6;
            this.lbInstruccion.Text = "Escribe tu pregunta:";
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btVolver.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btVolver.Location = new System.Drawing.Point(516, 404);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(95, 31);
            this.btVolver.TabIndex = 13;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btSalir.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btSalir.Location = new System.Drawing.Point(392, 404);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(95, 31);
            this.btSalir.TabIndex = 12;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbRespuesta
            // 
            this.lbRespuesta.AutoSize = true;
            this.lbRespuesta.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRespuesta.Location = new System.Drawing.Point(36, 118);
            this.lbRespuesta.Name = "lbRespuesta";
            this.lbRespuesta.Size = new System.Drawing.Size(149, 32);
            this.lbRespuesta.TabIndex = 14;
            this.lbRespuesta.Text = "Respuesta";
            // 
            // timerAgitar
            // 
            this.timerAgitar.Tick += new System.EventHandler(this.timerAgitar_Tick_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(404, 32);
            this.lbTitulo.TabIndex = 15;
            this.lbTitulo.Text = "Magic 8 Ball de Categorías";
            // 
            // Magic8BallCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(140)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbRespuesta);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btPreguntar);
            this.Controls.Add(this.cbNivelSabiduria);
            this.Controls.Add(this.cbNiveles);
            this.Controls.Add(this.gbCategorias);
            this.Controls.Add(this.tbPregunta);
            this.Controls.Add(this.lbInstruccion);
            this.Name = "Magic8BallCategorias";
            this.Text = "Magic8BallCategorias";
            this.gbCategorias.ResumeLayout(false);
            this.gbCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPreguntar;
        private System.Windows.Forms.Label cbNivelSabiduria;
        private System.Windows.Forms.ComboBox cbNiveles;
        private System.Windows.Forms.GroupBox gbCategorias;
        private System.Windows.Forms.RadioButton rbEstudios;
        private System.Windows.Forms.RadioButton rbDinero;
        private System.Windows.Forms.RadioButton rbTrabajo;
        private System.Windows.Forms.RadioButton rbAmor;
        private System.Windows.Forms.TextBox tbPregunta;
        private System.Windows.Forms.Label lbInstruccion;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbRespuesta;
        private System.Windows.Forms.Timer timerAgitar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbTitulo;
    }
}