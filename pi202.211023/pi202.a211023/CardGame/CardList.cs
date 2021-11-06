using System;
using System.Collections.Generic;

namespace pi202.a211023
{
  public class CCardList : List<CCard>
  {
    public CCardList(int iCardCount) :
        base()
    {
      if (iCardCount == 52) {
        h_Init52();
      }
      else
      if (iCardCount == 36) {
        h_Init36();
      }
      else {
        throw new Exception("Неподдерживаемое количество карт в колоде");
      }
    }

    private void h_Init36()
    {
      for (int ii = 6; ii <= 14; ii++) {
        ECardType[] ar =
            (ECardType[])System.Enum.GetValues(typeof(ECardType));
        for (int jj = 0; jj < ar.Length; jj++) {
          CCard pCard = new CCard(ar[jj], ii);
          this.Add(pCard);
        }
      }
    }

    private void h_Init52()
    {
      for (int ii = 2; ii <= 14; ii++) {
        ECardType[] ar =
            (ECardType[])System.Enum.GetValues(typeof(ECardType));
        for (int jj = 0; jj < ar.Length; jj++) {
          CCard pCard = new CCard(ar[jj], ii);
          this.Add(pCard);
        }
      }
    }

    public int Shuffle()
    {
      Random pRandom = new Random();

      int iCount = 0;
      while (!this.IsShuffled()) {
        iCount++;
        for (int ii = 0; ii < 10000; ii++) {
          int iIndex1 = pRandom.Next(0, this.Count);
          int iIndex2 = pRandom.Next(0, this.Count);
          CCard pCard1 = this[iIndex1];
          CCard pCard2 = this[iIndex2];
          this[iIndex1] = pCard2;
          this[iIndex2] = pCard1;
        }
      }
      return iCount;

    }

    public int Shuffle2()
    {
      Random pRandom = new Random();

      int iCount = 0;
      CCardList cCards = new CCardList(this.Count);
      cCards.Clear();
      while (!this.IsShuffled()) {
        iCount++;
        foreach (var pCard in this) {
          cCards.Add(pCard);
        }
        this.Clear();
        while (cCards.Count > 0) {
          int iIndex1 = pRandom.Next(0, cCards.Count);
          this.Add(cCards[iIndex1]);
          cCards.RemoveAt(iIndex1);
        }
      }
      return iCount;
    }


    private bool IsShuffled()
    {
      for (int ii = 1; ii < this.Count; ii++) {
        if (this[ii].Value == this[ii - 1].Value) {
          return false;
        }
        if (this[ii].CardType == this[ii - 1].CardType) {
          if (this[ii].Value == this[ii - 1].Value + 1) {
            return false;
          }
        }
      }
      return true;
    }
  }
}
