using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HexMapProject
{
    public partial class Form1 : Form
    {
        // Globals
        int size = 5;
        List<Label> labelsList = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            pnl1.AutoScroll = false;
            pnl1.HorizontalScroll.Enabled = true;
            pnl1.HorizontalScroll.Visible = true;
            pnl1.HorizontalScroll.Maximum = 1;

            //pnl1.VerticalScroll.Enabled = true;
            //pnl1.VerticalScroll.Visible = true;
            //pnl1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            size = (int)(2 * nmrcSizeInput.Value - 1);

            pnl1.Refresh();
            pnl1.Paint += new PaintEventHandler(pnl1_Paint);

            foreach (Label label in labelsList)
            {
                pnl1.Controls.Remove(label);
            }
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;
            int r = 20;

            //PointF center = new PointF(pnl1.Size.Width / 2, pnl1.Size.Height / 2);
            PointF center = new PointF(250, 250);
            Pen pen = new Pen(Color.Red);

            HexMap hexMap = new HexMap(size, r, center);
            pnl1.SuspendLayout();
            foreach (HexTile hexTile in hexMap.HexTilesList())
            {
                g.DrawLines(pen, hexTile.HexEdges());

                //Label hexPosLabel = hexTile.HexPositionLabel();
                //pnl1.Controls.Add(hexPosLabel);
                //hexPosLabel.Name = "hexTileLabel";
                //labelsList.Add(hexPosLabel);
            }
            pnl1.ResumeLayout();
        }
    }
}
