using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi202.a211023
{

  public class CGame
  {
    public CCardList CardList;

    public CGame()
    {
      CardList = new CCardList(36);
      int iCount = CardList.Shuffle2();
      //DateTime dtFrom = DateTime.Now;
      //for (int ii = 0; ii < 100; ii++) {
      //  CardList = new CCardList(36);
      //  int iCount = CardList.Shuffle();
      //}
      //DateTime dtTo = DateTime.Now;
      //for (int ii = 0; ii < 100; ii++) {
      //  CardList = new CCardList(36);
      //  int iCount = CardList.Shuffle2();
      //}
      //DateTime dtTo2 = DateTime.Now;
      //var ts1 = dtTo - dtFrom;
      //var ts2 = dtTo2 - dtTo;

    }
  }
}