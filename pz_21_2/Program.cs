namespace pz_21_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject("ЭВМ", 2, "Экзамен");
            Subject sub2 = new Subject("", 1.5, "Экзамен");
            Subject sub3 = new Subject("Музыкальное искусство", "");
            Subject sub4 = new Subject("Физ-ра", 2.5, "Зачет");

            sub1.PrintInfo();
            sub2.PrintInfo();
            sub3.PrintInfo();
            sub4.PrintInfo();
        }
    }
}