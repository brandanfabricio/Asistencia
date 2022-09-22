namespace Asistente.Presentacion
{
    partial class FmnCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCurso = new System.Windows.Forms.TextBox();
            this.BtnAgreagarCurso = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listarEscuela = new System.Windows.Forms.ComboBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso (*)";
            // 
            // TxtCurso
            // 
            this.TxtCurso.Location = new System.Drawing.Point(102, 12);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(225, 20);
            this.TxtCurso.TabIndex = 1;
            // 
            // BtnAgreagarCurso
            // 
            this.BtnAgreagarCurso.Location = new System.Drawing.Point(102, 126);
            this.BtnAgreagarCurso.Name = "BtnAgreagarCurso";
            this.BtnAgreagarCurso.Size = new System.Drawing.Size(75, 23);
            this.BtnAgreagarCurso.TabIndex = 2;
            this.BtnAgreagarCurso.Text = "Agregar";
            this.BtnAgreagarCurso.UseVisualStyleBackColor = true;
            this.BtnAgreagarCurso.Click += new System.EventHandler(this.BtnAgreagarCurso_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(252, 126);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(*) Datos requerido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escuela (*)";
            // 
            // listarEscuela
            // 
            this.listarEscuela.FormattingEnabled = true;
            this.listarEscuela.Location = new System.Drawing.Point(102, 68);
            this.listarEscuela.Name = "listarEscuela";
            this.listarEscuela.Size = new System.Drawing.Size(139, 21);
            this.listarEscuela.TabIndex = 10;
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FmnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 184);
            this.Controls.Add(this.listarEscuela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnAgreagarCurso);
            this.Controls.Add(this.TxtCurso);
            this.Controls.Add(this.label1);
            this.Name = "FmnCurso";
            this.Text = "Agregar Curso";
            this.Load += new System.EventHandler(this.FmnCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCurso;
        private System.Windows.Forms.Button BtnAgreagarCurso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listarEscuela;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
    }
}