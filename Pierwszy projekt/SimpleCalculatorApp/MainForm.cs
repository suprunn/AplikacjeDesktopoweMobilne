﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            if ( int.TryParse(FirstNumber.Text, out firstNumber)
                && int.TryParse(SecoundNumber.Text, out secondNumber))
            {
                int result = firstNumber + secondNumber;
                labelResult.Text = "Wynik operacij dodawania: " + result;
            }
        }
    }
}
