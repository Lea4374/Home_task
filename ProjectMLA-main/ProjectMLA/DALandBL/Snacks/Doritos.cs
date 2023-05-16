using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALandBL.Snacks
{
    public class Doritos: finishedProduct
    {
        static int count = 0;
        public Doritos(string name, double price) : base(name,price)
        {
            
        }
        //פונקציה שברגע שמזמינים מעלה את המונה באחד
        public void Counter()
        {
            //void/int?
            count++;
        }
        //דוח
        public virtual string Doch()
        {
            return $"{count}, doritus ";
        }

    }
}
