namespace PuntoVentaFruteria
{
    partial class FrmCompras
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
            this.BtnRegister = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.TextTotalPagar = new System.Windows.Forms.TextBox();
            this.IconBtnAgregarProductos = new FontAwesome.Sharp.IconButton();
            this.TextPrecioVenta = new System.Windows.Forms.TextBox();
            this.TextPrecioCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvDataCompras = new System.Windows.Forms.DataGridView();
            this.TextNombreProductos = new System.Windows.Forms.TextBox();
            this.TextIDProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TextCodigoProductos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextCantidadyPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextDescripcion = new System.Windows.Forms.TextBox();
            this.TextFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextNombreProveedor = new System.Windows.Forms.TextBox();
            this.TextIDProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextClaveProveedor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esPorPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataCompras)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegister.AutoSize = true;
            this.BtnRegister.BackColor = System.Drawing.Color.LightCoral;
            this.BtnRegister.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.BtnRegister.IconColor = System.Drawing.Color.Black;
            this.BtnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegister.IconSize = 25;
            this.BtnRegister.Location = new System.Drawing.Point(1452, 505);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(171, 35);
            this.BtnRegister.TabIndex = 54;
            this.BtnRegister.Text = "Cerrar Compra";
            this.BtnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1473, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 25);
            this.label12.TabIndex = 50;
            this.label12.Text = "Total a Pagar";
            // 
            // TextTotalPagar
            // 
            this.TextTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextTotalPagar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTotalPagar.Location = new System.Drawing.Point(1452, 447);
            this.TextTotalPagar.Name = "TextTotalPagar";
            this.TextTotalPagar.Size = new System.Drawing.Size(171, 32);
            this.TextTotalPagar.TabIndex = 51;
            this.TextTotalPagar.Text = "0";
            // 
            // IconBtnAgregarProductos
            // 
            this.IconBtnAgregarProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IconBtnAgregarProductos.AutoSize = true;
            this.IconBtnAgregarProductos.BackColor = System.Drawing.Color.LightCoral;
            this.IconBtnAgregarProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtnAgregarProductos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IconBtnAgregarProductos.IconColor = System.Drawing.Color.Black;
            this.IconBtnAgregarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtnAgregarProductos.IconSize = 70;
            this.IconBtnAgregarProductos.Location = new System.Drawing.Point(1480, 271);
            this.IconBtnAgregarProductos.Name = "IconBtnAgregarProductos";
            this.IconBtnAgregarProductos.Size = new System.Drawing.Size(107, 130);
            this.IconBtnAgregarProductos.TabIndex = 64;
            this.IconBtnAgregarProductos.Text = "Agregar\r\nCompra";
            this.IconBtnAgregarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconBtnAgregarProductos.UseVisualStyleBackColor = false;
            this.IconBtnAgregarProductos.Click += new System.EventHandler(this.IconBtnAgregarProductos_Click);
            // 
            // TextPrecioVenta
            // 
            this.TextPrecioVenta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrecioVenta.Location = new System.Drawing.Point(928, 61);
            this.TextPrecioVenta.Name = "TextPrecioVenta";
            this.TextPrecioVenta.Size = new System.Drawing.Size(185, 32);
            this.TextPrecioVenta.TabIndex = 35;
            this.TextPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPrecioVenta_KeyPress);
            // 
            // TextPrecioCompra
            // 
            this.TextPrecioCompra.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrecioCompra.Location = new System.Drawing.Point(720, 61);
            this.TextPrecioCompra.Name = "TextPrecioCompra";
            this.TextPrecioCompra.Size = new System.Drawing.Size(185, 32);
            this.TextPrecioCompra.TabIndex = 34;
            this.TextPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPrecioCompra_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(923, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Precio Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Precio Compra";
            // 
            // DgvDataCompras
            // 
            this.DgvDataCompras.AllowUserToAddRows = false;
            this.DgvDataCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DgvDataCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataCompras.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataCompras.ColumnHeadersHeight = 40;
            this.DgvDataCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoID,
            this.Producto,
            this.Descripciones,
            this.Precio_Compra,
            this.Precio_Venta,
            this.Cantidad,
            this.peso,
            this.esPorPeso,
            this.Sub_Total,
            this.btnEliminar});
            this.DgvDataCompras.EnableHeadersVisualStyles = false;
            this.DgvDataCompras.GridColor = System.Drawing.Color.Black;
            this.DgvDataCompras.Location = new System.Drawing.Point(12, 286);
            this.DgvDataCompras.MultiSelect = false;
            this.DgvDataCompras.Name = "DgvDataCompras";
            this.DgvDataCompras.ReadOnly = true;
            this.DgvDataCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataCompras.RowHeadersVisible = false;
            this.DgvDataCompras.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataCompras.RowTemplate.DividerHeight = 3;
            this.DgvDataCompras.RowTemplate.Height = 100;
            this.DgvDataCompras.Size = new System.Drawing.Size(1434, 375);
            this.DgvDataCompras.TabIndex = 52;
            this.DgvDataCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDataCompras_CellContentClick);
            this.DgvDataCompras.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDataCompras_CellPainting);
            // 
            // TextNombreProductos
            // 
            this.TextNombreProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombreProductos.Location = new System.Drawing.Point(250, 61);
            this.TextNombreProductos.Name = "TextNombreProductos";
            this.TextNombreProductos.Size = new System.Drawing.Size(249, 32);
            this.TextNombreProductos.TabIndex = 30;
            // 
            // TextIDProducto
            // 
            this.TextIDProducto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIDProducto.Location = new System.Drawing.Point(198, 23);
            this.TextIDProducto.Name = "TextIDProducto";
            this.TextIDProducto.Size = new System.Drawing.Size(31, 32);
            this.TextIDProducto.TabIndex = 29;
            this.TextIDProducto.Visible = false;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.Green;
            this.BtnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProducto.IconSize = 25;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(211, 60);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscarProducto.TabIndex = 29;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // TextCodigoProductos
            // 
            this.TextCodigoProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCodigoProductos.Location = new System.Drawing.Point(20, 61);
            this.TextCodigoProductos.Name = "TextCodigoProductos";
            this.TextCodigoProductos.Size = new System.Drawing.Size(185, 32);
            this.TextCodigoProductos.TabIndex = 25;
            this.TextCodigoProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextCodigoProductos_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Codigo Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TextPeso);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TextCodigoProductos);
            this.groupBox3.Controls.Add(this.TextCantidadyPeso);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TextDescripcion);
            this.groupBox3.Controls.Add(this.BtnBuscarProducto);
            this.groupBox3.Controls.Add(this.TextPrecioVenta);
            this.groupBox3.Controls.Add(this.TextIDProducto);
            this.groupBox3.Controls.Add(this.TextPrecioCompra);
            this.groupBox3.Controls.Add(this.TextNombreProductos);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(47, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1540, 110);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1126, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Cantidad Peso";
            // 
            // TextCantidadyPeso
            // 
            this.TextCantidadyPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextCantidadyPeso.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCantidadyPeso.Location = new System.Drawing.Point(1131, 61);
            this.TextCantidadyPeso.Name = "TextCantidadyPeso";
            this.TextCantidadyPeso.Size = new System.Drawing.Size(185, 32);
            this.TextCantidadyPeso.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Descripción";
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDescripcion.Location = new System.Drawing.Point(516, 61);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Size = new System.Drawing.Size(185, 32);
            this.TextDescripcion.TabIndex = 37;
            // 
            // TextFecha
            // 
            this.TextFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFecha.Location = new System.Drawing.Point(488, 62);
            this.TextFecha.Name = "TextFecha";
            this.TextFecha.Size = new System.Drawing.Size(185, 32);
            this.TextFecha.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 43);
            this.label1.TabIndex = 42;
            this.label1.Text = "Registrar Compra";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1648, 673);
            this.label10.TabIndex = 41;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TextFecha);
            this.groupBox2.Controls.Add(this.TextNombreProveedor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TextIDProveedor);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.TextClaveProveedor);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(487, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 106);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proveedor";
            // 
            // TextNombreProveedor
            // 
            this.TextNombreProveedor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombreProveedor.Location = new System.Drawing.Point(265, 62);
            this.TextNombreProveedor.Name = "TextNombreProveedor";
            this.TextNombreProveedor.Size = new System.Drawing.Size(185, 32);
            this.TextNombreProveedor.TabIndex = 29;
            // 
            // TextIDProveedor
            // 
            this.TextIDProveedor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIDProveedor.Location = new System.Drawing.Point(437, 27);
            this.TextIDProveedor.Name = "TextIDProveedor";
            this.TextIDProveedor.Size = new System.Drawing.Size(31, 32);
            this.TextIDProveedor.TabIndex = 28;
            this.TextIDProveedor.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(216, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 33);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextClaveProveedor
            // 
            this.TextClaveProveedor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextClaveProveedor.Location = new System.Drawing.Point(15, 62);
            this.TextClaveProveedor.Name = "TextClaveProveedor";
            this.TextClaveProveedor.Size = new System.Drawing.Size(185, 32);
            this.TextClaveProveedor.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Nombre Proveedor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Clave Proveedor";
            // 
            // TextPeso
            // 
            this.TextPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextPeso.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPeso.Location = new System.Drawing.Point(1330, 60);
            this.TextPeso.Name = "TextPeso";
            this.TextPeso.Size = new System.Drawing.Size(185, 32);
            this.TextPeso.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1325, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Peso";
            // 
            // productoID
            // 
            this.productoID.HeaderText = "productoID";
            this.productoID.Name = "productoID";
            this.productoID.ReadOnly = true;
            this.productoID.Visible = false;
            this.productoID.Width = 143;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Descripciones
            // 
            this.Descripciones.HeaderText = "Descripciones";
            this.Descripciones.Name = "Descripciones";
            this.Descripciones.ReadOnly = true;
            this.Descripciones.Width = 170;
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
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 90;
            // 
            // esPorPeso
            // 
            this.esPorPeso.HeaderText = "Por Peso";
            this.esPorPeso.Name = "esPorPeso";
            this.esPorPeso.ReadOnly = true;
            this.esPorPeso.Width = 124;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 129;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Width = 30;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TextTotalPagar);
            this.Controls.Add(this.IconBtnAgregarProductos);
            this.Controls.Add(this.DgvDataCompras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "FrmCompras";
            this.Text = "FrmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataCompras)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnRegister;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextTotalPagar;
        private FontAwesome.Sharp.IconButton IconBtnAgregarProductos;
        private System.Windows.Forms.TextBox TextPrecioVenta;
        private System.Windows.Forms.TextBox TextPrecioCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgvDataCompras;
        private System.Windows.Forms.TextBox TextNombreProductos;
        private System.Windows.Forms.TextBox TextIDProducto;
        private FontAwesome.Sharp.IconButton BtnBuscarProducto;
        private System.Windows.Forms.TextBox TextCodigoProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextNombreProveedor;
        private System.Windows.Forms.TextBox TextIDProveedor;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox TextClaveProveedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextCantidadyPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn esPorPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}