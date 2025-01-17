using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class DerivedClass1: BaseClass
    {
        #region Methods

        public override void DisplayMessage()
        {
            Console.WriteLine("This is DerivedClass1");
        }

        #endregion
    }
}
