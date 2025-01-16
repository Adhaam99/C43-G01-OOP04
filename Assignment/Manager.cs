using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Manager : Employee
    {

        #region Methods

        public override void Work()
        {
            Console.WriteLine("Manager is managing");
        }

        #endregion

    }
}
