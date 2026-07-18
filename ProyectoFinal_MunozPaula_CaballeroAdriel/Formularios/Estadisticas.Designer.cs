namespace ProyectoFinal_MunozPaula_CaballeroAdriel
{
    partial class Estadisticas
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
            this.btSalir = new System.Windows.Forms.Button();
            this.lbTotalPreguntas = new System.Windows.Forms.Label();
            this.lbPositivas = new System.Windows.Forms.Label();
            this.lbNegativas = new System.Windows.Forms.Label();
            this.lbIndecisas = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btSalir.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btSalir.Location = new System.Drawing.Point(37, 407);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(95, 31);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbTotalPreguntas
            // 
            this.lbTotalPreguntas.AutoSize = true;
            this.lbTotalPreguntas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPreguntas.Location = new System.Drawing.Point(45, 118);
            this.lbTotalPreguntas.Name = "lbTotalPreguntas";
            this.lbTotalPreguntas.Size = new System.Drawing.Size(0, 19);
            this.lbTotalPreguntas.TabIndex = 2;
            // 
            // lbPositivas
            // 
            this.lbPositivas.AutoSize = true;
            this.lbPositivas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPositivas.Location = new System.Drawing.Point(45, 175);
            this.lbPositivas.Name = "lbPositivas";
            this.lbPositivas.Size = new System.Drawing.Size(0, 19);
            this.lbPositivas.TabIndex = 3;
            // 
            // lbNegativas
            // 
            this.lbNegativas.AutoSize = true;
            this.lbNegativas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNegativas.Location = new System.Drawing.Point(45, 208);
            this.lbNegativas.Name = "lbNegativas";
            this.lbNegativas.Size = new System.Drawing.Size(0, 19);
            this.lbNegativas.TabIndex = 4;
            // 
            // lbIndecisas
            // 
            this.lbIndecisas.AutoSize = true;
            this.lbIndecisas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndecisas.Location = new System.Drawing.Point(45, 246);
            this.lbIndecisas.Name = "lbIndecisas";
            this.lbIndecisas.Size = new System.Drawing.Size(0, 19);
            this.lbIndecisas.TabIndex = 5;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(45, 279);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(0, 19);
            this.lbCategoria.TabIndex = 6;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btVolver.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btVolver.Location = new System.Drawing.Point(188, 407);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(95, 31);
            this.btVolver.TabIndex = 7;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(60, 43);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(194, 32);
            this.lbTitulo.TabIndex = 14;
            this.lbTitulo.Text = "Estadísticas";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(140)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbIndecisas);
            this.Controls.Add(this.lbNegativas);
            this.Controls.Add(this.lbPositivas);
            this.Controls.Add(this.lbTotalPreguntas);
            this.Controls.Add(this.btSalir);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbTotalPreguntas;
        private System.Windows.Forms.Label lbPositivas;
        private System.Windows.Forms.Label lbNegativas;
        private System.Windows.Forms.Label lbIndecisas;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label lbTitulo;
    }
}