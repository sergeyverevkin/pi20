using pi202.a211023;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi202Form
{
    public partial class Form1 : Form
    {
        private CGame m_pCardGame;
        public Form1(CGame pC)
        {
            m_pCardGame = pC;
            InitializeComponent();
            h_ShowCard();
        }

        private void h_ShowCard()
        {
            const int CardWidth = 60;
            const int CardPadding = 5;
            for(int ii = 0; ii < m_pCardGame.CardList.Count; ii++)
            {
                Panel pan = new Panel();
                pan.Width = CardWidth;
                pan.Height = 30;
                pan.BackColor = Color.White;
                pan.Location = new Point(10 + (CardWidth + CardPadding) * ii, 10);
                this.Controls.Add(pan);
                pan.Parent = this;
                Label pLabel = new Label();
                pLabel.Parent = pan;
                pLabel.Location = new Point(5, 5);
                pLabel.Text = m_pCardGame.CardList[ii].CardType + " " + m_pCardGame.CardList[ii].Value;
                pan.Controls.Add(pLabel);
            }
        }
    }
}
