using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DALandBL
{
    public class Meditor
    {
        Dictionary<JunkFood,int> d=new Dictionary<JunkFood, int>();
        string s = " ";
        public void M(JunkFood j)
        {
           var e= d.ToList().Where(x => (x.Key.Name).CompareTo( j.Name)==0).FirstOrDefault();

        }
        public void Me()
        {
            d.ToList().ForEach(x =>
            {
                //s += x.Key.GetType().GetProperties().ToList().Where(y => y.GetMethod?.Name.CompareTo("Doch") == 0).First();
               
                s += x.Key.Name;
                //קריאה לפונקציה s+=x.Key
            });
        }
    }
}
