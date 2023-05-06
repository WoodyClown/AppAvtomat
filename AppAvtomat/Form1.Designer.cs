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
            this.createTableButton = new System.Windows.Forms.Button();
            this.labeltest1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(35, 53);
            this.rowsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(117, 20);
            this.rowsTextBox.TabIndex = 0;
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(60, 77);
            this.createTableButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(68, 19);
            this.createTableButton.TabIndex = 2;
            this.createTableButton.Text = "Создать";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // labeltest1
            // 
            this.labeltest1.AutoSize = true;
            this.labeltest1.Location = new System.Drawing.Point(38, 38);
            this.labeltest1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltest1.Name = "labeltest1";
            this.labeltest1.Size = new System.Drawing.Size(99, 13);
            this.labeltest1.TabIndex = 3;
            this.labeltest1.Text = "Размерность NxN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 130);
            this.Controls.Add(this.labeltest1);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.rowsTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Задание на автомат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Label labeltest1;
    }
}

