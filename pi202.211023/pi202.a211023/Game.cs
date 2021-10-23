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
            CardList.Shuffle();
        }
    }
}
