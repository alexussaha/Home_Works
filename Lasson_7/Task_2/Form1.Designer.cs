namespace Task_2
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
            this.lblShowHelp = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tbEnterNum = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShowHelp
            // 
            this.lblShowHelp.AutoSize = true;
            this.lblShowHelp.Location = new System.Drawing.Point(15, 53);
            this.lblShowHelp.Name = "lblShowHelp";
            this.lblShowHelp.Size = new System.Drawing.Size(97, 17);
            this.lblShowHelp.TabIndex = 0;
            this.lblShowHelp.Text = "Начните игру";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(371, 53);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 17);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // tbEnterNum
            // 
            this.tbEnterNum.Location = new System.Drawing.Point(15, 163);
            this.tbEnterNum.Name = "tbEnterNum";
            this.tbEnterNum.Size = new System.Drawing.Size(149, 22);
            this.tbEnterNum.TabIndex = 2;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(15, 257);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(149, 60);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Играть";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите число:";
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(201, 161);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(117, 37);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ходов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.tbEnterNum);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblShowHelp);
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowHelp;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox tbEnterNum;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
    }
}

