using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace приложение
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            RandomChoice(); // собственный метод по выводу ответа
        }

        private void RandomChoice() 
        {
            string[] answers = 
            {
                "Звезды благосклонны к вам!", 
                "Звезды советуют быть осторожнее.", 
                "Ваше будущее туманно..."
            };
            Random random = new Random();
            int number = random.Next(answers.Length);
            magicLabel.Text = answers[number];
        }

        private void текстовыйРедакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorForm editor = new EditorForm();
            editor.Show();
            this.Hide();
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Магическое приложение\nВерсия 0.1");
            MessageBox.Show("Различай файл функций и файл дизайна!");
            MessageBox.Show("Повтори, что такое события!");
            MessageBox.Show("Повтори свойства в окне свойств!");
            MessageBox.Show("Повтори элементы в окне элементов!");
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("я котик", "это правда");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
