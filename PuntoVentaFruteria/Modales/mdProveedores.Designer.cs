namespace PuntoVentaFruteria.Modales
{
    partial class mdProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdProveedores));
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.TextBusquedas = new System.Windows.Forms.TextBox();
            this.CboBuscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvDataMDProveedores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDProveedores)).BeginInit();
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
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(565, 55);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(33, 33);
            this.BtnLimpiarBuscador.TabIndex = 39;
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
            this.BtnBuscar.Location = new System.Drawing.Point(526, 55);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscar.TabIndex = 38;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBusquedas
            // 
            this.TextBusquedas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBusquedas.Location = new System.Drawing.Point(320, 56);
            this.TextBusquedas.Name = "TextBusquedas";
            this.TextBusquedas.Size = new System.Drawing.Size(200, 32);
            this.TextBusquedas.TabIndex = 37;
            this.TextBusquedas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBusquedas_KeyDown);
            // 
            // CboBuscar
            // 
            this.CboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBuscar.FormattingEnabled = true;
            this.CboBuscar.Location = new System.Drawing.Point(114, 56);
            this.CboBuscar.Name = "CboBuscar";
            this.CboBuscar.Size = new System.Drawing.Size(200, 33);
            this.CboBuscar.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Buscar por: ";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(607, 101);
            this.label10.TabIndex = 34;
            this.label10.Text = "Lista de Proveedor";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DgvDataMDProveedores
            // 
            this.DgvDataMDProveedores.AllowUserToAddRows = false;
            this.DgvDataMDProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDataMDProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DgvDataMDProveedores.BackgroundColor = System.Drawing.Color.White;
            this.DgvDataMDProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataMDProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDataMDProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDataMDProveedores.ColumnHeadersHeight = 40;
            this.DgvDataMDProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Clave_Proveedor,
            this.Nombre_Proveedor});
            this.DgvDataMDProveedores.EnableHeadersVisualStyles = false;
            this.DgvDataMDProveedores.GridColor = System.Drawing.Color.Black;
            this.DgvDataMDProveedores.Location = new System.Drawing.Point(104, 104);
            this.DgvDataMDProveedores.MultiSelect = false;
            this.DgvDataMDProveedores.Name = "DgvDataMDProveedores";
            this.DgvDataMDProveedores.ReadOnly = true;
            this.DgvDataMDProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvDataMDProveedores.RowHeadersVisible = false;
            this.DgvDataMDProveedores.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDataMDProveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.DgvDataMDProveedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvDataMDProveedores.RowTemplate.DividerHeight = 3;
            this.DgvDataMDProveedores.RowTemplate.Height = 100;
            this.DgvDataMDProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDataMDProveedores.Size = new System.Drawing.Size(469, 476);
            this.DgvDataMDProveedores.TabIndex = 33;
            this.DgvDataMDProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDataMDProveedores_CellDoubleClick);
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
            this.Nombre_Proveedor.HeaderText = "Nombre Proveedor";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            this.Nombre_Proveedor.ReadOnly = true;
            this.Nombre_Proveedor.Width = 207;
            // 
            // mdProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 580);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBusquedas);
            this.Controls.Add(this.CboBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvDataMDProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.mdProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataMDProveedores)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvDataMDProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
    }
}