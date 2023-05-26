namespace Application_User
{
    partial class Form2
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
            this.name_Box = new System.Windows.Forms.TextBox();
            this.surname_Box = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.login_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password_group_Box = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generation_btn = new System.Windows.Forms.Button();
            this.number_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.letters_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.special_checkBox = new System.Windows.Forms.CheckBox();
            this.upper_checkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lenght_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.password_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.password_group_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenght_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(23, 32);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(100, 22);
            this.name_Box.TabIndex = 0;
            this.name_Box.Tag = "";
            this.name_Box.TextChanged += new System.EventHandler(this.Name_Box_TextChanged);
            // 
            // surname_Box
            // 
            this.surname_Box.Location = new System.Drawing.Point(162, 30);
            this.surname_Box.Name = "surname_Box";
            this.surname_Box.Size = new System.Drawing.Size(133, 22);
            this.surname_Box.TabIndex = 1;
            this.surname_Box.TextChanged += new System.EventHandler(this.Surname_Box_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(365, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // login_Box
            // 
            this.login_Box.Location = new System.Drawing.Point(24, 100);
            this.login_Box.Name = "login_Box";
            this.login_Box.Size = new System.Drawing.Size(202, 22);
            this.login_Box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(157, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // password_group_Box
            // 
            this.password_group_Box.BackColor = System.Drawing.SystemColors.Info;
            this.password_group_Box.Controls.Add(this.label6);
            this.password_group_Box.Controls.Add(this.label5);
            this.password_group_Box.Controls.Add(this.generation_btn);
            this.password_group_Box.Controls.Add(this.number_numericUpDown);
            this.password_group_Box.Controls.Add(this.letters_numericUpDown);
            this.password_group_Box.Controls.Add(this.special_checkBox);
            this.password_group_Box.Controls.Add(this.upper_checkBox);
            this.password_group_Box.Controls.Add(this.label4);
            this.password_group_Box.Controls.Add(this.lenght_numericUpDown);
            this.password_group_Box.Controls.Add(this.password_Box);
            this.password_group_Box.Location = new System.Drawing.Point(24, 148);
            this.password_group_Box.Name = "password_group_Box";
            this.password_group_Box.Size = new System.Drawing.Size(271, 270);
            this.password_group_Box.TabIndex = 7;
            this.password_group_Box.TabStop = false;
            this.password_group_Box.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Количество цифр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Количество букв";
            // 
            // generation_btn
            // 
            this.generation_btn.Location = new System.Drawing.Point(64, 241);
            this.generation_btn.Name = "generation_btn";
            this.generation_btn.Size = new System.Drawing.Size(138, 23);
            this.generation_btn.TabIndex = 13;
            this.generation_btn.Text = " Сгенерировать";
            this.generation_btn.UseVisualStyleBackColor = true;
            this.generation_btn.Click += new System.EventHandler(this.generation_btn_Click);
            // 
            // number_numericUpDown
            // 
            this.number_numericUpDown.Location = new System.Drawing.Point(131, 200);
            this.number_numericUpDown.Name = "number_numericUpDown";
            this.number_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.number_numericUpDown.TabIndex = 12;
            // 
            // letters_numericUpDown
            // 
            this.letters_numericUpDown.Location = new System.Drawing.Point(131, 155);
            this.letters_numericUpDown.Name = "letters_numericUpDown";
            this.letters_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.letters_numericUpDown.TabIndex = 11;
            // 
            // special_checkBox
            // 
            this.special_checkBox.AutoSize = true;
            this.special_checkBox.Location = new System.Drawing.Point(6, 118);
            this.special_checkBox.Name = "special_checkBox";
            this.special_checkBox.Size = new System.Drawing.Size(119, 20);
            this.special_checkBox.TabIndex = 10;
            this.special_checkBox.Text = "Спецсимволы";
            this.special_checkBox.UseVisualStyleBackColor = true;
            // 
            // upper_checkBox
            // 
            this.upper_checkBox.AutoSize = true;
            this.upper_checkBox.Location = new System.Drawing.Point(136, 118);
            this.upper_checkBox.Name = "upper_checkBox";
            this.upper_checkBox.Size = new System.Drawing.Size(101, 20);
            this.upper_checkBox.TabIndex = 9;
            this.upper_checkBox.Text = "Заглавные";
            this.upper_checkBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длина пароля";
            // 
            // lenght_numericUpDown
            // 
            this.lenght_numericUpDown.Location = new System.Drawing.Point(7, 76);
            this.lenght_numericUpDown.Name = "lenght_numericUpDown";
            this.lenght_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.lenght_numericUpDown.TabIndex = 1;
            // 
            // password_Box
            // 
            this.password_Box.Location = new System.Drawing.Point(7, 22);
            this.password_Box.Name = "password_Box";
            this.password_Box.Size = new System.Drawing.Size(195, 22);
            this.password_Box.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(360, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Список пользователей";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(365, 108);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(365, 308);
            this.listBox.TabIndex = 9;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save_btn.Location = new System.Drawing.Point(365, 428);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(261, 45);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(360, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Дата Рождения";
            // 
            // delete_btn
            // 
            this.delete_btn.BackgroundImage = global::Application_User.Properties.Resources.icon;
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_btn.Location = new System.Drawing.Point(685, 428);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(45, 45);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_add_user.Location = new System.Drawing.Point(632, 428);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(45, 45);
            this.btn_add_user.TabIndex = 13;
            this.btn_add_user.Text = "+";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // Form2
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 485);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.password_group_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_Box);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.surname_Box);
            this.Controls.Add(this.name_Box);
            this.Name = "Form2";
            this.Text = "Form1";
            this.password_group_Box.ResumeLayout(false);
            this.password_group_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letters_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenght_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.TextBox surname_Box;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox login_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox password_group_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generation_btn;
        private System.Windows.Forms.NumericUpDown number_numericUpDown;
        private System.Windows.Forms.NumericUpDown letters_numericUpDown;
        private System.Windows.Forms.CheckBox special_checkBox;
        private System.Windows.Forms.CheckBox upper_checkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lenght_numericUpDown;
        private System.Windows.Forms.TextBox password_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button btn_add_user;
    }
}

