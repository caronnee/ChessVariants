using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public interface ChessPiece
  {
    public int X { get; set; }
    public int Y { get; set; }

    public ChessBoard Board { get; set; }
    public List<int> Threatens();
    public List<int> CanMove();
  }
}
