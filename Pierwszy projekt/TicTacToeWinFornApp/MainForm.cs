using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWinFornApp
{
    public partial class MainForm : Form
    {

        string[] player = new string[2];
        int currentPlayerNumber;


        Button[,] buttonBoard = new Button[3, 3];

        public MainForm()
        {
            InitializeComponent();
            comboBoxWhoStarts.SelectedIndex = 0;
            player[0] = "O";
            player[1] = "X";
            buttonBoard[0, 0] = LeftTopButton;
            buttonBoard[1, 0] = MiddleTopButton;
            buttonBoard[2, 0] = RightTopButton;
            buttonBoard[0, 1] = LeftMiddleButton;
            buttonBoard[1, 1] = MiddleMiddleButton;
            buttonBoard[2, 1] = RightMiddleButton;
            buttonBoard[0, 2] = LeftBottomButton;
            buttonBoard[1, 2] = MiddleBottomButton;
            buttonBoard[2, 2] = RightBottomButton;
      


        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            currentPlayerNumber = comboBoxWhoStarts.SelectedIndex;
            tableLayoutPanelBoard.Visible = true;
        }


        private void buttonPosition_Click(object sender, EventArgs e)
        {
            Button buttonSender = sender as Button;
            if (buttonSender == null)
                return;


            if (buttonSender.Text != "")
                return;
            buttonSender.Text = player[currentPlayerNumber];


            if(CheckWin(currentPlayerNumber))
            {
                return;
            }


            //sprawdzanie czy koniec gry
            currentPlayerNumber = (currentPlayerNumber == 0) ? 1 : 0;
            
        }

        private bool CheckWin(int currentPlayerNumber)
        {
            return false;
        }
    }
}
