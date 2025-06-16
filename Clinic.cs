namespace My.Home.Work;

public class Clinic
{
    public const int MINETS_PER_PERSON = 10;
    public const int MINETS_PER_HOUR = 60;
    
    public void PrintClinic()
    {
        Console.WriteLine($"Введите количество старушек: ");
        int numberOfPeople = int.Parse(Console.ReadLine());

        int totalMinutes = numberOfPeople * MINETS_PER_PERSON;
        int hours = totalMinutes / MINETS_PER_HOUR;
        int minutes = totalMinutes % MINETS_PER_HOUR;
        
        string output = $"Вы должны отстоять в очереди {hours} час";

        if (hours >= 2 && hours <= 4)
        {
            output += "a";
        }
        else if (hours >= 5 || hours == 0)
        {
            output += "oв";
        }
        output += $" и {minutes} минут";
        
        Console.WriteLine(output);
        
    }

}