using System.Collections.Generic;

namespace Application_User
{
    partial class Form1
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
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authoriz_btn = new System.Windows.Forms.Button();
            this.guest_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(12, 67);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(253, 22);
            this.login_box.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(12, 122);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(253, 22);
            this.password_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // authoriz_btn
            // 
            this.authoriz_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.authoriz_btn.Location = new System.Drawing.Point(12, 192);
            this.authoriz_btn.Name = "authoriz_btn";
            this.authoriz_btn.Size = new System.Drawing.Size(154, 30);
            this.authoriz_btn.TabIndex = 4;
            this.authoriz_btn.Text = "Авторизация";
            this.authoriz_btn.UseVisualStyleBackColor = true;
            this.authoriz_btn.Click += new System.EventHandler(this.authoriz_btn_Click);
            // 
            // guest_btn
            // 
            this.guest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guest_btn.Location = new System.Drawing.Point(205, 192);
            this.guest_btn.Name = "guest_btn";
            this.guest_btn.Size = new System.Drawing.Size(154, 30);
            this.guest_btn.TabIndex = 5;
            this.guest_btn.Text = "Войти как гость";
            this.guest_btn.UseVisualStyleBackColor = true;
            this.guest_btn.Click += new System.EventHandler(this.guest_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.guest_btn);
            this.Controls.Add(this.authoriz_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Name = "Form1";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button authoriz_btn;
        private System.Windows.Forms.Button guest_btn;
        
    }
}