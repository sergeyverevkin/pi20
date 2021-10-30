
namespace pi201Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnCalc = new System.Windows.Forms.Button();
      this.btnMinus = new System.Windows.Forms.Button();
      this.btnPlus = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.panMoneyLack = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.panReturn = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.panResult = new System.Windows.Forms.Panel();
      this.labResult = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.panStake = new System.Windows.Forms.Panel();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.btnStart = new System.Windows.Forms.Button();
      this.panStakeWait = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.labMoney = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.labGameState = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button3 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panMoneyLack.SuspendLayout();
      this.panReturn.SuspendLayout();
      this.panResult.SuspendLayout();
      this.panStake.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.panStakeWait.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(800, 450);
      this.tabControl1.TabIndex = 5;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnCalc);
      this.tabPage1.Controls.Add(this.btnMinus);
      this.tabPage1.Controls.Add(this.btnPlus);
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(792, 424);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(161, 67);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(75, 23);
      this.btnCalc.TabIndex = 8;
      this.btnCalc.Text = "=";
      this.btnCalc.UseVisualStyleBackColor = true;
      // 
      // btnMinus
      // 
      this.btnMinus.Location = new System.Drawing.Point(30, 96);
      this.btnMinus.Name = "btnMinus";
      this.btnMinus.Size = new System.Drawing.Size(75, 23);
      this.btnMinus.TabIndex = 7;
      this.btnMinus.Text = "-";
      this.btnMinus.UseVisualStyleBackColor = true;
      // 
      // btnPlus
      // 
      this.btnPlus.Location = new System.Drawing.Point(30, 67);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(75, 23);
      this.btnPlus.TabIndex = 6;
      this.btnPlus.Text = "+";
      this.btnPlus.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(30, 32);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(206, 29);
      this.textBox1.TabIndex = 5;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.panel1);
      this.tabPage2.Controls.Add(this.panMoneyLack);
      this.tabPage2.Controls.Add(this.panReturn);
      this.tabPage2.Controls.Add(this.panResult);
      this.tabPage2.Controls.Add(this.panStake);
      this.tabPage2.Controls.Add(this.panStakeWait);
      this.tabPage2.Controls.Add(this.panel2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(792, 424);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Игровой автомат";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // panMoneyLack
      // 
      this.panMoneyLack.Controls.Add(this.label2);
      this.panMoneyLack.Dock = System.Windows.Forms.DockStyle.Top;
      this.panMoneyLack.Location = new System.Drawing.Point(3, 277);
      this.panMoneyLack.Name = "panMoneyLack";
      this.panMoneyLack.Size = new System.Drawing.Size(786, 51);
      this.panMoneyLack.TabIndex = 15;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(285, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(235, 24);
      this.label2.TabIndex = 11;
      this.label2.Text = "Автомат вышел из строя";
      // 
      // panReturn
      // 
      this.panReturn.Controls.Add(this.button2);
      this.panReturn.Dock = System.Windows.Forms.DockStyle.Top;
      this.panReturn.Location = new System.Drawing.Point(3, 226);
      this.panReturn.Name = "panReturn";
      this.panReturn.Size = new System.Drawing.Size(786, 51);
      this.panReturn.TabIndex = 14;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(359, 15);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(68, 20);
      this.button2.TabIndex = 11;
      this.button2.Text = "Забрать деньги";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // panResult
      // 
      this.panResult.Controls.Add(this.labResult);
      this.panResult.Controls.Add(this.label4);
      this.panResult.Dock = System.Windows.Forms.DockStyle.Top;
      this.panResult.Location = new System.Drawing.Point(3, 185);
      this.panResult.Name = "panResult";
      this.panResult.Size = new System.Drawing.Size(786, 41);
      this.panResult.TabIndex = 13;
      // 
      // labResult
      // 
      this.labResult.AutoSize = true;
      this.labResult.Location = new System.Drawing.Point(430, 14);
      this.labResult.Name = "labResult";
      this.labResult.Size = new System.Drawing.Size(22, 13);
      this.labResult.TabIndex = 11;
      this.labResult.Text = "-----";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(335, 14);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Результат";
      // 
      // panStake
      // 
      this.panStake.Controls.Add(this.numericUpDown1);
      this.panStake.Controls.Add(this.btnStart);
      this.panStake.Dock = System.Windows.Forms.DockStyle.Top;
      this.panStake.Location = new System.Drawing.Point(3, 144);
      this.panStake.Name = "panStake";
      this.panStake.Size = new System.Drawing.Size(786, 41);
      this.panStake.TabIndex = 12;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(312, 10);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(71, 20);
      this.numericUpDown1.TabIndex = 7;
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(407, 10);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(68, 20);
      this.btnStart.TabIndex = 6;
      this.btnStart.Text = "Старт";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // panStakeWait
      // 
      this.panStakeWait.Controls.Add(this.button1);
      this.panStakeWait.Dock = System.Windows.Forms.DockStyle.Top;
      this.panStakeWait.Location = new System.Drawing.Point(3, 44);
      this.panStakeWait.Name = "panStakeWait";
      this.panStakeWait.Size = new System.Drawing.Size(786, 100);
      this.panStakeWait.TabIndex = 11;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(312, 18);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(163, 63);
      this.button1.TabIndex = 3;
      this.button1.Text = "Играть";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // labMoney
      // 
      this.labMoney.AutoSize = true;
      this.labMoney.Location = new System.Drawing.Point(508, 14);
      this.labMoney.Name = "labMoney";
      this.labMoney.Size = new System.Drawing.Size(22, 13);
      this.labMoney.TabIndex = 7;
      this.labMoney.Text = "-----";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(404, 14);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Количество денег";
      // 
      // labGameState
      // 
      this.labGameState.AutoSize = true;
      this.labGameState.Location = new System.Drawing.Point(137, 14);
      this.labGameState.Name = "labGameState";
      this.labGameState.Size = new System.Drawing.Size(22, 13);
      this.labGameState.TabIndex = 1;
      this.labGameState.Text = "-----";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Состояние игры";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(3, 348);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(786, 73);
      this.panel1.TabIndex = 16;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(312, 20);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(163, 46);
      this.button3.TabIndex = 3;
      this.button3.Text = "Добавить деньги";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(5, 20);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(98, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Техобслуживание";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.labGameState);
      this.panel2.Controls.Add(this.labMoney);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(786, 41);
      this.panel2.TabIndex = 17;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.panMoneyLack.ResumeLayout(false);
      this.panMoneyLack.PerformLayout();
      this.panReturn.ResumeLayout(false);
      this.panResult.ResumeLayout(false);
      this.panResult.PerformLayout();
      this.panStake.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.panStakeWait.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labGameState;
    private System.Windows.Forms.Label labMoney;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panStake;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Panel panStakeWait;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panReturn;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Panel panResult;
    private System.Windows.Forms.Label labResult;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panMoneyLack;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel2;
  }
}

