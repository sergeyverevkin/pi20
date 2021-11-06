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
    /// <summary>
    /// Время последнего выигрыша
    /// </summary>
    private DateTime m_dtLastWin = DateTime.Now;

    //  Количество монет внутри
    private int coins;


    /// <summary>
    /// Количество монет "снаружи" (в лотке, выигрыш)
    /// </summary>
    public int CoinsOutside { get; set; }


    /// <summary>
    /// Коэффициент удачливости
    /// </summary>
    public double LuckyRate { get; private set; }


    /// <summary>
    /// Мультипликатор выигрыша
    /// </summary>
    public int StakeMultiplex { get; }


    private int coinsStake;

    internal int TakeAway()
    {
      int iCount = 0;
      if (CoinsOutside > 0) {
        iCount = CoinsOutside;
        CoinsOutside = 0;
      }
      machineState = EMachineState.WaitingPlayer;
      return iCount;
    }

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

    public void Turn(double dPlayerLuckyRate)
    {
      // жадность автомата
      double dDecreaseRate = coins < 30 ? 0.99 : 1;
      if (m_dtLastWin < DateTime.Now.AddSeconds(-10)) {
        dDecreaseRate = dDecreaseRate * 1.02;
      }
      // 0 .. 1
      double dLuckyRate = (dPlayerLuckyRate + LuckyRate) * dDecreaseRate;
      if (dLuckyRate >= 1) {
        m_dtLastWin = DateTime.Now;
        h_TurnPlayerWin();
        return;
      }

      if (dLuckyRate <= 0) {
        h_TurnPlayerFail();
        return;
      }

      Random pR = new Random();
      double dRnd = pR.NextDouble();
      bool bWin = (dRnd < dLuckyRate);

      // инверсия вероятности
      if (DateTime.Now.Second == 0) {
        bWin = !bWin;
      }

      if (bWin) {
        m_dtLastWin = DateTime.Now;
      }

      // адаптация
      if (bWin) {
        LuckyRate *= 0.99;
      } else {
        LuckyRate *= 1.01;
      }

      if (bWin) {
        h_TurnPlayerWin();
      }
      else {
        h_TurnPlayerFail();
      }
    }

    private void h_TurnPlayerFail()
    {
      this.coins += this.CoinsStake;
      this.CoinsStake = 0;
      machineState = EMachineState.Result;
    }

    private void h_TurnPlayerWin()
    {
      int iCount = this.CoinsStake * this.StakeMultiplex;
      this.coins -= iCount;
      this.CoinsOutside += this.CoinsStake + iCount; 
      this.CoinsStake = 0;
      machineState = EMachineState.Result;
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
