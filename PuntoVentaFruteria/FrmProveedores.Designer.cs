namespace PuntoVentaFruteria
{
    partial class FrmProveedores
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
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.TextIndices = new System.Windows.Forms.TextBox();
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextBusquedas = new System.Windows.Forms.TextBox();
            this.CboBuscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.DgvDataProveedores = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.TextNombreProveedores = new System.Windows.Forms.TextBox();
            this.TextClaveProveedores = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // TextTelefono
            // 
            this.TextTelefono.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTelefono.Location = new System.Drawing.Point(21, 346);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(159, 32);
            this.TextTelefono.TabIndex = 76;
            // 
            // TextIndices
            // 
            this.TextIndices.Location = new System.Drawing.Point(1428, 12);
            this.TextIndices.Name = "TextIndices";
            this.TextIndices.Size = new System.Drawing.Size(31, 20);
            this.TextIndices.TabIndex = 75;
            this.TextIndices.Text = "-1";
            this.TextIndices.Visible = false;
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
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(1451, 53);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(33, 33);
            this.BtnLimpiarBuscador.TabIndex = 74;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1412, 53);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscar.TabIndex = 73;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBusquedas
            // 
            this.TextBusquedas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBusquedas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBusquedas.Location = new System.Drawing.Point(1199, 55);
            this.TextBusquedas.Name = "TextBusquedas";
            this.TextBusquedas.Size = new System.Drawing.Size(207, 32);
            this.TextBusquedas.TabIndex = 72;
            this.TextBusquedas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBusquedas_KeyDown);
            // 
            // CboBuscar
            // 
            this.CboBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBuscar.FormattingEnabled = true;
            this.CboBuscar.Location = new System.Drawing.Point(986, 54);
            this.CboBuscar.Name = "CboBuscar";
            this.CboBuscar.Size = new System.Drawing.Size(207, 33);
            this.CboBuscar.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(907, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 25);
            this.label11.TabIndex = 70;
            this.label11.Text = "Buscar: ";
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(1465, 12);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(31, 20);
            this.TextID.TabIndex = 69;
            this.TextID.Text = "0";
            this.TextID.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1508, 127);
            this.label10.TabIndex = 68;
            this.label10.Text = "Proveedores";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 25;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.Location = new System.Drawing.Point(39, 608);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 37);
            this.BtnEliminar.TabIndex = 65;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.AutoSize = true;
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.BtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 25;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.Location = new System.Drawing.Point(39, 553);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(121, 37);
            this.BtnLimpiar.TabIndex = 64;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // DgvDataProveedores
            // 
            this.DgvDataProveedores.AllowUserToAddRows = false;
            this.DgvDataProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DgvDataProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataProveedores.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataProveedores.ColumnHeadersHeight = 40;
            this.DgvDataProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.ID,
            this.Clave_Proveedor,
            this.Nombre_Proveedor,
            this.Telefono,
            this.Estado_Valor,
            this.Estado});
            this.DgvDataProveedores.EnableHeadersVisualStyles = false;
            this.DgvDataProveedores.GridColor = System.Drawing.Color.Black;
            this.DgvDataProveedores.Location = new System.Drawing.Point(476, 127);
            this.DgvDataProveedores.MultiSelect = false;
            this.DgvDataProveedores.Name = "DgvDataProveedores";
            this.DgvDataProveedores.ReadOnly = true;
            this.DgvDataProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataProveedores.RowHeadersVisible = false;
            this.DgvDataProveedores.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDataProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataProveedores.RowTemplate.DividerHeight = 3;
            this.DgvDataProveedores.RowTemplate.Height = 100;
            this.DgvDataProveedores.Size = new System.Drawing.Size(717, 546);
            this.DgvDataProveedores.TabIndex = 67;
            this.DgvDataProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDataProveedores_CellContentClick);
            this.DgvDataProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDataProveedores_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 66;
            // 
            // Clave_Proveedor
            // 
            this.Clave_Proveedor.HeaderText = "Clave Proveedor";
            this.Clave_Proveedor.Name = "Clave_Proveedor";
            this.Clave_Proveedor.ReadOnly = true;
            this.Clave_Proveedor.Width = 188;
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.HeaderText = "Proveedor";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            this.Nombre_Proveedor.ReadOnly = true;
            this.Nombre_Proveedor.Width = 136;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 123;
            // 
            // Estado_Valor
            // 
            this.Estado_Valor.HeaderText = "Estado_Valor";
            this.Estado_Valor.Name = "Estado_Valor";
            this.Estado_Valor.ReadOnly = true;
            this.Estado_Valor.Visible = false;
            this.Estado_Valor.Width = 162;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 107;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.Black;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 25;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(39, 500);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(121, 37);
            this.BtnGuardar.TabIndex = 63;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "Estado";
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Location = new System.Drawing.Point(21, 441);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(159, 33);
            this.CboEstado.TabIndex = 61;
            // 
            // TextNombreProveedores
            // 
            this.TextNombreProveedores.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombreProveedores.Location = new System.Drawing.Point(21, 255);
            this.TextNombreProveedores.Name = "TextNombreProveedores";
            this.TextNombreProveedores.Size = new System.Drawing.Size(159, 32);
            this.TextNombreProveedores.TabIndex = 60;
            // 
            // TextClaveProveedores
            // 
            this.TextClaveProveedores.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextClaveProveedores.Location = new System.Drawing.Point(21, 164);
            this.TextClaveProveedores.Name = "TextClaveProveedores";
            this.TextClaveProveedores.Size = new System.Drawing.Size(159, 32);
            this.TextClaveProveedores.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Clave Proveedores";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 546);
            this.label2.TabIndex = 55;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 673);
            this.Controls.Add(this.TextTelefono);
            this.Controls.Add(this.TextIndices);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBusquedas);
            this.Controls.Add(this.CboBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.DgvDataProveedores);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.TextNombreProveedores);
            this.Controls.Add(this.TextClaveProveedores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "FrmProveedores";
            this.Text = "FrmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.TextBox TextIndices;
        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TextBusquedas;
        private System.Windows.Forms.ComboBox CboBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.DataGridView DgvDataProveedores;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.TextBox TextNombreProveedores;
        private System.Windows.Forms.TextBox TextClaveProveedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}