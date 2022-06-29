namespace приложение
{
    partial class EditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйРедакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генераторАнекдотовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.стилиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 26);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыйРедакторToolStripMenuItem,
            this.генераторАнекдотовToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.главноеОкноToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem2.Text = "Окно";
            // 
            // текстовыйРедакторToolStripMenuItem
            // 
            this.текстовыйРедакторToolStripMenuItem.Name = "текстовыйРедакторToolStripMenuItem";
            this.текстовыйРедакторToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.текстовыйРедакторToolStripMenuItem.Text = "Текстовый редактор";
            // 
            // генераторАнекдотовToolStripMenuItem
            // 
            this.генераторАнекдотовToolStripMenuItem.Name = "генераторАнекдотовToolStripMenuItem";
            this.генераторАнекдотовToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.генераторАнекдотовToolStripMenuItem.Text = "Генератор анекдотов";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            // 
            // главноеОкноToolStripMenuItem
            // 
            this.главноеОкноToolStripMenuItem.Name = "главноеОкноToolStripMenuItem";
            this.главноеОкноToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.главноеОкноToolStripMenuItem.Text = "Главное окно";
            this.главноеОкноToolStripMenuItem.Click += new System.EventHandler(this.главноеОкноToolStripMenuItem_Click);
            // 
            // стилиToolStripMenuItem
            // 
            this.стилиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветФонаToolStripMenuItem,
            this.цветТекстаToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.стилиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стилиToolStripMenuItem.Name = "стилиToolStripMenuItem";
            this.стилиToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.стилиToolStripMenuItem.Text = "Стиль";
            this.стилиToolStripMenuItem.Click += new System.EventHandler(this.стилиToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // цветТекстаToolStripMenuItem
            // 
            this.цветТекстаToolStripMenuItem.Name = "цветТекстаToolStripMenuItem";
            this.цветТекстаToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.цветТекстаToolStripMenuItem.Text = "Цвет текста";
            this.цветТекстаToolStripMenuItem.Click += new System.EventHandler(this.цветТекстаToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(29, 99);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(944, 442);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLabel.Location = new System.Drawing.Point(23, 48);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(21, 31);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = " ";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditorForm";
            this.ShowIcon = false;
            this.Text = "Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem текстовыйРедакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генераторАнекдотовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеОкноToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label fileNameLabel;
    }
}