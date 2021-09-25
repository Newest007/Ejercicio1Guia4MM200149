
namespace Ejercicio1___Guía4_MM200149
{
    partial class RegDocentes
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtmateria = new System.Windows.Forms.TextBox();
            this.dtgvdocentes = new System.Windows.Forms.DataGridView();
            this.grbxdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(556, 279);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(547, 118);
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(547, 171);
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(547, 224);
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // grbxdatos
            // 
            this.grbxdatos.Controls.Add(this.txtmateria);
            this.grbxdatos.Controls.Add(this.label5);
            this.grbxdatos.Location = new System.Drawing.Point(58, 79);
            this.grbxdatos.Size = new System.Drawing.Size(441, 279);
            this.grbxdatos.Controls.SetChildIndex(this.txtnombre, 0);
            this.grbxdatos.Controls.SetChildIndex(this.txtusuario, 0);
            this.grbxdatos.Controls.SetChildIndex(this.txtcodigo, 0);
            this.grbxdatos.Controls.SetChildIndex(this.label5, 0);
            this.grbxdatos.Controls.SetChildIndex(this.txtmateria, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 47);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registro Docentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Materia";
            // 
            // txtmateria
            // 
            this.txtmateria.Location = new System.Drawing.Point(150, 221);
            this.txtmateria.MaxLength = 8;
            this.txtmateria.Name = "txtmateria";
            this.txtmateria.Size = new System.Drawing.Size(175, 41);
            this.txtmateria.TabIndex = 7;
            // 
            // dtgvdocentes
            // 
            this.dtgvdocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvdocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdocentes.Location = new System.Drawing.Point(112, 378);
            this.dtgvdocentes.Name = "dtgvdocentes";
            this.dtgvdocentes.Size = new System.Drawing.Size(494, 174);
            this.dtgvdocentes.TabIndex = 12;
            this.dtgvdocentes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdocentes_CellContentDoubleClick);
            this.dtgvdocentes.DoubleClick += new System.EventHandler(this.dtgvdocentes_DoubleClick);
            // 
            // RegDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 578);
            this.Controls.Add(this.dtgvdocentes);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(8, 13, 8, 13);
            this.Name = "RegDocentes";
            this.Text = "RegDocentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegDocentes_FormClosed);
            this.Load += new System.EventHandler(this.RegDocentes_Load);
            this.Controls.SetChildIndex(this.grbxdatos, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnlimpiar, 0);
            this.Controls.SetChildIndex(this.btnmodificar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtgvdocentes, 0);
            this.grbxdatos.ResumeLayout(false);
            this.grbxdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmateria;
        private System.Windows.Forms.DataGridView dtgvdocentes;
    }
}