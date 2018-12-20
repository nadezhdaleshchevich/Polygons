using System.Collections.Generic;
using System.Drawing;

namespace Polygons.Polygon
{
    /// <summary>
    /// Класс GeneratedPolygon является наследником класса Polygon. 
    /// Данный класс описывает n-угольник, который генерируется исходя из заданных параметров. 
    /// Класс является абстрактным.
    /// </summary>
    abstract class GeneratedPolygon : Polygon
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public GeneratedPolygon()
        {
        }

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="n">Количество сторон n-угольника.</param>
        /// <param name="angle_start">Начальный угол генерации.</param>
        /// <param name="clockwise">Направление генерации.</param>
        public GeneratedPolygon(int n, double angle_start = 0, bool clockwise = false)
        {
            this.N = n;
            this.AngleStart = angle_start;
            this.clockwise = clockwise;
        }       

        int n = 2;  // Количество сторон n-угольника.
        public int N
        {
            set
            {
                if (value < 2)  // Если значение меньше 2, то количество сторон равно 2.
                    n = 2;
                else if (value > 360)   // Если значение больше 360, то количество сторон равно 360.
                    n = 360;
                else           // Иначе установить количество сторон равное значению.
                    n = value;
                Points = CreatePolygon();   // Создание n-угольника.
            }
        }        

        double angle_start = 0;    // Стартовый угол генерации точек n-угольника.
        public double AngleStart
        {
            get
            {
                return angle_start;
            }
            set
            {
                if (n % 2 == 0) // Если количество сторон четное, то стартовый угол равен 180 / количество сторон.
                    angle_start = 180 / n;
                else   // Иначе стартовый угол равен 90 градусов.
                    angle_start = 90;
                angle_start += value;             // Увеличение стартового угла на значение.
                angle_start = angle_start % 360;  // Корректировка стартового угла.     
                Points = CreatePolygon();   // Создание n-угольника.
            }
        }

        bool clockwise = false;     // Направление генерации точек n-угольника: 
                                    // true - по часовой стрелке,  false - против часовой стрелки.
        public bool Clockwise
        {
            get
            {
                return clockwise;
            }
            set
            {
                clockwise = value;
                Points = CreatePolygon();   // Создание n-угольника.
            }
        }

        Point center = new Point();     // Центр n-угольника.
        public Point Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
                Points = CreatePolygon();   // Создание n-угольника.
            }
        }

        /// <summary>
        /// Метод создания списка точек n-угольника.
        /// </summary>
        /// <returns>Список точек n-угольника</returns>
        protected List<Point> CreatePolygon()
        {
            List<Point> points = new List<Point>(); // Объявление нового списка точек n-угольника.
            double angle = 360 / n;     // Расчет центрального угла n-угольника.
            double z = angle_start;     // Угол поворота, изначально равен стартовому углу.

            for (int i = 0; i < n; ++i)
            {
                Point point = CreatePoint(z, i);   // Создание n-ой точки n-угольника.
                point.X = center.X + point.X;   // Коррекция координаты оси x относительно центра.
                point.Y = center.Y - point.Y;   // Коррекция координаты оси y относительно центра.
                points.Add(point);
                z += angle * (clockwise ? -1 : 1);
            }
            return points;
        }

        /// <summary>
        /// Метод, который возвращает координату n-ой точки n-угольника.
        /// Является абстрактным методом.
        /// </summary>
        /// <param name="z"> Угол поворота.</param>
        /// <param name="number"> Номер точки n-угольника.</param>
        /// <returns>n-ая точка n-угольника.</returns>
        protected abstract Point CreatePoint(double z, int number);
    }
}
