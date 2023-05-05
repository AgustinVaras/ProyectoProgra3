
namespace AppArticulos
{
    partial class VentanaAgregar
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
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.Label_CodigoArticulo = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Label_Marca = new System.Windows.Forms.Label();
            this.Label_Categoria = new System.Windows.Forms.Label();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.Label_Descripcion = new System.Windows.Forms.Label();
            this.Label_Imagen = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.grbFormulario = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.grbFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(113, 32);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(153, 20);
            this.txtCodigoArticulo.TabIndex = 0;
            // 
            // Label_CodigoArticulo
            // 
            this.Label_CodigoArticulo.AutoSize = true;
            this.Label_CodigoArticulo.Location = new System.Drawing.Point(23, 35);
            this.Label_CodigoArticulo.Name = "Label_CodigoArticulo";
            this.Label_CodigoArticulo.Size = new System.Drawing.Size(84, 13);
            this.Label_CodigoArticulo.TabIndex = 1;
            this.Label_CodigoArticulo.Text = "Codigo Articulo: ";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(57, 68);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(50, 13);
            this.Label_Nombre.TabIndex = 2;
            this.Label_Nombre.Text = "Nombre: ";
            // 
            // Label_Marca
            // 
            this.Label_Marca.AutoSize = true;
            this.Label_Marca.Location = new System.Drawing.Point(64, 98);
            this.Label_Marca.Name = "Label_Marca";
            this.Label_Marca.Size = new System.Drawing.Size(43, 13);
            this.Label_Marca.TabIndex = 3;
            this.Label_Marca.Text = "Marca: ";
            // 
            // Label_Categoria
            // 
            this.Label_Categoria.AutoSize = true;
            this.Label_Categoria.Location = new System.Drawing.Point(49, 129);
            this.Label_Categoria.Name = "Label_Categoria";
            this.Label_Categoria.Size = new System.Drawing.Size(58, 13);
            this.Label_Categoria.TabIndex = 4;
            this.Label_Categoria.Text = "Categoria: ";
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Location = new System.Drawing.Point(64, 161);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(43, 13);
            this.Label_Precio.TabIndex = 5;
            this.Label_Precio.Text = "Precio: ";
            // 
            // Label_Descripcion
            // 
            this.Label_Descripcion.AutoSize = true;
            this.Label_Descripcion.Location = new System.Drawing.Point(38, 191);
            this.Label_Descripcion.Name = "Label_Descripcion";
            this.Label_Descripcion.Size = new System.Drawing.Size(69, 13);
            this.Label_Descripcion.TabIndex = 6;
            this.Label_Descripcion.Text = "Descripcion: ";
            // 
            // Label_Imagen
            // 
            this.Label_Imagen.AutoSize = true;
            this.Label_Imagen.Location = new System.Drawing.Point(49, 308);
            this.Label_Imagen.Name = "Label_Imagen";
            this.Label_Imagen.Size = new System.Drawing.Size(42, 13);
            this.Label_Imagen.TabIndex = 7;
            this.Label_Imagen.Text = "Imagen";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(113, 161);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(153, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(113, 95);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(153, 21);
            this.cbMarca.TabIndex = 11;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(113, 126);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(153, 21);
            this.cbCategoria.TabIndex = 12;
            // 
            // grbFormulario
            // 
            this.grbFormulario.Controls.Add(this.rtxtDescripcion);
            this.grbFormulario.Controls.Add(this.Label_CodigoArticulo);
            this.grbFormulario.Controls.Add(this.cbCategoria);
            this.grbFormulario.Controls.Add(this.txtCodigoArticulo);
            this.grbFormulario.Controls.Add(this.cbMarca);
            this.grbFormulario.Controls.Add(this.Label_Nombre);
            this.grbFormulario.Controls.Add(this.Label_Marca);
            this.grbFormulario.Controls.Add(this.txtPrecio);
            this.grbFormulario.Controls.Add(this.Label_Categoria);
            this.grbFormulario.Controls.Add(this.txtNombre);
            this.grbFormulario.Controls.Add(this.Label_Precio);
            this.grbFormulario.Controls.Add(this.Label_Imagen);
            this.grbFormulario.Controls.Add(this.Label_Descripcion);
            this.grbFormulario.Location = new System.Drawing.Point(25, 12);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(368, 345);
            this.grbFormulario.TabIndex = 13;
            this.grbFormulario.TabStop = false;
            this.grbFormulario.Text = "Formulario";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(255, 378);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 45);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(25, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 45);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(113, 191);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(212, 111);
            this.rtxtDescripcion.TabIndex = 13;
            this.rtxtDescripcion.Text = "";
            // 
            // VentanaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 458);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbFormulario);
            this.Name = "VentanaAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaAgregar";
            this.Load += new System.EventHandler(this.VentanaAgregar_Load);
            this.grbFormulario.ResumeLayout(false);
            this.grbFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label Label_CodigoArticulo;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Marca;
        private System.Windows.Forms.Label Label_Categoria;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.Label Label_Descripcion;
        private System.Windows.Forms.Label Label_Imagen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox grbFormulario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
    }
}