using System;
using System.Drawing;

namespace ShapeDiller
{
    class Shape
    {
        #region ATTRIBUTES

        /* Цвет оконтовки */
        private Enum Color { get; set; }
        /* Цвет заливки */
        private Enum FillColor { get; set; }
        /* Координата X (центр) */
        private int X { get; set; }
        /* Координата Y (центр) */
        private int Y { get; set; }
        /* Длина фигуры */
        private int Width { get; set; }
        /* Высота фигуры */
        private int Height { get; set; }

        #endregion
        
        /**
         * 
         * */
        public Shape()
        {

        }

        
    }
}
