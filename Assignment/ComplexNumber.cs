using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ComplexNumber
    {

        #region Properties

        public int Real { get; set; }

        public int Img { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Number = {Real} + {Img}i";
        }

        #endregion

        #region Opertaors Overloading

        public static ComplexNumber operator + (ComplexNumber left, ComplexNumber right)
        {

            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0)
            };

        }

        public static ComplexNumber operator - (ComplexNumber left, ComplexNumber right)
        {

            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) -( right?.Img ?? 0)
            };

        }

        #endregion
    }
}
