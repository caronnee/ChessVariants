using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public class Rook : ChessPiece
  {
    public int X { get; set; }
    public int Y { get; set; }
    public ChessBoard Board { get; set; }

    public List<int> Threatens()
    {
      List<int> ret = new List<int>();
      for (int i = 1; i < 7; i++)
      {
        int x = X + i;
        if (x > Board.DimX)
          break;
        ret.Add(x);
        ret.Add(Y);
        if (Board.IsFree(x, Y) == false)
          break;
      }
      for (int i = 1; i < 7; i++)
      {
        int x = X - i;
        if (x < 0)
          break;
        ret.Add(x);
        ret.Add(Y);
        if (Board.IsFree(x, Y) == false)
          break;
      }

      for (int i = 1; i < 7; i++)
      {
        int y = Y + i;
        if (y > Board.DimY)
          break;
        ret.Add(X);
        ret.Add(y);
        if (Board.IsFree(X,y) == false)
          break;
      }
      for (int i = 1; i < 7; i++)
      {
        int y = Y - i;
        if (y <0)
          break;
        ret.Add(X);
        ret.Add(y);
        if (Board.IsFree(X, y) == false)
          break;
      }
      return ret;
    }
    public List<int> CanMove()
    {
      return Threatens();
    }
  }
}
