using System;
using System.Windows.Forms;
using Asistente.negocio;
using Asistente.negocio; 


namespace Asistente.Presentacion
{
    public partial class FmnCurso : Form
    {
        public FmnCurso()
        {
            InitializeComponent();
        }
         private void limpiar()
        {
            TxtCurso.Clear();
        } 
        private void BtnAgreagarCurso_Click(object sender, EventArgs e)
        {
            string Respuesta = "";
            if (TxtCurso.Text == String.Empty)
            {
                this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                ErrorIcono.SetError(TxtCurso, "Ingrese Un curso.");
            }
            else
            {
                Respuesta = Ncurso.Insertar(TxtCurso.Text.Trim(), Convert.ToInt32(listarEscuela.SelectedValue));

                if (Respuesta.Equals("OK"))
                {
                    
                    this.MensajeOk("Se insertó de forma correcta el registro");
                    this.limpiar();
                    this.Close();

                }
                else
                {
                    this.MensajeError(Respuesta);
                }
            }

        }

        private void FmnCurso_Load(object sender, EventArgs e)
        {
            listarEscuela.DataSource = NEscuela.Listar();
            listarEscuela.ValueMember = "Id";
            listarEscuela.DisplayMember = "escuela";

        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.Close();
        }
    }
}
