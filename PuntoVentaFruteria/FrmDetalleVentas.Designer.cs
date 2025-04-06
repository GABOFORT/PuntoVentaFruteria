namespace PuntoVentaFruteria
{
    partial class FrmDetalleVentas
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
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextBusquedas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFondo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.TextFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextMontosPagos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextMontosCambios = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DgvDataDetallesVentas = new System.Windows.Forms.DataGridView();
            this.TextMontosTotales = new System.Windows.Forms.TextBox();
            this.DgvDataVentasDia = new System.Windows.Forms.DataGridView();
            this.Numero_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricipciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadKgGr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsPorPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataDetallesVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVentasDia)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiarBuscador
            // 
            this.BtnLimpiarBuscador.BackColor = System.Drawing.Color.Red;
            this.BtnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarBuscador.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiarBuscador.IconSize = 25;
            this.BtnLimpiarBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(435, 67);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(33, 33);
            this.BtnLimpiarBuscador.TabIndex = 53;
            this.BtnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.BtnLimpiarBuscador.Click += new System.EventHandler(this.BtnLimpiarBuscador_Click);
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
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(396, 67);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscar.TabIndex = 52;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBusquedas
            // 
            this.TextBusquedas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBusquedas.Location = new System.Drawing.Point(183, 68);
            this.TextBusquedas.Name = "TextBusquedas";
            this.TextBusquedas.Size = new System.Drawing.Size(207, 32);
            this.TextBusquedas.TabIndex = 51;
            this.TextBusquedas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBusquedas_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(108, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 25);
            this.label11.TabIndex = 50;
            this.label11.Text = "Buscar: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 43);
            this.label1.TabIndex = 49;
            this.label1.Text = "DETALLE VENTA";
            // 
            // lblFondo
            // 
            this.lblFondo.BackColor = System.Drawing.Color.White;
            this.lblFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFondo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondo.Location = new System.Drawing.Point(0, 0);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(1531, 673);
            this.lblFondo.TabIndex = 48;
            this.lblFondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextUsuario);
            this.groupBox1.Controls.Add(this.TextFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 99);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Usuario";
            // 
            // TextUsuario
            // 
            this.TextUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsuario.Location = new System.Drawing.Point(250, 61);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(184, 32);
            this.TextUsuario.TabIndex = 27;
            // 
            // TextFecha
            // 
            this.TextFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFecha.Location = new System.Drawing.Point(19, 61);
            this.TextFecha.Name = "TextFecha";
            this.TextFecha.Size = new System.Drawing.Size(184, 32);
            this.TextFecha.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "Monto Pago";
            // 
            // TextMontosPagos
            // 
            this.TextMontosPagos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMontosPagos.Location = new System.Drawing.Point(573, 58);
            this.TextMontosPagos.Name = "TextMontosPagos";
            this.TextMontosPagos.Size = new System.Drawing.Size(145, 32);
            this.TextMontosPagos.TabIndex = 64;
            this.TextMontosPagos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Monto Cambio";
            // 
            // TextMontosCambios
            // 
            this.TextMontosCambios.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMontosCambios.Location = new System.Drawing.Point(572, 118);
            this.TextMontosCambios.Name = "TextMontosCambios";
            this.TextMontosCambios.Size = new System.Drawing.Size(146, 32);
            this.TextMontosCambios.TabIndex = 62;
            this.TextMontosCambios.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(572, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 59;
            this.label12.Text = "Monto Total";
            // 
            // DgvDataDetallesVentas
            // 
            this.DgvDataDetallesVentas.AllowUserToAddRows = false;
            this.DgvDataDetallesVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDataDetallesVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataDetallesVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataDetallesVentas.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataDetallesVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataDetallesVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataDetallesVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataDetallesVentas.ColumnHeadersHeight = 40;
            this.DgvDataDetallesVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descricipciones,
            this.Precio_Venta,
            this.Cantidad,
            this.PrecioPeso,
            this.UnidadKgGr,
            this.EsPorPeso,
            this.Sub_Total});
            this.DgvDataDetallesVentas.EnableHeadersVisualStyles = false;
            this.DgvDataDetallesVentas.GridColor = System.Drawing.Color.Black;
            this.DgvDataDetallesVentas.Location = new System.Drawing.Point(183, 246);
            this.DgvDataDetallesVentas.MultiSelect = false;
            this.DgvDataDetallesVentas.Name = "DgvDataDetallesVentas";
            this.DgvDataDetallesVentas.ReadOnly = true;
            this.DgvDataDetallesVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataDetallesVentas.RowHeadersVisible = false;
            this.DgvDataDetallesVentas.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataDetallesVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataDetallesVentas.RowTemplate.DividerHeight = 3;
            this.DgvDataDetallesVentas.RowTemplate.Height = 100;
            this.DgvDataDetallesVentas.Size = new System.Drawing.Size(1183, 415);
            this.DgvDataDetallesVentas.TabIndex = 67;
            // 
            // TextMontosTotales
            // 
            this.TextMontosTotales.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMontosTotales.Location = new System.Drawing.Point(572, 182);
            this.TextMontosTotales.Name = "TextMontosTotales";
            this.TextMontosTotales.Size = new System.Drawing.Size(146, 32);
            this.TextMontosTotales.TabIndex = 60;
            this.TextMontosTotales.Text = "0";
            // 
            // DgvDataVentasDia
            // 
            this.DgvDataVentasDia.AllowUserToAddRows = false;
            this.DgvDataVentasDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDataVentasDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataVentasDia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataVentasDia.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataVentasDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataVentasDia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataVentasDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDataVentasDia.ColumnHeadersHeight = 40;
            this.DgvDataVentasDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Venta,
            this.Monto_Total,
            this.Fecha_Registro});
            this.DgvDataVentasDia.EnableHeadersVisualStyles = false;
            this.DgvDataVentasDia.GridColor = System.Drawing.Color.Black;
            this.DgvDataVentasDia.Location = new System.Drawing.Point(977, 58);
            this.DgvDataVentasDia.MultiSelect = false;
            this.DgvDataVentasDia.Name = "DgvDataVentasDia";
            this.DgvDataVentasDia.ReadOnly = true;
            this.DgvDataVentasDia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataVentasDia.RowHeadersVisible = false;
            this.DgvDataVentasDia.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataVentasDia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDataVentasDia.RowTemplate.DividerHeight = 3;
            this.DgvDataVentasDia.RowTemplate.Height = 100;
            this.DgvDataVentasDia.Size = new System.Drawing.Size(554, 171);
            this.DgvDataVentasDia.TabIndex = 68;
            // 
            // Numero_Venta
            // 
            this.Numero_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero_Venta.HeaderText = "Numero Venta";
            this.Numero_Venta.Name = "Numero_Venta";
            this.Numero_Venta.ReadOnly = true;
            // 
            // Monto_Total
            // 
            this.Monto_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monto_Total.HeaderText = "Monto Total";
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.ReadOnly = true;
            // 
            // Fecha_Registro
            // 
            this.Fecha_Registro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha_Registro.HeaderText = "Fecha Registro";
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1116, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 43);
            this.label3.TabIndex = 69;
            this.label3.Text = "VENTAS DEL DIA";
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 126;
            // 
            // Descricipciones
            // 
            this.Descricipciones.HeaderText = "Descricipciones";
            this.Descricipciones.Name = "Descricipciones";
            this.Descricipciones.ReadOnly = true;
            this.Descricipciones.Width = 185;
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
            // PrecioPeso
            // 
            this.PrecioPeso.HeaderText = "Precio Peso";
            this.PrecioPeso.Name = "PrecioPeso";
            this.PrecioPeso.ReadOnly = true;
            this.PrecioPeso.Width = 149;
            // 
            // UnidadKgGr
            // 
            this.UnidadKgGr.HeaderText = "Unidad, Kg y Gr";
            this.UnidadKgGr.Name = "UnidadKgGr";
            this.UnidadKgGr.ReadOnly = true;
            this.UnidadKgGr.Width = 181;
            // 
            // EsPorPeso
            // 
            this.EsPorPeso.HeaderText = "Por Peso";
            this.EsPorPeso.Name = "EsPorPeso";
            this.EsPorPeso.ReadOnly = true;
            this.EsPorPeso.Width = 124;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 129;
            // 
            // FrmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 673);
            this.Controls.Add(this.DgvDataVentasDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextMontosPagos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextMontosCambios);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DgvDataDetallesVentas);
            this.Controls.Add(this.TextMontosTotales);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBusquedas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFondo);
            this.Name = "FrmDetalleVentas";
            this.Text = "FrmDetalleVentas";
            this.Load += new System.EventHandler(this.FrmDetalleVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataDetallesVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVentasDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TextBusquedas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFondo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox TextFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextMontosPagos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextMontosCambios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DgvDataDetallesVentas;
        private System.Windows.Forms.TextBox TextMontosTotales;
        private System.Windows.Forms.DataGridView DgvDataVentasDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricipciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadKgGr;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsPorPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
    }
}