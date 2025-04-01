namespace Weapon;

public class Weapon
{
    private int _magazine;
    private int _bullets;
    private bool _isAutomatic;

    public int Magazine
    {
        get
        {
            return _magazine;
        }
        set
        {
            if (value >= 0)
            {
                _magazine = value;
            }
            else
            {
                Console.WriteLine("Invalid magazine!!!");
            }
        }
    }

    public int Bullets
    {
        get
        {
            return _bullets;
        }
        set
        {
            if (value >= 0)
            {
                _bullets = value;
            }
            else
            {
                Console.WriteLine("Invalid bullets!!!");
            }
        }
    }

    public bool IsAutomatic { get; set; }

    public Weapon(int magazine, int bullets, bool isAutomatic)
    {
        Magazine = magazine;
        Bullets = bullets;
        IsAutomatic = isAutomatic;
    }

    public void Shoot()
    {
        if (Bullets == 0)
        {
            Console.WriteLine("No bullets left!");
            return;
        }

        if (IsAutomatic)
        {
            Console.WriteLine("Firing bullets automatically...");
            Bullets = 0;
        }
        else
        {
            Console.WriteLine("Firing a bullet...");
            Bullets--;
        }
    }

    public int GetRemainBulletCount()
    {
        return Magazine - Bullets;
    }

    public void Reload()
    {
        Bullets = Magazine;
        Console.WriteLine("Reloading...");
    }

    public void ChangeFireMode()
    {
        IsAutomatic = !IsAutomatic;
        Console.WriteLine($"Fire mode changed to {(IsAutomatic ? "Automatic" : "Single shot")}");
    }
    
    
}