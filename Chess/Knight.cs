using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public class Knight : ChessPiece
  {
    public int X { get; set; }
    public int Y { get; set; }
    public ChessBoard Board { get; set; }

    public List<int> Threatens()
    {
      List<int> ret = new List<int>();
      int x1 = X + 1;
      int x2 = X + 2;
      int xo1 = X - 1;
      int xo2 = X - 2;

      int y1 = Y + 1;
      int y2 = Y + 2;
      int yo1 = Y - 1;
      int yo2 = Y - 2;

      int[] a = new int[] { x1, x1, x2, x2, xo1, xo1, xo2, xo2 };
      int[] b = new int[] { y2, yo2, y1, yo1, y2, yo2, y1, yo1 };

      for ( int i =0; i < a.Length; i++)
      {
        if(Board.IsValid(a[i],b[i]))
        {
          ret.Add(a[i]);
          ret.Add(b[i]);
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
