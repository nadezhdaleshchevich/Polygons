using System;
using System.Drawing;

namespace Polygons.Polygon
{
    /// <summary>
    /// Класс RegularPolygon описывает правильный n-угольник, который вписан в круг с заданным радиусом r.
    /// Является наследником класса GeneratedPolygon.
    /// </summary>
    class RegularPolygon : GeneratedPolygon
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public RegularPolygon()
        {
        }

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="n">Количество сторон n-угольника.</param>
        /// <param name="angle_start">Начальный угол генерации.</param>
        /// <param name="clockwise">Направление генерации.</param>
        public RegularPolygon(int n, double angle_start = 0, bool clockwise = false) : base(n, angle_start, clockwise)
        {            
        }        

        int r = 0;  // Радиус описанного круга.
        public int R
        {
            get
            {
                return r;
            }
            set
            {
                if (value < 0)  // Если значение меньше 0, то радиус равен 0.
                    r = 0;
                else    // Иначе радиус равен значению.
                    r = value;
                Points = CreatePolygon();
            }
        }

        /// <summary>
        /// Метод, который возвращает координату n-ой точки n-угольника.
        /// Является абстрактным методом.
        /// </summary>
        /// <param name="z"> Угол поворота.</param>
        /// <param name="number"> Номер точки n-угольника.</param>
        /// <returns>n-ая точка n-угольника.</returns>
        protected override Point CreatePoint(double z, int number)
        {
            int x = (int)(Math.Cos(z / 180 * Math.PI) * r);     // Расчет координаты x.
            int y = (int)(Math.Sin(z / 180 * Math.PI) * r);     // Расчет координаты y.
            return new Point(x, y);     // Возврат точки.
        }
    }
}