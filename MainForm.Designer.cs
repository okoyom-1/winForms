namespace приложение
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйРедакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генераторАнекдотовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.котикиИСобачкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.magicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окнаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыйРедакторToolStripMenuItem,
            this.генераторАнекдотовToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.главноеОкноToolStripMenuItem});
            this.окнаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // текстовыйРедакторToolStripMenuItem
            // 
            this.текстовыйРедакторToolStripMenuItem.Name = "текстовыйРедакторToolStripMenuItem";
            this.текстовыйРедакторToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.текстовыйРедакторToolStripMenuItem.Text = "Текстовый редактор";
            this.текстовыйРедакторToolStripMenuItem.Click += new System.EventHandler(this.текстовыйРедакторToolStripMenuItem_Click);
            // 
            // генераторАнекдотовToolStripMenuItem
            // 
            this.генераторАнекдотовToolStripMenuItem.Name = "генераторАнекдотовToolStripMenuItem";
            this.генераторАнекдотовToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.генераторАнекдотовToolStripMenuItem.Text = "Генератор анекдотов";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            // 
            // главноеОкноToolStripMenuItem
            // 
            this.главноеОкноToolStripMenuItem.Name = "главноеОкноToolStripMenuItem";
            this.главноеОкноToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.главноеОкноToolStripMenuItem.Text = "Главное окно";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem,
            this.оРазработчикеToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowMerge = false;
            this.contextMenuStrip1.AutoClose = false;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.котикиИСобачкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 76);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // котикиИСобачкиToolStripMenuItem
            // 
            this.котикиИСобачкиToolStripMenuItem.Name = "котикиИСобачкиToolStripMenuItem";
            this.котикиИСобачкиToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.котикиИСобачкиToolStripMenuItem.Text = "Котики и собачки";
            // 
            // magicLabel
            // 
            this.magicLabel.BackColor = System.Drawing.Color.Plum;
            this.magicLabel.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.magicLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.magicLabel.Location = new System.Drawing.Point(487, 137);
            this.magicLabel.Name = "magicLabel";
            this.magicLabel.Size = new System.Drawing.Size(507, 227);
            this.magicLabel.TabIndex = 2;
            this.magicLabel.Text = "Ответ магического шара...";
            this.magicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.magicLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // magicButton
            // 
            this.magicButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.magicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.magicButton.FlatAppearance.BorderSize = 10;
            this.magicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.magicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.magicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.magicButton.Location = new System.Drawing.Point(604, 400);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(287, 127);
            this.magicButton.TabIndex = 4;
            this.magicButton.Text = "Вжух!";
            this.magicButton.UseVisualStyleBackColor = false;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Хотите сделать выбор? Магический шар вам подскажет!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.magicLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Магическое приложение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстовыйРедакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генераторАнекдотовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem котикиИСобачкиToolStripMenuItem;
        private System.Windows.Forms.Label magicLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem главноеОкноToolStripMenuItem;
    }
}

