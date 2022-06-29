namespace приложение
{
    partial class CheckerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.Location = new System.Drawing.Point(216, 47);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(266, 38);
            this.loginText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.Location = new System.Drawing.Point(216, 123);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '#';
            this.passwordText.Size = new System.Drawing.Size(266, 38);
            this.passwordText.TabIndex = 3;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordText_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(136, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(494, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CheckerForm";
            this.ShowIcon = false;
            this.Text = "Аутентификация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button button1;
    }
}