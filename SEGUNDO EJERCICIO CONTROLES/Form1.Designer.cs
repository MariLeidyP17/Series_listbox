namespace SEGUNDO_EJERCICIO_CONTROLES
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
            this.lbl_series = new System.Windows.Forms.Label();
            this.lbl_introducir = new System.Windows.Forms.Label();
            this.list_serie = new System.Windows.Forms.ListBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_series = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_series
            // 
            this.lbl_series.AutoSize = true;
            this.lbl_series.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_series.Location = new System.Drawing.Point(122, 109);
            this.lbl_series.Name = "lbl_series";
            this.lbl_series.Size = new System.Drawing.Size(44, 15);
            this.lbl_series.TabIndex = 0;
            this.lbl_series.Text = "Series";
            // 
            // lbl_introducir
            // 
            this.lbl_introducir.AutoSize = true;
            this.lbl_introducir.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_introducir.Location = new System.Drawing.Point(501, 71);
            this.lbl_introducir.Name = "lbl_introducir";
            this.lbl_introducir.Size = new System.Drawing.Size(124, 15);
            this.lbl_introducir.TabIndex = 1;
            this.lbl_introducir.Text = "Introduzca la serie";
            // 
            // list_serie
            // 
            this.list_serie.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_serie.FormattingEnabled = true;
            this.list_serie.ItemHeight = 15;
            this.list_serie.Location = new System.Drawing.Point(90, 140);
            this.list_serie.Name = "list_serie";
            this.list_serie.Size = new System.Drawing.Size(120, 94);
            this.list_serie.TabIndex = 2;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_salir.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(523, 278);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 40);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_agregar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(654, 278);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(96, 40);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_series
            // 
            this.txt_series.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_series.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_series.Location = new System.Drawing.Point(455, 89);
            this.txt_series.Name = "txt_series";
            this.txt_series.Size = new System.Drawing.Size(228, 21);
            this.txt_series.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_series);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.list_serie);
            this.Controls.Add(this.lbl_introducir);
            this.Controls.Add(this.lbl_series);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_series;
        private System.Windows.Forms.Label lbl_introducir;
        private System.Windows.Forms.ListBox list_serie;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_series;
    }
}

