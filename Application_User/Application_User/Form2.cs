using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Text.Json.Nodes;

namespace Application_User
{
    public partial class Form2 : Form
    {
        public string path_program = $@"{Environment.CurrentDirectory}\\Password_Generator\bin\Debug\Password_Generator.exe";

        int index_selected;
        bool isSelected = false;
        bool isMe = false;



        public Form2()
        {
            InitializeComponent();
            UpdateResultsList();
            if (Program.user_key == (int)Program.Permissions.CommonUser)
            {
                save_btn.Enabled = false;
                password_group_Box.Enabled = false;
                name_Box.Enabled = false;
                surname_Box.Enabled = false;
                login_Box.Enabled = false;
                password_Box.Enabled = false;
                dateTimePicker.Enabled = false;
            }
        }

        private void generation_btn_Click(object sender, EventArgs e)
        {
            string arg = "";
            PasswordGenerator password_generator = new PasswordGenerator();

            if(lenght_numericUpDown.Value > 0 ) { arg += "--length=" + lenght_numericUpDown.Value.ToString() + " "; }
            if(special_checkBox.Checked ) { arg += "--special "; }
            if(upper_checkBox.Checked ) { arg += "--uppercase "; }
            if(letters_numericUpDown.Value > 0 ) { arg += "--letters=" + letters_numericUpDown.Value.ToString() + " "; }
            if(number_numericUpDown.Value > 0 ) { arg += "--digits=" + number_numericUpDown.Value.ToString() + " "; }

            password_Box.Text = (password_generator.RunApp(path_program, arg));
        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {
            login_Box.Text = LoginGenerator();
        }
        private void Surname_Box_TextChanged(object sender, EventArgs e)
        {
            login_Box.Text = LoginGenerator();  
        }

        private string LoginGenerator()
        {
            string new_login = "";
            string login = (name_Box.Text + "_" + surname_Box.Text).ToLower();
            for(int i = 0; i < login.Length; i++) 
            {
                new_login += Dict.dictionary[login[i].ToString()];
            }
            return new_login;
        }
        Account CreateResult()
        {
            Account newResult = new Account
            {
                // заполнение данными
                NAME = name_Box.Text,
                SURNAME = surname_Box.Text,
                LOGIN = login_Box.Text,
                PASSWORD = password_Box.Text,
                BIRTHDAY = dateTimePicker.Value,
            };
            return newResult;
        }
        void UpdateResultsList() //Просмотр пользователей
        {
            listBox.Items.Clear();
            if (Program.user_key != (int)Program.Permissions.Guest)
            {
                foreach (Account result in Program.results)
                {
                        listBox.Items.Add(result.name);
                }
            }
            else
            {
                foreach (Account result in Program.results)
                {
                    if (result.usertype == (int)Program.Permissions.CommonUser)
                    {
                        listBox.Items.Add(result.name);
                    }
                    else listBox.Items.Add("Закрыт");
                }
            }
        }

        void FillForm(Account result) // Просмотр данных
        {
            ClearForm();
            name_Box.Text = result.name;
            surname_Box.Text = result.surname;
            login_Box.Text = result.login;
            password_Box.Text = result.password;
            if (!isMe)
            {
                if (Program.user_key == (int)Program.Permissions.Guest)
                    login_Box.Text = "*****";
                if (Program.user_key == (int)Program.Permissions.Guest
                    || Program.user_key == (int)Program.Permissions.CommonUser)
                    password_Box.Text = "*****";
            }
            dateTimePicker.Value = result.birthday;

            if (Program.user_key != (int)Program.Permissions.Admin && !isMe)
            {
                if(Program.user_key != (int)Program.Permissions.Guest)
                {
                    save_btn.Enabled = false;
                }
                password_group_Box.Enabled = false;
                name_Box.Enabled = false;
                surname_Box.Enabled = false;
                login_Box.Enabled = false;
                password_Box.Enabled = false;
                dateTimePicker.Enabled = false;
            }
            else
            {
                save_btn.Enabled = true;
                password_group_Box.Enabled = true;
                name_Box.Enabled = true;
                surname_Box.Enabled = true;
                login_Box.Enabled = true;
                password_Box.Enabled = true;
                dateTimePicker.Enabled = true;
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (isSelected && (Program.user_key == (int)Program.Permissions.Admin && isMe))
            {
                Program.results[index_selected].NAME = name_Box.Text;
                Program.results[index_selected].SURNAME = surname_Box.Text;
                Program.results[index_selected].LOGIN = login_Box.Text;
                Program.results[index_selected].PASSWORD = password_Box.Text;
                Program.results[index_selected].BIRTHDAY = dateTimePicker.Value;
                isSelected = false;
                delete_btn.Visible = false;
            }
            else if (Program.user_key == (int)Program.Permissions.Admin || Program.user_key == (int)Program.Permissions.Guest)
            {
                if (!isMe)
                {
                    CreateResult().USERTYPE = (int)Program.Permissions.CommonUser;
                }
                Program.results.Add(CreateResult());
                if(Program.user_key == (int)Program.Permissions.Guest)
                    Program.user_key = (int)Program.Permissions.CommonUser;
            }
            Save_file();
            UpdateResultsList();
            ClearForm();
            
        }
        void ClearForm()
        {
            save_btn.Enabled = true;
            password_group_Box.Enabled = true;
            name_Box.Enabled = true;
            surname_Box.Enabled = true;
            login_Box.Enabled = true;
            password_Box.Enabled = true;
            dateTimePicker.Enabled = true;

            name_Box.Text = "";
            surname_Box.Text = "";
            dateTimePicker.Value = DateTime.Now;
            password_Box.Text = "";
            login_Box.Text = "";
        }

        private void Save_file()
        {
            File.WriteAllText(Program.path_date, "");
            File.WriteAllText(Program.path_password, "");

            for (int i = 0; i < Program.results.Count; i++)
            {
                Program.results[i].Serialize();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e) // Выбор пользователя
        {
            ClearForm();
            index_selected = listBox.SelectedIndex;

            if (listBox.Items[index_selected].ToString() == Program.user_name)
                isMe = true;
            else isMe = false;

            if (listBox.Items[index_selected].ToString() != "Закрыт")
            {
                isSelected = true;
                if (Program.user_key == (int)Program.Permissions.Admin)
                delete_btn.Visible = true;
            }
            Account foundResult = Program.results[index_selected];
                FillForm(foundResult);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Program.results.RemoveAt(index_selected);

            isSelected = false;
            delete_btn.Visible = false;

            UpdateResultsList();
            ClearForm();
            Save_file();
        }
    }
}
