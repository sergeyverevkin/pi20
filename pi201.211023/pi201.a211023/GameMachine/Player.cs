using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi201.a211023.GameMachine
{
  /// <summary>
  /// Игрок
  /// </summary>
  public class CPlayer
  {
    /// <summary>
    /// Количество монет
    /// </summary>
    public int Coins { get; set; }

    /// <summary>
    /// Удачливость(коэффициент)
    /// </summary>
    public double LuckyRate { get; set; }

    public CPlayer(int coins)
    {
      Coins = coins;
      Random pR = new Random();
      LuckyRate = pR.NextDouble();
    }
  }
}
