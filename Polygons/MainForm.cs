using System;
using System.Drawing;
using System.Windows.Forms;
using Polygons.Polygon;

namespace Polygons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            x_text.Text = "" + 100;
            y_text.Text = "" + 100;
            width_text.Text = "" + 100;
            height_text.Text = "" + 100;
            n_text.Text = "" + 5;
            comboBox1.SelectedIndex = 0;

        }

        private void button_paint_polygon_Click(object sender, EventArgs e)
        {
            int x = int.Parse(x_text.Text);
            int y = int.Parse(y_text.Text);
            int w = int.Parse(width_text.Text);
            int h = int.Parse(height_text.Text);
            int n = int.Parse(n_text.Text);

            Polygon.Polygon polygon = null;
                    
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    RegularPolygon regular_polygon = new RegularPolygon(n);
                    regular_polygon.Center = new Point(x, y);
                    regular_polygon.R = w / 2;
                    polygon = regular_polygon;
                    break;
                case 1:
                    RegularPolygonEllipse convex_polygon = new RegularPolygonEllipse(n);
                    convex_polygon.Center = new Point(x, y);
                    convex_polygon.Width = w;
                    convex_polygon.Height = h;
                    polygon = convex_polygon;
                    break;
                case 2:
                    RegularStar star_polygon = new RegularStar(n);
                    star_polygon.Center = new Point(x, y);
                    star_polygon.R = w / 2;
                    polygon = star_polygon;
                    break;
                case 3:
                    RegularStarEllipse ellipse_star_polygon = new RegularStarEllipse(n);
                    ellipse_star_polygon.Center = new Point(x, y);
                    ellipse_star_polygon.Width = w;
                    ellipse_star_polygon.Height = h;
                    polygon = ellipse_star_polygon;
                    break;
                default:
                    return;
            }

            Graphics g = pictureBox1.CreateGraphics();
            
            if (checkBox1.Checked)
            {
                polygon.DrawFill(g);
            }
            else
            {
                polygon.Draw(g);
            }

            g.Dispose();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x_text.Text = "" + e.X;
                y_text.Text = "" + e.Y;
            }
        }
    }
}
