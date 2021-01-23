
namespace Cap5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.Label();
            this.lb_factorial = new System.Windows.Forms.Label();
            this.lb_ejercicio1 = new System.Windows.Forms.Button();
            this.lb_cadena = new System.Windows.Forms.Label();
            this.ejercicio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu.Location = new System.Drawing.Point(169, 24);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(87, 32);
            this.menu.TabIndex = 0;
            this.menu.Text = "MENU";
            // 
            // lb_factorial
            // 
            this.lb_factorial.AutoSize = true;
            this.lb_factorial.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_factorial.Location = new System.Drawing.Point(39, 68);
            this.lb_factorial.Name = "lb_factorial";
            this.lb_factorial.Size = new System.Drawing.Size(128, 18);
            this.lb_factorial.TabIndex = 1;
            this.lb_factorial.Text = "Fatorial de un numero";
            this.lb_factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // lb_ejercicio1
            // 
            this.lb_ejercicio1.Location = new System.Drawing.Point(51, 89);
            this.lb_ejercicio1.Name = "lb_ejercicio1";
            this.lb_ejercicio1.Size = new System.Drawing.Size(101, 35);
            this.lb_ejercicio1.TabIndex = 2;
            this.lb_ejercicio1.Text = "Click";
            this.lb_ejercicio1.UseVisualStyleBackColor = true;
            this.lb_ejercicio1.Click += new System.EventHandler(this.ejercicio1_Click);
            // 
            // lb_cadena
            // 
            this.lb_cadena.AutoSize = true;
            this.lb_cadena.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cadena.Location = new System.Drawing.Point(225, 68);
            this.lb_cadena.Name = "lb_cadena";
            this.lb_cadena.Size = new System.Drawing.Size(211, 18);
            this.lb_cadena.TabIndex = 3;
            this.lb_cadena.Text = "Dado el numero devuelva una cadena";
            // 
            // ejercicio2
            // 
            this.ejercicio2.Location = new System.Drawing.Point(280, 89);
            this.ejercicio2.Name = "ejercicio2";
            this.ejercicio2.Size = new System.Drawing.Size(102, 35);
            this.ejercicio2.TabIndex = 4;
            this.ejercicio2.Text = "Click";
            this.ejercicio2.UseVisualStyleBackColor = true;
            this.ejercicio2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 180);
            this.Controls.Add(this.ejercicio2);
            this.Controls.Add(this.lb_cadena);
            this.Controls.Add(this.lb_ejercicio1);
            this.Controls.Add(this.lb_factorial);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label lb_factorial;
        private System.Windows.Forms.Button lb_ejercicio1;
        private System.Windows.Forms.Label lb_cadena;
        private System.Windows.Forms.Button ejercicio2;
    }
}

