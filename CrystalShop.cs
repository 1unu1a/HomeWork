namespace My.Home.Work;

public class CrystalShop
{
    public float imputGold;
    public float Crystal;

    public int crystalToGold = 10;

    public float exchengeCurrencyCount;

    public void PrintCrystal()
    {
        Console.WriteLine($"Введите количество вашего золота: ");
        imputGold = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Cколько кристаллов вы хотите купить?");
        
        exchengeCurrencyCount = Convert.ToSingle(Console.ReadLine());
        imputGold -= exchengeCurrencyCount * crystalToGold;
        Crystal = exchengeCurrencyCount;
        
        Console.WriteLine($"У вас осталось {imputGold} золота и" +  $" {Crystal} кристалов");
    }

}