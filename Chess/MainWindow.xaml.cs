using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    enum Player
    {
      Black,
      White
    }

    Player onTurn;
    void CreateButton(bool black, char id, bool blackFigure)
    {
      Button b = new Button();
      b.Background = black ? Brushes.DarkGray : Brushes.Gray;
      b.Content = id;
      b.Foreground = blackFigure ? Brushes.Black : Brushes.AntiqueWhite;
      x_board.Children.Add(b);
    }
    private void CreateBoard()
    {
      CreateButton(true, 'R', true);
      CreateButton(false, 'J', true);
      CreateButton(true, 'B', true);
      CreateButton(false, 'K', true);
      CreateButton(true, 'Q', true);
      CreateButton(false, 'B', true);
      CreateButton(true, 'J', true);
      CreateButton(false, 'R', true);

      CreateButton(false, 'P', true);
      CreateButton(true, 'P', true);
      CreateButton(false, 'P', true);
      CreateButton(true, 'P', true);
      CreateButton(false, 'P', true);
      CreateButton(true, 'P', true);
      CreateButton(false, 'P', true);
      CreateButton(true, 'P', true);

      for (int i = 0; i < 4; i++)
      {
        bool startblack = i % 2 == 0;
        for (int j = 0; j < 8; j++)
        {
          CreateButton(j % 2 == 0 ? startblack : !startblack, ' ', true);
        }
      }

      CreateButton(true, 'P', false);
      CreateButton(false, 'P', false);
      CreateButton(true, 'P', false);
      CreateButton(false, 'P', false);
      CreateButton(true, 'P', false);
      CreateButton(false, 'P', false);
      CreateButton(true, 'P', false);
      CreateButton(false, 'P', false);

      CreateButton(false, 'R', false);
      CreateButton(true, 'J', false);
      CreateButton(false, 'B', false);
      CreateButton(true, 'K', false);
      CreateButton(false, 'Q', false);
      CreateButton(true, 'B', false);
      CreateButton(false, 'J', false);
      CreateButton(true, 'R', false);
    }
    private void x_click_start_game(object sender, RoutedEventArgs e)
    {
      onTurn = Player.White;
      CreateBoard();
      
    }
  }
}
