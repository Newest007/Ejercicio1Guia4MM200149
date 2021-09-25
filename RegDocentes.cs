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



        }

    }
}
