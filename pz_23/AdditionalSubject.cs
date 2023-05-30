using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class AdditionalSubject : Subject
    {
        public string _topic;
        public string Topic
        {
            get { return _topic; } 
            set //проверка на ненулевое значение
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Topic cannot be empty.");
                _topic = value;
            }
        }

        // Конструктор с параметрами для названия, темы, типа контроля и продолжительности
        public AdditionalSubject(string title, string topic, EControlTypes control = EControlTypes.TEST, int duration = 0) : base(title, control, duration)
        {
            Topic = topic;
        }

        // Конструктор с параметрами для названия, темы и продолжительности
        public AdditionalSubject(string title, string topic, int duration) : base(title, duration)
        {
            Topic = topic;
        }

        // Переопределение метода для вывода обновленной информации
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Topic: {Topic}");
        }
    }

}
}
}
