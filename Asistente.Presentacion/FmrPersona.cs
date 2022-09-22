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
using SpreadsheetLight;

namespace Asistente.Presentacion
{
        
    public partial class FmrPersona : Form
    {
        private int escuela;
        public FmrPersona()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            try
            {

                GridListado.DataSource = Npersona.Listar(escuela);
                textTotal.Text = "Total de registro: " + Convert.ToString(GridListado.Rows.Count);
                TapGeneral.SelectedIndex = 0;
                this.Limpiar();
                this.Formato();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Formato()
        {
            GridListado.Columns[1].Visible = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            texApellido.Clear();
            BtnActualizar.Visible = false;
           BtnRegistrar.Visible = true;
        }


        private void FmrPersona_Load(object sender, EventArgs e)
        {

            listarEscuela.DataSource = NEscuela.Listar();
            listarEscuela.ValueMember = "Id";
            listarEscuela.DisplayMember = "escuela";
            //this.Listar();
        }


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
                
            try
            {
                int curso = Convert.ToInt32(lisCurso.SelectedValue);

                    string Respuesta = "";
                    if (txtNombre.Text == string.Empty || texApellido.Text == string.Empty)
                    {
                        this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                        ErrorIcono.SetError(txtNombrea, "Ingrese un nombre.");
                        ErrorIcono.SetError(texApellido, "Ingrese el Apellido.");
                    }
                    else
                    {
                        Respuesta = Npersona.Insertar(txtNombre.Text.Trim(), texApellido.Text.Trim(),curso);
                        if (Respuesta.Equals("OK"))
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro");
                            this.Limpiar();
                            this.Listar();
                            TapGeneral.SelectedIndex = 0;

                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }

                

                
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtNombre.Text == string.Empty || txtId.Text == string.Empty || texApellido.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(txtNombre, "Ingrese un nombre.");
                    ErrorIcono.SetError(texApellido, "Ingrese el Apellido.");
                }
                else
                {
                    Rpta = Npersona.Actualizar(Convert.ToInt32(txtId.Text), txtNombre.Text.Trim(), texApellido.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void GridListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnRegistrar.Visible = false;
                txtId.Text = Convert.ToString(GridListado.CurrentRow.Cells["Id"].Value);
                //this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                txtNombre.Text = Convert.ToString(GridListado.CurrentRow.Cells["Nombre"].Value);
                texApellido.Text = Convert.ToString(GridListado.CurrentRow.Cells["Apellido"].Value);
                TapGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }
        }

        private void BtnExel_Click(object sender, EventArgs e)
        {
            System.Data.DataTable Mas = new System.Data.DataTable();
            System.Data.DataTable Dia = new System.Data.DataTable();
            SLDocument Sl = new SLDocument();
            SLStyle style = new SLStyle();
            SLStyle styleFila = new SLStyle();
            string fecha = DateTime.Now.ToString("dd-MMMM-yyyy");



            style.Font.FontSize = 15;
            style.Font.Bold = true;
            styleFila.Font.Bold = true;

            int filas = 2;
            int columnas = 0;


            Mas.Columns.Add("Asistencia", typeof(string));
            Dia.Columns.Add("Fecha", typeof(string));
            //System.Data.DuplicateNameException: 'La columna 'Asistencia' ya pertenece a DataTable.'





            //else
            //{

            //}

            foreach (DataGridViewColumn column in GridListado.Columns)
            {
                Sl.SetCellValue(1, columnas, column.HeaderText.ToString());
                Sl.SetCellStyle(1, columnas, style);
                columnas++;
            }

            foreach (DataGridViewRow row in GridListado.Rows)
            {

                Sl.SetCellValue(filas, 1, row.Cells[1].Value.ToString());
                Sl.SetCellValue(filas, 2, row.Cells[2].Value.ToString());
                Sl.SetCellValue(filas, 3, row.Cells[3].Value.ToString());
                Sl.SetCellValue(filas, 4, row.Cells[4].Value.ToString());
                Sl.SetCellValue(filas, 5, row.Cells[5].Value.ToString());
                if (Convert.ToBoolean(row.Cells[0].Value))
                {

                    styleFila.Font.FontColor = Color.Green;

                    Mas.Rows.Add("Presente");

                    Sl.SetCellStyle(filas, 6, styleFila);

                }
                else
                {
                    styleFila.Font.FontColor = Color.Red;

                    Mas.Rows.Add("Ausente");
                    Sl.SetCellStyle(filas, 6, styleFila);

                }

                filas++;
            }
            Dia.Rows.Add(fecha);
            Sl.SetCellStyle(1, 7, style);


            Sl.SetCellStyle(1, 6, style);

            Sl.ImportDataTable(1, 6, Mas, true);

            Sl.ImportDataTable(1, 6, Mas, true);
            Sl.ImportDataTable(1, 7, Dia, true);




            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar archivo";
            saveFileDialog1.FileName = "Asistencia " + fecha ; 
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Sl.SaveAs(pathFile);
                    
                    Sl.SaveAs(saveFileDialog1.FileName);
                    MessageBox.Show("Archivo exportado con éxito");
                    this.Listar();
                       Mas.Columns.Remove("Asistencia");
                        Mas.Rows.Clear();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
     

        private void GridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == GridListado.Columns["Selecionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)GridListado.Rows[e.RowIndex].Cells["Selecionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FmnCurso curso = new FmnCurso();
            curso.ShowDialog();
        }


        private void nuevoCurso_Click(object sender, EventArgs e)
        {
            Escuala escuela = new Escuala();
            escuela.ShowDialog();
        }


        private void lisCurso_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            escuela = Convert.ToInt32(listarEscuela.SelectedValue);

            lisCurso.DataSource = Ncurso.Listar(escuela);

            lisCurso.ValueMember = "Id";
            lisCurso.DisplayMember = "curso";
            this.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Listar();
            listarEscuela.DataSource = NEscuela.Listar();
            listarEscuela.ValueMember = "Id";
            listarEscuela.DisplayMember = "escuela";
        }
    }
}
