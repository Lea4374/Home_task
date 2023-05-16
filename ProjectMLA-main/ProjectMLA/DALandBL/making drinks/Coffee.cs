using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.making_drinks
{
    internal class Coffee : UnfinishedProduct
    {
        public Coffee(string _name, double _price) : base(_name, _price)
        {
        }
    }
}
