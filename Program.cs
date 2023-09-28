using Rock_Paper_Scissors;
using System.Data;
var randomord = new Random();
var randomline = randomord.Next(0, 2);




Console.WriteLine("Bot or no bot?");
string bot = Convert.ToString(Console.ReadLine().ToLower());





Console.WriteLine("Player 1, state your name:");
string name1 = Console.ReadLine();
Player player1 = new Player(name1);

Console.WriteLine("Player 2, state your name:");
string name2 = Console.ReadLine();
Player player2 = new Player(name2);


Console.WriteLine("Welcome " + player1.Name);
Console.WriteLine("Welcome " + player2.Name);
var player1Score = 0;
var player2Score = 0;

string player1Choice = string.Empty;
string player2Choice = string.Empty;
var p = 1;
var o = 1;



while (player1Score < 3 && player2Score < 3)
{
    p = 1;
    o = 1;

    while (p == 1)
    {
        //player 1 picks
        Console.WriteLine("Player 1 picks");
        Console.WriteLine("Pick rock, paper or scissors");
        string p1 = Console.ReadLine();
        if (p1.Equals("rock"))
        {
            player1Choice = "rock";
            p--;
        }
        else if (p1.Equals("paper"))
        {
            player1Choice = "paper";
            p--;

        }
        else if (p1.Equals("scissors"))
        {
            player1Choice = "scissors";
            p--;

        }
        Console.Clear();
    }

    while (o == 1)
    {
        //player 2 picks
        Console.WriteLine("Player 2 picks");
        Console.WriteLine("Pick rock, paper or scissors");
        string p2 = Console.ReadLine();
        if (p2.Equals("rock"))
        {
            player2Choice = "rock";
            o--;
        }
        else if (p2.Equals("paper"))
        {
            player2Choice = "paper";
            o--;
        }
        else if (p2.Equals("scissors"))
        {
            player2Choice = "scissors";
            o--;
        }
        Console.Clear();
    }







    if (player1Choice == player2Choice)
    {
        Console.WriteLine("Its a draw");
    }
    else if (player1Choice == "rock" && player2Choice == "scissors" ||
             player1Choice == "paper" && player2Choice == "rock" ||
             player1Choice == "scissors" && player2Choice == "paper")
    {
        Console.WriteLine(name1 + " wins");
        player1Score++;
    }
    else
    {
        Console.WriteLine(name2 + " wins");
        player2Score++;
    }
    Console.WriteLine(name1 + " points " + player1Score);
    Console.WriteLine(name2 + " points " + player2Score);

}


if (player1Score == 3)
{
    Console.WriteLine("Player " + name1 + " wins");
}
if (player2Score == 3)
{
    Console.WriteLine("Player " + name2 + " wins");

}
