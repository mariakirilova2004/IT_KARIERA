using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class AttackedKingEventArgs:EventArgs
    {
        private string kingName;

        public string KingName
        {
            get { return kingName; }
            set { kingName = value; }
        }
        public AttackedKingEventArgs(string kingName)
        {
            KingName = kingName;
        }
    }
}
