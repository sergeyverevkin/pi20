using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi201.a211023.GameMachine
{
  /// <summary>
  /// Игра
  /// </summary>
  public class CGame
  {
    #region constructors
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="iCoinsCount"></param>
    public CGame(int iCoinsCount)
    {
      Player = new CPlayer(iCoinsCount);
      Machine = new CMachine(2);
    }
    #endregion

    #region properties
    /// <summary>
    /// Игрок
    /// </summary>
    public CPlayer Player { get; }

    /// <summary>
    /// Игровой автомат
    /// </summary>
    public CMachine Machine { get; }

    #endregion
    #region methods
    public void Turn()
    {
      // TODO: брать удачливость игрока и вызывать метод автомата
    }
    #endregion

  }
}
