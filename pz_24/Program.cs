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

            Subject subject1 = new Subject("Математика", getRandomType(rnd), rnd.Next(30, 161));
            Subject subjectClone = (Subject)subject1.Clone();

            AdditionalSubject addSub1 = new AdditionalSubject("История", "Внешю политика СССР в 90-х годах", EControlTypes.TEST, rnd.Next(30, 161));
            AdditionalSubject addSubClone = (AdditionalSubject)addSub1.Clone();

            subject1.PrintInfo();
            subjectClone.PrintInfo();

            addSub1.PrintInfo();
            addSubClone.PrintInfo();



            
            
            /*AdditionalSubject addSub_1 = new AdditionalSubject("Математика", "Векторы", getRandomType(rnd), rnd.Next(30, 161));
            addSub_1.PrintInfo();

            Subject addSub1_Clone = new (Subject)addSub_1.Clone();

            AdditionalSubject addSub2 = new AdditionalSubject("История", "Вторая мировая война", EControlTypes.TEST, 90);
            addSub2.PrintInfo();

            AdditionalSubject addSub3 = new AdditionalSubject("Литература", "Пушкин А. С.", 60);
            addSub3.PrintInfo();*/
        }
    }
}