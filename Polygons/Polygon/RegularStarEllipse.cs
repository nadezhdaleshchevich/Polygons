using System;
using System.Drawing;

namespace Polygons.Polygon
{
    /// <summary>
    /// Класс RegularStarEllipse описывает правильную n-конечную звезду, 
    /// которая вписана в эллипс с заданными шириной и высотой.
    /// Является наследником класса RegularPolygonEllipse.
    /// </summary>
    class RegularStarEllipse : RegularPolygonEllipse
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public RegularStarEllipse()
        {
        }

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="n">Количество вершин n-конечной звезды.</param>
        /// <param name="angle_start">Начальный угол генерации.</param>
        /// <param name="clockwise">Направление генерации.</param>
        public RegularStarEllipse(int n, double angle_start = 0, bool clockwise = false) : base(2 * n, angle_start, clockwise)
        {
        }

        /// <summary>
        /// Метод, который возвращает координату n-ой точки n-конечной звезды.
        /// Является абстрактным методом.
        /// </summary>
        /// <param name="z"> Угол поворота.</param>
        /// <param name="number"> Номер точки n-угольника.</param>
        /// <returns>n-ая точка n-угольника.</returns>
        protected override Point CreatePoint(double z, int number)
        {
            double a;   // Половина ширины.
            double b;   // Половина высоты.
            if (number % 2 == 0)
            {
                a = Width / 2;
                b = Height / 2;
            }
            else    // Если номер точки нечетный, то разделить ширину и высоту на два.
            {
                a = Width / 4;
                b = Height / 4;
            }               
            int x = (int)(Math.Cos(z / 180 * Math.PI) * a);     // Расчет координаты x.
            int y = (int)(Math.Sin(z / 180 * Math.PI) * b);     // Расчет координаты y.
            return new Point(x, y);     // Возврат точки.
        }
    }
}
