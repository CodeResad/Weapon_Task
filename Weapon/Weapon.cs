namespace Weapon;

public class Weapon
{
    public int magazine;
    public int bullets;
    public bool isAutomatic;

    public Weapon(int magazine, int bullets, bool isAutomatic)
    {
        this.magazine = magazine;
        this.bullets = bullets;
        this.isAutomatic = isAutomatic;
    }

    public void Shoot()
    {
        if (bullets == 0)
        {
            Console.WriteLine("No bullets left!");
            return;
        }

        if (isAutomatic)
        {
            Console.WriteLine("Firing bullets automatically...");
            bullets = 0;
        }
        else
        {
            Console.WriteLine("Firing a bullet...");
            bullets--;
        }
    }

    public int GetRemainBulletCount()
    {
        return magazine - bullets;
    }

    public void Reload()
    {
        bullets = magazine;
        Console.WriteLine("Reloading...");
    }

    public void ChangeFireMode()
    {
        isAutomatic = !isAutomatic;
        Console.WriteLine($"Fire mode changed to {(isAutomatic ? "Automatic" : "Single shot")}");
    }
    
    
}