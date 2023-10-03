namespace Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Ф.И.О.";
            int age = 20;
            string eMail = "Эл. Почта";
            float progPoints = 3.7f;
            float mathPoints = 4f;
            float physPoints = 4.5f;

            string pattern = "Ф.И.О.: {0} \nВозраст: {1} \nЭл. почка: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

            Console.WriteLine(pattern, fullName, age, eMail, progPoints, mathPoints, physPoints);
            Console.ReadKey();

            float sumPoints = progPoints + mathPoints + physPoints;
            float averagePoints = sumPoints / 3;
            string averagePointsFormated = averagePoints.ToString("#.###");

            string newPattern = "\nСумма баллов: {0} \nСреднее Арифметическое: {1}";

            Console.WriteLine(newPattern, sumPoints, averagePointsFormated);
            Console.ReadKey();

        }
    }
}