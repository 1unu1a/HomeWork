namespace My.Home.Work;

public class Clinic
{
    const int MinutesPerPerson = 10;
    const int MinutesPerHour = 60;
    
    public void PrintClinic()
    {
        Console.WriteLine($"Введите количество старушек: ");
        int numberOfPeople = int.Parse(Console.ReadLine());

        int totalMinutes = numberOfPeople * MinutesPerPerson;
        int hours = totalMinutes / MinutesPerHour;
        int minutes = totalMinutes % MinutesPerHour;
        
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