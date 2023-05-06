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
        private int rowss;
        public Form1()
        {
            InitializeComponent();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }

        private void createTableButton_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(rowsTextBox.Text);
            int cols = rows;

            table = new TableLayoutPanel();
            this.Size = new Size(912, 405);
            rowsTextBox.Visible = false;
            labeltest1.Visible = false;
            createTableButton.Visible = false;
            table.RowCount = rows + 1; // учитываем строку заголовков
            rowss = rows;
            table.ColumnCount = cols + 3; // учитываем столбец заголовков
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // задаем ширину столбцов 912; 405
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
            table.Controls.Add(calculateButton, 0, rows + 2);
            table.AutoScroll = true;
            table.Dock = DockStyle.Fill;
        }
        private void CalculateRowsSum(object sender, EventArgs e)
        {
            int emptyCount = 0; // переменная для подсчета количества пустых TextBox
            foreach (Control ctrl in table.Controls)
            {
                if (ctrl is TextBox && string.IsNullOrEmpty(ctrl.Text))
                {
                    emptyCount++;
                    break;
                }
            }
            if(emptyCount != 0)
            {
                MessageBox.Show("Заполните все поля таблицы!");
                return;
            }
            calculateButton.Visible = false;
            float sumfunish = 0;
            float sumfunish_2 = 0;
            float[] arrfunish = new float[rowss];

            for (int i = 1; i < table.RowCount; i++)
            {
                float rowComp = 1.0f;
                // Проходим по каждому TextBox в строке
                foreach (Control control in table.Controls)
                {
                    if (table.GetRow(control) == i && control is TextBox textBox)
                    {
                        if (double.TryParse(textBox.Text, out double value))
                        {
                            // Если удалось успешно распарсить число из TextBox, то добавляем его к сумме строки
                            rowComp *= (float)value;
                        }
                    }
                }
                float delit = 1.0f / rowss;
                float finish = (float)Math.Round((float)Math.Pow(rowComp, delit), 2);
                sumfunish += (float)finish;
                arrfunish[i - 1] = (float)finish;
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                Label labelfi = new Label();
                labelfi.Text = finish.ToString();
                labelfi.Dock = DockStyle.Fill;
                labelfi.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(labelfi, table.ColumnCount - 2, i);
                // Выводим сумму строки в консоль (вы можете сделать что-то другое с этой информацией)
            }
            for (int i = 1; i < table.RowCount; i++)
            {
               
                float finish = (float)Math.Round(arrfunish[i - 1] / (float)sumfunish, 3);
                sumfunish_2 += (float)finish;

                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                Label labelfi = new Label();
                labelfi.Text = finish.ToString();
                labelfi.Dock = DockStyle.Fill;
                labelfi.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(labelfi, table.ColumnCount - 1, i);
                // Выводим сумму строки в консоль (вы можете сделать что-то другое с этой информацией)
            }
            Label label = new Label();
            label.Text = sumfunish.ToString();
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            table.Controls.Add(label, table.ColumnCount - 2, table.ColumnCount);

            Label label2 = new Label();
            label2.Text = sumfunish_2.ToString();
            label2.Dock = DockStyle.Fill;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            table.Controls.Add(label2, table.ColumnCount - 1, table.ColumnCount);

            Label label3 = new Label();
            label3.Text = "Сумма:";
            label3.Dock = DockStyle.Fill;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            table.Controls.Add(label3, 0, table.ColumnCount);
        }
    }
}
