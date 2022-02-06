using be_on_time_exam.Models;
using be_on_time_exam.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_on_time_exam.Controllers
{
    public class TimeActionController
    {
        private Display display;
        private Time time;

        public TimeActionController()
        {
            display = new Display();
            time = new Time(display.hourEx, display.minEx, display.hourAr, display.minAr);
            display.Rez = time.CheckIfOnTime();
            display.GetRez();
        }
    }
}
