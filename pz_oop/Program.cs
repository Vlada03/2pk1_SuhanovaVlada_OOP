using pz_21;
using System.Reflection;

namespace pz_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new("Математика", 2, "Зачет", "Зеленина С. В.");
            Subject sub2 = new("Менеджмент", 1.5, "Экзамен");
            Subject sub3 = new("Архитектура аппаратных средств", "Экзамен");
            Subject sub4 = new("МДК", 1.5);
            sub.PrintInfo();
            sub2.PrintInfo();
            sub3.PrintInfo();
            sub4.PrintInfo();
        }
    }
}