namespace Asistente.Presentacion
{
    partial class FmrPersona
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
            this.components = new System.ComponentModel.Container();
            this.TapGeneral = new System.Windows.Forms.TabControl();
            this.TapListar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listarEscuela = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.nuevoCurso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExel = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.Label();
            this.GridListado = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TapRegistro = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lisCurso = new System.Windows.Forms.ComboBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.texApellidos = new System.Windows.Forms.Label();
            this.txtNombrea = new System.Windows.Forms.Label();
            this.texApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.TapGeneral.SuspendLayout();
            this.TapListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListado)).BeginInit();
            this.TapRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TapGeneral
            // 
            this.TapGeneral.Controls.Add(this.TapListar);
            this.TapGeneral.Controls.Add(this.TapRegistro);
            this.TapGeneral.Location = new System.Drawing.Point(0, -2);
            this.TapGeneral.Name = "TapGeneral";
            this.TapGeneral.SelectedIndex = 0;
            this.TapGeneral.Size = new System.Drawing.Size(799, 452);
            this.TapGeneral.TabIndex = 0;
            // 
            // TapListar
            // 
            this.TapListar.Controls.Add(this.button2);
            this.TapListar.Controls.Add(this.label2);
            this.TapListar.Controls.Add(this.listarEscuela);
            this.TapListar.Controls.Add(this.BtnBuscar);
            this.TapListar.Controls.Add(this.nuevoCurso);
            this.TapListar.Controls.Add(this.button1);
            this.TapListar.Controls.Add(this.BtnExel);
            this.TapListar.Controls.Add(this.textTotal);
            this.TapListar.Controls.Add(this.GridListado);
            this.TapListar.Location = new System.Drawing.Point(4, 22);
            this.TapListar.Name = "TapListar";
            this.TapListar.Padding = new System.Windows.Forms.Padding(3);
            this.TapListar.Size = new System.Drawing.Size(791, 426);
            this.TapListar.TabIndex = 0;
            this.TapListar.Text = "Listar";
            this.TapListar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleciones una escuela";
            // 
            // listarEscuela
            // 
            this.listarEscuela.FormattingEnabled = true;
            this.listarEscuela.Location = new System.Drawing.Point(154, 12);
            this.listarEscuela.Name = "listarEscuela";
            this.listarEscuela.Size = new System.Drawing.Size(157, 21);
            this.listarEscuela.TabIndex = 6;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(332, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(117, 36);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // nuevoCurso
            // 
            this.nuevoCurso.Location = new System.Drawing.Point(544, 3);
            this.nuevoCurso.Name = "nuevoCurso";
            this.nuevoCurso.Size = new System.Drawing.Size(117, 36);
            this.nuevoCurso.TabIndex = 4;
            this.nuevoCurso.Text = "Agregar Escuela";
            this.nuevoCurso.UseVisualStyleBackColor = true;
            this.nuevoCurso.Click += new System.EventHandler(this.nuevoCurso_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nuevo Curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExel
            // 
            this.BtnExel.Location = new System.Drawing.Point(486, 384);
            this.BtnExel.Name = "BtnExel";
            this.BtnExel.Size = new System.Drawing.Size(121, 36);
            this.BtnExel.TabIndex = 2;
            this.BtnExel.Text = "Generar Exel";
            this.BtnExel.UseVisualStyleBackColor = true;
            this.BtnExel.Click += new System.EventHandler(this.BtnExel_Click);
            // 
            // textTotal
            // 
            this.textTotal.AutoSize = true;
            this.textTotal.Location = new System.Drawing.Point(28, 396);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(31, 13);
            this.textTotal.TabIndex = 1;
            this.textTotal.Text = "Total";
            // 
            // GridListado
            // 
            this.GridListado.AllowUserToAddRows = false;
            this.GridListado.AllowUserToDeleteRows = false;
            this.GridListado.AllowUserToOrderColumns = true;
            this.GridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.GridListado.Location = new System.Drawing.Point(0, 42);
            this.GridListado.Name = "GridListado";
            this.GridListado.ReadOnly = true;
            this.GridListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridListado.Size = new System.Drawing.Size(791, 336);
            this.GridListado.TabIndex = 0;
            this.GridListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListado_CellContentClick);
            this.GridListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListado_CellDoubleClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            // 
            // TapRegistro
            // 
            this.TapRegistro.Controls.Add(this.label3);
            this.TapRegistro.Controls.Add(this.lisCurso);
            this.TapRegistro.Controls.Add(this.BtnActualizar);
            this.TapRegistro.Controls.Add(this.label1);
            this.TapRegistro.Controls.Add(this.BtnRegistrar);
            this.TapRegistro.Controls.Add(this.textId);
            this.TapRegistro.Controls.Add(this.txtId);
            this.TapRegistro.Controls.Add(this.BtnCancelar);
            this.TapRegistro.Controls.Add(this.texApellidos);
            this.TapRegistro.Controls.Add(this.txtNombrea);
            this.TapRegistro.Controls.Add(this.texApellido);
            this.TapRegistro.Controls.Add(this.txtNombre);
            this.TapRegistro.Location = new System.Drawing.Point(4, 22);
            this.TapRegistro.Name = "TapRegistro";
            this.TapRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.TapRegistro.Size = new System.Drawing.Size(791, 426);
            this.TapRegistro.TabIndex = 1;
            this.TapRegistro.Text = "Registrar";
            this.TapRegistro.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Curso (*)";
            // 
            // lisCurso
            // 
            this.lisCurso.FormattingEnabled = true;
            this.lisCurso.Location = new System.Drawing.Point(141, 232);
            this.lisCurso.Name = "lisCurso";
            this.lisCurso.Size = new System.Drawing.Size(167, 21);
            this.lisCurso.TabIndex = 12;
            this.lisCurso.SelectedIndexChanged += new System.EventHandler(this.lisCurso_SelectedIndexChanged);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(120, 330);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "(*) Dato Obligatorio";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(120, 330);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 7;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // textId
            // 
            this.textId.AutoSize = true;
            this.textId.Location = new System.Drawing.Point(73, 27);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(16, 13);
            this.textId.TabIndex = 6;
            this.textId.Text = "Id";
            this.textId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 20);
            this.txtId.TabIndex = 5;
            this.txtId.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(246, 330);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // texApellidos
            // 
            this.texApellidos.AutoSize = true;
            this.texApellidos.Location = new System.Drawing.Point(73, 132);
            this.texApellidos.Name = "texApellidos";
            this.texApellidos.Size = new System.Drawing.Size(57, 13);
            this.texApellidos.TabIndex = 3;
            this.texApellidos.Text = "Apellido (*)";
            // 
            // txtNombrea
            // 
            this.txtNombrea.AutoSize = true;
            this.txtNombrea.Location = new System.Drawing.Point(73, 75);
            this.txtNombrea.Name = "txtNombrea";
            this.txtNombrea.Size = new System.Drawing.Size(57, 13);
            this.txtNombrea.TabIndex = 2;
            this.txtNombrea.Text = "Nombre (*)";
            // 
            // texApellido
            // 
            this.texApellido.Location = new System.Drawing.Point(141, 132);
            this.texApellido.Name = "texApellido";
            this.texApellido.Size = new System.Drawing.Size(167, 20);
            this.texApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Recargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FmrPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TapGeneral);
            this.Name = "FmrPersona";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.FmrPersona_Load);
            this.TapGeneral.ResumeLayout(false);
            this.TapListar.ResumeLayout(false);
            this.TapListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListado)).EndInit();
            this.TapRegistro.ResumeLayout(false);
            this.TapRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TapGeneral;
        private System.Windows.Forms.TabPage TapListar;
        private System.Windows.Forms.Label textTotal;
        private System.Windows.Forms.DataGridView GridListado;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BtnExel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nuevoCurso;
        private System.Windows.Forms.TabPage TapRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lisCurso;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label textId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label texApellidos;
        private System.Windows.Forms.Label txtNombrea;
        private System.Windows.Forms.TextBox texApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox listarEscuela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}