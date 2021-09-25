
namespace Ejercicio1___Guía4_MM200149
{
    partial class MenuPrincipal
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btndocentes = new System.Windows.Forms.Button();
            this.btnalumnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnsalir.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(475, 169);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(139, 84);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btndocentes
            // 
            this.btndocentes.BackColor = System.Drawing.SystemColors.MenuText;
            this.btndocentes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocentes.ForeColor = System.Drawing.SystemColors.Control;
            this.btndocentes.Location = new System.Drawing.Point(275, 160);
            this.btndocentes.Name = "btndocentes";
            this.btndocentes.Size = new System.Drawing.Size(150, 103);
            this.btndocentes.TabIndex = 2;
            this.btndocentes.Text = "Registrar Docentes";
            this.btndocentes.UseVisualStyleBackColor = false;
            this.btndocentes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnalumnos
            // 
            this.btnalumnos.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnalumnos.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalumnos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnalumnos.Location = new System.Drawing.Point(67, 160);
            this.btnalumnos.Name = "btnalumnos";
            this.btnalumnos.Size = new System.Drawing.Size(150, 103);
            this.btnalumnos.TabIndex = 3;
            this.btnalumnos.Text = "Registrar Alumnos";
            this.btnalumnos.UseVisualStyleBackColor = false;
            this.btnalumnos.Click += new System.EventHandler(this.btnalumnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido al Ejercicio 1 Guía 4!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "¿Que desea hacer?";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnalumnos);
            this.Controls.Add(this.btndocentes);
            this.Controls.Add(this.btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnsalir;
        protected System.Windows.Forms.Button btndocentes;
        protected System.Windows.Forms.Button btnalumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}