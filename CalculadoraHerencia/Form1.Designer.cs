namespace CalculadoraHerencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(141, 57);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(100, 20);
            this.txtv1.TabIndex = 3;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(141, 98);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(100, 20);
            this.txtv2.TabIndex = 4;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(141, 134);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 5;
            // 
            // BtnSuma
            // 
            this.BtnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuma.Location = new System.Drawing.Point(278, 37);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(37, 29);
            this.BtnSuma.TabIndex = 6;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResta.Location = new System.Drawing.Point(278, 72);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(37, 29);
            this.BtnResta.TabIndex = 7;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = true;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(278, 107);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(37, 29);
            this.BtnMult.TabIndex = 8;
            this.BtnMult.Text = "x";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(278, 142);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(37, 29);
            this.BtnDiv.TabIndex = 9;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 213);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnDiv;
    }
}

