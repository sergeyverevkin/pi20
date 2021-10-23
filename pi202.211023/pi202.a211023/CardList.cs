using System;
using System.Collections.Generic;

namespace pi202.a211023
{
    public class CCardList: List<CCard>
    {
        public CCardList(int iCardCount): 
            base()
        {
            if (iCardCount == 52)
            {
                h_Init52();
            } else
            if (iCardCount == 36)
            {
                h_Init36();
            }
            else
            {
                throw new Exception("Неподдерживаемое количество карт в колоде");
            }
        }

        private void h_Init36()
        {
            for(int ii = 6; ii <= 14; ii++)
            {
                ECardType[] ar = 
                    (ECardType[])System.Enum.GetValues(typeof(ECardType));
                for(int jj = 0; jj < ar.Length; jj++ )
                {
                    CCard pCard = new CCard(ar[jj], ii);
                    this.Add(pCard);
                }
            }
        }

        private void h_Init52()
        {
            for (int ii = 2; ii <= 14; ii++)
            {
                ECardType[] ar =
                    (ECardType[])System.Enum.GetValues(typeof(ECardType));
                for (int jj = 0; jj < ar.Length; jj++)
                {
                    CCard pCard = new CCard(ar[jj], ii);
                    this.Add(pCard);
                }
            }
        }
 
        public void Shuffle()
        {
            //...
        }
    
    }
}
