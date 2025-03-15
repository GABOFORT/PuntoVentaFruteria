namespace PuntoVentaFruteria
{
    partial class FrmReportesCompras
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
            this.BtnBuscarProveedores = new FontAwesome.Sharp.IconButton();
            this.CboBuscarProveedores = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextBusquedas = new System.Windows.Forms.TextBox();
            this.CboBuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvDataReportesCompra = new System.Windows.Forms.DataGridView();
            this.Fecha_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TextMontoCompra = new System.Windows.Forms.TextBox();
            this.BtnVerMasVendidos = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataReportesCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscarProveedores
            // 
            this.BtnBuscarProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscarProveedores.BackColor = System.Drawing.Color.Green;
            this.BtnBuscarProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarProveedores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProveedores.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarProveedores.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarProveedores.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProveedores.IconSize = 25;
            this.BtnBuscarProveedores.Location = new System.Drawing.Point(871, 80);
            this.BtnBuscarProveedores.Name = "BtnBuscarProveedores";
            this.BtnBuscarProveedores.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscarProveedores.TabIndex = 36;
            this.BtnBuscarProveedores.UseVisualStyleBackColor = false;
            this.BtnBuscarProveedores.Click += new System.EventHandler(this.BtnBuscarProveedores_Click);
            // 
            // CboBuscarProveedores
            // 
            this.CboBuscarProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboBuscarProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscarProveedores.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBuscarProveedores.FormattingEnabled = true;
            this.CboBuscarProveedores.Location = new System.Drawing.Point(658, 80);
            this.CboBuscarProveedores.Name = "CboBuscarProveedores";
            this.CboBuscarProveedores.Size = new System.Drawing.Size(207, 33);
            this.CboBuscarProveedores.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(555, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Proveedor:";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.CalendarForeColor = System.Drawing.Color.Black;
            this.DateTimePicker2.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.SteelBlue;
            this.DateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.DateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.DateTimePicker2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker2.Location = new System.Drawing.Point(387, 77);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(130, 32);
            this.DateTimePicker2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha Fin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 43);
            this.label2.TabIndex = 30;
            this.label2.Text = "Reporte Compras";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.SteelBlue;
            this.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.DateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.DateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(134, 77);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(134, 32);
            this.DateTimePicker1.TabIndex = 28;
            // 
            // BtnLimpiarBuscador
            // 
            this.BtnLimpiarBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiarBuscador.BackColor = System.Drawing.Color.Red;
            this.BtnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarBuscador.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiarBuscador.IconSize = 25;
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(1508, 80);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(33, 33);
            this.BtnLimpiarBuscador.TabIndex = 42;
            this.BtnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.BtnLimpiarBuscador.Click += new System.EventHandler(this.BtnLimpiarBuscador_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.Green;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 25;
            this.BtnBuscar.Location = new System.Drawing.Point(1469, 80);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscar.TabIndex = 41;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBusquedas
            // 
            this.TextBusquedas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBusquedas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBusquedas.Location = new System.Drawing.Point(1256, 80);
            this.TextBusquedas.Name = "TextBusquedas";
            this.TextBusquedas.Size = new System.Drawing.Size(207, 32);
            this.TextBusquedas.TabIndex = 40;
            this.TextBusquedas.TextChanged += new System.EventHandler(this.TextBusquedas_TextChanged);
            // 
            // CboBuscar
            // 
            this.CboBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBuscar.FormattingEnabled = true;
            this.CboBuscar.Location = new System.Drawing.Point(1039, 80);
            this.CboBuscar.Name = "CboBuscar";
            this.CboBuscar.Size = new System.Drawing.Size(207, 33);
            this.CboBuscar.TabIndex = 39;
            this.CboBuscar.SelectedIndexChanged += new System.EventHandler(this.CboBuscar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(959, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Buscar: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1574, 121);
            this.label5.TabIndex = 37;
            // 
            // DgvDataReportesCompra
            // 
            this.DgvDataReportesCompra.AllowUserToAddRows = false;
            this.DgvDataReportesCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDataReportesCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataReportesCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDataReportesCompra.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataReportesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataReportesCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataReportesCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataReportesCompra.ColumnHeadersHeight = 40;
            this.DgvDataReportesCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha_Registro,
            this.Numero_Documento,
            this.Monto_Total,
            this.Usuario_Registro,
            this.Documento_Proveedor,
            this.Nombre_Proveedor,
            this.Codigo_Producto,
            this.Nombre_Producto,
            this.descripcion,
            this.Categoria,
            this.Precio_Compra,
            this.Precio_Venta,
            this.Cantidad,
            this.Sub_Total});
            this.DgvDataReportesCompra.EnableHeadersVisualStyles = false;
            this.DgvDataReportesCompra.GridColor = System.Drawing.Color.Black;
            this.DgvDataReportesCompra.Location = new System.Drawing.Point(0, 121);
            this.DgvDataReportesCompra.MultiSelect = false;
            this.DgvDataReportesCompra.Name = "DgvDataReportesCompra";
            this.DgvDataReportesCompra.ReadOnly = true;
            this.DgvDataReportesCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataReportesCompra.RowHeadersVisible = false;
            this.DgvDataReportesCompra.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataReportesCompra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataReportesCompra.RowTemplate.DividerHeight = 3;
            this.DgvDataReportesCompra.RowTemplate.Height = 100;
            this.DgvDataReportesCompra.Size = new System.Drawing.Size(1574, 566);
            this.DgvDataReportesCompra.TabIndex = 43;
            // 
            // Fecha_Registro
            // 
            this.Fecha_Registro.HeaderText = "Fecha Registro";
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.ReadOnly = true;
            this.Fecha_Registro.Width = 177;
            // 
            // Numero_Documento
            // 
            this.Numero_Documento.HeaderText = "Numero Compras";
            this.Numero_Documento.Name = "Numero_Documento";
            this.Numero_Documento.ReadOnly = true;
            this.Numero_Documento.Width = 195;
            // 
            // Monto_Total
            // 
            this.Monto_Total.HeaderText = "Monto Total";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.ReadOnly = true;
            this.Monto_Total.Width = 150;
            // 
            // Usuario_Registro
            // 
            this.Usuario_Registro.HeaderText = "Usuario Registro";
            this.Usuario_Registro.Name = "Usuario_Registro";
            this.Usuario_Registro.ReadOnly = true;
            this.Usuario_Registro.Width = 191;
            // 
            // Documento_Proveedor
            // 
            this.Documento_Proveedor.HeaderText = "Clave Proveedor";
            this.Documento_Proveedor.Name = "Documento_Proveedor";
            this.Documento_Proveedor.ReadOnly = true;
            this.Documento_Proveedor.Width = 188;
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.HeaderText = "Proveedor";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            this.Nombre_Proveedor.ReadOnly = true;
            this.Nombre_Proveedor.Width = 136;
            // 
            // Codigo_Producto
            // 
            this.Codigo_Producto.HeaderText = "Codigo Producto";
            this.Codigo_Producto.Name = "Codigo_Producto";
            this.Codigo_Producto.ReadOnly = true;
            this.Codigo_Producto.Width = 192;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.ReadOnly = true;
            this.Nombre_Producto.Width = 126;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 130;
            // 
            // Precio_Compra
            // 
            this.Precio_Compra.HeaderText = "Precio Compra";
            this.Precio_Compra.Name = "Precio_Compra";
            this.Precio_Compra.ReadOnly = true;
            this.Precio_Compra.Width = 173;
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.HeaderText = "Precio Venta";
            this.Precio_Venta.Name = "Precio_Venta";
            this.Precio_Venta.ReadOnly = true;
            this.Precio_Venta.Width = 155;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 124;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Monto Comprado:";
            // 
            // TextMontoCompra
            // 
            this.TextMontoCompra.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMontoCompra.Location = new System.Drawing.Point(174, 30);
            this.TextMontoCompra.Name = "TextMontoCompra";
            this.TextMontoCompra.Size = new System.Drawing.Size(207, 32);
            this.TextMontoCompra.TabIndex = 75;
            // 
            // BtnVerMasVendidos
            // 
            this.BtnVerMasVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerMasVendidos.BackColor = System.Drawing.Color.Green;
            this.BtnVerMasVendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerMasVendidos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVerMasVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerMasVendidos.ForeColor = System.Drawing.Color.White;
            this.BtnVerMasVendidos.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnVerMasVendidos.IconColor = System.Drawing.Color.Black;
            this.BtnVerMasVendidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVerMasVendidos.IconSize = 30;
            this.BtnVerMasVendidos.Location = new System.Drawing.Point(1508, 36);
            this.BtnVerMasVendidos.Name = "BtnVerMasVendidos";
            this.BtnVerMasVendidos.Size = new System.Drawing.Size(32, 32);
            this.BtnVerMasVendidos.TabIndex = 78;
            this.BtnVerMasVendidos.UseVisualStyleBackColor = false;
            this.BtnVerMasVendidos.Click += new System.EventHandler(this.BtnVerMasVendidos_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1259, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 25);
            this.label7.TabIndex = 77;
            this.label7.Text = "Productos Mas Comprados";
            // 
            // FrmReportesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 687);
            this.Controls.Add(this.BtnVerMasVendidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextMontoCompra);
            this.Controls.Add(this.DgvDataReportesCompra);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBusquedas);
            this.Controls.Add(this.CboBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBuscarProveedores);
            this.Controls.Add(this.CboBuscarProveedores);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.label5);
            this.Name = "FrmReportesCompras";
            this.Text = "FrmReporteCompras";
            this.Load += new System.EventHandler(this.FrmReportesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataReportesCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBuscarProveedores;
        private System.Windows.Forms.ComboBox CboBuscarProveedores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TextBusquedas;
        private System.Windows.Forms.ComboBox CboBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvDataReportesCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextMontoCompra;
        private FontAwesome.Sharp.IconButton BtnVerMasVendidos;
        private System.Windows.Forms.Label label7;
    }
}