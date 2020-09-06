using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class PuntoVenta : Form
    {
        public PuntoVenta()
        {
            InitializeComponent();
        }

        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            
            DGProductos.Width = this.Width * 98 / 100;
            DGProductos.Columns[0].Width = DGProductos.Width * 2 / 10;
            DGProductos.Columns[1].Width = DGProductos.Width * 4 / 10;
            DGProductos.Columns[2].Width = DGProductos.Width * 2 / 10;
            DGProductos.Columns[3].Width = DGProductos.Width * 2 / 10;

            DGProductos.Height = this.Height * 8/10;

            int ay = LBTituloPuntoVenta.Height;
            int by = LBTimer.Height;
            int cy = DGProductos.Height;
            int ey = TBCaptura.Height;
            int fy = this.Height * 1 / 100;
            int dy = this.Height - (ay + by + cy + ey + fy);
            int gy = dy * 90 / 100;
            int hy = (dy - gy) / 2;

            int bx = DGProductos.Columns[0].Width;
            int cx = DGProductos.Columns[1].Width;
            int dx = DGProductos.Columns[2].Width;
            int ex = DGProductos.Columns[3].Width;
            int ax = (this.Width - DGProductos.Width) / 2;
            int fx = (this.Width - DGProductos.Width) / 2;

            LBTituloPuntoVenta.Location = new Point(this.Width / 2 - LBTituloPuntoVenta.Width / 2, 0);
            LBTimer.Location = new Point(this.Width / 2 - LBTimer.Width / 2, ay);
            DGProductos.Location = new Point(ax, ay + by);
            TBCaptura.Width = DGProductos.Width;
            TBCaptura.Location = new Point (ax, (this.Height - TBCaptura.Height)-fy);
            BTPagarEfectivo.Height = gy;
            BTPagarEfectivo.Width = gy;
            BTPagarEfectivo.Location = new Point(ax, ay + by + cy + hy);
            BTPagarTcd.Height = gy;
            BTPagarTcd.Width = gy;
            BTPagarTcd.Location = new Point(ax + gy + hy, ay + by + cy + hy);
            BTRetirarEfectivo.Height = gy;
            BTRetirarEfectivo.Width = gy;
            BTRetirarEfectivo.Location = new Point(ax + 2 * gy + 2 * hy, ay + by + cy + hy);
            BTPonerSaldo.Height = gy;
            BTPonerSaldo.Width = gy;
            BTPonerSaldo.Location = new Point(ax + 3 * gy + 3 * hy, ay + by + cy + hy);

            LBTotal.Location = new Point(ax + bx + cx + dx, ay + by + cy + dy / 2 - LBTotal.Height / 2);
            LBTotalStatic.Location = new Point(ax + bx + cx + dx - LBTotalStatic.Width, ay + by + cy + dy / 2 - LBTotalStatic.Height / 2);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void TextBoxCaptura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DGProductos.Rows.Add(TBCaptura.Text,"Lo que sea");
            }
        }

    }
}
