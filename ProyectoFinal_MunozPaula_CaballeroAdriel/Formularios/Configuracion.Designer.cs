namespace ProyectoFinal_MunozPaula_CaballeroAdriel
{
    partial class Configuracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.btRestablecer = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.rbModoVerde = new System.Windows.Forms.RadioButton();
            this.rbModoRojo = new System.Windows.Forms.RadioButton();
            this.rbModoAzul = new System.Windows.Forms.RadioButton();
            this.btSalir = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modo:";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(41, 51);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(194, 32);
            this.lbLabel.TabIndex = 5;
            this.lbLabel.Text = "¡Bienvenido!";
            // 
            // cbTiempo
            // 
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Location = new System.Drawing.Point(56, 266);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(121, 21);
            this.cbTiempo.TabIndex = 6;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(53, 250);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(160, 13);
            this.lbTiempo.TabIndex = 7;
            this.lbTiempo.Text = "Tiempo de responder preguntas:";
            // 
            // btRestablecer
            // 
            this.btRestablecer.Location = new System.Drawing.Point(160, 348);
            this.btRestablecer.Name = "btRestablecer";
            this.btRestablecer.Size = new System.Drawing.Size(75, 23);
            this.btRestablecer.TabIndex = 9;
            this.btRestablecer.Text = "Restablecer";
            this.btRestablecer.UseVisualStyleBackColor = true;
            this.btRestablecer.Click += new System.EventHandler(this.btRestablecer_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(35, 348);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // rbModoVerde
            // 
            this.rbModoVerde.AutoSize = true;
            this.rbModoVerde.Location = new System.Drawing.Point(46, 169);
            this.rbModoVerde.Name = "rbModoVerde";
            this.rbModoVerde.Size = new System.Drawing.Size(83, 17);
            this.rbModoVerde.TabIndex = 11;
            this.rbModoVerde.TabStop = true;
            this.rbModoVerde.Text = "Modo Verde";
            this.rbModoVerde.UseVisualStyleBackColor = true;
            // 
            // rbModoRojo
            // 
            this.rbModoRojo.AutoSize = true;
            this.rbModoRojo.Location = new System.Drawing.Point(137, 169);
            this.rbModoRojo.Name = "rbModoRojo";
            this.rbModoRojo.Size = new System.Drawing.Size(77, 17);
            this.rbModoRojo.TabIndex = 12;
            this.rbModoRojo.TabStop = true;
            this.rbModoRojo.Text = "Modo Rojo";
            this.rbModoRojo.UseVisualStyleBackColor = true;
            // 
            // rbModoAzul
            // 
            this.rbModoAzul.AutoSize = true;
            this.rbModoAzul.Location = new System.Drawing.Point(93, 202);
            this.rbModoAzul.Name = "rbModoAzul";
            this.rbModoAzul.Size = new System.Drawing.Size(75, 17);
            this.rbModoAzul.TabIndex = 13;
            this.rbModoAzul.TabStop = true;
            this.rbModoAzul.Text = "Modo Azul";
            this.rbModoAzul.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(35, 399);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 0;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(160, 399);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 14;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.rbModoAzul);
            this.Controls.Add(this.rbModoRojo);
            this.Controls.Add(this.rbModoVerde);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btRestablecer);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Name = "Configuracion";
            this.Text = "Coniguracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Button btRestablecer;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.RadioButton rbModoVerde;
        private System.Windows.Forms.RadioButton rbModoRojo;
        private System.Windows.Forms.RadioButton rbModoAzul;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btVolver;
    }
}