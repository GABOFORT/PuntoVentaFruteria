namespace PuntoVentaFruteria.Modales
{
    partial class mdComprasDesplazados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdComprasDesplazados));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscarFechas = new FontAwesome.Sharp.IconButton();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DgvDataMDMasComprados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Comprado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDMasComprados)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Fecha Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 74;
            this.label4.Text = "Fecha Inicio";
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
            this.BtnBuscarFechas.Location = new System.Drawing.Point(562, 64);
            this.BtnBuscarFechas.Name = "BtnBuscarFechas";
            this.BtnBuscarFechas.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscarFechas.TabIndex = 73;
            this.BtnBuscarFechas.UseVisualStyleBackColor = false;
            this.BtnBuscarFechas.Click += new System.EventHandler(this.BtnBuscarFechas_Click);
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
            this.DateTimePicker2.Location = new System.Drawing.Point(426, 64);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(130, 32);
            this.DateTimePicker2.TabIndex = 72;
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
            this.DateTimePicker1.Location = new System.Drawing.Point(175, 64);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(130, 32);
            this.DateTimePicker1.TabIndex = 71;
            // 
            // DgvDataMDMasComprados
            // 
            this.DgvDataMDMasComprados.AllowUserToAddRows = false;
            this.DgvDataMDMasComprados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataMDMasComprados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataMDMasComprados.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataMDMasComprados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataMDMasComprados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataMDMasComprados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataMDMasComprados.ColumnHeadersHeight = 40;
            this.DgvDataMDMasComprados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre_Producto,
            this.descripcion,
            this.Total_Comprado,
            this.Total_Costo});
            this.DgvDataMDMasComprados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDataMDMasComprados.EnableHeadersVisualStyles = false;
            this.DgvDataMDMasComprados.GridColor = System.Drawing.Color.Black;
            this.DgvDataMDMasComprados.Location = new System.Drawing.Point(0, 103);
            this.DgvDataMDMasComprados.MultiSelect = false;
            this.DgvDataMDMasComprados.Name = "DgvDataMDMasComprados";
            this.DgvDataMDMasComprados.ReadOnly = true;
            this.DgvDataMDMasComprados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataMDMasComprados.RowHeadersVisible = false;
            this.DgvDataMDMasComprados.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDMasComprados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataMDMasComprados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DgvDataMDMasComprados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDMasComprados.RowTemplate.DividerHeight = 3;
            this.DgvDataMDMasComprados.RowTemplate.Height = 100;
            this.DgvDataMDMasComprados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDataMDMasComprados.Size = new System.Drawing.Size(662, 492);
            this.DgvDataMDMasComprados.TabIndex = 70;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 62;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Nombre Producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.ReadOnly = true;
            this.Nombre_Producto.Width = 193;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 146;
            // 
            // Total_Comprado
            // 
            this.Total_Comprado.HeaderText = "Total Comprado";
            this.Total_Comprado.Name = "Total_Comprado";
            this.Total_Comprado.ReadOnly = true;
            this.Total_Comprado.Width = 180;
            // 
            // Total_Costo
            // 
            this.Total_Costo.HeaderText = "Total Costo";
            this.Total_Costo.Name = "Total_Costo";
            this.Total_Costo.ReadOnly = true;
            this.Total_Costo.Width = 142;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(662, 103);
            this.label10.TabIndex = 69;
            this.label10.Text = "Productos Mas Comprados";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mdComprasDesplazados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnBuscarFechas);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.DgvDataMDMasComprados);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdComprasDesplazados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprasDesplazados";
            this.Load += new System.EventHandler(this.mdComprasDesplazados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDMasComprados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BtnBuscarFechas;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.DataGridView DgvDataMDMasComprados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Comprado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Costo;
    }
}