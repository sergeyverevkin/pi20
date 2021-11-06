using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi202.a211023
{

  public class CPlayer
  {
    public string Name;
    public List<CCard> CardList;

    public CPlayer(string sName)
    {
      CardList = new List<CCard>();
      Name = sName;
    }
  }
}