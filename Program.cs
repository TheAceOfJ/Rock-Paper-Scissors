using Rock_Paper_Scissors;

Console.WriteLine("Player 1, state your name:");
string name1 = Console.ReadLine();
Player player1 = new Player(name1);

Console.WriteLine("Player 2, state your name:");
string name2 = Console.ReadLine();
Player player2 = new Player(name2);


Console.WriteLine("Welcome " + player1.Name);
Console.WriteLine("Welcome " + player2.Name);

var lives = 3;

while (lives != 0)
{
    Console.WriteLine("Player 1");
    var p1 = Console.ReadLine();
    if (p1.Contains("rock"))
    {
        Console.WriteLine("beans");
    }
}