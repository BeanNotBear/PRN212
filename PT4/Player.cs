using PT4;

public class Player : IPlayer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Stamina { get; set; }
    public int Speed { get; set; }
    public int Power { get; set; }
    public int Samina { get; set; }

    public void GetInfor()
    {
        double average = (Attack + Defense + Stamina + Speed + Power) / 5.0;
        Console.WriteLine($"Name: {Name}, Age: {Age}, Average Point: {average}");
    }
}