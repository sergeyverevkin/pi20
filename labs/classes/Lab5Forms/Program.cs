using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5Dll;

namespace Lab5Forms
{
  static class Program
  {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      CGame pGame = new CGame();
      pGame.TimeLeft = 100;
      Application.Run(new Form1(pGame));
    }
  }
}
