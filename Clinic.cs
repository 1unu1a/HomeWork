namespace My.Home.Work;

public class Clinic
{
    const int minutesPerPerson = 10;
    const int minutesPerHour = 60;
    
    public void PrintClinic()
    {
        Console.WriteLine($"Введите количество старушек: ");
        int numberOfPeople = int.Parse(Console.ReadLine());

        int totalMinutes = numberOfPeople * minutesPerPerson;
        int hours = totalMinutes / minutesPerHour;
        int minutes = totalMinutes % minutesPerHour;
        
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