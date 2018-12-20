using System;
using System.Drawing;

namespace Polygons.Polygon
{
    /// <summary>
    /// Класс RegularStar описывает правильную n-конечную звезду, которая вписана в круг с заданным радиусом r.
    /// Является наследником класса RegularPolygon.
    /// </summary>
    class RegularStar : RegularPolygon
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public RegularStar()
        {
        }

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="n">Количество вершин n-конечной звезды.</param>
        /// <param name="angle_start">Начальный угол генерации.</param>
        /// <param name="clockwise">Направление генерации.</param>
        public RegularStar(int n, double angle_start = 0, bool clockwise = false) : base(2 * n, angle_start, clockwise)
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
            double r;
            if (number % 2 == 0) 
                r = R;
            else    // Если номер точки нечетный, то радиус делить на два
                r = R / 2;
            int x = (int)(Math.Cos(z / 180 * Math.PI) * r);     // Расчет координаты x.
            int y = (int)(Math.Sin(z / 180 * Math.PI) * r);     // Расчет координаты y.
            return new Point(x, y);     // Возврат точки.
        }        
    }
}