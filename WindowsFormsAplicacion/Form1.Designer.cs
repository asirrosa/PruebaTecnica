namespace WindowsFormsAplicacion
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 228);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 188);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(36, 45);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(720, 20);
            this.txtBox.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(36, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 67);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar nota";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(322, 113);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(134, 67);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer notas";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(622, 113);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(134, 67);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar notas";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Aplicación de escritorio Windows Forms ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnBorrar;
    }
}

