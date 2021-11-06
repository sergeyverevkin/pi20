using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi202.a211023
{

  public class CDurakGame : CGame
  {
    /// <summary>
    /// Список игроков
    /// </summary>
    public List<CPlayer> Players = new List<CPlayer>();
    public CTable Table = new CTable();
    /// <summary>
    /// КОзырная масть
    /// </summary>
    public ECardType CardType;
    /// <summary>
    /// Текущий игрок
    /// </summary>
    public CPlayer CurrentPlayer = new CPlayer();

    public CDurakGame() : base()
    {
    }



    public void NewGame()
    {
      CPlayer pPlayer1 = new CPlayer("1");
      CPlayer pPlayer2 = new CPlayer("2");
      this.Players(pPlayer1);
      this.Players(pPlayer2);

      h_InitCards();
      
    }

    private void h_InitCards()
    {
      for (int ii = 0; ii < 6; ii++) {
        foreach (var pPlayer in Players) {
          var pLastCard = CardList[CardList.Length - 1];
          CardList.RemoveAt(CardList.Length - 1);
          pPlayer.CardList.Add(pLastCard);
        }
      }

      var pLastCard = CardList[CardList.Length - 1];
      CardList.RemoveAt(CardList.Length - 1);
      CardList.Insert(0, pLastCard);

      CardType = pLastCard.CardType;
    }
  }
}