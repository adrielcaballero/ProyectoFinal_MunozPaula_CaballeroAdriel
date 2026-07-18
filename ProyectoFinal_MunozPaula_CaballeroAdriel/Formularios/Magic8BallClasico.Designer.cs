namespace ProyectoFinal_MunozPaula_CaballeroAdriel
{
    partial class Magic8BallClasico
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
            this.lbInstruccion = new System.Windows.Forms.Label();
            this.tbPregunta = new System.Windows.Forms.TextBox();
            this.btPreguntar = new System.Windows.Forms.Button();
            this.pbBola = new System.Windows.Forms.PictureBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.timerAgitar = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInstruccion
            // 
            this.lbInstruccion.AutoSize = true;
            this.lbInstruccion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lbInstruccion.Location = new System.Drawing.Point(14, 347);
            this.lbInstruccion.Name = "lbInstruccion";
            this.lbInstruccion.Size = new System.Drawing.Size(189, 19);
            this.lbInstruccion.TabIndex = 0;
            this.lbInstruccion.Text = "Escribe tu pregunta:";
            // 
            // tbPregunta
            // 
            this.tbPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.tbPregunta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPregunta.Location = new System.Drawing.Point(209, 344);
            this.tbPregunta.Name = "tbPregunta";
            this.tbPregunta.Size = new System.Drawing.Size(401, 26);
            this.tbPregunta.TabIndex = 1;
            // 
            // btPreguntar
            // 
            this.btPreguntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btPreguntar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPreguntar.Location = new System.Drawing.Point(63, 396);
            this.btPreguntar.Name = "btPreguntar";
            this.btPreguntar.Size = new System.Drawing.Size(194, 31);
            this.btPreguntar.TabIndex = 5;
            this.btPreguntar.Text = "Preguntar";
            this.btPreguntar.UseVisualStyleBackColor = false;
            this.btPreguntar.Click += new System.EventHandler(this.btPreguntar_Click);
            // 
            // pbBola
            // 
            this.pbBola.Location = new System.Drawing.Point(178, 57);
            this.pbBola.Name = "pbBola";
            this.pbBola.Size = new System.Drawing.Size(305, 273);
            this.pbBola.TabIndex = 6;
            this.pbBola.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btSalir.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btSalir.Location = new System.Drawing.Point(516, 407);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(95, 31);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btVolver.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btVolver.Location = new System.Drawing.Point(393, 407);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(95, 31);
            this.btVolver.TabIndex = 8;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
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
            this.lbTitulo.Location = new System.Drawing.Point(12, 19);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(314, 32);
            this.lbTitulo.TabIndex = 9;
            this.lbTitulo.Text = "Magic 8 Ball Clásico";
            // 
            // Magic8BallClasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(140)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.pbBola);
            this.Controls.Add(this.btPreguntar);
            this.Controls.Add(this.tbPregunta);
            this.Controls.Add(this.lbInstruccion);
            this.Name = "Magic8BallClasico";
            this.Text = "Magic8Ball";
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInstruccion;
        private System.Windows.Forms.TextBox tbPregunta;
        private System.Windows.Forms.Button btPreguntar;
        private System.Windows.Forms.PictureBox pbBola;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Timer timerAgitar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbTitulo;
    }
}