namespace pi201.a211023
{
  /// <summary>
  /// Состояние автомата (ждет игрока, ждет хода, результат хода, ожидание обслуживания)
  /// </summary>
  public enum EMachineState
  {
    WaitingPlayer = 1,
    WaitingTurn = 2,
    Result = 3,
    MoneyLack = 4
  }
}