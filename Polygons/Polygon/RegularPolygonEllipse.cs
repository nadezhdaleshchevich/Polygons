using System;
using System.Drawing;

namespace Polygons.Polygon
{
    /// <summary>
    /// Класс RegularPolygonEllipse описывает n-угольник, который вписан в эллипс с заданными шириной и высотой.
    /// Является наследником класса GeneratedPolygon.
    /// </summary>
    class RegularPolygonEllipse : GeneratedPolygon
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public RegularPolygonEllipse()
        {
        }

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="n">Количество сторон n-угольника.</param>
        /// <param name="angle_start">Начальный угол генерации.</param>
        /// <param name="clockwise">Направление генерации.</param>
        public RegularPolygonEllipse(int n, double angle_start = 0, bool clockwise = false) : base(n, angle_start, clockwise)
        {
        }        

        int a = 0;  // Половина ширины.
        public int Width
        {
            get
            {
                return a * 2;
            }
            set
            {
                if (value < 0)  // Если значение меньше 0, то половина ширина равна 0.
                    a = 0;
                else    // Иначе половина ширины равна значение / 2;
                    a = value;
                Points = CreatePolygon();
            }
        }

        int b = 0;  // Половина высоты.
        public int Height
        {
            get
            {
                return b * 2;
            }
            set
            {
                if (value < 0)  // Если значение меньше 0, то половина высоты равна 0.
                    b = 0;
                else    // Иначе половина высоты равна значение / 2;
                    b = value;
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
            int x = (int)(Math.Cos(z / 180 * Math.PI) * a);     // Расчет координаты x.
            int y = (int)(Math.Sin(z / 180 * Math.PI) * b);     // Расчет координаты y.
            return new Point(x, y);     // Возврат точки.
        }
    }
}
