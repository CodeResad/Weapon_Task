namespace Weapon;

class Program
{
    static void Main(string[] args)
    {
        Weapon ak47 = new Weapon(30, 25, true);

        while (true)
        {
            Console.WriteLine("0 - Get info");
            Console.WriteLine("1 - Shoot");
            Console.WriteLine("2 - Remaining Bullets");
            Console.WriteLine("3 - Reload");
            Console.WriteLine("4 - Change Fire Mode");
            Console.WriteLine("5 - Exit");
            
            Console.WriteLine("Choose an option: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 0: Console.WriteLine($"Magazine: {ak47.magazine} bullets, {ak47.bullets} bullets, Mode: {(ak47.isAutomatic ? "Automatic" : "Single Shot")}");
                    break;
                case 1: ak47.Shoot();
                    break;
                case 2: Console.WriteLine($"Bullets Remaining: {ak47.GetRemainBulletCount()} bullets");
                    break;
                case 3: ak47.Reload(); 
                    break;
                case 4: ak47.ChangeFireMode();
                    break;
                case 5:
                    return;
                default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}