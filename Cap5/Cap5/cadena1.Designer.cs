
namespace Cap5
{
    partial class cadena1
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
            this.btn_trasformar = new System.Windows.Forms.Button();
            this.txt_cadena = new System.Windows.Forms.TextBox();
            this.lb_cadena = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lb_numero = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_trasformar
            // 
            this.btn_trasformar.Location = new System.Drawing.Point(237, 55);
            this.btn_trasformar.Name = "btn_trasformar";
            this.btn_trasformar.Size = new System.Drawing.Size(95, 36);
            this.btn_trasformar.TabIndex = 9;
            this.btn_trasformar.Text = "Generar texto";
            this.btn_trasformar.UseVisualStyleBackColor = true;
            this.btn_trasformar.Click += new System.EventHandler(this.btn_trasformar_Click);
            // 
            // txt_cadena
            // 
            this.txt_cadena.Location = new System.Drawing.Point(131, 87);
            this.txt_cadena.Name = "txt_cadena";
            this.txt_cadena.Size = new System.Drawing.Size(100, 23);
            this.txt_cadena.TabIndex = 8;
            // 
            // lb_cadena
            // 
            this.lb_cadena.AutoSize = true;
            this.lb_cadena.Location = new System.Drawing.Point(78, 90);
            this.lb_cadena.Name = "lb_cadena";
            this.lb_cadena.Size = new System.Drawing.Size(47, 15);
            this.lb_cadena.TabIndex = 7;
            this.lb_cadena.Text = "Cadena";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(131, 33);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 23);
            this.txt_numero.TabIndex = 6;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(17, 36);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(108, 15);
            this.lb_numero.TabIndex = 5;
            this.lb_numero.Text = "Introduzca numero";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_trasformar);
            this.groupBox1.Controls.Add(this.txt_cadena);
            this.groupBox1.Controls.Add(this.lb_cadena);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.lb_numero);
            this.groupBox1.Location = new System.Drawing.Point(56, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 151);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Funcion que calcule el factorial\r\nde un número";
            // 
            // cadena1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadena1";
            this.Text = "cadena1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_trasformar;
        private System.Windows.Forms.TextBox txt_cadena;
        private System.Windows.Forms.Label lb_cadena;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}