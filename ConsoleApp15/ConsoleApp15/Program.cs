using System;

 namespace  TimeOfLife
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
          
            Console.WriteLine("Введіть дату свого народження у форматі ДД.ММ.РРРР");
            if (DateTime.TryParse((Console.ReadLine()), out DateTime birthDay))
            {
                TimeSpan dateResult = date.Subtract(birthDay);
              
                if (birthDay > date)
                { 
                    Console.WriteLine("Ви ще не народились:)");
                    return;
                }
                Console.WriteLine($"Вам {dateResult.Days / 365} повних років.");
                Console.WriteLine($"Ви прожили днів - {dateResult.Days}, місяців - {Math.Round( dateResult.Days / 30.4375)}.");

                if ((dateResult.Days / 365) < 18)
                { Console.WriteLine("Ви неповнолітній."); }

                else { Console.WriteLine("Ви досягли повноліття "+birthDay.AddYears(18).ToString("dd/MM/yyyy")); }
            } 
            else { Console.WriteLine("Error!!!");
            return; }  
        }
    }
}
