using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Rectangle
    {
        #region Properties

        public int Width { get; set; }

        public int Height { get; set; }

        #endregion

        #region Constructors

        // A parameterless constructor that sets the width and height to 0.
        public Rectangle()
        {
            Width = default;
            Height = default;
        }



        //A constructor that accepts width and height as integers.

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //A constructor that accepts a single integer and sets both width and height to that value

        public Rectangle(int num)
        {
            Width = Height = num;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Width is : {Width}\nHeight is : {Height}";
        }

        #endregion
    }
}
