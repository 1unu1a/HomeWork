namespace My.Home.Work;

public class PermutationOfValues
{
    string name = "Dima";
    string surname = "Gromov";

    public void PrintName()
    {
        Console.WriteLine($"{name}, {surname}");
        (name, surname) = (surname, name);
        Console.WriteLine($"{name}, {surname}");
    }

}