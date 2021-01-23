
namespace Ejercicio4
{
    partial class Ejercicio_1
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
            this.multiplicado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.multiplicador = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dijite numero";
            // 
            // multiplicado
            // 
            this.multiplicado.Location = new System.Drawing.Point(217, 31);
            this.multiplicado.Name = "multiplicado";
            this.multiplicado.Size = new System.Drawing.Size(49, 23);
            this.multiplicado.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiplicador
            // 
            this.multiplicador.Location = new System.Drawing.Point(164, 31);
            this.multiplicador.Name = "multiplicador";
            this.multiplicador.Size = new System.Drawing.Size(47, 23);
            this.multiplicador.TabIndex = 4;
            this.multiplicador.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tabla
            // 
            this.tabla.Location = new System.Drawing.Point(181, 60);
            this.tabla.Multiline = true;
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(85, 191);
            this.tabla.TabIndex = 2;
            // 
            // Ejercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 272);
            this.Controls.Add(this.multiplicador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.multiplicado);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio_1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox multiplicado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox multiplicador;
        private System.Windows.Forms.TextBox tabla;
    }
}