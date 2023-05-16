using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL
{
    public class JunkFood
    {
        string name;
        double price;
        public JunkFood(string _name,double _price)
        {
            this.name = _name;
            this.price = _price;
         }
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual string Doch()
        {
            return " ";
        }
    }
}
