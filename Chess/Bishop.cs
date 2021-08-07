using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public class Bishop : ChessPiece
  {
    public int X { get; set; }
    public int Y { get; set; }
    public ChessBoard Board { get; set; }

    public List<int> Threatens()
    {
      List<int> ret = new List<int>();
      int xup = Board.DimX - X;
      int yup = Board.DimY - Y;
      int xdown = X;
      int ydown = Y;

      for ( int i =1; i < xup; i++)
      {
        for (int j = 1; j < yup; j++)
        {
          int x = X + i;
          int y = Y + j;
          ret.Add(x);
          ret.Add(y);
          if (Board.IsFree(x, y) == false)
          {
            break;
          }
        }
        for (int j = 1; j < ydown; j++)
        {
          int x = X + i;
          int y = Y - j;
          ret.Add(x);
          ret.Add(y);
          if (Board.IsFree(x, y) == false)
          {
            break;
          }
        }
      }

      for (int i = 1; i < xdown; i++)
      {
        for (int j = 1; j < yup; j++)
        {
          int x = X - i;
          int y = Y + j;
          ret.Add(x);
          ret.Add(y);
          if (Board.IsFree(x, y) == false)
            break;
        }
        for (int j = 1; j < ydown; j++)
        {
          int x = X - i;
          int y = Y - j;
          ret.Add(x);
          ret.Add(y);
          if (Board.IsFree(x, y) == false)
            break;
        }
      }
      return ret;
    }

    public List<int> CanMove()
    {
      return Threatens();
    }
  }
}
