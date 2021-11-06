namespace pi202.a211023
{
  public class CCard
  {
    /// <summary>
    /// Масть карты
    /// </summary>

    public ECardType CardType;
    /// <summary>
    /// Величина карты
    /// </summary>
    public int Value; // 6 = 6, Ace = 14

    public CCard(ECardType cardType, int value)
    {
      CardType = cardType;
      Value = value;
    }
  }
}
