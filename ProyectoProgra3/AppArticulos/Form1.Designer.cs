
namespace AppArticulos
{
    partial class Ventana_Principal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBox_Buscar = new System.Windows.Forms.TextBox();
            this.Boton_Buscar = new System.Windows.Forms.Button();
            this.Boton_Agregar = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.Boton_Detalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.Location = new System.Drawing.Point(12, 57);
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.Size = new System.Drawing.Size(368, 20);
            this.TextBox_Buscar.TabIndex = 1;
            // 
            // Boton_Buscar
            // 
            this.Boton_Buscar.Location = new System.Drawing.Point(386, 57);
            this.Boton_Buscar.Name = "Boton_Buscar";
            this.Boton_Buscar.Size = new System.Drawing.Size(75, 56);
            this.Boton_Buscar.TabIndex = 2;
            this.Boton_Buscar.Text = "Buscar";
            this.Boton_Buscar.UseVisualStyleBackColor = true;
            // 
            // Boton_Agregar
            // 
            this.Boton_Agregar.Location = new System.Drawing.Point(386, 250);
            this.Boton_Agregar.Name = "Boton_Agregar";
            this.Boton_Agregar.Size = new System.Drawing.Size(75, 64);
            this.Boton_Agregar.TabIndex = 3;
            this.Boton_Agregar.Text = "Agregar";
            this.Boton_Agregar.UseVisualStyleBackColor = true;
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.Location = new System.Drawing.Point(386, 119);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(75, 67);
            this.Boton_Modificar.TabIndex = 4;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = true;
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.Location = new System.Drawing.Point(386, 192);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(75, 52);
            this.Boton_Eliminar.TabIndex = 5;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Boton_Detalles
            // 
            this.Boton_Detalles.Location = new System.Drawing.Point(386, 330);
            this.Boton_Detalles.Name = "Boton_Detalles";
            this.Boton_Detalles.Size = new System.Drawing.Size(75, 66);
            this.Boton_Detalles.TabIndex = 6;
            this.Boton_Detalles.Text = "Detalles";
            this.Boton_Detalles.UseVisualStyleBackColor = true;
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 408);
            this.Controls.Add(this.Boton_Detalles);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_Agregar);
            this.Controls.Add(this.Boton_Buscar);
            this.Controls.Add(this.TextBox_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ventana_Principal";
            this.Text = "Ventana principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextBox_Buscar;
        private System.Windows.Forms.Button Boton_Buscar;
        private System.Windows.Forms.Button Boton_Agregar;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.Button Boton_Detalles;
    }
}

