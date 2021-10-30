using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi201.a211023.GameMachine
{
  /*
   * Игровой автомат
  Количество монет внутри
  Количество монет "снаружи" (в лотке, выигрыш)
  Количество монет "ставка"
  Состояние автомата (ждет игрока, ждет хода, результат хода, ожидание обслуживания)
  Мультипликатор выигрыша
  Коэффициент удачливости
  */

  /// <summary>
  /// Игровой автомат
  /// </summary>
  public class CMachine
  {
    #region variables
    //  Количество монет внутри
    private int coins;


    /// <summary>
    /// Количество монет "снаружи" (в лотке, выигрыш)
    /// </summary>
    public int CoinsOutside { get; set; }


    /// <summary>
    /// Коэффициент удачливости
    /// </summary>
    public double LuckyRate { get; }


    /// <summary>
    /// Мультипликатор выигрыша
    /// </summary>
    public int StakeMultiplex { get; }


    private int coinsStake;
    /// <summary>
    /// Количество монет "ставка"
    /// </summary>
    public int CoinsStake
    {
      get => coinsStake;
      set
      {
        if (coins > (value - 1) * StakeMultiplex) {
          coinsStake = value;
        } else {
          // не хватает денег на выдачу выигрыша
        }
      }
    }

    private EMachineState machineState;
    public EMachineState MachineState
    {
      get => machineState;
    }

 
    #region property demo
    //public int Coins
    //{
    //  get { 
    //    return coins; 
    //  }
    //  set
    //  {
    //    coins = value;
    //  }
    //}

    // public int Coins2 { get => coins; set => coins = value; }
    // public int CoinsProperty { get; set; }
    //  Количество монет "снаружи" (в лотке, выигрыш)
    //  Количество монет "ставка"
    //  Состояние автомата(ждет игрока, ждет хода, результат хода, ожидание обслуживания)
    //  Коэффициент выигрыша
    #endregion
    #endregion

    #region constructor 
    /// <summary>
    /// .ctor
    /// </summary>
    public CMachine(int iStakeMultiplex)
    {
      LuckyRate = 0.5;
      StakeMultiplex = iStakeMultiplex;
      Random pR = new Random();
      LuckyRate = pR.Next(40, 61) / 100; // 40 - 60 %
      h_UpdateState();
    }
    #endregion

    #region private methods
    private void h_UpdateState()
    {
      if (coins < 10) {
        machineState = EMachineState.MoneyLack;
      }
    }

    public void Turn()
    {
      throw new NotImplementedException();
    }

    #endregion

    #region methods

    /// <summary>
    /// Старт игры
    /// </summary>
    /// <returns></returns>
    public bool Start()
    {
      if (machineState == EMachineState.WaitingPlayer) {
        machineState = EMachineState.WaitingTurn;
        CoinsStake = 1;
        return true;
      }
      return false;
    }
    /// <summary>
    /// Техобслуживание: дозагрузка монет
    /// </summary>
    /// <param name="iCoinsCount"></param>
    public void LoadCoins(int iCoinsCount)
    {
      coins += iCoinsCount;
      if (MachineState == EMachineState.MoneyLack && coins > 10) {
        machineState = EMachineState.WaitingPlayer;
      }
    }

    #endregion
  }
}
