namespace AppArticulos
{
    partial class VentanaDetalles
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
            this.flyplDatos = new System.Windows.Forms.FlowLayoutPanel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.rtxbDescripcion = new System.Windows.Forms.RichTextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.flyplDatos.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // flyplDatos
            // 
            this.flyplDatos.Controls.Add(this.gbDatos);
            this.flyplDatos.Location = new System.Drawing.Point(23, 12);
            this.flyplDatos.Name = "flyplDatos";
            this.flyplDatos.Size = new System.Drawing.Size(345, 310);
            this.flyplDatos.TabIndex = 0;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.rtxbDescripcion);
            this.gbDatos.Controls.Add(this.txbPrecio);
            this.gbDatos.Controls.Add(this.txbCategoria);
            this.gbDatos.Controls.Add(this.txbMarca);
            this.gbDatos.Controls.Add(this.txbNombre);
            this.gbDatos.Controls.Add(this.lbPrecio);
            this.gbDatos.Controls.Add(this.lbCategoria);
            this.gbDatos.Controls.Add(this.lbMarca);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Controls.Add(this.lbNombre);
            this.gbDatos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(3, 3);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(342, 307);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Articulo: ";
            // 
            // rtxbDescripcion
            // 
            this.rtxbDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtxbDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxbDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbDescripcion.Location = new System.Drawing.Point(91, 141);
            this.rtxbDescripcion.Name = "rtxbDescripcion";
            this.rtxbDescripcion.ReadOnly = true;
            this.rtxbDescripcion.Size = new System.Drawing.Size(245, 157);
            this.rtxbDescripcion.TabIndex = 9;
            this.rtxbDescripcion.TabStop = false;
            this.rtxbDescripcion.Text = "";
            // 
            // txbPrecio
            // 
            this.txbPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrecio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbPrecio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(91, 106);
            this.txbPrecio.Multiline = true;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.ReadOnly = true;
            this.txbPrecio.Size = new System.Drawing.Size(136, 20);
            this.txbPrecio.TabIndex = 8;
            this.txbPrecio.TabStop = false;
            this.txbPrecio.Text = "$";
            this.txbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbCategoria
            // 
            this.txbCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoria.Location = new System.Drawing.Point(91, 80);
            this.txbCategoria.Multiline = true;
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.ReadOnly = true;
            this.txbCategoria.Size = new System.Drawing.Size(136, 20);
            this.txbCategoria.TabIndex = 7;
            this.txbCategoria.TabStop = false;
            this.txbCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbMarca
            // 
            this.txbMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbMarca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMarca.Location = new System.Drawing.Point(91, 54);
            this.txbMarca.Multiline = true;
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.ReadOnly = true;
            this.txbMarca.Size = new System.Drawing.Size(136, 20);
            this.txbMarca.TabIndex = 6;
            this.txbMarca.TabStop = false;
            this.txbMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(91, 28);
            this.txbNombre.Multiline = true;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.ReadOnly = true;
            this.txbNombre.Size = new System.Drawing.Size(136, 20);
            this.txbNombre.TabIndex = 5;
            this.txbNombre.TabStop = false;
            this.txbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(40, 108);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(45, 15);
            this.lbPrecio.TabIndex = 4;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(21, 82);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(64, 15);
            this.lbCategoria.TabIndex = 3;
            this.lbCategoria.Text = "Categoría:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(40, 56);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(43, 15);
            this.lbMarca.TabIndex = 2;
            this.lbMarca.Text = "Marca:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(9, 144);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(76, 15);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(30, 30);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(55, 15);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.btnIzquierda);
            this.panelImagen.Controls.Add(this.btnDerecha);
            this.panelImagen.Controls.Add(this.pbImagenes);
            this.panelImagen.Location = new System.Drawing.Point(374, 12);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(253, 310);
            this.panelImagen.TabIndex = 1;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(4, 268);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(106, 32);
            this.btnIzquierda.TabIndex = 2;
            this.btnIzquierda.Text = "<-";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(144, 268);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(106, 32);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "->";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(4, 4);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(249, 258);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenes.TabIndex = 0;
            this.pbImagenes.TabStop = false;
            // 
            // VentanaDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 334);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.flyplDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VentanaDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.VentanaDetalles_Load);
            this.flyplDatos.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flyplDatos;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.RichTextBox rtxbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.PictureBox pbImagenes;
    }
}