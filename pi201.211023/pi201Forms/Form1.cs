using pi201.a211023;
using pi201.a211023.GameMachine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi201Forms
{
  public partial class Form1 : Form
  {
    private CCalculator m_pClass;
    private CGame m_pGame;

    public Form1()
    {
      m_pClass = new CCalculator();
      m_pGame = new CGame(10);
      InitializeComponent();
      h_RefreshPanels();
    }

    #region calc handlers
    private void btnPlus_Click(object sender, EventArgs e)
    {
      m_pClass.CurrentOperation = EOperation.Plus;
      m_pClass.Arg1 = Double.Parse(textBox1.Text);
      textBox1.Text = "";
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
      m_pClass.CurrentOperation = EOperation.Minus;
      m_pClass.Arg1 = Double.Parse(textBox1.Text);
      textBox1.Text = "";
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      m_pClass.Arg2 = Double.Parse(textBox1.Text);
      textBox1.Text = m_pClass.Calculate().ToString();
    }
    #endregion

    private void h_RefreshPanels()
    {
      panMoneyLack.Enabled = (m_pGame.Machine.MachineState == EMachineState.MoneyLack);
      panResult.Enabled = (m_pGame.Machine.MachineState == EMachineState.Result);
      panReturn.Enabled = (m_pGame.Machine.MachineState == EMachineState.Result); // && m_pGame.Machine.CoinsOutside > 0;
      panStakeWait.Enabled = (m_pGame.Machine.MachineState == EMachineState.WaitingPlayer);
      panStake.Enabled = (m_pGame.Machine.MachineState == EMachineState.WaitingTurn);

      labGameState.Text = m_pGame.Machine.MachineState.ToString();
      labMoney.Text = m_pGame.Player.Coins.ToString();
      labResult.Text = m_pGame.Machine.CoinsOutside.ToString();

      numericUpDown1.Value = m_pGame.Machine.CoinsStake;

    }

    private void button3_Click(object sender, EventArgs e)
    {
      m_pGame.Machine.LoadCoins(10);
      h_RefreshPanels();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      m_pGame.Machine.Start();
      h_RefreshPanels();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      // TODO: контроль, что ставка не больше имеющихся денег
      m_pGame.Machine.CoinsStake = (int) ((NumericUpDown)sender).Value;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      m_pGame.Turn(m_pGame.Player, m_pGame.Machine);
      h_RefreshPanels();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      m_pGame.TakeAway(m_pGame.Player, m_pGame.Machine);
      h_RefreshPanels();
    }
  }
}
