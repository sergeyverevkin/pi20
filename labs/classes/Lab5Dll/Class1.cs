using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Dll
{
    public class CGame
    {
      public int TimeLeft { get; set; }
      public string CurrentPlayerName { get; set; }
      public List<Shell> ShellList { get; }

      public CGame()
      {
        ShellList = new List<Shell>();
      }

      public void BeginGame()
      {
        ShellList.Clear();
        Shell pS1 = new Shell() {
          Name = "one",
          Position = 1,
        };
        Shell pS2 = new Shell() {
          Name = "two",
          Position = 2,
        };
        Shell pS3 = new Shell() {
          Name = "three",
          Position = 3,
        };
        ShellList.Add(pS1);
        ShellList.Add(pS2);
        ShellList.Add(pS3);
        pS3 = new Shell() {
          Name = "5",
          Position = 5,
        };
        ShellList.Add(pS3);
        pS3 = new Shell() {
          Name = "4",
          Position = 4,
        };
        ShellList.Add(pS3);

        Random pRandom = new Random();
        ShellList[pRandom.Next(0, ShellList.Count)].FlagLucky = true;
      }

    public void Shuffle()
      {
        Random pRandom = new Random();
        int iMaxIndex = ShellList.Count;
        for (int ii = 0; ii < 10; ii++) {
          int iIndex = pRandom.Next(0, iMaxIndex);
          int iPos1 = ShellList[iIndex].Position;
          int iIndex2 = iIndex == iMaxIndex - 1 ? 0 : iIndex + 1;
          ShellList[iIndex].Position = ShellList[iIndex2].Position;
          ShellList[iIndex2].Position = iPos1;
        }
      }
    }
}
