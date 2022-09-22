using System;
using System.Windows.Forms;
using Asistente.negocio;
namespace Asistente.Presentacion
{
    public partial class Escuala : Form
    {
        public Escuala()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtEscual.Clear();
            this.Close();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (txtEscual.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtEscual, "Ingrese La Escuela.");
                }
                else
                {
                    Respuesta = NEscuela.Insertar(txtEscual.Text.Trim());

                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        this.Limpiar();
                        this.Close();

                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Escuala_Load(object sender, EventArgs e)
        {

        }
    }
}
