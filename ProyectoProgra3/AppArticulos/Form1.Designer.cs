
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
            this.TextBox_Buscar = new System.Windows.Forms.TextBox();
            this.Boton_Buscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cboCriterioBusqueda = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Boton_Detalles = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.Location = new System.Drawing.Point(193, 14);
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.Size = new System.Drawing.Size(194, 20);
            this.TextBox_Buscar.TabIndex = 2;
            // 
            // Boton_Buscar
            // 
            this.Boton_Buscar.Location = new System.Drawing.Point(394, 14);
            this.Boton_Buscar.Name = "Boton_Buscar";
            this.Boton_Buscar.Size = new System.Drawing.Size(95, 21);
            this.Boton_Buscar.TabIndex = 3;
            this.Boton_Buscar.Text = "Buscar";
            this.Boton_Buscar.UseVisualStyleBackColor = true;
            this.Boton_Buscar.Click += new System.EventHandler(this.Boton_Buscar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(11, 14);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(63, 20);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Búsqueda";
            // 
            // cboCriterioBusqueda
            // 
            this.cboCriterioBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioBusqueda.FormattingEnabled = true;
            this.cboCriterioBusqueda.Location = new System.Drawing.Point(77, 13);
            this.cboCriterioBusqueda.Name = "cboCriterioBusqueda";
            this.cboCriterioBusqueda.Size = new System.Drawing.Size(109, 21);
            this.cboCriterioBusqueda.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAgregar});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // itemAgregar
            // 
            this.itemAgregar.Name = "itemAgregar";
            this.itemAgregar.Size = new System.Drawing.Size(116, 22);
            this.itemAgregar.Text = "Agregar";
            this.itemAgregar.Click += new System.EventHandler(this.itemAgregar_Click_1);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemModificar,
            this.itemEliminar});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.edicionToolStripMenuItem.Text = "Editar";
            // 
            // itemModificar
            // 
            this.itemModificar.Name = "itemModificar";
            this.itemModificar.Size = new System.Drawing.Size(125, 22);
            this.itemModificar.Text = "Modificar";
            this.itemModificar.Click += new System.EventHandler(this.itemModificar_Click);
            // 
            // itemEliminar
            // 
            this.itemEliminar.Name = "itemEliminar";
            this.itemEliminar.Size = new System.Drawing.Size(125, 22);
            this.itemEliminar.Text = "Eliminar";
            this.itemEliminar.Click += new System.EventHandler(this.itemEliminar_Click);
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.cboCriterioBusqueda);
            this.gbxBusqueda.Controls.Add(this.lblBusqueda);
            this.gbxBusqueda.Controls.Add(this.Boton_Buscar);
            this.gbxBusqueda.Controls.Add(this.TextBox_Buscar);
            this.gbxBusqueda.Location = new System.Drawing.Point(17, 27);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(502, 43);
            this.gbxBusqueda.TabIndex = 9;
            this.gbxBusqueda.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Boton_Detalles);
            this.groupBox1.Controls.Add(this.dgvPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(17, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 341);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Boton_Detalles
            // 
            this.Boton_Detalles.Location = new System.Drawing.Point(370, 294);
            this.Boton_Detalles.Name = "Boton_Detalles";
            this.Boton_Detalles.Size = new System.Drawing.Size(123, 33);
            this.Boton_Detalles.TabIndex = 0;
            this.Boton_Detalles.Text = "Detalles";
            this.Boton_Detalles.UseVisualStyleBackColor = true;
            this.Boton_Detalles.Click += new System.EventHandler(this.Boton_Detalles_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(17, 14);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.Size = new System.Drawing.Size(476, 274);
            this.dgvPrincipal.TabIndex = 1;
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBusqueda);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ventana_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.Ventana_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_Buscar;
        private System.Windows.Forms.Button Boton_Buscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cboCriterioBusqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAgregar;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemModificar;
        private System.Windows.Forms.ToolStripMenuItem itemEliminar;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Boton_Detalles;
        private System.Windows.Forms.DataGridView dgvPrincipal;
    }
}

