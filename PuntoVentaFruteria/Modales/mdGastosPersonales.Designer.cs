namespace PuntoVentaFruteria.Modales
{
    partial class mdGastosPersonales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdGastosPersonales));
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextBusquedas = new System.Windows.Forms.TextBox();
            this.CboBuscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextMontoTotal = new System.Windows.Forms.TextBox();
            this.TextConcepto = new System.Windows.Forms.TextBox();
            this.TextNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextFecha = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.TextIndice = new System.Windows.Forms.TextBox();
            this.TextID = new System.Windows.Forms.TextBox();
            this.DgvDataGastosPersonales = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gastosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montosTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.TextMontoGasto = new System.Windows.Forms.TextBox();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscarFechas = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataGastosPersonales)).BeginInit();
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
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(1149, 62);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(33, 33);
            this.BtnLimpiarBuscador.TabIndex = 55;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1110, 62);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscar.TabIndex = 54;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBusquedas
            // 
            this.TextBusquedas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBusquedas.Location = new System.Drawing.Point(904, 63);
            this.TextBusquedas.Name = "TextBusquedas";
            this.TextBusquedas.Size = new System.Drawing.Size(200, 32);
            this.TextBusquedas.TabIndex = 53;
            this.TextBusquedas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBusquedas_KeyDown);
            // 
            // CboBuscar
            // 
            this.CboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBuscar.FormattingEnabled = true;
            this.CboBuscar.Location = new System.Drawing.Point(698, 62);
            this.CboBuscar.Name = "CboBuscar";
            this.CboBuscar.Size = new System.Drawing.Size(200, 33);
            this.CboBuscar.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(585, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "Buscar por: ";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1194, 101);
            this.label10.TabIndex = 50;
            this.label10.Text = "Gastos Personales";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 522);
            this.label1.TabIndex = 56;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextMontoTotal
            // 
            this.TextMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextMontoTotal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMontoTotal.Location = new System.Drawing.Point(27, 307);
            this.TextMontoTotal.Name = "TextMontoTotal";
            this.TextMontoTotal.Size = new System.Drawing.Size(185, 32);
            this.TextMontoTotal.TabIndex = 61;
            // 
            // TextConcepto
            // 
            this.TextConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextConcepto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextConcepto.Location = new System.Drawing.Point(27, 221);
            this.TextConcepto.Name = "TextConcepto";
            this.TextConcepto.Size = new System.Drawing.Size(185, 32);
            this.TextConcepto.TabIndex = 60;
            // 
            // TextNombreUsuario
            // 
            this.TextNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombreUsuario.Location = new System.Drawing.Point(27, 140);
            this.TextNombreUsuario.Name = "TextNombreUsuario";
            this.TextNombreUsuario.Size = new System.Drawing.Size(185, 32);
            this.TextNombreUsuario.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Monto Total";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Concepto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha";
            // 
            // TextFecha
            // 
            this.TextFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFecha.Location = new System.Drawing.Point(27, 385);
            this.TextFecha.Name = "TextFecha";
            this.TextFecha.Size = new System.Drawing.Size(185, 32);
            this.TextFecha.TabIndex = 71;
            // 
            // BtnEliminar
            // 
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
            this.BtnEliminar.Location = new System.Drawing.Point(54, 540);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 37);
            this.BtnEliminar.TabIndex = 74;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpiar
            // 
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
            this.BtnLimpiar.Location = new System.Drawing.Point(54, 487);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(121, 37);
            this.BtnLimpiar.TabIndex = 73;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
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
            this.BtnGuardar.Location = new System.Drawing.Point(54, 434);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(121, 37);
            this.BtnGuardar.TabIndex = 72;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TextIndice
            // 
            this.TextIndice.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIndice.Location = new System.Drawing.Point(181, 104);
            this.TextIndice.Name = "TextIndice";
            this.TextIndice.Size = new System.Drawing.Size(31, 20);
            this.TextIndice.TabIndex = 81;
            this.TextIndice.Text = "-1";
            this.TextIndice.Visible = false;
            // 
            // TextID
            // 
            this.TextID.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextID.Location = new System.Drawing.Point(218, 104);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(31, 20);
            this.TextID.TabIndex = 80;
            this.TextID.Text = "0";
            this.TextID.Visible = false;
            // 
            // DgvDataGastosPersonales
            // 
            this.DgvDataGastosPersonales.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataGastosPersonales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataGastosPersonales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataGastosPersonales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDataGastosPersonales.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataGastosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataGastosPersonales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataGastosPersonales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataGastosPersonales.ColumnHeadersHeight = 40;
            this.DgvDataGastosPersonales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.gastosID,
            this.usuariosID,
            this.nombresUsuarios,
            this.concepto,
            this.montosTotales,
            this.fechaRegistros});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataGastosPersonales.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDataGastosPersonales.Dock = System.Windows.Forms.DockStyle.Right;
            this.DgvDataGastosPersonales.EnableHeadersVisualStyles = false;
            this.DgvDataGastosPersonales.GridColor = System.Drawing.Color.Black;
            this.DgvDataGastosPersonales.Location = new System.Drawing.Point(276, 101);
            this.DgvDataGastosPersonales.MultiSelect = false;
            this.DgvDataGastosPersonales.Name = "DgvDataGastosPersonales";
            this.DgvDataGastosPersonales.ReadOnly = true;
            this.DgvDataGastosPersonales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataGastosPersonales.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDataGastosPersonales.RowHeadersVisible = false;
            this.DgvDataGastosPersonales.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDataGastosPersonales.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDataGastosPersonales.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvDataGastosPersonales.RowTemplate.DividerHeight = 3;
            this.DgvDataGastosPersonales.RowTemplate.Height = 100;
            this.DgvDataGastosPersonales.Size = new System.Drawing.Size(918, 522);
            this.DgvDataGastosPersonales.TabIndex = 82;
            this.DgvDataGastosPersonales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDataGastosPersonales_CellContentClick);
            this.DgvDataGastosPersonales.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvDataGastosPersonales_CellPainting);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 14;
            // 
            // gastosID
            // 
            this.gastosID.HeaderText = "gastosID";
            this.gastosID.Name = "gastosID";
            this.gastosID.ReadOnly = true;
            this.gastosID.Visible = false;
            this.gastosID.Width = 124;
            // 
            // usuariosID
            // 
            this.usuariosID.HeaderText = "usuariosID";
            this.usuariosID.Name = "usuariosID";
            this.usuariosID.ReadOnly = true;
            this.usuariosID.Visible = false;
            this.usuariosID.Width = 141;
            // 
            // nombresUsuarios
            // 
            this.nombresUsuarios.HeaderText = "Nombre Usuario";
            this.nombresUsuarios.Name = "nombresUsuarios";
            this.nombresUsuarios.ReadOnly = true;
            this.nombresUsuarios.Width = 185;
            // 
            // concepto
            // 
            this.concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.concepto.DefaultCellStyle = dataGridViewCellStyle3;
            this.concepto.HeaderText = "Concepto";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            // 
            // montosTotales
            // 
            this.montosTotales.HeaderText = "Montos Total";
            this.montosTotales.Name = "montosTotales";
            this.montosTotales.ReadOnly = true;
            this.montosTotales.Width = 160;
            // 
            // fechaRegistros
            // 
            this.fechaRegistros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaRegistros.HeaderText = "Fecha Registros";
            this.fechaRegistros.Name = "fechaRegistros";
            this.fechaRegistros.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(822, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Monto Gastado:";
            // 
            // TextMontoGasto
            // 
            this.TextMontoGasto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextMontoGasto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMontoGasto.Location = new System.Drawing.Point(975, 24);
            this.TextMontoGasto.Name = "TextMontoGasto";
            this.TextMontoGasto.Size = new System.Drawing.Size(207, 32);
            this.TextMontoGasto.TabIndex = 83;
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
            this.DateTimePicker2.Location = new System.Drawing.Point(399, 63);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(130, 32);
            this.DateTimePicker2.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 87;
            this.label6.Text = "Fecha Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 86;
            this.label8.Text = "Fecha Fin";
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
            this.DateTimePicker1.Location = new System.Drawing.Point(148, 63);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(130, 32);
            this.DateTimePicker1.TabIndex = 85;
            // 
            // BtnBuscarFechas
            // 
            this.BtnBuscarFechas.BackColor = System.Drawing.Color.Green;
            this.BtnBuscarFechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarFechas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarFechas.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarFechas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarFechas.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarFechas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarFechas.IconSize = 25;
            this.BtnBuscarFechas.Location = new System.Drawing.Point(535, 62);
            this.BtnBuscarFechas.Name = "BtnBuscarFechas";
            this.BtnBuscarFechas.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscarFechas.TabIndex = 89;
            this.BtnBuscarFechas.UseVisualStyleBackColor = false;
            this.BtnBuscarFechas.Click += new System.EventHandler(this.BtnBuscarFechas_Click);
            // 
            // mdGastosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 623);
            this.Controls.Add(this.BtnBuscarFechas);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextMontoGasto);
            this.Controls.Add(this.DgvDataGastosPersonales);
            this.Controls.Add(this.TextIndice);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TextFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextMontoTotal);
            this.Controls.Add(this.TextConcepto);
            this.Controls.Add(this.TextNombreUsuario);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBusquedas);
            this.Controls.Add(this.CboBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdGastosPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastosPersonales";
            this.Load += new System.EventHandler(this.GastosPersonales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataGastosPersonales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox TextBusquedas;
        private System.Windows.Forms.ComboBox CboBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextMontoTotal;
        private System.Windows.Forms.TextBox TextConcepto;
        private System.Windows.Forms.TextBox TextNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextFecha;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox TextIndice;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnSeleccionar;
        private System.Windows.Forms.DataGridView DgvDataGastosPersonales;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastosID;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariosID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn montosTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextMontoGasto;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private FontAwesome.Sharp.IconButton BtnBuscarFechas;
    }
}