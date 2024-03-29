﻿
namespace TicTacToeWinFornApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConfigGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.comboBoxWhoStarts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelBoard = new System.Windows.Forms.TableLayoutPanel();
            this.LeftTopButton = new System.Windows.Forms.Button();
            this.MiddleTopButton = new System.Windows.Forms.Button();
            this.RightTopButton = new System.Windows.Forms.Button();
            this.LeftMiddleButton = new System.Windows.Forms.Button();
            this.MiddleMiddleButton = new System.Windows.Forms.Button();
            this.RightMiddleButton = new System.Windows.Forms.Button();
            this.LeftBottomButton = new System.Windows.Forms.Button();
            this.MiddleBottomButton = new System.Windows.Forms.Button();
            this.RightBottomButton = new System.Windows.Forms.Button();
            this.panelConfigGame.SuspendLayout();
            this.tableLayoutPanelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfigGame
            // 
            this.panelConfigGame.Controls.Add(this.label1);
            this.panelConfigGame.Controls.Add(this.buttonNewGame);
            this.panelConfigGame.Controls.Add(this.comboBoxWhoStarts);
            this.panelConfigGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfigGame.Location = new System.Drawing.Point(0, 0);
            this.panelConfigGame.Margin = new System.Windows.Forms.Padding(10);
            this.panelConfigGame.Name = "panelConfigGame";
            this.panelConfigGame.Size = new System.Drawing.Size(851, 76);
            this.panelConfigGame.TabIndex = 0;
            this.panelConfigGame.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kto zaczyna grę:";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(387, 12);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 1;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // comboBoxWhoStarts
            // 
            this.comboBoxWhoStarts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhoStarts.FormattingEnabled = true;
            this.comboBoxWhoStarts.Items.AddRange(new object[] {
            "Kółko",
            "Krzyżyk"});
            this.comboBoxWhoStarts.Location = new System.Drawing.Point(35, 29);
            this.comboBoxWhoStarts.Name = "comboBoxWhoStarts";
            this.comboBoxWhoStarts.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWhoStarts.TabIndex = 0;
            // 
            // tableLayoutPanelBoard
            // 
            this.tableLayoutPanelBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelBoard.ColumnCount = 3;
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.00149F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0015F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.99702F));
            this.tableLayoutPanelBoard.Controls.Add(this.LeftTopButton, 0, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.MiddleTopButton, 1, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.RightTopButton, 2, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.LeftMiddleButton, 0, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.MiddleMiddleButton, 1, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.RightMiddleButton, 2, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.LeftBottomButton, 0, 2);
            this.tableLayoutPanelBoard.Controls.Add(this.MiddleBottomButton, 1, 2);
            this.tableLayoutPanelBoard.Controls.Add(this.RightBottomButton, 2, 2);
            this.tableLayoutPanelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBoard.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanelBoard.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            this.tableLayoutPanelBoard.RowCount = 3;
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelBoard.Size = new System.Drawing.Size(851, 432);
            this.tableLayoutPanelBoard.TabIndex = 0;
            this.tableLayoutPanelBoard.Visible = false;
            // 
            // LeftTopButton
            // 
            this.LeftTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftTopButton.Location = new System.Drawing.Point(4, 4);
            this.LeftTopButton.Name = "LeftTopButton";
            this.LeftTopButton.Size = new System.Drawing.Size(273, 135);
            this.LeftTopButton.TabIndex = 0;
            this.LeftTopButton.UseVisualStyleBackColor = true;
            this.LeftTopButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // MiddleTopButton
            // 
            this.MiddleTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleTopButton.Location = new System.Drawing.Point(284, 4);
            this.MiddleTopButton.Name = "MiddleTopButton";
            this.MiddleTopButton.Size = new System.Drawing.Size(273, 135);
            this.MiddleTopButton.TabIndex = 1;
            this.MiddleTopButton.UseVisualStyleBackColor = true;
            this.MiddleTopButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // RightTopButton
            // 
            this.RightTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightTopButton.Location = new System.Drawing.Point(564, 4);
            this.RightTopButton.Name = "RightTopButton";
            this.RightTopButton.Size = new System.Drawing.Size(283, 135);
            this.RightTopButton.TabIndex = 2;
            this.RightTopButton.UseVisualStyleBackColor = true;
            this.RightTopButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // LeftMiddleButton
            // 
            this.LeftMiddleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftMiddleButton.Location = new System.Drawing.Point(4, 146);
            this.LeftMiddleButton.Name = "LeftMiddleButton";
            this.LeftMiddleButton.Size = new System.Drawing.Size(273, 135);
            this.LeftMiddleButton.TabIndex = 3;
            this.LeftMiddleButton.UseVisualStyleBackColor = true;
            this.LeftMiddleButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // MiddleMiddleButton
            // 
            this.MiddleMiddleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleMiddleButton.Location = new System.Drawing.Point(284, 146);
            this.MiddleMiddleButton.Name = "MiddleMiddleButton";
            this.MiddleMiddleButton.Size = new System.Drawing.Size(273, 135);
            this.MiddleMiddleButton.TabIndex = 4;
            this.MiddleMiddleButton.UseVisualStyleBackColor = true;
            this.MiddleMiddleButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // RightMiddleButton
            // 
            this.RightMiddleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightMiddleButton.Location = new System.Drawing.Point(564, 146);
            this.RightMiddleButton.Name = "RightMiddleButton";
            this.RightMiddleButton.Size = new System.Drawing.Size(283, 135);
            this.RightMiddleButton.TabIndex = 5;
            this.RightMiddleButton.UseVisualStyleBackColor = true;
            this.RightMiddleButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // LeftBottomButton
            // 
            this.LeftBottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftBottomButton.Location = new System.Drawing.Point(4, 288);
            this.LeftBottomButton.Name = "LeftBottomButton";
            this.LeftBottomButton.Size = new System.Drawing.Size(273, 140);
            this.LeftBottomButton.TabIndex = 6;
            this.LeftBottomButton.UseVisualStyleBackColor = true;
            this.LeftBottomButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // MiddleBottomButton
            // 
            this.MiddleBottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleBottomButton.Location = new System.Drawing.Point(284, 288);
            this.MiddleBottomButton.Name = "MiddleBottomButton";
            this.MiddleBottomButton.Size = new System.Drawing.Size(273, 140);
            this.MiddleBottomButton.TabIndex = 7;
            this.MiddleBottomButton.UseVisualStyleBackColor = true;
            this.MiddleBottomButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // RightBottomButton
            // 
            this.RightBottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightBottomButton.Location = new System.Drawing.Point(564, 288);
            this.RightBottomButton.Name = "RightBottomButton";
            this.RightBottomButton.Size = new System.Drawing.Size(283, 140);
            this.RightBottomButton.TabIndex = 8;
            this.RightBottomButton.UseVisualStyleBackColor = true;
            this.RightBottomButton.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 508);
            this.Controls.Add(this.tableLayoutPanelBoard);
            this.Controls.Add(this.panelConfigGame);
            this.Name = "MainForm";
            this.Text = "Gra kółko i krzyżyk";
            this.panelConfigGame.ResumeLayout(false);
            this.panelConfigGame.PerformLayout();
            this.tableLayoutPanelBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfigGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.ComboBox comboBoxWhoStarts;
        private System.Windows.Forms.Button LeftTopButton;
        private System.Windows.Forms.Button MiddleTopButton;
        private System.Windows.Forms.Button RightTopButton;
        private System.Windows.Forms.Button LeftMiddleButton;
        private System.Windows.Forms.Button MiddleMiddleButton;
        private System.Windows.Forms.Button RightMiddleButton;
        private System.Windows.Forms.Button LeftBottomButton;
        private System.Windows.Forms.Button MiddleBottomButton;
        private System.Windows.Forms.Button RightBottomButton;
        private System.Windows.Forms.Label label1;
    }
}

