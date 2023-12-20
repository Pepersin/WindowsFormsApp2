using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Добавьте варианты статуса счета в ComboBox
            comboBox1.Items.AddRange(new object[] { "Действующий", "Заблокированный", "Замороженный" });

            // Установите значение по умолчанию
            comboBox1.SelectedIndex = 0;

            // Добавьте обработчик события KeyPress к textBox1
            textBox1.KeyPress += textBox1_KeyPress;

            textBox3.KeyPress += textBox3_KeyPress;

            textBox4.KeyPress += textBox4_KeyPress;

            textBox5.KeyPress += textBox5_KeyPress;

            textBox6.KeyPress += textBox6_KeyPress;

            textBox7.KeyPress += textBox7_KeyPress;

            textBox8.KeyPress += textBox8_KeyPress;

            textBox9.KeyPress += textBox9_KeyPress;

            textBox10.KeyPress += textBox10_KeyPress;
        }

        private void TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Сделайте кнопку невидимой
            button1.Visible = false;

            // Сделайте textBox1, textBox2, textBox3, textBox4 и их соответствующие метки видимыми
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;

            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;


            // Сделайте comboBox видимым
            comboBox1.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;

            // Установите фокус ввода на textBox1
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработка изменения статуса счета
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Действующий":
                    EnableAccountFields();
                    break;
                case "Заблокированный":
                    DisableAccountFields();
                    break;
                case "Замороженный":
                    DisableAccountFields();
                    break;
            }
        }

        private void EnableAccountFields()
        {
            // Разрешить ввод текста для всех текстовых полей
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
        }

        private void DisableAccountFields()
        {
            // Заблокировать ввод текста для всех текстовых полей
           
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
        }

        // Добавьте аналогичные обработчики для других текстовых полей и меток, если необходимо

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ буквой или Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                // Отменяем ввод, если символ не является буквой или Backspace
                e.Handled = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой или Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                // Отменяем ввод, если символ не является цифрой или Backspace
                e.Handled = true;
            }

            // Проверяем, что количество цифр в textBox3 равно 10
            if (textBox3.Text.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем ввод, если достигнут лимит в 10 цифр
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем ввод, если символ не является цифрой или Backspace
                e.Handled = true;
            }

            // Проверяем, что количество цифр в textBox4 равно 9
            if (textBox4.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем ввод, если достигнут лимит в 9 цифр
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем ввод, если символ не является цифрой или Backspace
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем ввод, если символ не является цифрой или Backspace
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем ввод, если символ не является цифрой или Backspace
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox6.Text, out decimal value1) && decimal.TryParse(textBox7.Text, out decimal value2))
            {
                decimal sum = value1 + value2;
                textBox8.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числовые значения в TextBox1 и TextBox2", "Ошибка");
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Отменяем ввод любых символов
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox8.Text, out decimal value1) && decimal.TryParse(textBox9.Text, out decimal value2))
            {
                decimal difference = value1 - value2;
                textBox10.Text = difference.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числовые значения в TextBox1 и TextBox2", "Ошибка");
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Отменяем ввод, если символ не является цифрой или Backspace
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Отменяем ввод любых символов
            e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверка, что все TextBox'ы заполнены
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox10.Text))
            {
                // Отобразить сообщение об ошибке
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Сделайте кнопку невидимой
                button4.Visible = false;

                // Покажите сообщение о успешном сохранении
                MessageBox.Show("Данные банковского аккаунта сохранены", "Успех");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
