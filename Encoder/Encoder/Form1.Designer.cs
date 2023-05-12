namespace Encoder
{
    partial class Form1
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
            this.textbox_your_text = new System.Windows.Forms.RichTextBox();
            this.listBox_encoders = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.listBox_added_encoders = new System.Windows.Forms.ListBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.textbox_encrypted = new System.Windows.Forms.RichTextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.textbox_key = new System.Windows.Forms.RichTextBox();
            this.textbox_unencrypted = new System.Windows.Forms.RichTextBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_your_text
            // 
            this.textbox_your_text.Location = new System.Drawing.Point(13, 13);
            this.textbox_your_text.Name = "textbox_your_text";
            this.textbox_your_text.Size = new System.Drawing.Size(666, 96);
            this.textbox_your_text.TabIndex = 0;
            this.textbox_your_text.Text = "";
            // 
            // listBox_encoders
            // 
            this.listBox_encoders.FormattingEnabled = true;
            this.listBox_encoders.ItemHeight = 16;
            this.listBox_encoders.Items.AddRange(new object[] {
            "Increment (+1)",
            "Decrement (-1)",
            "Zero (0)",
            "Negative (255-code)"});
            this.listBox_encoders.Location = new System.Drawing.Point(13, 116);
            this.listBox_encoders.Name = "listBox_encoders";
            this.listBox_encoders.Size = new System.Drawing.Size(188, 196);
            this.listBox_encoders.TabIndex = 1;
            this.listBox_encoders.SelectedIndexChanged += new System.EventHandler(this.listBox_encoders_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(207, 154);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 40);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(207, 231);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 40);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "-";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // listBox_added_encoders
            // 
            this.listBox_added_encoders.FormattingEnabled = true;
            this.listBox_added_encoders.ItemHeight = 16;
            this.listBox_added_encoders.Location = new System.Drawing.Point(318, 115);
            this.listBox_added_encoders.Name = "listBox_added_encoders";
            this.listBox_added_encoders.Size = new System.Drawing.Size(188, 196);
            this.listBox_added_encoders.TabIndex = 4;
            this.listBox_added_encoders.SelectedIndexChanged += new System.EventHandler(this.listBox_added_encoders_SelectedIndexChanged);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(13, 319);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(493, 41);
            this.btn_encrypt.TabIndex = 5;
            this.btn_encrypt.Text = "Шифровать";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // textbox_encrypted
            // 
            this.textbox_encrypted.Location = new System.Drawing.Point(12, 377);
            this.textbox_encrypted.Name = "textbox_encrypted";
            this.textbox_encrypted.Size = new System.Drawing.Size(666, 96);
            this.textbox_encrypted.TabIndex = 6;
            this.textbox_encrypted.Text = "";
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(12, 523);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(493, 41);
            this.btn_decrypt.TabIndex = 7;
            this.btn_decrypt.Text = "Разшифровать";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // textbox_key
            // 
            this.textbox_key.Location = new System.Drawing.Point(12, 480);
            this.textbox_key.Name = "textbox_key";
            this.textbox_key.Size = new System.Drawing.Size(666, 37);
            this.textbox_key.TabIndex = 8;
            this.textbox_key.Text = "";
            // 
            // textbox_unencrypted
            // 
            this.textbox_unencrypted.Location = new System.Drawing.Point(13, 570);
            this.textbox_unencrypted.Name = "textbox_unencrypted";
            this.textbox_unencrypted.Size = new System.Drawing.Size(666, 96);
            this.textbox_unencrypted.TabIndex = 9;
            this.textbox_unencrypted.Text = "";
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(512, 154);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(105, 40);
            this.btn_up.TabIndex = 10;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(512, 231);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(105, 40);
            this.btn_down.TabIndex = 11;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 687);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.textbox_unencrypted);
            this.Controls.Add(this.textbox_key);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.textbox_encrypted);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.listBox_added_encoders);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listBox_encoders);
            this.Controls.Add(this.textbox_your_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textbox_your_text;
        private System.Windows.Forms.ListBox listBox_encoders;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox listBox_added_encoders;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.RichTextBox textbox_encrypted;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.RichTextBox textbox_key;
        private System.Windows.Forms.RichTextBox textbox_unencrypted;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
    }
}

