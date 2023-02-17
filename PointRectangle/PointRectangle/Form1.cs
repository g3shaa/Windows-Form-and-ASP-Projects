using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointRectangle
{
    public partial class Form1 : Form
    {
        private Point point;
        private Rectangle rectangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(txtX1.Text);
            double y1 = Convert.ToDouble(txtY1.Text);
            double x2 = Convert.ToDouble(txtX2.Text);
            double y2 = Convert.ToDouble(txtY2.Text);

            rectangle = new Rectangle(
                new Point((int)Math.Min(x1, x2), (int)Math.Min(y1, y2)),
                new Size((int)Math.Abs(x2 - x1), (int)Math.Abs(y2 - y1))
            );

            point = new Point(
                (int)Convert.ToDouble(txtXPoint.Text),
                (int)Convert.ToDouble(txtYPoint.Text)
            );

            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (rectangle != null && point != null)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.LightGray, rectangle);

                if (rectangle.Contains(point))
                {
                    g.FillEllipse(Brushes.Green, point.X - 5, point.Y - 5, 10, 10);
                    lblResult.BackColor = Color.PaleGreen;
                    lblResult.Text = "Inside";
                }
                else if (rectangle.IntersectsWith(new Rectangle(point, new Size(1, 1))))
                {
                    g.FillEllipse(Brushes.Blue, point.X - 5, point.Y - 5, 10, 10);
                    lblResult.BackColor= Color.LightCoral;
                    lblResult.Text = "Border";
                }
                else
                {
                    g.FillEllipse(Brushes.Red, point.X - 5, point.Y - 5, 10, 10);
                    lblResult.BackColor = Color.Red;
                    lblResult.Text = "Outside";
                }
            }
        }
    }
}
