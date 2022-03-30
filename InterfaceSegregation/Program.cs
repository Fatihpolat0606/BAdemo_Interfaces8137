Robot robot = new Robot();
robot.MaasAl();

Bot bot = new Bot();
bot.Calis();

interface ICalisan
{
    void Calis();
    void YemekYe();
    void MaasAl();
}

class Yonetici : ICalisan
{
    public void Calis()
    {
        Console.WriteLine("Yönetici çalışır");
    }

    public void MaasAl()
    {
        Console.WriteLine("Yönetici maaş alır");
    }

    public void YemekYe()
    {
        Console.WriteLine("Yönetici bol bol yemek yer");
    }
}

class Calisan : ICalisan
{
    public void Calis()
    {
        Console.WriteLine("Çalışan çok çalışır");
    }

    public void MaasAl()
    {
        Console.WriteLine("Çalışan maaş alır");
    }

    public void YemekYe()
    {
        Console.WriteLine("Çalışan az az yemek yer");
    }
}

class Robot : ICalisan
{
    public void Calis()
    {
        throw new NotImplementedException();
    }

    public void MaasAl()
    {
        
    }

    public void YemekYe()
    {
        
    }
}

interface ICalis
{
    void Calis();
}

interface IYemekYe
{
    void YemekYe();
}

interface IMaasAl
{
    void MaasAl();
}

class Isci : ICalis, IYemekYe, IMaasAl // interface segregation
{
    public void Calis()
    {
        Console.WriteLine("İşçi çok çalışır");
    }

    public void MaasAl()
    {
        Console.WriteLine("İşçi az maaş alır");
    }

    public void YemekYe()
    {
        Console.WriteLine("İşçi az az yemek yer");
    }
}

class Bot : ICalis
{
    public void Calis()
    {
        Console.WriteLine("Robot çalışır");
    }
}
