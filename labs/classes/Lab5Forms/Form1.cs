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
  public partial class Form1 : Form
  {
    private CGame _game;

    public Form1(CGame pGame)
    {
      InitializeComponent();
      _game = pGame;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // !!!!!!! :(
      this.Visible = false;
      _game.CurrentPlayerName = txtLogin.Text;
      using (Form2 pForm2 = new Form2(_game)) {
        pForm2.ShowDialog();
      }

      // !!!!!!! :(
      Close();
    }
  }
}
