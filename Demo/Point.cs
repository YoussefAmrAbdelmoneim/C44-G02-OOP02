using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        #region Attributes

        public int x;
        public int y;

        #endregion

        #region Constructors
        /// Is A Special Function 
        ///    1. Named As Struct
        ///    2. Has No Return Type 

        #region Constructor Overloading 
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            x = default;
            y = default;
        }

        public Point(int number)
        {
            x = y = number;
        }
        #endregion

        public override string ToString()
        {
            return $"({x} , {y})";
        }
        #endregion

    }
}
