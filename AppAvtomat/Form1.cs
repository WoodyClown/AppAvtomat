using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAvtomat
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel table;
        private Button calculateButton;
        public Form1()
        {
            InitializeComponent();
        }

        private void createTableButton_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(rowsTextBox.Text);
            int cols = int.Parse(colsTextBox.Text);

            table = new TableLayoutPanel();
            rowsTextBox.Visible = false;
            colsTextBox.Visible = false;
            labeltest1.Visible = false;
            labeltest2.Visible = false;
            createTableButton.Visible = false;
            table.RowCount = rows + 1; // учитываем строку заголовков
            table.ColumnCount = cols + 3; // учитываем столбец заголовков
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // задаем ширину столбцов
            Label labelk = new Label();
            labelk.Text = "Критерии";
            labelk.Dock = DockStyle.Fill;
            labelk.TextAlign = ContentAlignment.MiddleCenter;
            table.Controls.Add(labelk, 0, 0);
            for (int i = 1; i <= cols; i++) // добавляем заголовки столбцов
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                Label label = new Label();
                label.Text = "L" + i.ToString();
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(label, i, 0);
            }
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Label label1 = new Label();
            label1.Text = "Вектор\r\nкритериев";
            label1.Dock = DockStyle.Fill;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            table.Controls.Add(label1, cols + 1, 0);
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Label label2 = new Label();
            label2.Text = "Вектор\r\nприоритетов";
            label2.Dock = DockStyle.Fill;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            table.Controls.Add(label2, cols + 2, 0);
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F)); // задаем высоту строки заголовков
            for (int i = 1; i <= rows; i++) // добавляем заголовки строк
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                Label label = new Label();
                label.Text = "L" + i.ToString();
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(label, 0, i);
            }
            for (int i = 1; i <= rows; i++) // добавляем ячейки таблицы
            {
                for (int j = 1; j <= cols; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Dock = DockStyle.Fill;
                    textBox.TextAlign = HorizontalAlignment.Center;
                    table.Controls.Add(textBox, j, i);
                }
            }
            table.AutoScroll = true;
            table.Dock = DockStyle.Fill;
            this.Controls.Add(table);



            calculateButton = new Button();
            calculateButton.Text = "Посчитать";
            calculateButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            calculateButton.Click += new EventHandler(CalculateRowsSum);
            table.Controls.Add(calculateButton, 0, rows + 1);
            table.AutoScroll = true;
            table.Dock = DockStyle.Fill;
        }
        private void CalculateRowsSum(object sender, EventArgs e)
        {
            calculateButton.Enabled = false;
            for (int i = 1; i < table.RowCount; i++)
            {
                double rowSum = 0;
                // Проходим по каждому TextBox в строке
                foreach (Control control in table.Controls)
                {
                    if (table.GetRow(control) == i && control is TextBox textBox)
                    {
                        if (double.TryParse(textBox.Text, out double value))
                        {
                            // Если удалось успешно распарсить число из TextBox, то добавляем его к сумме строки
                            rowSum += value;
                        }
                    }
                }
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                Label label = new Label();
                label.Text = rowSum.ToString();
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(label, table.ColumnCount - 2, i);
                // Выводим сумму строки в консоль (вы можете сделать что-то другое с этой информацией)
            }
        }
    }
}
