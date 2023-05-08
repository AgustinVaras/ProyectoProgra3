
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
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lwImagenes = new System.Windows.Forms.ListView();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbFormulario.SuspendLayout();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(113, 19);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(212, 20);
            this.txtCodigoArticulo.TabIndex = 0;
            // 
            // Label_CodigoArticulo
            // 
            this.Label_CodigoArticulo.AutoSize = true;
            this.Label_CodigoArticulo.Location = new System.Drawing.Point(23, 22);
            this.Label_CodigoArticulo.Name = "Label_CodigoArticulo";
            this.Label_CodigoArticulo.Size = new System.Drawing.Size(84, 13);
            this.Label_CodigoArticulo.TabIndex = 1;
            this.Label_CodigoArticulo.Text = "Codigo Articulo: ";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(57, 55);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(50, 13);
            this.Label_Nombre.TabIndex = 2;
            this.Label_Nombre.Text = "Nombre: ";
            // 
            // Label_Marca
            // 
            this.Label_Marca.AutoSize = true;
            this.Label_Marca.Location = new System.Drawing.Point(64, 85);
            this.Label_Marca.Name = "Label_Marca";
            this.Label_Marca.Size = new System.Drawing.Size(43, 13);
            this.Label_Marca.TabIndex = 3;
            this.Label_Marca.Text = "Marca: ";
            // 
            // Label_Categoria
            // 
            this.Label_Categoria.AutoSize = true;
            this.Label_Categoria.Location = new System.Drawing.Point(49, 116);
            this.Label_Categoria.Name = "Label_Categoria";
            this.Label_Categoria.Size = new System.Drawing.Size(58, 13);
            this.Label_Categoria.TabIndex = 4;
            this.Label_Categoria.Text = "Categoria: ";
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Location = new System.Drawing.Point(64, 148);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(43, 13);
            this.Label_Precio.TabIndex = 5;
            this.Label_Precio.Text = "Precio: ";
            // 
            // Label_Descripcion
            // 
            this.Label_Descripcion.AutoSize = true;
            this.Label_Descripcion.Location = new System.Drawing.Point(38, 178);
            this.Label_Descripcion.Name = "Label_Descripcion";
            this.Label_Descripcion.Size = new System.Drawing.Size(69, 13);
            this.Label_Descripcion.TabIndex = 6;
            this.Label_Descripcion.Text = "Descripcion: ";
            // 
            // Label_Imagen
            // 
            this.Label_Imagen.AutoSize = true;
            this.Label_Imagen.Location = new System.Drawing.Point(16, 22);
            this.Label_Imagen.Name = "Label_Imagen";
            this.Label_Imagen.Size = new System.Drawing.Size(86, 13);
            this.Label_Imagen.TabIndex = 7;
            this.Label_Imagen.Text = "Url de la imagen:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(113, 148);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(212, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(113, 82);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(212, 21);
            this.cbMarca.TabIndex = 11;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(113, 113);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(212, 21);
            this.cbCategoria.TabIndex = 12;
            // 
            // grbFormulario
            // 
            this.grbFormulario.Controls.Add(this.gbImagen);
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
            this.grbFormulario.Controls.Add(this.Label_Descripcion);
            this.grbFormulario.Location = new System.Drawing.Point(25, 12);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(677, 468);
            this.grbFormulario.TabIndex = 13;
            this.grbFormulario.TabStop = false;
            this.grbFormulario.Text = "Formulario";
            // 
            // gbImagen
            // 
            this.gbImagen.Controls.Add(this.btnEliminarImg);
            this.gbImagen.Controls.Add(this.pbImagen);
            this.gbImagen.Controls.Add(this.btnCargarImagen);
            this.gbImagen.Controls.Add(this.txtUrl);
            this.gbImagen.Controls.Add(this.lwImagenes);
            this.gbImagen.Controls.Add(this.Label_Imagen);
            this.gbImagen.Location = new System.Drawing.Point(6, 238);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(665, 224);
            this.gbImagen.TabIndex = 16;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagenes";
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Location = new System.Drawing.Point(108, 176);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(140, 23);
            this.btnEliminarImg.TabIndex = 18;
            this.btnEliminarImg.Text = "Eliminar Url Seleccionada";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(403, 49);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(220, 169);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImagen.TabIndex = 17;
            this.pbImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(401, 19);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarImagen.TabIndex = 16;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(108, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(288, 20);
            this.txtUrl.TabIndex = 14;
            // 
            // lwImagenes
            // 
            this.lwImagenes.HideSelection = false;
            this.lwImagenes.Location = new System.Drawing.Point(108, 45);
            this.lwImagenes.Name = "lwImagenes";
            this.lwImagenes.Size = new System.Drawing.Size(288, 124);
            this.lwImagenes.TabIndex = 15;
            this.lwImagenes.UseCompatibleStateImageBehavior = false;
            this.lwImagenes.View = System.Windows.Forms.View.List;
            this.lwImagenes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwImagenes_ItemSelectionChanged);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(113, 178);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(289, 54);
            this.rtxtDescripcion.TabIndex = 13;
            this.rtxtDescripcion.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(381, 486);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 45);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(212, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 45);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // VentanaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 543);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grbFormulario);
            this.Name = "VentanaAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaAgregar";
            this.Load += new System.EventHandler(this.VentanaAgregar_Load);
            this.grbFormulario.ResumeLayout(false);
            this.grbFormulario.PerformLayout();
            this.gbImagen.ResumeLayout(false);
            this.gbImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
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
        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ListView lwImagenes;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnEliminarImg;
    }
}