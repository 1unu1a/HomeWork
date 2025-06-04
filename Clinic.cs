namespace My.Home.Work;

public class Clinic
{
    public int totalMinutes;
    public int hours;
    public int minutes;
    
    public void PrintClinic()
    {
        Console.WriteLine($"Введите количество старушек: ");
        int numberOfPeople = int.Parse(Console.ReadLine());

        totalMinutes = numberOfPeople * 10;
        hours = totalMinutes / 60;
        minutes = totalMinutes % 60;
        
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