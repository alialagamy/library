
class Player
{
    public string name {  get; set; }
    public int health { get; set; }
    public double exprince { get; set; }

    public Player(string name="none", int health=0, double exprince=0)
    {
        this.name = name;
        this.health = health;
        this.exprince = exprince;
    }
    public string Shoot()
    {
        return $"{name} is shooting";
    }
    public string Throw()
    {
        return $"{name} is throwing";
    }
    public string Pass()
    {
        return $"{name} is passing";
    }
}

internal class Program
{
   
    static void Main(string[] args)
    {
        Player player1 = new Player("Ali",100,100);
        Player player2 = new Player("Ahmed", 100, 100);
        Player player3 = new Player();
        Console.WriteLine(player1.Shoot());
        Console.WriteLine(player2.Throw());
        Console.WriteLine(player1.Pass());
    }
}
