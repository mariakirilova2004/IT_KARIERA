using MagicNumbers.Models;
using MagicNumbers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Controllers
{
    public class MagicNumActionController
    {
        private Display display;
        private MagicNum magicNum;
        public MagicNumActionController()
        {
            display = new Display();
            magicNum = new MagicNum(display.MagicNum);
            display.MagicNums = magicNum.GenerateNums();
            display.GetRez();
        }
    }
}
