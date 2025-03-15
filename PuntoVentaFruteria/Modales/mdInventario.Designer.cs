namespace PuntoVentaFruteria.Modales
{
    partial class mdInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdInventario));
            this.DgvDataMDInventarios = new System.Windows.Forms.DataGridView();
            this.inventariosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextBusquedas = new System.Windows.Forms.TextBox();
            this.CboBuscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnAgregarProductos = new FontAwesome.Sharp.IconButton();
            this.iconBtnEliminarProductos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDInventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDataMDInventarios
            // 
            this.DgvDataMDInventarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvDataMDInventarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataMDInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataMDInventarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataMDInventarios.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataMDInventarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataMDInventarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataMDInventarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataMDInventarios.ColumnHeadersHeight = 40;
            this.DgvDataMDInventarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventariosID,
            this.nombresProductos,
            this.descripciones,
            this.stockActual,
            this.stockMinimo,
            this.fechaActualizacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDataMDInventarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDataMDInventarios.EnableHeadersVisualStyles = false;
            this.DgvDataMDInventarios.GridColor = System.Drawing.Color.Black;
            this.DgvDataMDInventarios.Location = new System.Drawing.Point(177, 101);
            this.DgvDataMDInventarios.MultiSelect = false;
            this.DgvDataMDInventarios.Name = "DgvDataMDInventarios";
            this.DgvDataMDInventarios.ReadOnly = true;
            this.DgvDataMDInventarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataMDInventarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDataMDInventarios.RowHeadersVisible = false;
            this.DgvDataMDInventarios.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDInventarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDataMDInventarios.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvDataMDInventarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DgvDataMDInventarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDInventarios.RowTemplate.DividerHeight = 3;
            this.DgvDataMDInventarios.RowTemplate.Height = 100;
            this.DgvDataMDInventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDataMDInventarios.Size = new System.Drawing.Size(989, 550);
            this.DgvDataMDInventarios.TabIndex = 43;
            // 
            // inventariosID
            // 
            this.inventariosID.HeaderText = "inventariosID";
            this.inventariosID.Name = "inventariosID";
            this.inventariosID.ReadOnly = true;
            this.inventariosID.Visible = false;
            this.inventariosID.Width = 157;
            // 
            // nombresProductos
            // 
            this.nombresProductos.HeaderText = "Nombres Productos";
            this.nombresProductos.Name = "nombresProductos";
            this.nombresProductos.ReadOnly = true;
            this.nombresProductos.Width = 213;
            // 
            // descripciones
            // 
            this.descripciones.HeaderText = "Descripciones";
            this.descripciones.Name = "descripciones";
            this.descripciones.ReadOnly = true;
            this.descripciones.Width = 166;
            // 
            // stockActual
            // 
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.Name = "stockActual";
            this.stockActual.ReadOnly = true;
            this.stockActual.Width = 151;
            // 
            // stockMinimo
            // 
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.Name = "stockMinimo";
            this.stockMinimo.ReadOnly = true;
            this.stockMinimo.Width = 159;
            // 
            // fechaActualizacion
            // 
            this.fechaActualizacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaActualizacion.HeaderText = "Fecha Compra";
            this.fechaActualizacion.Name = "fechaActualizacion";
            this.fechaActualizacion.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1166, 101);
            this.label10.TabIndex = 44;
            this.label10.Text = "Inventario";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Red;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 25;
            this.BtnLimpiar.Location = new System.Drawing.Point(848, 62);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(33, 33);
            this.BtnLimpiar.TabIndex = 53;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Green;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 25;
            this.BtnBuscar.Location = new System.Drawing.Point(809, 62);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscar.TabIndex = 52;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBusquedas
            // 
            this.TextBusquedas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBusquedas.Location = new System.Drawing.Point(603, 63);
            this.TextBusquedas.Name = "TextBusquedas";
            this.TextBusquedas.Size = new System.Drawing.Size(200, 32);
            this.TextBusquedas.TabIndex = 51;
            // 
            // CboBuscar
            // 
            this.CboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBuscar.FormattingEnabled = true;
            this.CboBuscar.Location = new System.Drawing.Point(397, 62);
            this.CboBuscar.Name = "CboBuscar";
            this.CboBuscar.Size = new System.Drawing.Size(200, 33);
            this.CboBuscar.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(284, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Buscar por: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 550);
            this.label1.TabIndex = 54;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconBtnAgregarProductos
            // 
            this.iconBtnAgregarProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconBtnAgregarProductos.AutoSize = true;
            this.iconBtnAgregarProductos.BackColor = System.Drawing.Color.LightCoral;
            this.iconBtnAgregarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconBtnAgregarProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconBtnAgregarProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAgregarProductos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAgregarProductos.IconColor = System.Drawing.Color.Black;
            this.iconBtnAgregarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAgregarProductos.IconSize = 70;
            this.iconBtnAgregarProductos.Location = new System.Drawing.Point(23, 183);
            this.iconBtnAgregarProductos.Name = "iconBtnAgregarProductos";
            this.iconBtnAgregarProductos.Size = new System.Drawing.Size(126, 155);
            this.iconBtnAgregarProductos.TabIndex = 65;
            this.iconBtnAgregarProductos.Text = "Agregar\r\nProducto\r\nInventario\r\n";
            this.iconBtnAgregarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnAgregarProductos.UseVisualStyleBackColor = false;
            this.iconBtnAgregarProductos.Click += new System.EventHandler(this.iconBtnAgregarProductos_Click);
            // 
            // iconBtnEliminarProductos
            // 
            this.iconBtnEliminarProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconBtnEliminarProductos.AutoSize = true;
            this.iconBtnEliminarProductos.BackColor = System.Drawing.Color.LightCoral;
            this.iconBtnEliminarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconBtnEliminarProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconBtnEliminarProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnEliminarProductos.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconBtnEliminarProductos.IconColor = System.Drawing.Color.Black;
            this.iconBtnEliminarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnEliminarProductos.IconSize = 70;
            this.iconBtnEliminarProductos.Location = new System.Drawing.Point(23, 361);
            this.iconBtnEliminarProductos.Name = "iconBtnEliminarProductos";
            this.iconBtnEliminarProductos.Size = new System.Drawing.Size(126, 155);
            this.iconBtnEliminarProductos.TabIndex = 66;
            this.iconBtnEliminarProductos.Text = "Agregar\r\nProducto\r\nInventario\r\n";
            this.iconBtnEliminarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnEliminarProductos.UseVisualStyleBackColor = false;
            this.iconBtnEliminarProductos.Click += new System.EventHandler(this.iconBtnEliminarProductos_Click);
            // 
            // mdInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 651);
            this.Controls.Add(this.iconBtnEliminarProductos);
            this.Controls.Add(this.iconBtnAgregarProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBusquedas);
            this.Controls.Add(this.CboBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvDataMDInventarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.mdInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDInventarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDataMDInventarios;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TextBusquedas;
        private System.Windows.Forms.ComboBox CboBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventariosID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaActualizacion;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconBtnAgregarProductos;
        private FontAwesome.Sharp.IconButton iconBtnEliminarProductos;
    }
}