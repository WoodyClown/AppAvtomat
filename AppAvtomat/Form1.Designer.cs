namespace AppAvtomat
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
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.colsTextBox = new System.Windows.Forms.TextBox();
            this.createTableButton = new System.Windows.Forms.Button();
            this.labeltest1 = new System.Windows.Forms.Label();
            this.labeltest2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(218, 176);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(155, 22);
            this.rowsTextBox.TabIndex = 0;
            // 
            // colsTextBox
            // 
            this.colsTextBox.Location = new System.Drawing.Point(379, 176);
            this.colsTextBox.Name = "colsTextBox";
            this.colsTextBox.Size = new System.Drawing.Size(147, 22);
            this.colsTextBox.TabIndex = 1;
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(327, 204);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(90, 23);
            this.createTableButton.TabIndex = 2;
            this.createTableButton.Text = "Создать";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // labeltest1
            // 
            this.labeltest1.AutoSize = true;
            this.labeltest1.Location = new System.Drawing.Point(269, 157);
            this.labeltest1.Name = "labeltest1";
            this.labeltest1.Size = new System.Drawing.Size(54, 16);
            this.labeltest1.TabIndex = 3;
            this.labeltest1.Text = "Строки";
            // 
            // labeltest2
            // 
            this.labeltest2.AutoSize = true;
            this.labeltest2.Location = new System.Drawing.Point(418, 157);
            this.labeltest2.Name = "labeltest2";
            this.labeltest2.Size = new System.Drawing.Size(64, 16);
            this.labeltest2.TabIndex = 4;
            this.labeltest2.Text = "Столбцы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltest2);
            this.Controls.Add(this.labeltest1);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.colsTextBox);
            this.Controls.Add(this.rowsTextBox);
            this.Name = "Form1";
            this.Text = "Задание на автомат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.TextBox colsTextBox;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Label labeltest1;
        private System.Windows.Forms.Label labeltest2;
    }
}

