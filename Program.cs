using System; 
using ChessAttack;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter the X coordinate for the Queen");
    int queenX = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Enter the Y coordinate for the Queen");
    int queenY = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Enter the X coordinate for the Opponent Piece");
    int oppX = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Enter the Y coordinate for the Opponent Piece");
    int oppY = int.Parse(Console.ReadLine()); 
    Queen newQueen = new Queen(queenX, queenY); 
    Opp newOpp = new Opp(oppX, oppY);
    Console.WriteLine(newQueen.XCoor + ", " + newQueen.YCoor);  
    Console.WriteLine(newOpp.XCoor + ", " + newOpp.YCoor);
    bool attack = newQueen.TheQueensGambit(queenX, queenY, oppX,oppY); 
    Console.WriteLine(attack); 
  }
}