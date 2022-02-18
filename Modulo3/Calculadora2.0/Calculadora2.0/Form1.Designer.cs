namespace Calculadora2_0
{
    partial class formCalc
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Num1 = new System.Windows.Forms.Label();
            this.label_Num2 = new System.Windows.Forms.Label();
            this.radioButtonSuma = new System.Windows.Forms.RadioButton();
            this.radioButtonResta = new System.Windows.Forms.RadioButton();
            this.radioButtonMutliplicacion = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.textBox_Num1 = new System.Windows.Forms.TextBox();
            this.textBox_Num2 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Num1
            // 
            this.label_Num1.AutoSize = true;
            this.label_Num1.Location = new System.Drawing.Point(29, 38);
            this.label_Num1.Name = "label_Num1";
            this.label_Num1.Size = new System.Drawing.Size(53, 13);
            this.label_Num1.TabIndex = 0;
            this.label_Num1.Text = "Numero 1";
            // 
            // label_Num2
            // 
            this.label_Num2.AutoSize = true;
            this.label_Num2.Location = new System.Drawing.Point(30, 69);
            this.label_Num2.Name = "label_Num2";
            this.label_Num2.Size = new System.Drawing.Size(53, 13);
            this.label_Num2.TabIndex = 1;
            this.label_Num2.Text = "Numero 2";
            this.label_Num2.Click += new System.EventHandler(this.label_Num2_Click);
            // 
            // radioButtonSuma
            // 
            this.radioButtonSuma.AutoSize = true;
            this.radioButtonSuma.Location = new System.Drawing.Point(12, 109);
            this.radioButtonSuma.Name = "radioButtonSuma";
            this.radioButtonSuma.Size = new System.Drawing.Size(61, 17);
            this.radioButtonSuma.TabIndex = 2;
            this.radioButtonSuma.TabStop = true;
            this.radioButtonSuma.Text = "+ Suma";
            this.radioButtonSuma.UseVisualStyleBackColor = true;
            this.radioButtonSuma.CheckedChanged += new System.EventHandler(this.radioButtonSuma_CheckedChanged);
            // 
            // radioButtonResta
            // 
            this.radioButtonResta.AutoSize = true;
            this.radioButtonResta.Location = new System.Drawing.Point(12, 147);
            this.radioButtonResta.Name = "radioButtonResta";
            this.radioButtonResta.Size = new System.Drawing.Size(59, 17);
            this.radioButtonResta.TabIndex = 3;
            this.radioButtonResta.TabStop = true;
            this.radioButtonResta.Text = "- Resta";
            this.radioButtonResta.UseVisualStyleBackColor = true;
            this.radioButtonResta.CheckedChanged += new System.EventHandler(this.radioButtonResta_CheckedChanged);
            // 
            // radioButtonMutliplicacion
            // 
            this.radioButtonMutliplicacion.AutoSize = true;
            this.radioButtonMutliplicacion.Location = new System.Drawing.Point(118, 109);
            this.radioButtonMutliplicacion.Name = "radioButtonMutliplicacion";
            this.radioButtonMutliplicacion.Size = new System.Drawing.Size(96, 17);
            this.radioButtonMutliplicacion.TabIndex = 4;
            this.radioButtonMutliplicacion.TabStop = true;
            this.radioButtonMutliplicacion.Text = "* Multiplicación";
            this.radioButtonMutliplicacion.UseVisualStyleBackColor = true;
            this.radioButtonMutliplicacion.CheckedChanged += new System.EventHandler(this.radioButtonMutliplicacion_CheckedChanged);
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(118, 147);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDivision.TabIndex = 5;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "/ División";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            this.radioButtonDivision.CheckedChanged += new System.EventHandler(this.radioButtonDivision_CheckedChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(130, 170);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(99, 26);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(207, 38);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(47, 13);
            this.labelNum1.TabIndex = 8;
            this.labelNum1.Text = "Mensaje";
            this.labelNum1.Visible = false;
            this.labelNum1.Click += new System.EventHandler(this.labelNum1_Click);
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(207, 69);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(47, 13);
            this.labelNum2.TabIndex = 9;
            this.labelNum2.Text = "Mensaje";
            this.labelNum2.Visible = false;
            this.labelNum2.Click += new System.EventHandler(this.labelNum2_Click);
            // 
            // textBox_Num1
            // 
            this.textBox_Num1.Location = new System.Drawing.Point(84, 35);
            this.textBox_Num1.Name = "textBox_Num1";
            this.textBox_Num1.Size = new System.Drawing.Size(117, 20);
            this.textBox_Num1.TabIndex = 10;
            this.textBox_Num1.TextChanged += new System.EventHandler(this.textBox_Num1_TextChanged);
            // 
            // textBox_Num2
            // 
            this.textBox_Num2.Location = new System.Drawing.Point(84, 66);
            this.textBox_Num2.Name = "textBox_Num2";
            this.textBox_Num2.Size = new System.Drawing.Size(117, 20);
            this.textBox_Num2.TabIndex = 11;
            this.textBox_Num2.TextChanged += new System.EventHandler(this.textBox_Num2_TextChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(257, 175);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(61, 13);
            this.labelResultado.TabIndex = 12;
            this.labelResultado.Text = "Resultado: ";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Enabled = false;
            this.textBoxResultado.Location = new System.Drawing.Point(313, 174);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(68, 20);
            this.textBoxResultado.TabIndex = 13;
            // 
            // buttonCalculo
            // 
            this.buttonCalculo.Location = new System.Drawing.Point(12, 170);
            this.buttonCalculo.Name = "buttonCalculo";
            this.buttonCalculo.Size = new System.Drawing.Size(99, 26);
            this.buttonCalculo.TabIndex = 14;
            this.buttonCalculo.Text = "Calculo";
            this.buttonCalculo.UseVisualStyleBackColor = true;
            this.buttonCalculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // formCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 204);
            this.Controls.Add(this.buttonCalculo);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBox_Num2);
            this.Controls.Add(this.textBox_Num1);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.radioButtonDivision);
            this.Controls.Add(this.radioButtonMutliplicacion);
            this.Controls.Add(this.radioButtonResta);
            this.Controls.Add(this.radioButtonSuma);
            this.Controls.Add(this.label_Num2);
            this.Controls.Add(this.label_Num1);
            this.Name = "formCalc";
            this.Text = "Calculadora2.0";
            this.Load += new System.EventHandler(this.formCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Num1;
        private System.Windows.Forms.Label label_Num2;
        private System.Windows.Forms.RadioButton radioButtonSuma;
        private System.Windows.Forms.RadioButton radioButtonResta;
        private System.Windows.Forms.RadioButton radioButtonMutliplicacion;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.TextBox textBox_Num1;
        private System.Windows.Forms.TextBox textBox_Num2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCalculo;
    }
}

