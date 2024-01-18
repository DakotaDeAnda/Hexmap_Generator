using System;
using System.Drawing;
using System.Windows.Forms;


namespace HexMapProject
{
    class HexTile
    {
        float r;
        PointF tileCenter;
        Label lblPos;
        public HexTile(PointF centerInput, int rInput, Label lblPosInput)
        {
            tileCenter = centerInput;
            r = rInput;
            lblPos = lblPosInput;
        }

        public PointF HexPosition()
        {
            return tileCenter;
        }

        public Label HexPositionLabel()
        {
            return lblPos;
        }

        public PointF[] HexEdges()
        {
            PointF[] points = new PointF[7];

            points[0] = new PointF(tileCenter.X - r, tileCenter.Y);
            points[1] = new PointF(tileCenter.X - (r / 2), tileCenter.Y + (float)(Math.Sqrt(3) / 2 * r));
            points[2] = new PointF(tileCenter.X + (r / 2), tileCenter.Y + (float)(Math.Sqrt(3) / 2 * r));
            points[3] = new PointF(tileCenter.X + r, tileCenter.Y);
            points[4] = new PointF(tileCenter.X + (r / 2), tileCenter.Y - (float)(Math.Sqrt(3) / 2 * r));
            points[5] = new PointF(tileCenter.X - (r / 2), tileCenter.Y - (float)(Math.Sqrt(3) / 2 * r));
            points[6] = points[0];

            return points;
        }
    }
}
