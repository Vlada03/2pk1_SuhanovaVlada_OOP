using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23_2
{

    // Перечисление
    public enum EControlTypes : int
    {
        EXAM = 0,
        TEST
    };
    public class Subject : ICloneable
    {
        public Object Clone()
        {
            Subject subject = new Subject(Title, Control, Duration);
            return subject;
        }
        public string Title { get; set; }
        public int Duration { get; set; }
        public EControlTypes Control { get; set; }

        public static int Exam { get; set; }
        public static int Test { get; set; }

        public static int exam = 0;
        public static int test = 0;

        public Subject(string title, EControlTypes control = EControlTypes.TEST, int duration = 0)
        {
            Title = title;
            Duration = duration;
            Control = control;
            if (control == EControlTypes.EXAM) exam++;
            else test++;
        }

        public Subject(string title, int duration)
        {
            Title = title;
            Duration = duration;
            Control = EControlTypes.EXAM;
            if (Control == EControlTypes.EXAM) exam++;
            else test++;
        }

        public virtual void PrintInfo()
        {
            string controlType = "";
            switch (Control)
            {
                case EControlTypes.EXAM:
                    controlType = "Экзамен";
                    break;
                case EControlTypes.TEST:
                    controlType = "Зачёт";
                    break;
            }

            Console.WriteLine($"Итоговая форма оценивания знаний: {controlType}\nПредмет: {Title}\nКол-во часов: {Duration}\nКол-во экзаменов: {exam}\nКол-во зачетов: {test}");
        }
    }
}

