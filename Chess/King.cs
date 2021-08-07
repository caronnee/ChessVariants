using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public class King : ChessPiece
  {
    public int X { get; set; }
    public int Y { get; set; }
    public ChessBoard Board { get; set; }

    public List<int> Threatens()
    {
      List<int> ret = new List<int>();
      
      for ( int i =-1; i<2; i++)
      {
        for (int j =-1; j <2; j++)
        {
          if (i == 0 && j == 0)
            continue;
          int x = X + i;
          int y = Y + j;
          if (Board.IsValid(x,y))
          {
            ret.Add(x);
            ret.Add(y);
          }
        }
      }
      return ret;
    }
    
    public List<int> CanMove()
    {
      // todo sarade
      return Threatens();
    }
  }
  

}
