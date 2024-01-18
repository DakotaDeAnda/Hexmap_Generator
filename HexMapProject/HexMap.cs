using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HexMapProject
{
    class HexMap
    {
        int size;
        int r;
        PointF mapCenter;
        List<HexTile> hexTileList = new List<HexTile> ();

        public HexMap(int sizeInput, int rInput, PointF centerInput)
        {
            size = sizeInput;
            r = rInput;
            mapCenter = centerInput;

            GenerateHexMap();
        }

        // https://stackoverflow.com/questions/20734438/algorithm-to-generate-a-hexagonal-grid-with-coordinate-system
        private void GenerateHexMap()
        {
            double hexAngle = (Math.PI/180) * 30;
            double xOffset = Math.Cos(hexAngle) * r;
            double yOffset = Math.Sin(hexAngle) * r;

            for (int i = 0; i < size; i++)
            {
                int altSize = size - Math.Abs(i - (size / 2));

                for (int j = 0; j < altSize; j++)
                {
                    int x = (int)(mapCenter.Y + yOffset * (i - (size / 2)) * 3);
                    int y = (int)(mapCenter.X + xOffset * (j * 2 + 1 - altSize));

                    int lblX = i < altSize ? j - i : j - altSize;
                    int lblY = i - altSize;

                    Label hexLabel = new Label();
                    hexLabel.TextAlign = ContentAlignment.MiddleCenter;
                    hexLabel.Text = lblX + "," + lblY;
                    hexLabel.Font = new Font("Arial", 6);
                    hexLabel.BackColor = System.Drawing.Color.Transparent;
                    hexLabel.ForeColor = Color.White;
                    hexLabel.Location = new Point(x - (hexLabel.Width / 2), y - (hexLabel.Height / 2));

                    hexTileList.Add(new HexTile(new PointF(x, y), r, hexLabel));
                }
            }
        }

        public List<HexTile> HexTilesList()
        {
            return hexTileList;
        }
    }
}
