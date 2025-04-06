namespace PuntoVentaFruteria
{
    partial class FrmVentas
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
            this.TextPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextNombreProductos = new System.Windows.Forms.TextBox();
            this.TextIDProductos = new System.Windows.Forms.TextBox();
            this.btnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TextCodigoProductos = new System.Windows.Forms.TextBox();
            this.TextCambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextPagaCon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TextTotalPagar = new System.Windows.Forms.TextBox();
            this.iconBtnAgregarProductos = new FontAwesome.Sharp.IconButton();
            this.DgvDataVentas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextCantidadyPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextPrecioReal = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.Label();
            this.BtnCamara = new FontAwesome.Sharp.IconButton();
            this.TextDescripcion = new System.Windows.Forms.TextBox();
            this.TextPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsPorPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVentas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextPrecioVenta
            // 
            this.TextPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextPrecioVenta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrecioVenta.Location = new System.Drawing.Point(748, 55);
            this.TextPrecioVenta.Name = "TextPrecioVenta";
            this.TextPrecioVenta.Size = new System.Drawing.Size(185, 32);
            this.TextPrecioVenta.TabIndex = 34;
            this.TextPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPrecioCompra_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(743, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Precio Venta";
            // 
            // TextNombreProductos
            // 
            this.TextNombreProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextNombreProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombreProductos.Location = new System.Drawing.Point(213, 55);
            this.TextNombreProductos.Name = "TextNombreProductos";
            this.TextNombreProductos.Size = new System.Drawing.Size(259, 32);
            this.TextNombreProductos.TabIndex = 30;
            // 
            // TextIDProductos
            // 
            this.TextIDProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextIDProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIDProductos.Location = new System.Drawing.Point(440, 17);
            this.TextIDProductos.Name = "TextIDProductos";
            this.TextIDProductos.Size = new System.Drawing.Size(32, 32);
            this.TextIDProductos.TabIndex = 29;
            this.TextIDProductos.Visible = false;
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrearVenta.AutoSize = true;
            this.btnCrearVenta.BackColor = System.Drawing.Color.LightCoral;
            this.btnCrearVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCrearVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrearVenta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.ForeColor = System.Drawing.Color.Black;
            this.btnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnCrearVenta.IconColor = System.Drawing.Color.Black;
            this.btnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVenta.IconSize = 25;
            this.btnCrearVenta.Location = new System.Drawing.Point(1483, 390);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(155, 37);
            this.btnCrearVenta.TabIndex = 71;
            this.btnCrearVenta.Text = "Cerrar Venta";
            this.btnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearVenta.UseVisualStyleBackColor = false;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Green;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 25;
            this.btnBuscarProducto.Location = new System.Drawing.Point(493, 55);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(33, 33);
            this.btnBuscarProducto.TabIndex = 29;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // TextCodigoProductos
            // 
            this.TextCodigoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextCodigoProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCodigoProductos.Location = new System.Drawing.Point(17, 55);
            this.TextCodigoProductos.Name = "TextCodigoProductos";
            this.TextCodigoProductos.Size = new System.Drawing.Size(185, 32);
            this.TextCodigoProductos.TabIndex = 25;
            this.TextCodigoProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextCodigoProductos_KeyDown);
            // 
            // TextCambio
            // 
            this.TextCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextCambio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCambio.Location = new System.Drawing.Point(817, 198);
            this.TextCambio.Name = "TextCambio";
            this.TextCambio.Size = new System.Drawing.Size(150, 32);
            this.TextCambio.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(812, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 25);
            this.label14.TabIndex = 69;
            this.label14.Text = "Cambio";
            // 
            // TextPagaCon
            // 
            this.TextPagaCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextPagaCon.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPagaCon.Location = new System.Drawing.Point(640, 197);
            this.TextPagaCon.Name = "TextPagaCon";
            this.TextPagaCon.Size = new System.Drawing.Size(150, 32);
            this.TextPagaCon.TabIndex = 68;
            this.TextPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextPagaCon_KeyDown);
            this.TextPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPagaCon_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(635, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 25);
            this.label13.TabIndex = 67;
            this.label13.Text = "Paga Con";
            // 
            // TextTotalPagar
            // 
            this.TextTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextTotalPagar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTotalPagar.Location = new System.Drawing.Point(474, 198);
            this.TextTotalPagar.Name = "TextTotalPagar";
            this.TextTotalPagar.Size = new System.Drawing.Size(150, 32);
            this.TextTotalPagar.TabIndex = 66;
            this.TextTotalPagar.Text = "0";
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
            this.iconBtnAgregarProductos.Location = new System.Drawing.Point(1506, 245);
            this.iconBtnAgregarProductos.Name = "iconBtnAgregarProductos";
            this.iconBtnAgregarProductos.Size = new System.Drawing.Size(104, 132);
            this.iconBtnAgregarProductos.TabIndex = 64;
            this.iconBtnAgregarProductos.Text = "Agregar\r\nProducto";
            this.iconBtnAgregarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnAgregarProductos.UseVisualStyleBackColor = false;
            this.iconBtnAgregarProductos.Click += new System.EventHandler(this.iconBtnAgregarProductos_Click);
            // 
            // DgvDataVentas
            // 
            this.DgvDataVentas.AllowUserToAddRows = false;
            this.DgvDataVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DgvDataVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataVentas.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataVentas.ColumnHeadersHeight = 40;
            this.DgvDataVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoID,
            this.Producto,
            this.descripciones,
            this.Precio_Compra,
            this.Cantidad,
            this.pesos,
            this.precioReal,
            this.Sub_Total,
            this.EsPorPeso,
            this.btnEliminar});
            this.DgvDataVentas.EnableHeadersVisualStyles = false;
            this.DgvDataVentas.GridColor = System.Drawing.Color.Black;
            this.DgvDataVentas.Location = new System.Drawing.Point(48, 245);
            this.DgvDataVentas.MultiSelect = false;
            this.DgvDataVentas.Name = "DgvDataVentas";
            this.DgvDataVentas.ReadOnly = true;
            this.DgvDataVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataVentas.RowHeadersVisible = false;
            this.DgvDataVentas.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataVentas.RowTemplate.DividerHeight = 3;
            this.DgvDataVentas.RowTemplate.Height = 100;
            this.DgvDataVentas.Size = new System.Drawing.Size(1429, 425);
            this.DgvDataVentas.TabIndex = 50;
            this.DgvDataVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDataVentas_CellContentClick);
            this.DgvDataVentas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDataVentas_CellPainting);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Producto";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(469, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "Total a Pagar";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Codigo Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.TextCantidadyPeso);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TextPrecioReal);
            this.groupBox3.Controls.Add(this.Peso);
            this.groupBox3.Controls.Add(this.BtnCamara);
            this.groupBox3.Controls.Add(this.TextDescripcion);
            this.groupBox3.Controls.Add(this.TextPeso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TextPrecioVenta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TextNombreProductos);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.TextIDProductos);
            this.groupBox3.Controls.Add(this.TextCodigoProductos);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(48, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1526, 100);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-36, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 32);
            this.textBox1.TabIndex = 47;
            // 
            // TextCantidadyPeso
            // 
            this.TextCantidadyPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextCantidadyPeso.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCantidadyPeso.Location = new System.Drawing.Point(944, 55);
            this.TextCantidadyPeso.Name = "TextCantidadyPeso";
            this.TextCantidadyPeso.Size = new System.Drawing.Size(185, 32);
            this.TextCantidadyPeso.TabIndex = 46;
            this.TextCantidadyPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCantidadyPeso_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(939, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cantidad Peso";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1326, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Precio Real";
            // 
            // TextPrecioReal
            // 
            this.TextPrecioReal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextPrecioReal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrecioReal.Location = new System.Drawing.Point(1331, 57);
            this.TextPrecioReal.Name = "TextPrecioReal";
            this.TextPrecioReal.Size = new System.Drawing.Size(185, 32);
            this.TextPrecioReal.TabIndex = 42;
            // 
            // Peso
            // 
            this.Peso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Peso.AutoSize = true;
            this.Peso.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(1135, 28);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(54, 25);
            this.Peso.TabIndex = 41;
            this.Peso.Text = "Peso";
            // 
            // BtnCamara
            // 
            this.BtnCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnCamara.BackColor = System.Drawing.Color.Green;
            this.BtnCamara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCamara.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCamara.ForeColor = System.Drawing.Color.White;
            this.BtnCamara.IconChar = FontAwesome.Sharp.IconChar.CameraAlt;
            this.BtnCamara.IconColor = System.Drawing.Color.Black;
            this.BtnCamara.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCamara.IconSize = 25;
            this.BtnCamara.Location = new System.Drawing.Point(493, 16);
            this.BtnCamara.Name = "BtnCamara";
            this.BtnCamara.Size = new System.Drawing.Size(33, 33);
            this.BtnCamara.TabIndex = 39;
            this.BtnCamara.UseVisualStyleBackColor = false;
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextDescripcion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDescripcion.Location = new System.Drawing.Point(552, 55);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Size = new System.Drawing.Size(185, 32);
            this.TextDescripcion.TabIndex = 38;
            // 
            // TextPeso
            // 
            this.TextPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextPeso.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPeso.Location = new System.Drawing.Point(1140, 55);
            this.TextPeso.Name = "TextPeso";
            this.TextPeso.Size = new System.Drawing.Size(185, 32);
            this.TextPeso.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripción";
            // 
            // TextFecha
            // 
            this.TextFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFecha.Location = new System.Drawing.Point(990, 197);
            this.TextFecha.Name = "TextFecha";
            this.TextFecha.Size = new System.Drawing.Size(185, 32);
            this.TextFecha.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(985, 169);
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
            this.label1.Location = new System.Drawing.Point(699, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 43);
            this.label1.TabIndex = 59;
            this.label1.Text = "Registrar Venta";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1648, 673);
            this.label10.TabIndex = 58;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // descripciones
            // 
            this.descripciones.HeaderText = "Descripciones";
            this.descripciones.Name = "descripciones";
            this.descripciones.ReadOnly = true;
            this.descripciones.Width = 170;
            // 
            // Precio_Compra
            // 
            this.Precio_Compra.HeaderText = "Precio Compra";
            this.Precio_Compra.Name = "Precio_Compra";
            this.Precio_Compra.ReadOnly = true;
            this.Precio_Compra.Width = 173;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 124;
            // 
            // pesos
            // 
            this.pesos.HeaderText = "Peso";
            this.pesos.Name = "pesos";
            this.pesos.ReadOnly = true;
            this.pesos.Width = 90;
            // 
            // precioReal
            // 
            this.precioReal.HeaderText = "Precio Peso";
            this.precioReal.Name = "precioReal";
            this.precioReal.ReadOnly = true;
            this.precioReal.Width = 149;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 129;
            // 
            // EsPorPeso
            // 
            this.EsPorPeso.HeaderText = "Por Peso";
            this.EsPorPeso.Name = "EsPorPeso";
            this.EsPorPeso.ReadOnly = true;
            this.EsPorPeso.Width = 124;
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
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 673);
            this.Controls.Add(this.DgvDataVentas);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.TextCambio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TextPagaCon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TextTotalPagar);
            this.Controls.Add(this.TextFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconBtnAgregarProductos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVentas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextNombreProductos;
        private System.Windows.Forms.TextBox TextIDProductos;
        private FontAwesome.Sharp.IconButton btnCrearVenta;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox TextCodigoProductos;
        private System.Windows.Forms.TextBox TextCambio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextPagaCon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextTotalPagar;
        private FontAwesome.Sharp.IconButton iconBtnAgregarProductos;
        private System.Windows.Forms.DataGridView DgvDataVentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextFecha;
        private System.Windows.Forms.TextBox TextDescripcion;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BtnCamara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextPrecioReal;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.TextBox TextPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextCantidadyPeso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsPorPeso;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}