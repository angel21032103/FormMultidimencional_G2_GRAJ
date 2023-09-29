namespace FormMultidimencional_G2_GRAJ
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMatriz1 = new System.Windows.Forms.Label();
            this.lbMatriz2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.rdbRad = new System.Windows.Forms.RadioButton();
            this.rdbDeg = new System.Windows.Forms.RadioButton();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(111, 71);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(381, 20);
            this.txtDisplay.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(246, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "T";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Red;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Window;
            this.btn2.Location = new System.Drawing.Point(382, 357);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(119, 55);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "C";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btnIntro
            // 
            this.btnIntro.BackColor = System.Drawing.Color.Yellow;
            this.btnIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(554, 291);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(53, 99);
            this.btnIntro.TabIndex = 1;
            this.btnIntro.Text = "In";
            this.btnIntro.UseVisualStyleBackColor = false;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // lbMatriz1
            // 
            this.lbMatriz1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatriz1.Location = new System.Drawing.Point(96, 147);
            this.lbMatriz1.Name = "lbMatriz1";
            this.lbMatriz1.Size = new System.Drawing.Size(105, 80);
            this.lbMatriz1.TabIndex = 2;
            this.lbMatriz1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMatriz2
            // 
            this.lbMatriz2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatriz2.Location = new System.Drawing.Point(243, 147);
            this.lbMatriz2.Name = "lbMatriz2";
            this.lbMatriz2.Size = new System.Drawing.Size(103, 80);
            this.lbMatriz2.TabIndex = 2;
            this.lbMatriz2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(397, 138);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(127, 98);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbRad
            // 
            this.rdbRad.AutoSize = true;
            this.rdbRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRad.Location = new System.Drawing.Point(130, 35);
            this.rdbRad.Name = "rdbRad";
            this.rdbRad.Size = new System.Drawing.Size(48, 20);
            this.rdbRad.TabIndex = 3;
            this.rdbRad.TabStop = true;
            this.rdbRad.Text = "rad";
            this.rdbRad.UseVisualStyleBackColor = true;
            // 
            // rdbDeg
            // 
            this.rdbDeg.AutoSize = true;
            this.rdbDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDeg.Location = new System.Drawing.Point(400, 35);
            this.rdbDeg.Name = "rdbDeg";
            this.rdbDeg.Size = new System.Drawing.Size(52, 20);
            this.rdbDeg.TabIndex = 3;
            this.rdbDeg.TabStop = true;
            this.rdbDeg.Text = "deg";
            this.rdbDeg.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(108, 265);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(119, 55);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(246, 265);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(119, 55);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(382, 265);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(119, 55);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 486);
            this.Controls.Add(this.rdbDeg);
            this.Controls.Add(this.rdbRad);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMatriz2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMatriz1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMatriz1;
        private System.Windows.Forms.Label lbMatriz2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.RadioButton rdbRad;
        private System.Windows.Forms.RadioButton rdbDeg;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}

