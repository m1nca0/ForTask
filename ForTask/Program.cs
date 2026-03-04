//13 Дана последовательность вещественных чисел. Найти количество вещественных чисел, которые больше своих “соседей”, т. е. предшествующего и последующего
namespace ForTask
{
    public class Logic
    {
        public static List<double> CreateArrayNeighbors(int length, double[] doubleMassive)
        {
            var countdouble = new List<double>();

            for (int i = 1; i < length - 1; i++)
            {
                if (doubleMassive[i] > doubleMassive[i - 1] && doubleMassive[i] > doubleMassive[i + 1])
                {
                    countdouble.Add(doubleMassive[i]);
                }
            }
            return countdouble;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов последовательности: ");
            int length = int.Parse(Console.ReadLine());
            double[] doubleMassive = new double[length];
            for (int i = 0; i < length; i++) { 
                Console.WriteLine("doubleMassive[" + (i + 1) + "] = ");
                doubleMassive[i] = double.Parse(Console.ReadLine());
            }

            var countdouble = Logic.CreateArrayNeighbors(length, doubleMassive);

            Console.WriteLine("Количество элементов больше соседей: " + countdouble.Count());
            Console.WriteLine("Элементы больше соседей");
            for (int i = 0; i < countdouble.Count; i++) {
                Console.WriteLine(countdouble[i]);
            }
        }   
    }
}
