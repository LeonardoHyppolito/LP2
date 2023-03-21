namespace Pimc
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
            this.label_peso = new System.Windows.Forms.Label();
            this.label_alt = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.label_imc = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Location = new System.Drawing.Point(446, 65);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(58, 13);
            this.label_peso.TabIndex = 0;
            this.label_peso.Text = "Peso Atual";
            // 
            // label_alt
            // 
            this.label_alt.AutoSize = true;
            this.label_alt.Location = new System.Drawing.Point(446, 134);
            this.label_alt.Name = "label_alt";
            this.label_alt.Size = new System.Drawing.Size(34, 13);
            this.label_alt.TabIndex = 1;
            this.label_alt.Text = "Altura";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(449, 224);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(88, 32);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular IMC";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(640, 229);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(122, 27);
            this.btnFecha.TabIndex = 3;
            this.btnFecha.Text = "Fechar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.BtnFecha_Click);
            // 
            // label_imc
            // 
            this.label_imc.AutoSize = true;
            this.label_imc.Location = new System.Drawing.Point(454, 182);
            this.label_imc.Name = "label_imc";
            this.label_imc.Size = new System.Drawing.Size(26, 13);
            this.label_imc.TabIndex = 4;
            this.label_imc.Text = "IMC";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(595, 66);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(167, 20);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.Leave += new System.EventHandler(this.TxtPeso_Leave);
            this.txtPeso.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPeso_Validating);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(595, 134);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(167, 20);
            this.txtAltura.TabIndex = 6;
            this.txtAltura.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAltura_Validating);
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(595, 192);
            this.txtImc.Name = "txtImc";
            this.txtImc.ReadOnly = true;
            this.txtImc.Size = new System.Drawing.Size(167, 20);
            this.txtImc.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label_imc);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label_alt);
            this.Controls.Add(this.label_peso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.Label label_alt;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label label_imc;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtImc;
    }
}

