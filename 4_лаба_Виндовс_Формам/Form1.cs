using System;
using System.Windows.Forms;

namespace _4_лаба_Виндовс_Формам
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView.Columns.Add("ColumnX", "x");
            dataGridView.Columns.Add("ColumnZ", "z");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Res_Click(object sender, EventArgs e)
        {
            // Получаем значения начального x, конечного x, параметров a и b, а также шага Delta x
            if (double.TryParse(Xn.Text, out double xn) &&
                double.TryParse(Xk.Text, out double xk) &&
                double.TryParse(a.Text, out double aVal) &&
                double.TryParse(b.Text, out double bVal) &&
                double.TryParse(DX.Text, out double dx))
            {
                // Очищаем DataGridView перед заполнением новыми данными
                dataGridView.Rows.Clear();

                // Вычисляем и выводим значения функции для каждого x
                for (double x = xn; x <= xk; x += dx)
                {
                    double z;
                    if (x <= aVal)
                    {
                        z = Math.Pow(x, 2) + Math.Sin(x);
                    }
                    else if (x < bVal)
                    {
                        z = Math.Cos(Math.Pow(x, 2));
                    }
                    else
                    {
                        z = Math.Tan(x);
                    }

                    // Добавляем строку в DataGridView с результатом вычислений
                    dataGridView.Rows.Add(x, z.ToString("F2"));
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных. Проверьте введенные значения.");
            }
        }
    }
}
