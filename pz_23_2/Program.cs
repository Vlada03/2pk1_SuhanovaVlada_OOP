namespace pz_23_2
{
    internal class Program
    {
        private static EControlTypes getRandomType(Random rnd)
        {
            switch (rnd.Next(0, 2))
            {
                case 0:
                    return EControlTypes.EXAM;
                case 1:
                    return EControlTypes.TEST;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            AdditionalSubject addSub1 = new AdditionalSubject("Математика", "Векторы", getRandomType(rnd), rnd.Next(30, 161));
            addSub1.PrintInfo();

            AdditionalSubject addSub2 = new AdditionalSubject("История", "Вторая мировая война", EControlTypes.TEST, 90);
            addSub2.PrintInfo();

            AdditionalSubject addSub3 = new AdditionalSubject("Литература", "Пушкин А. С.", 60);
            addSub3.PrintInfo();
        }
    }
}