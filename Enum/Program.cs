
class Program
{
    static void Main()
    {
        Symbol result = Symbol.e;
      
  
        int b = 4;
        int R = (int)(b + result); 
       // Console.WriteLine(R);   

        DaysOfWeek day = DaysOfWeek.Monday;
        if (day == DaysOfWeek.Monday) 
        { 
        }
        // Console.WriteLine("Началась рабочая неделя!");

        DayTime now = DayTime.Evening;
        void PrintMessage(DayTime dayTime)
        {
            switch (dayTime)
            {
                case DayTime.Morning:
                    Console.WriteLine("Доброе утро");
                    break;
                case DayTime.Afternoon:
                    Console.WriteLine("Добрый день");
                    break;
                case DayTime.Evening:
                    Console.WriteLine("Добрый вечер");
                    break;
                case DayTime.Night:
                    Console.WriteLine("Доброй ночи");
                    break;
            }
        }

        PrintMessage(now);                   // Добрый вечер
        PrintMessage(DayTime.Afternoon);    // Добрый день
        PrintMessage(DayTime.Night);
    }

    enum Symbol
    { 
        a = 6,
        b,
        c,
        d,
        e
     }

    enum DaysOfWeek
    {
        Monday,
        Tuesday,   
        Wednesday, 
        Friday    
    }



   
    enum DayTime
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
}