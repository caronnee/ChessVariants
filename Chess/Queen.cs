using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public class Queen : ChessPiece
  {
    public int X { get; set; }
    public int Y { get; set; }
    public ChessBoard Board { get; set; }

    public List<int> Threatens()
    {
      List<int> ret = new List<int>();
      Rook r = new Rook();
      r.Board = Board;
      r.X = X;
      r.Y = Y;
      ret = r.Threatens();
      Bishop b = new Bishop();
      b.X = X;
      b.Y = Y;
      b.Board = Board;
      ret.Concat(b.Threatens());
      return ret;
    }
    public List<int> CanMove()
    {
      return Threatens();
    }
  }

}
