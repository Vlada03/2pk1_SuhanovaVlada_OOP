using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23_2
{
    public class AdditionalSubject : Subject
    {
        public new virtual object Clone()
        {
            return new AdditionalSubject(Title, Topic, Control, Duration);
        }

        private string _topic;
        public string Topic
        {
            get => _topic;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Поле с темой не должно быть пустым.");
                _topic = value;
            }
        }

        public AdditionalSubject(string title, string topic, EControlTypes control = EControlTypes.TEST, int duration = 0) : base(title, control, duration)
        {
            Topic = topic;
        }

        public AdditionalSubject(string title, string topic, int duration) : base(title, duration)
        {
            Topic = topic;
        }

        public override void PrintInfo() //новая обновленная информация
        {
            base.PrintInfo();
            Console.WriteLine($"Тема: {Topic}");
        }
    }
}
