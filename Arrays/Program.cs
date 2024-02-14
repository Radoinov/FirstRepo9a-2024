using System.Threading.Channels;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dekalriram masiv ot 13 elementa
            double[] grades = new double[13];
            string[] names = new string[13] { "Lybo",
            "Milen", "Mihail", "Radoslav", "Svetlomir", "Siana", "Silvia", "Shtako", "Tedo",
            "Hristian", "Hristomir", "Cvetelina", "Cvetina"} ;
            //vyvejdat se elementite ot klaviaturata - cikyl
            for (int i = 0; i < grades.Length; i++) 
            {
                Console.Write($"{i + 14}. {names[i]} =====>> ");
                grades[i] = double.Parse(Console.ReadLine());
            }
            // obrabotka 
            grades[9] = 6;
            names[8] = "Teodor";
            grades[1] = Math.Ceiling(5.234);
            
            grades[7] = 5;
            // otpechatvane na resultatite
            for (int i = 0;i < names.Length;i++)
            {
                Console.WriteLine($"{i + 13}. {grades[i]}");
            }
        }
    }
}
