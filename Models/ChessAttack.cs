using System;  
using System.Collections.Generic;

namespace ChessAttack {
  public class Queen
  {
    public int XCoor { get; set; }
    public int YCoor { get; set; }

    public Queen(int x, int y)
    {
      XCoor = x;
      YCoor = y;
    }

    public bool TheQueensGambit(int XCoor, int YCoor, int XCoor2, int YCoor2) 
    {
      if (XCoor == XCoor2 || YCoor == YCoor2) {
        return true;
      } 
      else if (Math.Pow((XCoor - XCoor2), 2) == Math.Pow((YCoor - YCoor2), 2)) {
        return true; 
      }
      else {
        return false;
      }
    }
  }
  public class Opp
  {
    public int XCoor { get; set; }
    public int YCoor { get; set; }

    public Opp(int x, int y)
    {
      XCoor = x;
      YCoor = y;
    }
  }
}