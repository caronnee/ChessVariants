using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public class ChessBoard
  {
    List<List<ChessPiece>> _content;
    public ChessBoard(int x, int y)
    {
      _content = new List<List<ChessPiece>>();
      for ( int i =0; i< x; i++)
      {
        _content[i] = new List<ChessPiece>();
        for ( int j =0; j < y; j++)
        {
          _content[i][j] = null;
        }
      }
    }
    public int DimX { get => _content.Count; }
    public int DimY { get => _content[0].Count; }
    public bool IsFree(int x, int y)
    {
      return _content[x][y] == null;
    }
    public bool IsValid(int x, int y)
    {
      if (x < 0 || y < 0)
        return false;
      if (x > DimX || y > DimY)
        return false;
      return true;
    }
    public void SetPiece(ChessPiece p, int x, int y)
    {
      int oldX = p.X, oldY = p.Y;
      _content[oldX][oldY] = null;
      _content[x][y] = p;
      p.X = x;
      p.Y = y;
    }
  }
}
