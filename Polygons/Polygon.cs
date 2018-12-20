using System;
using System.Collections.Generic;
using System.Drawing;

namespace Polygons.Polygon
{
    public abstract class Polygon
    {
        Color color_contour = Color.Black;
        public virtual Color ColorContour
        {
            get
            {
                return color_contour;
            }
            set
            {
                color_contour = value;
            }
        }

        Color color_fill = Color.Yellow;
        public virtual Color ColorFill
        {
            get
            {
                return color_fill;
            }
            set
            {
                color_fill = value;
            }
        }

        Color color_background = Color.White;
        public virtual Color ColorBackground
        {
            get
            {
                return color_background;
            }
            set
            {
                color_background = value;
            }
        }

        List<Point> points = new List<Point>();
        public List<Point> Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }

        protected virtual void Draw(Graphics g, Color color)
        {
            if (points == null) return;
            if (points.Count == 0) return;
            Pen pen = new Pen(color);
            g.DrawPolygon(pen, points.ToArray());
            pen.Dispose();
        }

        protected virtual void DrawFill(Graphics g, Color color)
        {
            if (points == null) return;
            if (points.Count == 0) return;
            SolidBrush brush = new SolidBrush(color);
            g.FillPolygon(brush, points.ToArray());
            brush.Dispose();
        }

        public void Draw(Graphics g)
        {
            Draw(g, color_contour);
        }       

        public void DrawFill(Graphics g)
        {
            DrawFill(g, color_fill);
            Draw(g, color_contour);
        }

        public void WipeContour(Graphics g)
        {
            Draw(g, color_background);
        }

        public void WipeFill(Graphics g)
        {
            DrawFill(g, color_background);
            Draw(g, color_background);
        }
    }
}