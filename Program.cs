namespace My.Home.Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задача картинки-----------------------
            int album = 52;
            int row = 3;
            int result = album / row;
            int remainder = album % row;
            Console.WriteLine($"Число заполненных рядов:{result}");
            Console.WriteLine($"Число оставшихся картинок:{remainder}");
            //задача картинки-----------------------
            var person = new PermutationOfValues();
            var shop = new CrystalShop();
            //задача перестановка местами значений
            person.PrintName();
            //задача магазин кристаллов
            shop.PrintCrystal();
            //задача поликлиника
            var clinic = new Clinic();
            clinic.PrintClinic();
        }
    }
}
