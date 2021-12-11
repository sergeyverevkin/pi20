using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5Dll;

namespace Lab5Forms
{

  public partial class Form2 : Form
  {
    private CGame _game;

    public Form2(CGame pGame)
    {
      InitializeComponent();
      _game = pGame;
      h_Refresh();
    }

    private void h_Refresh()
    {
      labLogin.Text = _game.CurrentPlayerName;

      foreach (var pControl in Controls) {
        if (!(pControl is Button)) continue;
        Button pBtn = (pControl as Button);
        if (pBtn.Tag != null) {
          Controls.Remove(pBtn);
        }
      }

      foreach (Shell pShell in _game.ShellList) {
        h_drawButton(pShell);
      }
    }

    private void h_drawButton(Shell shell)
    {
      Button pShellButton = null;

      foreach (var pControl in Controls) {
        if (!(pControl is Button)) continue;
        Button pBtn = (pControl as Button);
        if (pBtn.Tag == shell) {
          pShellButton = pBtn;
          break;
        }
      }

      if (pShellButton == null) {
        // рисуем новую кнопку
        pShellButton = new Button();
        pShellButton.Parent = this;
        pShellButton.Width = 30;
        pShellButton.Height = 30;
        pShellButton.Tag = shell;
        pShellButton.Click += PShellButton_OnClick;
      }
      // обновляем кнопку
      pShellButton.Text = shell.Name;
      pShellButton.Location = new Point(
        40 * shell.Position + 40,
        40);
    }

    private void PShellButton_OnClick(object sender, EventArgs e)
    {
      Button pButton = (sender as Button);
      Shell pShell = (pButton.Tag as Shell);
      if (pShell.FlagLucky) {
        MessageBox.Show("Great!");
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      _game.BeginGame();
      h_Refresh();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      _game.Shuffle();
      h_Refresh();
    }
  }
}
