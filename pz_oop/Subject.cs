using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21_1
{
    internal class Subject
    {
        private string _title = "";
        private double _duration = 1.5;
        private string _control = "Экзамен";
        private string _name = "Преподаватель неизвестен";

        public Subject(string title, double duration, string control)
        {
            _title = title;
            _duration = duration;
            _control = control;
        }

        public Subject(string title, string control)
        {
            _title = title;
            _control = control;
        }

        public Subject(string title, double duration)
        {
            _title = title;
            _duration = duration;
        }

        public Subject(string title, double duration, string control, string name)
        {
            _title = title;
            _duration = duration;
            _control = control;
            _name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название предмета: {_title}\nПродолжительность: {_duration} часа\n{_control}\n");
        }
    }
}
