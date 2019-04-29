namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.grpAritmetica = new System.Windows.Forms.GroupBox();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grpAritmetica.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(188, 78);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(188, 105);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(188, 145);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(305, 70);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(305, 138);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(305, 98);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 5;
            // 
            // grpAritmetica
            // 
            this.grpAritmetica.Controls.Add(this.rdbDividir);
            this.grpAritmetica.Controls.Add(this.rdbMultiplicar);
            this.grpAritmetica.Controls.Add(this.rdbSubtrair);
            this.grpAritmetica.Controls.Add(this.rdbSomar);
            this.grpAritmetica.Location = new System.Drawing.Point(253, 198);
            this.grpAritmetica.Name = "grpAritmetica";
            this.grpAritmetica.Size = new System.Drawing.Size(200, 128);
            this.grpAritmetica.TabIndex = 6;
            this.grpAritmetica.TabStop = false;
            this.grpAritmetica.Text = "Operações";
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(7, 20);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(55, 17);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(7, 43);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(6, 66);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdbMultiplicar.TabIndex = 2;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(6, 89);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(54, 17);
            this.rdbDividir.TabIndex = 3;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(253, 333);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(378, 333);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(316, 382);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpAritmetica);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.grpAritmetica.ResumeLayout(false);
            this.grpAritmetica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.GroupBox grpAritmetica;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFechar;
    }
}

