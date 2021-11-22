using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preizpolzvane_na_klasove
{
    public class RandomList : ArrayList
    {
        private Random rnd;
        public object RandomString(ArrayList data)
        {
            int element = rnd.Next(0, data.Count - 1);
            string str = data[element];
            data.Remove(str);
            return str;
        }
    }

}
