using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_on_time_exam.Models
{
    public class Time
    {
        public Time(int hourExam, int minExam, int hourArive, int minArive)
        {
            this.hourExam = hourExam;
            MinExam = minExam;
            this.hourArive = hourArive;
            MinArive = minArive;
        }

        public int hourExam { get; set; }
        public int MinExam { get; set; }
        public int hourArive { get; set; }
        public int MinArive { get; set; }

        public string CheckIfOnTime()
        {
            int minsExam = hourExam * 60 + MinExam;
            int minsArive = hourArive * 60 + MinArive;
            int hour = Math.Abs(minsExam - minsArive) / 60;
            int min = Math.Abs(minsExam - minsArive) % 60;
            if (minsExam - minsArive >= 60)
            {
                return $"Early\n{hour}:{min:00} hours before the start";           
            }
            if (minsExam - minsArive < 60 && minsExam - minsArive > 30)
            {
                return $"Early\n{min:00} minutes before the start";
            }
            if (minsExam - minsArive >= 0 && minsExam - minsArive <= 30)
            {
                return $"On time";
            }
            if (minsExam - minsArive > -60 && minsExam - minsArive < 0)
            {
                return $"Late\n{min:00} minutes after the start";                
            }
            if (minsExam - minsArive <= -60)
            {
                return $"Late\n{hour}:{min:00} hours after the start";
            }
            return "...";
        }
    }
}
