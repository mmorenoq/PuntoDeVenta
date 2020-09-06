namespace PuntoDeVenta
{
    partial class PuntoVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntoVenta));
            this.LBTituloPuntoVenta = new System.Windows.Forms.Label();
            this.LBTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBCaptura = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.LBTotal = new System.Windows.Forms.Label();
            this.BTPagarEfectivo = new System.Windows.Forms.Button();
            this.LBTotalStatic = new System.Windows.Forms.Label();
            this.BTPonerSaldo = new System.Windows.Forms.Button();
            this.BTRetirarEfectivo = new System.Windows.Forms.Button();
            this.BTPagarTcd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LBTituloPuntoVenta
            // 
            this.LBTituloPuntoVenta.AutoSize = true;
            this.LBTituloPuntoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTituloPuntoVenta.Location = new System.Drawing.Point(205, 39);
            this.LBTituloPuntoVenta.Name = "LBTituloPuntoVenta";
            this.LBTituloPuntoVenta.Size = new System.Drawing.Size(513, 25);
            this.LBTituloPuntoVenta.TabIndex = 0;
            this.LBTituloPuntoVenta.Text = "Ultramarinos \"EL MANOS FRIAS\" 2.0 Reloaded\"";
            // 
            // LBTimer
            // 
            this.LBTimer.AutoSize = true;
            this.LBTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTimer.Location = new System.Drawing.Point(321, 64);
            this.LBTimer.Name = "LBTimer";
            this.LBTimer.Size = new System.Drawing.Size(113, 20);
            this.LBTimer.TabIndex = 1;
            this.LBTimer.Text = "Fecha, Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToDeleteRows = false;
            this.DGProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.Precio,
            this.Total});
            this.DGProductos.Location = new System.Drawing.Point(16, 94);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.ReadOnly = true;
            this.DGProductos.RowHeadersVisible = false;
            this.DGProductos.Size = new System.Drawing.Size(304, 203);
            this.DGProductos.TabIndex = 2;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // TBCaptura
            // 
            this.TBCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCaptura.Location = new System.Drawing.Point(12, 409);
            this.TBCaptura.Name = "TBCaptura";
            this.TBCaptura.Size = new System.Drawing.Size(648, 29);
            this.TBCaptura.TabIndex = 3;
            this.TBCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCaptura_KeyPress);
            // 
            // LBTotal
            // 
            this.LBTotal.AutoSize = true;
            this.LBTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotal.Location = new System.Drawing.Point(728, 417);
            this.LBTotal.Name = "LBTotal";
            this.LBTotal.Size = new System.Drawing.Size(60, 24);
            this.LBTotal.TabIndex = 4;
            this.LBTotal.Text = "$ 0.00";
            // 
            // BTPagarEfectivo
            // 
            this.BTPagarEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTPagarEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPagarEfectivo.Image = ((System.Drawing.Image)(resources.GetObject("BTPagarEfectivo.Image")));
            this.BTPagarEfectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTPagarEfectivo.Location = new System.Drawing.Point(16, 315);
            this.BTPagarEfectivo.Name = "BTPagarEfectivo";
            this.BTPagarEfectivo.Size = new System.Drawing.Size(85, 75);
            this.BTPagarEfectivo.TabIndex = 5;
            this.BTPagarEfectivo.Text = "Pagar Efectivo";
            this.BTPagarEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTPagarEfectivo.UseVisualStyleBackColor = true;
            // 
            // LBTotalStatic
            // 
            this.LBTotalStatic.AutoSize = true;
            this.LBTotalStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotalStatic.Location = new System.Drawing.Point(666, 417);
            this.LBTotalStatic.Name = "LBTotalStatic";
            this.LBTotalStatic.Size = new System.Drawing.Size(56, 24);
            this.LBTotalStatic.TabIndex = 6;
            this.LBTotalStatic.Text = "Total:";
            // 
            // BTPonerSaldo
            // 
            this.BTPonerSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTPonerSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPonerSaldo.Image = ((System.Drawing.Image)(resources.GetObject("BTPonerSaldo.Image")));
            this.BTPonerSaldo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTPonerSaldo.Location = new System.Drawing.Point(349, 315);
            this.BTPonerSaldo.Name = "BTPonerSaldo";
            this.BTPonerSaldo.Size = new System.Drawing.Size(85, 75);
            this.BTPonerSaldo.TabIndex = 7;
            this.BTPonerSaldo.Text = "Poner Saldo";
            this.BTPonerSaldo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTPonerSaldo.UseVisualStyleBackColor = true;
            // 
            // BTRetirarEfectivo
            // 
            this.BTRetirarEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTRetirarEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRetirarEfectivo.Image = ((System.Drawing.Image)(resources.GetObject("BTRetirarEfectivo.Image")));
            this.BTRetirarEfectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTRetirarEfectivo.Location = new System.Drawing.Point(235, 315);
            this.BTRetirarEfectivo.Name = "BTRetirarEfectivo";
            this.BTRetirarEfectivo.Size = new System.Drawing.Size(85, 75);
            this.BTRetirarEfectivo.TabIndex = 8;
            this.BTRetirarEfectivo.Text = "Retirar Efectivo";
            this.BTRetirarEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTRetirarEfectivo.UseVisualStyleBackColor = true;
            // 
            // BTPagarTcd
            // 
            this.BTPagarTcd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTPagarTcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTPagarTcd.Image = ((System.Drawing.Image)(resources.GetObject("BTPagarTcd.Image")));
            this.BTPagarTcd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTPagarTcd.Location = new System.Drawing.Point(116, 315);
            this.BTPagarTcd.Name = "BTPagarTcd";
            this.BTPagarTcd.Size = new System.Drawing.Size(85, 75);
            this.BTPagarTcd.TabIndex = 9;
            this.BTPagarTcd.Text = "Pagar Tarjeta";
            this.BTPagarTcd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTPagarTcd.UseVisualStyleBackColor = true;
            // 
            // PuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTPagarTcd);
            this.Controls.Add(this.BTRetirarEfectivo);
            this.Controls.Add(this.BTPonerSaldo);
            this.Controls.Add(this.LBTotalStatic);
            this.Controls.Add(this.BTPagarEfectivo);
            this.Controls.Add(this.LBTotal);
            this.Controls.Add(this.TBCaptura);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.LBTimer);
            this.Controls.Add(this.LBTituloPuntoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PuntoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBTituloPuntoVenta;
        private System.Windows.Forms.Label LBTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.TextBox TBCaptura;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.Label LBTotal;
        private System.Windows.Forms.Button BTPagarEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label LBTotalStatic;
        private System.Windows.Forms.Button BTPonerSaldo;
        private System.Windows.Forms.Button BTRetirarEfectivo;
        private System.Windows.Forms.Button BTPagarTcd;
    }
}