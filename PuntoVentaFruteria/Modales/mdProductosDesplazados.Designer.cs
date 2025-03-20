namespace PuntoVentaFruteria.Modales
{
    partial class mdProductosDesplazados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdProductosDesplazados));
            this.label10 = new System.Windows.Forms.Label();
            this.DgvDataMDMasVendidos = new System.Windows.Forms.DataGridView();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscarFechas = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Vendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDMasVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(565, 103);
            this.label10.TabIndex = 44;
            this.label10.Text = "Productos Mas Vendidos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DgvDataMDMasVendidos
            // 
            this.DgvDataMDMasVendidos.AllowUserToAddRows = false;
            this.DgvDataMDMasVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataMDMasVendidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataMDMasVendidos.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataMDMasVendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataMDMasVendidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataMDMasVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataMDMasVendidos.ColumnHeadersHeight = 40;
            this.DgvDataMDMasVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre_Producto,
            this.descripcion,
            this.Total_Vendido});
            this.DgvDataMDMasVendidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvDataMDMasVendidos.EnableHeadersVisualStyles = false;
            this.DgvDataMDMasVendidos.GridColor = System.Drawing.Color.Black;
            this.DgvDataMDMasVendidos.Location = new System.Drawing.Point(0, 103);
            this.DgvDataMDMasVendidos.MultiSelect = false;
            this.DgvDataMDMasVendidos.Name = "DgvDataMDMasVendidos";
            this.DgvDataMDMasVendidos.ReadOnly = true;
            this.DgvDataMDMasVendidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataMDMasVendidos.RowHeadersVisible = false;
            this.DgvDataMDMasVendidos.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDMasVendidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataMDMasVendidos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DgvDataMDMasVendidos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDMasVendidos.RowTemplate.DividerHeight = 3;
            this.DgvDataMDMasVendidos.RowTemplate.Height = 100;
            this.DgvDataMDMasVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDataMDMasVendidos.Size = new System.Drawing.Size(565, 492);
            this.DgvDataMDMasVendidos.TabIndex = 45;
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
            this.DateTimePicker1.Location = new System.Drawing.Point(125, 65);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(130, 32);
            this.DateTimePicker1.TabIndex = 60;
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
            this.DateTimePicker2.Location = new System.Drawing.Point(376, 65);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(130, 32);
            this.DateTimePicker2.TabIndex = 65;
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
            this.BtnBuscarFechas.Location = new System.Drawing.Point(512, 65);
            this.BtnBuscarFechas.Name = "BtnBuscarFechas";
            this.BtnBuscarFechas.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscarFechas.TabIndex = 66;
            this.BtnBuscarFechas.UseVisualStyleBackColor = false;
            this.BtnBuscarFechas.Click += new System.EventHandler(this.BtnBuscarFechas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Fecha Fin";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 61;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Producto.HeaderText = "Nombre Producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 146;
            // 
            // Total_Vendido
            // 
            this.Total_Vendido.HeaderText = "Total Vendido";
            this.Total_Vendido.Name = "Total_Vendido";
            this.Total_Vendido.ReadOnly = true;
            this.Total_Vendido.Width = 162;
            // 
            // mdProductosDesplazados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnBuscarFechas);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.DgvDataMDMasVendidos);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdProductosDesplazados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosDesplazados";
            this.Load += new System.EventHandler(this.mdProductosDesplazados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDMasVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvDataMDMasVendidos;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private FontAwesome.Sharp.IconButton BtnBuscarFechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Vendido;
    }
}