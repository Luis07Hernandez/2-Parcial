namespace Actividad.ListasEnlazadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListar = new System.Windows.Forms.Button();
            this.txtBxTabla = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtBxBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcColor = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtpPlaca = new System.Windows.Forms.TextBox();
            this.txtmModelo = new System.Windows.Forms.TextBox();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnReporteInverso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.AutoSize = true;
            this.btnListar.Location = new System.Drawing.Point(338, 167);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(88, 34);
            this.btnListar.TabIndex = 37;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtBxTabla
            // 
            this.txtBxTabla.Location = new System.Drawing.Point(16, 224);
            this.txtBxTabla.Multiline = true;
            this.txtBxTabla.Name = "txtBxTabla";
            this.txtBxTabla.Size = new System.Drawing.Size(740, 147);
            this.txtBxTabla.TabIndex = 36;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Location = new System.Drawing.Point(338, 127);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 34);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Placa a buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(498, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(138, 29);
            this.txtBuscar.TabIndex = 33;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBxTelBuscar_TextChanged);
            // 
            // txtBxBuscar
            // 
            this.txtBxBuscar.AutoSize = true;
            this.txtBxBuscar.Location = new System.Drawing.Point(446, 88);
            this.txtBxBuscar.Name = "txtBxBuscar";
            this.txtBxBuscar.Size = new System.Drawing.Size(88, 34);
            this.txtBxBuscar.TabIndex = 32;
            this.txtBxBuscar.Text = "Buscar";
            this.txtBxBuscar.UseVisualStyleBackColor = true;
            this.txtBxBuscar.Click += new System.EventHandler(this.txtBxBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Location = new System.Drawing.Point(338, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 34);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre:";
            // 
            // txtcColor
            // 
            this.txtcColor.Location = new System.Drawing.Point(172, 146);
            this.txtcColor.Name = "txtcColor";
            this.txtcColor.Size = new System.Drawing.Size(138, 29);
            this.txtcColor.TabIndex = 23;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(172, 111);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(138, 29);
            this.txtMarca.TabIndex = 22;
            // 
            // txtpPlaca
            // 
            this.txtpPlaca.Location = new System.Drawing.Point(172, 76);
            this.txtpPlaca.Name = "txtpPlaca";
            this.txtpPlaca.Size = new System.Drawing.Size(138, 29);
            this.txtpPlaca.TabIndex = 21;
            // 
            // txtmModelo
            // 
            this.txtmModelo.Location = new System.Drawing.Point(172, 41);
            this.txtmModelo.Name = "txtmModelo";
            this.txtmModelo.Size = new System.Drawing.Size(138, 29);
            this.txtmModelo.TabIndex = 20;
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Location = new System.Drawing.Point(172, 6);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(138, 29);
            this.txtBxNombre.TabIndex = 19;
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.AutoSize = true;
            this.btnEliminarPrimero.Location = new System.Drawing.Point(432, 128);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(159, 34);
            this.btnEliminarPrimero.TabIndex = 38;
            this.btnEliminarPrimero.Text = "Eliminar Primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.AutoSize = true;
            this.btnEliminarUltimo.Location = new System.Drawing.Point(597, 128);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(159, 34);
            this.btnEliminarUltimo.TabIndex = 39;
            this.btnEliminarUltimo.Text = "Eliminar Ultimo";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnReporteInverso
            // 
            this.btnReporteInverso.AutoSize = true;
            this.btnReporteInverso.Location = new System.Drawing.Point(438, 168);
            this.btnReporteInverso.Name = "btnReporteInverso";
            this.btnReporteInverso.Size = new System.Drawing.Size(153, 34);
            this.btnReporteInverso.TabIndex = 40;
            this.btnReporteInverso.Text = "Reporte Inverso";
            this.btnReporteInverso.UseVisualStyleBackColor = true;
            this.btnReporteInverso.Click += new System.EventHandler(this.btnReporteInverso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 382);
            this.Controls.Add(this.btnReporteInverso);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtBxTabla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtBxBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcColor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtpPlaca);
            this.Controls.Add(this.txtmModelo);
            this.Controls.Add(this.txtBxNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Listas Enlazadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtBxTabla;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button txtBxBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcColor;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtpPlaca;
        private System.Windows.Forms.TextBox txtmModelo;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnReporteInverso;
    }
}

