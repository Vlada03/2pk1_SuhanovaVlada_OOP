

namespace pz_22_2
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

            Subject sub1 = new Subject("ЭВМ", getRandomType(rnd), rnd.Next(30, 161));
            sub1.PrintInfo();
            Subject sub2 = new Subject("МДК 22.8", getRandomType(rnd));
            sub2.PrintInfo();
            Subject sub3 = new Subject("Музыкальное искусство");
            sub3.PrintInfo();
            Subject sub4 = new Subject("Физ-ра", rnd.Next(30, 161));
            sub4.PrintInfo();


            
        }
    }
}