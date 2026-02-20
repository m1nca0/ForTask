//13 Дана последовательность вещественных чисел. Найти количество вещественных чисел, которые больше своих “соседей”, т. е. предшествующего и последующего
namespace ForTask
{
    public class Logic
    {
        public static List<float> FindBiggest(int length, float[] floatMassive)
        {
            var countFloat = new List<float>();

            for (int i = 1; i < length - 1; i++)
            {
                if (floatMassive[i] > floatMassive[i - 1] && floatMassive[i] > floatMassive[i + 1])
                {
                    countFloat.Add(floatMassive[i]);
                }
            }
            return countFloat;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов последовательности: ");
            int length = int.Parse(Console.ReadLine());
            float[] floatMassive = new float[length];
            for (int i = 0; i < length; i++) { 
                Console.WriteLine("floatMassive[" + (i + 1) + "] = ");
                floatMassive[i] = float.Parse(Console.ReadLine());
            }

            var countFloat = Logic.FindBiggest(length, floatMassive);

            Console.WriteLine("Количество элементов больше соседей: " + countFloat.Count());
            Console.WriteLine("Элементы больше соседей");
            for (int i = 0; i < countFloat.Count; i++) {
                Console.WriteLine(countFloat[i]);
            }
        }   
    }
}
