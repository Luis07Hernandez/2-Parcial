namespace Actividad.AnalizadorExpresionesAritmeticas
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
            this.txtBxExpresion = new System.Windows.Forms.TextBox();
            this.txtBxTabla = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxExpresion
            // 
            this.txtBxExpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxExpresion.Location = new System.Drawing.Point(12, 42);
            this.txtBxExpresion.Name = "txtBxExpresion";
            this.txtBxExpresion.Size = new System.Drawing.Size(326, 24);
            this.txtBxExpresion.TabIndex = 0;
            this.txtBxExpresion.TextChanged += new System.EventHandler(this.txtBxExpresion_TextChanged);
            // 
            // txtBxTabla
            // 
            this.txtBxTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTabla.Location = new System.Drawing.Point(344, 12);
            this.txtBxTabla.Multiline = true;
            this.txtBxTabla.Name = "txtBxTabla";
            this.txtBxTabla.ReadOnly = true;
            this.txtBxTabla.Size = new System.Drawing.Size(420, 88);
            this.txtBxTabla.TabIndex = 3;
            this.txtBxTabla.TabStop = false;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.AutoSize = true;
            this.btnAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Location = new System.Drawing.Point(12, 72);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(326, 28);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Expresión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 113);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.txtBxTabla);
            this.Controls.Add(this.txtBxExpresion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Analizador de Expresiones Aritmeticas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxExpresion;
        private System.Windows.Forms.TextBox txtBxTabla;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Label label1;
    }
}

