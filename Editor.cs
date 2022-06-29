using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // библиотека ввода и вывода информации (Input/Output)

namespace приложение
{
    public partial class EditorForm : Form
    {
        public EditorForm() // Здесь Editor() - конструктор класса
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt";
        }

        private void главноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void стилиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox.BackColor = colorDialog1.Color;
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox.ForeColor = colorDialog1.Color;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox.Font = fontDialog1.Font;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName; // имя файла
            File.WriteAllText(filename, textBox.Text); // записываем данные в файл

            // работа с сохранением файлов в C#
            // - нужно подключить пространство имен System.IO
            // - нужно написать фильтр в конструкторе класса формы
            // - нужно написать действие в случае отмены сохранения
            // - нужно прописать имя файла как переменную
            // - нужно записать все данные в файл по его имени
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName; // имя файла
            string filetext = File.ReadAllText(filename); // текст файла
            textBox.Text = filetext; // ставим текст файла в текстовый блок
            fileNameLabel.Text = filename;
            // работа с открытием файлов в C#
            // - нужно подключить пространство имен System.IO
            // - нужно написать действие в случае отмены сохранения
            // - нужно прописать имя файла как переменную
            // - нужно прописать текст выбранного файла как переменную
            // - нужно в текстовом блоке формы отобразить прочитанный текст

        }
    }
}
