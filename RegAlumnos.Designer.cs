
namespace Ejercicio1___Guía4_MM200149
{
    partial class RegAlumnos
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvalumnos = new System.Windows.Forms.DataGridView();
            this.grbxdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(556, 282);
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 47);
            this.label4.TabIndex = 10;
            this.label4.Text = "Registro Estudiantes";
            // 
            // dtgvalumnos
            // 
            this.dtgvalumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvalumnos.Location = new System.Drawing.Point(34, 373);
            this.dtgvalumnos.Name = "dtgvalumnos";
            this.dtgvalumnos.Size = new System.Drawing.Size(637, 145);
            this.dtgvalumnos.TabIndex = 11;
            this.dtgvalumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvalumnos_CellDoubleClick);
            // 
            // RegAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 555);
            this.Controls.Add(this.dtgvalumnos);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(8, 13, 8, 13);
            this.Name = "RegAlumnos";
            this.Text = "v";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegAlumnos_FormClosed);
            this.Load += new System.EventHandler(this.RegAlumnos_Load);
            this.Controls.SetChildIndex(this.grbxdatos, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnlimpiar, 0);
            this.Controls.SetChildIndex(this.btnmodificar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtgvalumnos, 0);
            this.grbxdatos.ResumeLayout(false);
            this.grbxdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvalumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvalumnos;
    }
}