
namespace FirstWinFormsApp
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.labelWiek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFirst.Location = new System.Drawing.Point(482, 221);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(112, 43);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "Przycisk";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(229, 243);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(111, 43);
            this.buttonHello.TabIndex = 1;
            this.buttonHello.Text = "Przycisk2";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(284, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(30, 15);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "imię";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(284, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(284, 139);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(132, 23);
            this.textBoxSurname.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(284, 121);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(57, 15);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(284, 186);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(132, 23);
            this.textBoxWiek.TabIndex = 7;
            this.textBoxWiek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(284, 169);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(33, 15);
            this.labelWiek.TabIndex = 8;
            this.labelWiek.Text = "Wiek";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 502);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.buttonFirst);
            this.Name = "MainForm";
            this.Text = "Pierwszy program okienkowy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion




        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Label labelWiek;
    }
}

