namespace Zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //da se vavede n v droq na elementite da se vyvedyt vsichki elementi v masiva
            //da se otpechati sumata ot vsichki elementi
            //sumata na vsichki elementi
            //nai golemiqt element na masiva i na koe mqsto e



            Console.Write("Vavedi broi na elementite: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i <= numbers.Length - 1; i++) 
            {
                Console.Write($"num[{i}] = ");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            long sum = 0l;
            for (int i =0; i <= numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Sum = {sum}");


            int min = int.MaxValue;
            byte minPos = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] < min) 
                {
                    min = numbers[i];
                    minPos = i;
                }
                
            }
            Console.WriteLine($"num [{i}]  = {numbers[i]}");
        }
    }
}
