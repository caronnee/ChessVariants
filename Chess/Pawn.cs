using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public class Pawn : ChessPiece
  {
    public int X { get; set; }
    public int Y { get; set; }
    public ChessBoard Board { get; set; }

    public List<int> Threatens()
    {
      List<int> ret = new List<int>();
      if (Board.IsValid(X+1,Y+1))
      {
        ret.Add(X + 1);
        ret.Add(Y + 1);
      }

      if (Board.IsValid(X - 1, Y + 1))
      {
        ret.Add(X - 1);
        ret.Add(Y + 1);
      }
      return ret;
    }
    public List<int> CanMove()
    {
      return Threatens();
    }
  }
}
