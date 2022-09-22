using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asistente.negocio;

namespace Asistente.Presentacion
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }


        public int escuela;

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            listEscuela.DataSource = NEscuela.Listar();
            listEscuela.ValueMember = "Id";
            listEscuela.DisplayMember = "escuela";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           escuela = Convert.ToInt32(listEscuela.SelectedValue);

            this.Close();
        }


    }
}
