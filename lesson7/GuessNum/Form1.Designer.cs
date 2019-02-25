namespace GuessNum
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.labelAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(331, 17);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Загаданно число от 1 до 100. Попробуй угадать.";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(16, 72);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(182, 22);
            this.answer.TabIndex = 1;
            this.answer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.answer_KeyUp);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(205, 70);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(139, 24);
            this.button.TabIndex = 2;
            this.button.Text = "Угадать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAns.Location = new System.Drawing.Point(16, 49);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(0, 17);
            this.labelAns.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(357, 116);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.button);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.labelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelAns;
    }
}

