using System.Buffers;

Console.SetCursorPosition(7, 2);
Console.WriteLine("Mi reloj digital");

int hours, minutes, seconds;
DateTime now = DateTime.Now;

hours = now.Hour;

while (true)
{
        for (minutes = now.Minute; minutes < 60; minutes++)
        {
            for (seconds = now.Second; seconds < 60; seconds++)
            {
                Console.SetCursorPosition(10, 4);
                Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");
                Thread.Sleep(1000);
            }
        }
    hours++;

    if (hours >= 24) hours = 0;
}

/*for (hours = now.Hour; hours < 24; hours++)
{
    for(minutes = now.Minute; minutes < 60; minutes++) 
    {
        for (seconds = now.Second; seconds < 60; seconds++) 
        {
           Console.SetCursorPosition(10, 4);
           Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");
           Thread.Sleep(1000);
        }
    }  
      
}*/