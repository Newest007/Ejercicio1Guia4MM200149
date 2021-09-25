using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1___Guía4_MM200149
{
    public partial class RegDocentes : FormBase
    {
        public RegDocentes()
        {
            InitializeComponent();
        }

        private void RegDocentes_Load(object sender, EventArgs e)
        {

        }

        private void RegDocentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private List<Docente> Docentes = new List<Docente>();
        int edit_indice = -1;

        private void ActualizarGrid()
        {
            dtgvdocentes.DataSource = null;
            dtgvdocentes.DataSource = Docentes;
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            Docente doc = new Docente();
            doc.Nombre = txtnombre.Text;
            doc.Usuario = txtusuario.Text;
            doc.Codigo = txtcodigo.Text;
            doc.Materia = txtmateria.Text;

            if(edit_indice > -1)
            {
                Docentes[edit_indice] = doc;
                edit_indice = -1;
            }

            else
            {
                Docentes.Add(doc);
            }

            ActualizarGrid();


            MessageBox.Show("Datos Ingresados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presione doble click sobre la fila que desea modificar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvdocentes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtmateria.Clear();
        }

        private void dtgvdocentes_DoubleClick(object sender, EventArgs e)
        {

            DataGridViewRow seleccion = dtgvdocentes.SelectedRows[0];
            int pos = dtgvdocentes.Rows.IndexOf(seleccion);
            edit_indice = pos;

            Docente doc = Docentes[pos];

            txtnombre.Text = doc.Nombre;
            txtusuario.Text = doc.Usuario;
            txtcodigo.Text = doc.Codigo;
            txtmateria.Text = doc.Materia;

        }
    }
}
