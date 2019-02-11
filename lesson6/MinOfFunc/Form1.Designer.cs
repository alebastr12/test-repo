namespace MinOfFunc
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
            this.FunBox = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.NumericUpDown();
            this.end = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end)).BeginInit();
            this.SuspendLayout();
            // 
            // FunBox
            // 
            this.FunBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunBox.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "1/x^2",
            "1/sin(x)",
            "1/cos(x)"});
            this.FunBox.Location = new System.Drawing.Point(250, 6);
            this.FunBox.Name = "FunBox";
            this.FunBox.Size = new System.Drawing.Size(121, 24);
            this.FunBox.TabIndex = 0;
            this.FunBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(251, 44);
            this.start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(120, 22);
            this.start.TabIndex = 1;
            this.start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(250, 82);
            this.end.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(120, 22);
            this.end.TabIndex = 2;
            this.end.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите функцию для расчета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Начальное значение";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Конечное значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Минимальное значение функции:";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(247, 122);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(0, 17);
            this.min.TabIndex = 7;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 198);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(356, 278);
            this.textBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Считать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.FunBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FunBox;
        private System.Windows.Forms.NumericUpDown start;
        private System.Windows.Forms.NumericUpDown end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
    }
}

