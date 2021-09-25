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
    public partial class RegAlumnos : FormBase
    {
        public RegAlumnos()
        {
            InitializeComponent();
        }

        private void RegAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void RegAlumnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Alumno regis = new Alumno();
            regis.Nombre = txtnombre.Text;
            regis.Usuario = txtusuario.Text;
            regis.Codigo = txtcodigo.Text;


            if (edit_indice > -1)
            {
                Alumnos[edit_indice] = regis;
                edit_indice = -1;

            }

            else
            {
                Alumnos.Add(regis);
            }

            ActualizarGrid();
            txtnombre.Clear();
            txtusuario.Clear();
            txtcodigo.Clear();

            MessageBox.Show("Datos Ingresados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private List<Alumno> Alumnos = new List<Alumno>();
        private int edit_indice = -1;
        private void ActualizarGrid()
        {
            dtgvalumnos.DataSource = null;
            dtgvalumnos.DataSource = Alumnos;

        }


        private void dtgvAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgvalumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow seleccion = dtgvalumnos.SelectedRows[0];
            int pos = dtgvalumnos.Rows.IndexOf(seleccion);
            edit_indice = pos;

            Alumno regis = Alumnos[pos];

            txtnombre.Text = regis.Nombre;
            txtusuario.Text = regis.Usuario;
            txtcodigo.Text = regis.Codigo;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
    }
}
