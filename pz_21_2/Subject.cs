using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21_2
{
    internal class Subject
    {
        public string title;
        public double duration;
        public string control;

        public Subject(string title, double duration, string control)
        {
            this.title = title;
            this.duration = duration;
            this.control = control;
        }

        public Subject(string title, string control)
        {
            this.title =title;
            this.control = "Зачет";
        }

        public Subject(string title, double duration)
        {
            this.title = "Программирование";
            this.duration = duration;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{control} по предмету {title} длится {duration} часа");
        }
    }
}
