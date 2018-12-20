using System.Collections.Generic;
using System.Drawing;

namespace Polygons.Polygon
{
    /// <summary>
    /// Класс Polygon описывает произвольный многоугольник. 
    /// Является абстрактным классом.
    /// Многоугольник представляет собой список точек
    /// </summary>
    public abstract class Polygon
    {        
        Color color_contour = Color.Black;  // цвет контура
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
                
        Color color_fill = Color.Yellow;    // цвет заливки
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
                
        Color color_background = Color.White;   // цвет фона
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
        
        List<Point> points = new List<Point>(); // список точек многоугольника
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

        public int N
        {
            get
            {
                return Points.Count;
            }
        }

        /// <summary>
        /// Метод, который рисует контур многоугольника заданным цветом
        /// </summary>
        /// <param name="g">Поверхность рисования GDI+</param>
        /// <param name="color">Цвет контура</param>
        protected virtual void Draw(Graphics g, Color color)
        {
            // проверка списка точек многоугольника на корректность
            if (points == null) return;
            if (points.Count == 0) return;
            Pen pen = new Pen(color);               // создание ручки
            g.DrawPolygon(pen, points.ToArray());   // рисование контура многоугольника
            pen.Dispose();
        }

        /// <summary>
        /// Метод, который рисует закрашенный многоугольник заданным цветом
        /// </summary>
        /// <param name="g">Поверхность рисования GDI+</param>
        /// <param name="color">цвет заливки</param>
        protected virtual void DrawFill(Graphics g, Color color)
        {
            // проверка списка точек многоугольника на корректность
            if (points == null) return;
            if (points.Count == 0) return;
            SolidBrush brush = new SolidBrush(color);   // создание кисти
            g.FillPolygon(brush, points.ToArray());     // рисование заливки многоугольника
            brush.Dispose();
        }

        /// <summary>
        /// Метод, который рисует контур многоугольника цветом контура
        /// </summary>
        /// <param name="g">Поверхность рисования GDI+</param>
        public void Draw(Graphics g)
        {
            Draw(g, color_contour); // рисование контура
        }

        /// <summary>
        /// Метод, который рисует:
        /// 1. закрашенный многоугольник цветом заливки,  
        /// 2. контур многоугольника цветом контура.
        /// /// </summary>
        /// <param name="g">Поверхность рисования GDI+</param>
        public void DrawFill(Graphics g)
        {
            DrawFill(g, color_fill);    // рисование заливки
            Draw(g, color_contour);     // рисование контура
        }

        /// <summary>
        /// Метод, который рисует контур многоугольника цветом фона
        /// </summary>
        /// <param name="g">Поверхность рисования GDI+</param>
        public void WipeContour(Graphics g)
        {
            Draw(g, color_background);  // рисование контура цветом фона
        }

        /// <summary>
        /// Метод, который рисует:
        /// 1. закрашенный многоугольник цветом фона,  
        /// 2. контур многоугольника цветом заливки.
        /// /// </summary>
        /// <param name="g">Поверхность рисования GDI+</param>
        public void WipeFill(Graphics g)
        {
            DrawFill(g, color_background);  // рисование заливки цветом фона
            Draw(g, color_background);      // рисование контура цветом фона
        }
    }
}