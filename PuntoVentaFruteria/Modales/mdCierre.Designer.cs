namespace PuntoVentaFruteria.Modales
{
    partial class mdCierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdCierre));
            this.label10 = new System.Windows.Forms.Label();
            this.TextCierreCaja = new System.Windows.Forms.TextBox();
            this.BtnCierre = new FontAwesome.Sharp.IconButton();
            this.BtnTicket = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 151);
            this.label10.TabIndex = 70;
            this.label10.Text = "Cierre De Caja";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextCierreCaja
            // 
            this.TextCierreCaja.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCierreCaja.Location = new System.Drawing.Point(12, 56);
            this.TextCierreCaja.Name = "TextCierreCaja";
            this.TextCierreCaja.Size = new System.Drawing.Size(200, 32);
            this.TextCierreCaja.TabIndex = 71;
            // 
            // BtnCierre
            // 
            this.BtnCierre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCierre.BackColor = System.Drawing.Color.Green;
            this.BtnCierre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCierre.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCierre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCierre.ForeColor = System.Drawing.Color.Black;
            this.BtnCierre.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.BtnCierre.IconColor = System.Drawing.Color.Black;
            this.BtnCierre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCierre.IconSize = 25;
            this.BtnCierre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCierre.Location = new System.Drawing.Point(218, 56);
            this.BtnCierre.Name = "BtnCierre";
            this.BtnCierre.Size = new System.Drawing.Size(100, 33);
            this.BtnCierre.TabIndex = 72;
            this.BtnCierre.Text = "Cierre";
            this.BtnCierre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCierre.UseVisualStyleBackColor = false;
            this.BtnCierre.Click += new System.EventHandler(this.BtnCierre_Click);
            // 
            // BtnTicket
            // 
            this.BtnTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTicket.BackColor = System.Drawing.Color.Red;
            this.BtnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTicket.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTicket.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTicket.ForeColor = System.Drawing.Color.Black;
            this.BtnTicket.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnTicket.IconColor = System.Drawing.Color.Black;
            this.BtnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTicket.IconSize = 25;
            this.BtnTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTicket.Location = new System.Drawing.Point(27, 106);
            this.BtnTicket.Name = "BtnTicket";
            this.BtnTicket.Size = new System.Drawing.Size(174, 33);
            this.BtnTicket.TabIndex = 73;
            this.BtnTicket.Text = "Generar Ticket";
            this.BtnTicket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTicket.UseVisualStyleBackColor = false;
            this.BtnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            // 
            // mdCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 151);
            this.Controls.Add(this.BtnCierre);
            this.Controls.Add(this.BtnTicket);
            this.Controls.Add(this.TextCierreCaja);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mdCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre";
            this.Load += new System.EventHandler(this.mdCierre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextCierreCaja;
        private FontAwesome.Sharp.IconButton BtnCierre;
        private FontAwesome.Sharp.IconButton BtnTicket;
    }
}